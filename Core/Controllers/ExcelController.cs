using Core.Models.Original;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace Core.Controllers
{
    public class ExcelWriter : IDisposable
    {
        private bool _isEpPlus;

        private string _path;
        private string _sheetName;
        private int _columnEditNumber;
        private int _columnDeleteNumber;
        private bool _isDeleteColumnNumber;

        private Excel.Application _excelApplication;
        private Excel.Workbook _workbook;
        private Excel._Worksheet _worksheet;
        private Excel.Range _range;

        public int Count { get; private set; }
        public int CountSubstitutions { get; private set; }
        public int CountZeroSubstitutions { get; private set; }

        public delegate void WriterEventHandler(int position, int count, int countSubstitutions);
        public event WriterEventHandler Writer;


        public delegate void LogEventHandler(string message);
        public event LogEventHandler Log;

        public ExcelWriter(string path, 
            string sheetName = "Остатки", 
            int columnEditNumber = 5, 
            int columnDeleteNumber = 6, 
            bool isDeleteColumnNumber = false)
        {
            _path = path;
            _sheetName = sheetName;
            _columnEditNumber = columnEditNumber;
            _columnDeleteNumber = columnDeleteNumber;
            _isDeleteColumnNumber = isDeleteColumnNumber;
        }
        
        public void StartWriterEPPlus(Data data)
        {
            _isEpPlus = true;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            Log?.Invoke($"Открытие файла: {_path}");
            using (var package = new ExcelPackage(_path))
            {
                Log?.Invoke($"Поиск индекса страницы файла Excel по наименованию.");
                foreach (var worksheet in package.Workbook.Worksheets)
                {
                    Log?.Invoke($"Найдена страница: [{worksheet.Index}] {worksheet.Name}");
                    if (worksheet.Name.Equals(_sheetName))
                    {
                        Log?.Invoke($"Найдена необходимая страница: [{worksheet.Index}] {worksheet.Name}");

                        var rowCount = worksheet.Dimension.End.Row;
                        Log?.Invoke($"Строк для обработки файла Excel: {rowCount}");

                        Count = rowCount - 2;

                        for (int i = 1; i <= rowCount; i++)
                        {
                            string excelArticle = worksheet.Cells[i, _columnDeleteNumber].Value?.ToString();
                            Log?.Invoke($"Получение артикля из ячейки [{i}; {_columnDeleteNumber}] : {excelArticle ?? "NULL"}");

                            if (!string.IsNullOrWhiteSpace(excelArticle))
                            {
                                var product = data.Product
                                    .Where(w => w.Instock?.Stock?.Type != null && w.Instock.Stock.Type.Equals("free"))
                                    .FirstOrDefault(f => f.Article != null && f.Article.Equals(excelArticle));
                                Log?.Invoke($"Поиск артикля в XML файле");

                                if (product != null)
                                {
                                    var value = product?.Instock?.Stock?.Text ?? string.Empty;
                                    Log?.Invoke($"Найдено значение для артикля [{excelArticle}]: {value ?? "NULL"}");

                                    worksheet.Cells[i, _columnEditNumber].Value = value;
                                    Log?.Invoke($"Подстановка артикула [{value}] в ячейку [{i}, {_columnEditNumber}]");

                                    CountSubstitutions++;
                                }
                                else
                                {
                                    if (i > 1)
                                    {
                                        worksheet.Cells[i, _columnEditNumber].Value = "0";
                                        Log?.Invoke($"НЕ найдено значение для артикля: {excelArticle}");
                                        CountZeroSubstitutions++;
                                    }                                    
                                }

                                if (_isDeleteColumnNumber)
                                {
                                    worksheet.Cells[i, _columnDeleteNumber].Value = string.Empty;
                                }
                            }

                            SentWriter(rowCount, i);                        
                        }
                    }
                }

                package.Save();
            }
        }

        public void StartWriter(Data data)
        {
            _isEpPlus = false;
            if (System.IO.File.Exists(_path) is false)
            {
                Log?.Invoke($"Не найден файл: {_path}");
                return;
            }

            try
            {
                Log?.Invoke($"Создание новой сессии Excel");
                _excelApplication = new Excel.Application();

                Log?.Invoke($"Открытие файла: {_path}");
                _workbook = _excelApplication.Workbooks.Open(_path);

                Log?.Invoke($"Поиск индекса страницы файла Excel по наименованию.");
                var worksheetIndex = default(int?);
                foreach (Excel.Worksheet sheet in _workbook.Sheets)
                {
                    Log?.Invoke($"Найдена страница: [{sheet.Index}] {sheet.Name}");
                    if (sheet.Name == _sheetName 
                        || sheet.CodeName == _sheetName 
                        || sheet._CodeName == _sheetName)
                    {
                        worksheetIndex = sheet.Index;
                        Log?.Invoke($"Найден необходимый индекс: {worksheetIndex}");
                        break;
                    }
                }

                if (worksheetIndex is null)
                {
                    Log?.Invoke($"Не найден индекс страницы по имени. Подставка стандартного значения: 2");
                    return;
                }

                Log?.Invoke($"Открытие страницы файла Excel по индексу: {worksheetIndex}");
                _worksheet = _workbook.Sheets[worksheetIndex];

                Log?.Invoke($"Получение рабочей зоны");
                _range = _worksheet.UsedRange;

                var rowCount = _range.Rows.Count;
                Log?.Invoke($"Строк для обработки файла Excel: {rowCount}");

                Count = rowCount - 2;

                for (int i = 1; i <= rowCount; i++)
                {
                    string excelArticle = _worksheet.Cells[i, _columnDeleteNumber].Value?.ToString();
                    Log?.Invoke($"Получение артикля из ячейки [{i}; {_columnDeleteNumber}] : {excelArticle ?? "NULL"}");

                    if (!string.IsNullOrWhiteSpace(excelArticle))
                    {
                        var product = data.Product
                            .Where(w => w.Instock?.Stock?.Type != null && w.Instock.Stock.Type.Equals("free"))
                            .FirstOrDefault(f => f.Article != null && f.Article.Equals(excelArticle));
                        Log?.Invoke($"Поиск артикля в XML файле");

                        if (product != null)
                        {
                            var value = product?.Instock?.Stock?.Text ?? string.Empty;
                            Log?.Invoke($"Найдено значение для артикля [{excelArticle}]: {value ?? "NULL"}");

                            _worksheet.Cells[i, _columnEditNumber].Value = value;
                            Log?.Invoke($"Подстановка артикула [{value}] в ячейку [{i}, {_columnEditNumber}]");

                            CountSubstitutions++;
                        }
                        else
                        {
                            if (i > 1)
                            {
                                _worksheet.Cells[i, _columnEditNumber].Value = "0";
                                Log?.Invoke($"НЕ найдено значение для артикля: {excelArticle}");
                                CountZeroSubstitutions++;
                            }
                        }

                        if (_isDeleteColumnNumber)
                        {
                            _worksheet.Cells[i, _columnDeleteNumber].Value = string.Empty;
                        }
                    }

                    SentWriter(rowCount, i);
                }

                _workbook.Save();
                Log?.Invoke($"Сохранение файла: {_path}");
            }
            catch (Exception ex)
            {
                Log?.Invoke($"{ex.Message}");
                Debug.WriteLine(ex);
                Dispose();
            }
        }

        private void SentWriter(int rowCount, int i)
        {
            Writer?.Invoke(i, rowCount, CountSubstitutions);
        }

        public void Dispose()
        {
            if (_isEpPlus)
            {
                return;
            }

            try
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();

                if (_worksheet != null)
                {
                    Marshal.ReleaseComObject(_worksheet);
                }

                _workbook?.Close();
                if (_workbook != null)
                {
                    Marshal.ReleaseComObject(_workbook);
                }

                _excelApplication?.Quit();
                if (_excelApplication != null)
                {
                    Marshal.ReleaseComObject(_excelApplication);
                }
            }
            catch (Exception ex)
            {
                Log?.Invoke($"{ex.Message}");
                Debug.WriteLine(ex);
            }

            try
            {
                var excelProcesses = Process.GetProcessesByName("excel");
                foreach (var process in excelProcesses)
                {
                    if (string.IsNullOrEmpty(process.MainWindowTitle))
                    {
                        Log?.Invoke($"Закрытие процесса: {process.ProcessName}");
                        process.Kill();
                    }
                }
            }
            catch (Exception ex)
            {
                Log?.Invoke($"{ex.Message}");
                Debug.WriteLine(ex);
            }
        }
    }
}
