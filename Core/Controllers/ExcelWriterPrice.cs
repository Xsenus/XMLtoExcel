using Core.Models;
using Core.Models.Original;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Controllers
{
    public class ExcelWriterPrice
    {
        private string _path;
        private ExcelSetting _excelSetting;
        private string _sheetName;
        private bool _pricePerSet;

        public int Total { get; private set; }
        public int CountSubstitutions { get; private set; }
        public int CountNoPrice { get; private set; }
        public int CountCurrentPriceHigherThanNew { get; private set; }
        public int CountCurrentPriceLessThanNew { get; private set; }
        public int CountPercentageApplied { get; private set; }
        public int NumberOfIdenticalValues { get; private set; }
        public int NumberOfDifferentlValues { get; private set; }

        public int NoQty { get; private set; }
        public int NoPrice { get; private set; }


        public delegate void WriterEventHandler(int position, int count, int countSubstitutions);
        public event WriterEventHandler Writer;

        public delegate void LogEventHandler(string message);
        public event LogEventHandler Log;

        public ExcelWriterPrice(string path,
            ExcelSetting excelSetting,
            bool pricePerSet = false,
            string sheetName = "Товары и цены")
        {
            _path = path;
            _excelSetting = excelSetting;
            _pricePerSet = pricePerSet;
            _sheetName = sheetName;
        }
        
        public void StartWriterEPPlus(Data data)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            Log?.Invoke($"Открытие файла: {_path}");
            using (var package = new ExcelPackage(_path))
            {
                Log?.Invoke($"Поиск индекса страницы файла Excel по наименованию.");
                foreach (var worksheet in package.Workbook.Worksheets)
                {
                    Log?.Invoke($"Найдена страница: [{worksheet.Index}] {worksheet.Name}");
                    if (worksheet.Name.Trim().Equals(_sheetName.Trim()))
                    {
                        Log?.Invoke($"Найдена необходимая страница: [{worksheet.Index}] {worksheet.Name}");

                        var columnDictionary = GetColumnDictionary(worksheet);

                        var message = CheckingSettings(_excelSetting, columnDictionary);
                        if (string.IsNullOrWhiteSpace(message))
                        {
                            var rowCount = worksheet.Dimension.End.Row;
                            Log?.Invoke($"Строк для обработки файла Excel: {rowCount}");

                            for (int i = 0; i <= rowCount; i++)
                            {
                                try
                                {
                                    var indexExcelArticleColumn = GetColumnIndex(_excelSetting.ColumnArticle, columnDictionary);
                                    string excelArticle = worksheet.Cells[i, indexExcelArticleColumn].Value?.ToString();
                                    Log?.Invoke($"Получение артикля из ячейки [{i}; {indexExcelArticleColumn}] : {excelArticle ?? "NULL"}");

                                    if (!string.IsNullOrWhiteSpace(excelArticle))
                                    {
                                        if (_pricePerSet)
                                        {
                                            PricePerSetMethod(data, worksheet, columnDictionary, i, excelArticle);
                                        }
                                        else
                                        {
                                            BaseMethod(data, worksheet, columnDictionary, i, excelArticle);
                                        }
                                        Total++;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Log?.Invoke(ex.ToString());
                                }

                                SentWriter(rowCount, i);
                            }
                        }
                        else
                        {
                            throw new Exception(message);
                        }                        
                    }
                }

                package.Save();
            }
        }

        private void PricePerSetMethod(Data data, ExcelWorksheet worksheet, Dictionary<int, string> columnDictionary, int i, string excelArticle)
        {
            var product = data.Product
                .Where(w => w.Package != null 
                    && w.Package.Qty != null)
                .Where(w => w.Prices != null
                    && w.Prices.Price != null
                    && w.Prices.Price.FirstOrDefault(f => f.Type == "retail") != null)
                .FirstOrDefault(f => f.Article != null && f.Article.Equals(excelArticle));
            Log?.Invoke($"Поиск артикля в XML файле");

            if (product != null)
            {
                var qty = product.Package.Qty.Text;
                Log?.Invoke($"Получение текущей цены продукта их XML файла. Артикул: [{product.Article}]. Qty: {qty}.");

                var retailPrice = product.Prices.Price.First(f => f.Type == "retail").Text;
                Log?.Invoke($"Получение текущей цены продукта их XML файла. Артикул: [{product.Article}]. Цена: {retailPrice}.");

                var isReturn = false;

                if (string.IsNullOrWhiteSpace(qty))
                {
                    NoQty++;
                    isReturn = true;
                }

                if (string.IsNullOrWhiteSpace(retailPrice))
                {
                    NoPrice++;
                    isReturn = true;
                }

                if (decimal.TryParse(qty.Replace(".", ","), out decimal qtyResult))
                {
                    if (decimal.TryParse(retailPrice.Replace(".", ","), out decimal retailPriceResult))
                    {
                        retailPrice = (qtyResult * retailPriceResult).ToString();
                    }
                    else
                    {
                        isReturn = true;
                    }
                }
                else
                {
                    isReturn = true;
                }


                if (isReturn)
                {
                    return;
                }


                var indexExcelColumnCurrentPrice = GetColumnIndex(_excelSetting.ColumnCurrentPrice, columnDictionary);
                var currentPrice = worksheet.Cells[i, indexExcelColumnCurrentPrice].Value?.ToString();
                Log?.Invoke($"Получение текущей цены продукта их Excel файла. Артикул: [{product.Article}]. Цена: {currentPrice}.");

                if (string.IsNullOrWhiteSpace(currentPrice))
                {
                    CountNoPrice++;
                }

                var indexExcelColumnSetCurrentPrice = GetColumnIndex(_excelSetting.ColumnSetCurrentPrice, columnDictionary);
                worksheet.Cells[i, indexExcelColumnSetCurrentPrice].Value = currentPrice?.Replace(".", ",");
                Log?.Invoke($"Перенос старой цены в Excel файле. Артикул: [{product.Article}]. Цена: {currentPrice}.");

                if (!string.IsNullOrWhiteSpace(_excelSetting.Percent))
                {
                    if (_excelSetting.Percent != "+0" && _excelSetting.Percent != "-0" && _excelSetting.Percent != "0")
                    {
                        if (_excelSetting.Percent.Contains("+"))
                        {
                            if (int.TryParse(_excelSetting.Percent.Replace("+", "").Trim(), out int result))
                            {
                                if (decimal.TryParse(retailPrice.Replace(".", ","), out decimal resultPrice))
                                {
                                    var value = (resultPrice + (resultPrice * result / 100));
                                    retailPrice = value.ToString("n2");
                                    CountPercentageApplied++;
                                }
                            }
                        }

                        if (_excelSetting.Percent.Contains("-"))
                        {
                            if (int.TryParse(_excelSetting.Percent.Replace("-", "").Trim(), out int result))
                            {
                                if (decimal.TryParse(retailPrice.Replace(".", ","), out decimal resultPrice))
                                {
                                    var value = (resultPrice - (resultPrice * result / 100));
                                    retailPrice = value.ToString("n2");
                                    CountPercentageApplied++;
                                }
                            }
                        }
                    }
                }


                CheckingGreaterValue(currentPrice, retailPrice);

                var indexExcelColumnSetNewPrice = GetColumnIndex(_excelSetting.ColumnSetNewPrice, columnDictionary);
                worksheet.Cells[i, indexExcelColumnSetNewPrice].Value = retailPrice?.Replace(".", ",");
                Log?.Invoke($"Перенос новой цены в Excel файле. Артикул: [{product.Article}]. Цена: {retailPrice}.");

                CountSubstitutions++;
            }
        }

        private void BaseMethod(Data data, ExcelWorksheet worksheet, Dictionary<int, string> columnDictionary, int i, string excelArticle)
        {
            var product = data.Product
                .Where(w => w.Prices != null
                    && w.Prices.Price != null
                    && w.Prices.Price.FirstOrDefault(f => f.Type == "retail") != null)
                .FirstOrDefault(f => f.Article != null && f.Article.Equals(excelArticle));
            Log?.Invoke($"Поиск артикля в XML файле");

            if (product != null)
            {
                var retailPrice = product.Prices.Price.First(f => f.Type == "retail").Text;
                Log?.Invoke($"Получение текущей цены продукта их XML файла. Артикул: [{product.Article}]. Цена: {retailPrice}.");

                var indexExcelColumnCurrentPrice = GetColumnIndex(_excelSetting.ColumnCurrentPrice, columnDictionary);
                var currentPrice = worksheet.Cells[i, indexExcelColumnCurrentPrice].Value?.ToString();
                Log?.Invoke($"Получение текущей цены продукта их Excel файла. Артикул: [{product.Article}]. Цена: {currentPrice}.");

                if (string.IsNullOrWhiteSpace(currentPrice))
                {
                    CountNoPrice++;
                }

                var indexExcelColumnSetCurrentPrice = GetColumnIndex(_excelSetting.ColumnSetCurrentPrice, columnDictionary);
                worksheet.Cells[i, indexExcelColumnSetCurrentPrice].Value = currentPrice?.Replace(".", ",");
                Log?.Invoke($"Перенос старой цены в Excel файле. Артикул: [{product.Article}]. Цена: {currentPrice}.");

                if (!string.IsNullOrWhiteSpace(_excelSetting.Percent))
                {
                    if (_excelSetting.Percent != "+0" && _excelSetting.Percent != "-0" && _excelSetting.Percent != "0")
                    {
                        if (_excelSetting.Percent.Contains("+"))
                        {
                            if (int.TryParse(_excelSetting.Percent.Replace("+", "").Trim(), out int result))
                            {
                                if (decimal.TryParse(retailPrice.Replace(".", ","), out decimal resultPrice))
                                {
                                    var value = (resultPrice + (resultPrice * result / 100));
                                    retailPrice = value.ToString("n2");
                                    CountPercentageApplied++;
                                }
                            }
                        }

                        if (_excelSetting.Percent.Contains("-"))
                        {
                            if (int.TryParse(_excelSetting.Percent.Replace("-", "").Trim(), out int result))
                            {
                                if (decimal.TryParse(retailPrice.Replace(".", ","), out decimal resultPrice))
                                {
                                    var value = (resultPrice - (resultPrice * result / 100));
                                    retailPrice = value.ToString("n2");
                                    CountPercentageApplied++;
                                }
                            }
                        }
                    }
                }


                CheckingGreaterValue(currentPrice, retailPrice);

                var indexExcelColumnSetNewPrice = GetColumnIndex(_excelSetting.ColumnSetNewPrice, columnDictionary);
                worksheet.Cells[i, indexExcelColumnSetNewPrice].Value = retailPrice?.Replace(".", ",");
                Log?.Invoke($"Перенос новой цены в Excel файле. Артикул: [{product.Article}]. Цена: {retailPrice}.");

                CountSubstitutions++;
            }
        }

        private void CheckingGreaterValue(string currentPrice, string newPrice)
        {
            var currentPriceValue = default(decimal);
            var newPriceValue = default(decimal);

            if (decimal.TryParse(currentPrice?.Replace(".", ","), out currentPriceValue)) { }
            if (decimal.TryParse(newPrice?.Replace(".", ","), out newPriceValue)) { }

            if (currentPriceValue > newPriceValue)
            {
                CountCurrentPriceHigherThanNew++;
            }
            else if (currentPriceValue < newPriceValue)
            {
                CountCurrentPriceLessThanNew++;
            }
            else if (currentPriceValue == newPriceValue)
            {
                NumberOfIdenticalValues++;
            }
            else if (currentPriceValue != newPriceValue)
            {
                NumberOfDifferentlValues++;
            }
        }

        private string CheckingSettings(ExcelSetting excelSetting, Dictionary<int, string> columnDictionary)
        {
            try
            {
                CheckColumn(excelSetting.ColumnArticle, columnDictionary);
                CheckColumn(excelSetting.ColumnCurrentPrice, columnDictionary);
                CheckColumn(excelSetting.ColumnSetCurrentPrice, columnDictionary);
                CheckColumn(excelSetting.ColumnSetNewPrice, columnDictionary);
                //CheckColumn(excelSetting.Percent, columnDictionary);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return default;
        }

        private static bool CheckColumn(string obj, Dictionary<int, string> columnDictionary)
        {
            var returnResult = default(bool);

            if (int.TryParse(obj, out int result))
            {
                returnResult = columnDictionary.ContainsKey(result);
            }
            else
            {
                returnResult = columnDictionary.ContainsValue(obj?.ToUpper());
            }

            if (returnResult is false)
            {
                throw new Exception($"Столбец [{obj}] не найден. Проверьте настройки программы.");
            }

            return returnResult;
        }

        private static int GetColumnIndex(string obj, Dictionary<int, string> columnDictionary)
        {
            if (int.TryParse(obj, out int result))
            {
                return result;
            }
            else
            {
                return columnDictionary.First(f => f.Value == obj.ToUpper()).Key;
            }
        }

        private Dictionary<int, string> GetColumnDictionary(ExcelWorksheet worksheet)
        {
            Log?.Invoke($"Формирование словаря индекса всех используемых столбцов.");
            var result = new Dictionary<int, string>();
            foreach (var item in worksheet.Columns)
            {
                var columnPosition = item.StartColumn;
                var columnName = ExcelCellAddress.GetColumnLetter(columnPosition).ToUpper();

                if (!result.ContainsKey(columnPosition))
                {
                    result.Add(columnPosition, columnName);
                    Log?.Invoke($"Добавление столбца ({columnName} [{columnPosition}]) в словарь.");
                }
            }

            return result;
        }

        private void SentWriter(int rowCount, int i)
        {
            Writer?.Invoke(i, rowCount, CountSubstitutions);
        }
    }
}
