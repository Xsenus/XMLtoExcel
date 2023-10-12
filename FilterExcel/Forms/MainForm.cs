using FilterExcel.Controllers;
using FilterExcel.Models;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FilterExcel.Forms
{
    public partial class MainForm : Form
    {
        private Setting _setting;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _setting = SettingController.GetSetting();

            txtExcel.Text = _setting.Excel;
            txtExcelWorksheet.Text = _setting.ExcelWorksheet;
            txtRowPosition.Text = _setting.RowPosition;
            txtCol1.Text = _setting.Column1;
            txtCol2.Text = _setting.Column2;
            txtCol3.Text = _setting.Column3;
            txtCol4.Text = _setting.Column4;
            txtCol5.Text = _setting.Column5;
            txtCol6.Text = _setting.Column6;
            txtCol7.Text = _setting.Column7;
            cmbCol1.Text = _setting.ComboBoxValue1;
            cmbCol2.Text = _setting.ComboBoxValue2;
            cmbCol3.Text = _setting.ComboBoxValue3;
            cmbCol4.Text = _setting.ComboBoxValue4;
            cmbCol5.Text = _setting.ComboBoxValue5;
            cmbCol6.Text = _setting.ComboBoxValue6;
            cmbCol7.Text = _setting.ComboBoxValue7;
            txtVendorCodeColumn.Text = _setting.VendorCodeColumn;
            txtNewColumnValue.Text = _setting.NewColumnValue;
            txtValue.Text = _setting.Value;
        }

        private void SaveSetting()
        {
            _setting.Excel = txtExcel.Text;
            _setting.ExcelWorksheet = txtExcelWorksheet.Text;
            _setting.RowPosition = txtRowPosition.Text;
            _setting.Column1 = txtCol1.Text;
            _setting.Column2 = txtCol2.Text;
            _setting.Column3 = txtCol3.Text;
            _setting.Column4 = txtCol4.Text;
            _setting.Column5 = txtCol5.Text;
            _setting.Column6 = txtCol6.Text;
            _setting.Column7 = txtCol7.Text;
            _setting.ComboBoxValue1 = cmbCol1.Text;
            _setting.ComboBoxValue2 = cmbCol2.Text;
            _setting.ComboBoxValue3 = cmbCol3.Text;
            _setting.ComboBoxValue4 = cmbCol4.Text;
            _setting.ComboBoxValue5 = cmbCol5.Text;
            _setting.ComboBoxValue6 = cmbCol6.Text;
            _setting.ComboBoxValue7 = cmbCol7.Text;
            _setting.VendorCodeColumn = txtVendorCodeColumn.Text;
            _setting.NewColumnValue = txtNewColumnValue.Text;
            _setting.Value = txtValue.Text;
            _setting.Save();
        }

        private void btnOpenExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog();
        }

        private void txtExcel_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog();
        }

        private void OpenFileDialog()
        {
            using (var ofd = new OpenFileDialog()
            {
                Filter = "Excel Files (.xlsx)|*.xlsx|Excel Files(.xls)|*.xls|Excel Files(*.xlsm)|*.xlsm"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtExcel.Text = ofd.FileName;
                }
            }
        }

        private void btnFillValue_Click(object sender, EventArgs e)
        {
            var filePath = txtExcel.Text;
            if (string.IsNullOrWhiteSpace(filePath))
            {
                MessageBox.Show(
                    "Укажите путь до файла Excel.",
                    "Информационное сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtExcel.Focus();
                return;
            }

            if (!File.Exists(filePath))
            {
                MessageBox.Show(
                    $"Не найден файл по заданному пути: {filePath}",
                    "Информационное сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtExcel.Focus();
                return;
            }

            var excelWorksheet = txtExcelWorksheet.Text;
            if (string.IsNullOrWhiteSpace(excelWorksheet))
            {
                MessageBox.Show(
                    $"Задайте номер или имя страницы Excel.",
                    "Информационное сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtExcelWorksheet.Focus();
                return;
            }

            var rowPosition = txtRowPosition.Text;
            if (int.TryParse(rowPosition, out int resultRowPosition))
            {
                if (resultRowPosition < 1)
                {
                    MessageBox.Show(
                    $"Номер первой строки должен быть больше 1.",
                    "Информационное сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    txtRowPosition.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show(
                    $"Задайте номер первой строки, с которой будет происходить чтение Excel значений.",
                    "Информационное сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtRowPosition.Focus();
                return;
            }

            var collection = GetUsingComboBoxControls();
            if (collection.Count == 0)
            {
                MessageBox.Show(
                    $"Для поиска доступных параметров задайте номера столбцов.",
                    "Информационное сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            using (var excelPackage = new ExcelPackage(filePath))
            {
                var worksheet = default(ExcelWorksheet);
                try
                {
                    if (int.TryParse(excelWorksheet, out int resultExcelWorksheet))
                    {
                        worksheet = excelPackage.Workbook.Worksheets[resultExcelWorksheet];
                    }
                    else
                    {
                        worksheet = excelPackage.Workbook.Worksheets[excelWorksheet];
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show(
                       $"Указанная страница не найдена в текущем Excel файле. Попробуйте другое значение",
                       "Информационное сообщение",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    txtExcelWorksheet.Focus();
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"{ex.Message}",
                        "Информационное сообщение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtExcelWorksheet.Focus();
                    return;
                }

                if (worksheet is null)
                {
                    MessageBox.Show(
                       $"Указанная страница не найдена в текущем Excel файле. Попробуйте другое значение",
                       "Информационное сообщение",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    txtExcelWorksheet.Focus();
                    return;
                }

                var collectionUsingExcelColumn = new List<UsingExcelColumn>();
                foreach (var item in worksheet.Columns)
                {
                    var id = item.StartColumn;
                    var name = item.Range.Address.Split(':').First();
                    collectionUsingExcelColumn.Add(new UsingExcelColumn(name, id));
                }

                foreach (var item in collection)
                {
                    var usingExcelColumn = default(UsingExcelColumn);
                    if (int.TryParse(item.ExcelColumnName, out int resultExcelColumnIndex))
                    {
                        usingExcelColumn = collectionUsingExcelColumn.First(f => f.Index == resultExcelColumnIndex);
                    }
                    else
                    {
                        usingExcelColumn = collectionUsingExcelColumn.First(f => f.Name.Equals(item.ExcelColumnName, StringComparison.OrdinalIgnoreCase));
                    }

                    var lastRow = worksheet.Cells.LastOrDefault(c => c.Start.Column == usingExcelColumn.Index);
                    if (lastRow != null)
                    {
                        var lastRowAddress = string.Join(string.Empty, lastRow?.Address?.Where(char.IsDigit));

                        if (int.TryParse(lastRowAddress, out int resultLastRow))
                        {
                            var colletctionValue = new List<string>();
                            for (int i = resultRowPosition; i <= resultLastRow; i++)
                            {
                                try
                                {
                                    colletctionValue.Add(worksheet.Cells[i, usingExcelColumn.Index].Text?.ToString());
                                }
                                catch (Exception) { }
                            }
                            colletctionValue = colletctionValue.Distinct().Where(w => !string.IsNullOrWhiteSpace(w)).ToList();
                            item.ComboBox.Items.AddRange(colletctionValue.ToArray());
                        }
                    }
                }
            }

            MessageBox.Show(
                    $"Значения для указанных столбцов успешно заполнены.",
                    "Информационное сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private List<UsingComboBox> GetUsingComboBoxControls(bool isSetDefaultValue = true)
        {
            var collection = new List<UsingComboBox>();
            foreach (var item in Controls)
            {
                if (item is TextBox textBox && textBox.Name.Contains("txtCol"))
                {
                    var number = textBox.Name.Replace("txtCol", string.Empty);
                    if (int.TryParse(number, out int numberResult))
                    {
                        var comboBoxCollection = Controls.Find($"cmbCol{numberResult}", false);
                        if (comboBoxCollection.Length >= 1)
                        {
                            if (comboBoxCollection[0] is ComboBox comboBox)
                            {
                                var value = textBox.Text;
                                if (!string.IsNullOrWhiteSpace(value))
                                {
                                    comboBox.Items.Clear();
                                    if (isSetDefaultValue)
                                    {
                                        comboBox.Text = default;
                                    }
                                    var obj = new UsingComboBox(numberResult, value, comboBox);
                                    collection.Add(obj);
                                }
                            }
                        }
                    }
                }
            }

            return collection.OrderBy(o => o.FilterPosition).ToList();
        }

        public class UsingComboBox
        {
            public UsingComboBox(int filterPosition, string excelColumnName, ComboBox comboBox)
            {
                FilterPosition = filterPosition;
                ExcelColumnName = excelColumnName ?? throw new ArgumentNullException(nameof(excelColumnName));
                ComboBox = comboBox ?? throw new ArgumentNullException(nameof(comboBox));
            }

            public int FilterPosition { get; }
            public string ExcelColumnName { get; }
            public ComboBox ComboBox { get; }
            public string ComboBoxValue => ComboBox?.Text;

            public override string ToString()
            {
                return ExcelColumnName;
            }
        }

        private void btnWorkOutExcel_Click(object sender, EventArgs e)
        {
            var filePath = txtExcel.Text;
            if (string.IsNullOrWhiteSpace(filePath))
            {
                MessageBox.Show(
                    "Укажите путь до файла Excel.",
                    "Информационное сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtExcel.Focus();
                return;
            }

            if (!File.Exists(filePath))
            {
                MessageBox.Show(
                    $"Не найден файл по заданному пути: {filePath}",
                    "Информационное сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtExcel.Focus();
                return;
            }

            var excelWorksheet = txtExcelWorksheet.Text;
            if (string.IsNullOrWhiteSpace(excelWorksheet))
            {
                MessageBox.Show(
                    $"Задайте номер или имя страницы Excel.",
                    "Информационное сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtExcelWorksheet.Focus();
                return;
            }

            var rowPosition = txtRowPosition.Text;
            if (int.TryParse(rowPosition, out int resultRowPosition))
            {
                if (resultRowPosition < 1)
                {
                    MessageBox.Show(
                    $"Номер первой строки должен быть больше 1.",
                    "Информационное сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    txtRowPosition.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show(
                    $"Задайте номер первой строки, с которой будет происходить чтение Excel значений.",
                    "Информационное сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtRowPosition.Focus();
                return;
            }


            var vendorCodeColumn = txtVendorCodeColumn.Text;
            if (string.IsNullOrWhiteSpace(vendorCodeColumn))
            {
                MessageBox.Show(
                    $"Задайте номер или имя столбца с артикулом",
                    "Информационное сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtVendorCodeColumn.Focus();
                return;
            }

            var newColumnValue = txtNewColumnValue.Text;
            if (string.IsNullOrWhiteSpace(newColumnValue))
            {
                MessageBox.Show(
                    $"Задайте номер или имя столбца, в который будет установлено новое значение.",
                    "Информационное сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtNewColumnValue.Focus();
                return;
            }

            var value = txtValue.Text;
            if (string.IsNullOrWhiteSpace(value))
            {
                MessageBox.Show(
                    $"Задайте символ, который будет добавлен перед артикулом.",
                    "Информационное сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtValue.Focus();
                return;
            }

            var collectionUsingComboBox = GetUsingComboBoxControls(false);
            if (collectionUsingComboBox.Count == 0)
            {
                if (MessageBox.Show(
                        $"Нет активных фильтров, хотите продолжить операцию без фильтрации?",
                        "Информационное сообщение",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question) != DialogResult.OK)
                {
                    return;
                }
            }

            var isUseFilter = false;

            foreach (var item in collectionUsingComboBox)
            {
                var filterValue = item.ComboBox.Text;
                if (!string.IsNullOrWhiteSpace(filterValue))
                {
                    isUseFilter = true;
                    break;

                    //if (MessageBox.Show(
                    //    $"Не задано значение фильтра для столбца № {item.FilterPosition}. Продолжить с пустым значением?",
                    //    "Информационное сообщение",
                    //    MessageBoxButtons.OKCancel,
                    //    MessageBoxIcon.Question) != DialogResult.OK)
                    //{
                    //    return;
                    //}
                }
            }

            SaveSetting();

            var dateTimeStart = DateTime.Now;

            var generalMeaning = 0;
            var valuesChanged = 0;

            using (var excelPackage = new ExcelPackage(filePath))
            {
                var worksheet = default(ExcelWorksheet);
                try
                {
                    if (int.TryParse(excelWorksheet, out int resultExcelWorksheet))
                    {
                        worksheet = excelPackage.Workbook.Worksheets[resultExcelWorksheet];
                    }
                    else
                    {
                        worksheet = excelPackage.Workbook.Worksheets[excelWorksheet];
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show(
                       $"Указанная страница не найдена в текущем Excel файле. Попробуйте другое значение",
                       "Информационное сообщение",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    txtExcelWorksheet.Focus();
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"{ex.Message}",
                        "Информационное сообщение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtExcelWorksheet.Focus();
                    return;
                }

                if (worksheet is null)
                {
                    MessageBox.Show(
                       $"Указанная страница не найдена в текущем Excel файле. Попробуйте другое значение",
                       "Информационное сообщение",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    txtExcelWorksheet.Focus();
                    return;
                }

                var collectionUsingExcelColumn = new List<UsingExcelColumn>();
                foreach (var item in worksheet.Columns)
                {
                    var id = item.StartColumn;
                    var name = item.Range.Address.Split(':').First();
                    collectionUsingExcelColumn.Add(new UsingExcelColumn(name, id));

                    if (collectionUsingExcelColumn.Count >= 500)
                    {
                        break;
                    }
                }

                var vendorCodeExcelColumn = GetUsingExcelColumn(collectionUsingExcelColumn, vendorCodeColumn);
                var newColumnExcelValue = GetUsingExcelColumn(collectionUsingExcelColumn, newColumnValue);
                var countDataTableRow = worksheet.Dimension.End.Row;

                if (isUseFilter)
                {
                    var firstVendorCode = default(string);
                    for (int i = resultRowPosition; i < countDataTableRow; i++)
                    {
                        generalMeaning++;
                        ProcessingFilterEnabled(value, collectionUsingComboBox, ref valuesChanged, worksheet, collectionUsingExcelColumn, ref firstVendorCode, vendorCodeExcelColumn, newColumnExcelValue, i);
                    }
                }
                else
                {
                    var dataExcel = new List<DataExcel>();
                    for (int i = resultRowPosition; i < countDataTableRow + 1; i++)
                    {
                        generalMeaning++;
                        var obj = new object[collectionUsingExcelColumn.Count];
                        for (int j = 0; j <= collectionUsingExcelColumn.Count - 1; j++)
                        {
                            obj[j] = worksheet.Cells[i, j + 1].Value;
                        }
                        dataExcel.Add(new DataExcel(i, obj?.Select(s => s?.ToString())?.ToList()));
                    }

                    var usingExcelColumns = new List<UsingExcelColumn>();
                    var possibleValues = new List<HashSet<string>>();
                    foreach (var item in collectionUsingComboBox)
                    {
                        var filterColumn = GetUsingExcelColumn(collectionUsingExcelColumn, item.ExcelColumnName);
                        usingExcelColumns.Add(filterColumn);
                        possibleValues.Add(GetPossibleValues(dataExcel, filterColumn.Index));
                    }

                    if (usingExcelColumns.Count == 7)
                    {
                        var groupListDataExcel = dataExcel.GroupBy(group => new
                        {
                            Column1 = group.GetValueByColumn(usingExcelColumns[0].Index),
                            Column2 = group.GetValueByColumn(usingExcelColumns[1].Index),
                            Column3 = group.GetValueByColumn(usingExcelColumns[2].Index),
                            Column4 = group.GetValueByColumn(usingExcelColumns[3].Index),
                            Column5 = group.GetValueByColumn(usingExcelColumns[4].Index),
                            Column6 = group.GetValueByColumn(usingExcelColumns[5].Index),
                            Column7 = group.GetValueByColumn(usingExcelColumns[6].Index),
                        });

                        foreach (var item in groupListDataExcel)
                        {
                            var firstVendorCode = item.First().GetValueByColumn(vendorCodeExcelColumn.Index);
                            var newValue = $"{value}{firstVendorCode}";

                            foreach (var objDataExcel in item)
                            {
                                if (item.Count() > 1)
                                {
                                    worksheet.Cells[objDataExcel.Row, newColumnExcelValue.Index].Value = newValue;
                                    valuesChanged++;
                                }
                                else
                                {
                                    worksheet.Cells[objDataExcel.Row, newColumnExcelValue.Index].Value = string.Empty;
                                }
                            }
                        }

                    }
                    else if (usingExcelColumns.Count == 6)
                    {
                        var groupListDataExcel = dataExcel.GroupBy(group => new
                        {
                            Column1 = group.GetValueByColumn(usingExcelColumns[0].Index),
                            Column2 = group.GetValueByColumn(usingExcelColumns[1].Index),
                            Column3 = group.GetValueByColumn(usingExcelColumns[2].Index),
                            Column4 = group.GetValueByColumn(usingExcelColumns[3].Index),
                            Column5 = group.GetValueByColumn(usingExcelColumns[4].Index),
                            Column6 = group.GetValueByColumn(usingExcelColumns[5].Index),
                        });

                        foreach (var item in groupListDataExcel)
                        {
                            var firstVendorCode = item.First().GetValueByColumn(vendorCodeExcelColumn.Index);
                            var newValue = $"{value}{firstVendorCode}";

                            foreach (var objDataExcel in item)
                            {
                                if (item.Count() > 1)
                                {
                                    worksheet.Cells[objDataExcel.Row, newColumnExcelValue.Index].Value = newValue;
                                    valuesChanged++;
                                }
                                else
                                {
                                    worksheet.Cells[objDataExcel.Row, newColumnExcelValue.Index].Value = string.Empty;
                                }
                            }
                        }
                    }
                    else if (usingExcelColumns.Count == 5)
                    {
                        var groupListDataExcel = dataExcel.GroupBy(group => new
                        {
                            Column1 = group.GetValueByColumn(usingExcelColumns[0].Index),
                            Column2 = group.GetValueByColumn(usingExcelColumns[1].Index),
                            Column3 = group.GetValueByColumn(usingExcelColumns[2].Index),
                            Column4 = group.GetValueByColumn(usingExcelColumns[3].Index),
                            Column5 = group.GetValueByColumn(usingExcelColumns[4].Index),
                        });

                        foreach (var item in groupListDataExcel)
                        {
                            var firstVendorCode = item.First().GetValueByColumn(vendorCodeExcelColumn.Index);
                            var newValue = $"{value}{firstVendorCode}";

                            foreach (var objDataExcel in item)
                            {
                                if (item.Count() > 1)
                                {
                                    worksheet.Cells[objDataExcel.Row, newColumnExcelValue.Index].Value = newValue;
                                    valuesChanged++;
                                }
                                else
                                {
                                    worksheet.Cells[objDataExcel.Row, newColumnExcelValue.Index].Value = string.Empty;
                                }
                            }
                        }
                    }
                    else if (usingExcelColumns.Count == 4)
                    {
                        var groupListDataExcel = dataExcel.GroupBy(group => new
                        {
                            Column1 = group.GetValueByColumn(usingExcelColumns[0].Index),
                            Column2 = group.GetValueByColumn(usingExcelColumns[1].Index),
                            Column3 = group.GetValueByColumn(usingExcelColumns[2].Index),
                            Column4 = group.GetValueByColumn(usingExcelColumns[3].Index),
                        });

                        foreach (var item in groupListDataExcel)
                        {
                            var firstVendorCode = item.First().GetValueByColumn(vendorCodeExcelColumn.Index);
                            var newValue = $"{value}{firstVendorCode}";

                            foreach (var objDataExcel in item)
                            {
                                if (item.Count() > 1)
                                {
                                    worksheet.Cells[objDataExcel.Row, newColumnExcelValue.Index].Value = newValue;
                                    valuesChanged++;
                                }
                                else
                                {
                                    worksheet.Cells[objDataExcel.Row, newColumnExcelValue.Index].Value = string.Empty;
                                }
                            }
                        }
                    }
                    else if (usingExcelColumns.Count == 3)
                    {
                        var groupListDataExcel = dataExcel.GroupBy(group => new
                        {
                            Column1 = group.GetValueByColumn(usingExcelColumns[0].Index),
                            Column2 = group.GetValueByColumn(usingExcelColumns[1].Index),
                            Column3 = group.GetValueByColumn(usingExcelColumns[2].Index),
                        });

                        foreach (var item in groupListDataExcel)
                        {
                            var firstVendorCode = item.First().GetValueByColumn(vendorCodeExcelColumn.Index);
                            var newValue = $"{value}{firstVendorCode}";

                            foreach (var objDataExcel in item)
                            {
                                if (item.Count() > 1)
                                {
                                    worksheet.Cells[objDataExcel.Row, newColumnExcelValue.Index].Value = newValue;
                                    valuesChanged++;
                                }
                                else
                                {
                                    worksheet.Cells[objDataExcel.Row, newColumnExcelValue.Index].Value = string.Empty;
                                }
                            }
                        }
                    }
                    else if (usingExcelColumns.Count == 2)
                    {
                        var groupListDataExcel = dataExcel.GroupBy(group => new
                        {
                            Column1 = group.GetValueByColumn(usingExcelColumns[0].Index),
                            Column2 = group.GetValueByColumn(usingExcelColumns[1].Index),
                        });

                        foreach (var item in groupListDataExcel)
                        {
                            var firstVendorCode = item.First().GetValueByColumn(vendorCodeExcelColumn.Index);
                            var newValue = $"{value}{firstVendorCode}";

                            foreach (var objDataExcel in item)
                            {
                                if (item.Count() > 1)
                                {
                                    worksheet.Cells[objDataExcel.Row, newColumnExcelValue.Index].Value = newValue;
                                    valuesChanged++;
                                }
                                else
                                {
                                    worksheet.Cells[objDataExcel.Row, newColumnExcelValue.Index].Value = string.Empty;
                                }
                            }
                        }

                    }
                    else if (usingExcelColumns.Count == 1)
                    {
                        var groupListDataExcel = dataExcel.GroupBy(group => new
                        {
                            Column1 = group.GetValueByColumn(usingExcelColumns[0].Index),
                        });

                        foreach (var item in groupListDataExcel)
                        {
                            var firstVendorCode = item.First().GetValueByColumn(vendorCodeExcelColumn.Index);
                            var newValue = $"{value}{firstVendorCode}";
                            
                            foreach (var objDataExcel in item)
                            {
                                if (item.Count() > 1)
                                {
                                    worksheet.Cells[objDataExcel.Row, newColumnExcelValue.Index].Value = newValue;
                                    valuesChanged++;
                                }
                                else
                                {
                                    worksheet.Cells[objDataExcel.Row, newColumnExcelValue.Index].Value = string.Empty;
                                }
                            }
                        }
                    }
                }

                try
                {
                    excelPackage.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                       $"{ex.Message}",
                       "Информационное сообщение",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    return;
                }
            }

            var dateTimeStop = DateTime.Now;

            var messageResult = $"Отработка Excel успешно завершена.{Environment.NewLine}" +
                        $"Обработано записей: {generalMeaning}";
            messageResult += $"{Environment.NewLine}Установлено новых значений: {valuesChanged}";
            messageResult += $"{Environment.NewLine}Время начало операции: {dateTimeStart}";
            messageResult += $"{Environment.NewLine}Время окончания операции: {dateTimeStop}";

            MessageBox.Show(
                    messageResult,
                    "Информационное сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private static HashSet<string> GetPossibleValues(List<DataExcel> data, int columnIndex)
        {
            var possibleValues = new HashSet<string>();
            foreach (var item in data)
            {
                string value = item.GetValueByColumn(columnIndex);
                if (!possibleValues.Contains(value))
                {
                    possibleValues.Add(value);
                }
            }
            return possibleValues;
        }

        public static List<List<DataExcel>> dataExcels = new List<List<DataExcel>>();
        private static List<List<DataExcel>> GroupByColumns(List<DataExcel> data, List<HashSet<string>> possibleValues, List<UsingExcelColumn> usingExcelColumns, int columnIndex)
        {
            if (columnIndex == possibleValues.Count)
            {
                return new List<List<DataExcel>> { data };
            }

            var result = new List<List<DataExcel>>();
            foreach (var value in possibleValues[columnIndex])
            {
                var subData = new List<DataExcel>();
                foreach (var item in data)
                {
                    if (item.GetValueByColumn(usingExcelColumns[columnIndex].Index) == value)
                    {
                        subData.Add(item);
                    }
                }
                var subGroups = GroupByColumns(subData, possibleValues, usingExcelColumns, columnIndex + 1);
                result.AddRange(subGroups.Where(w => w.Count > 0));
                dataExcels.AddRange(subGroups.Where(w => w.Count > 0));
            }
            return result;
        }

        public class DataExcel
        {
            public DataExcel(int row, List<string> columnValues)
            {
                Row = row;
                ColumnValues = columnValues ?? new List<string>();
            }

            public int Row { get; }
            public List<string> ColumnValues { get; }
            public int ColumnValuesCount => ColumnValues?.Count ?? -1;

            public string GetValueByColumn(int columnIndex, bool isRealColumnIndex = false)
            {
                var index = columnIndex - 1;
                if (isRealColumnIndex)
                {
                    index = columnIndex;
                }

                if (index > ColumnValuesCount || index == -1)
                {
                    return default;
                }
                return ColumnValues[index];
            }

            public override string ToString()
            {
                return $"{Row}";
            }
        }

        public class UsingExcelColumn
        {
            public UsingExcelColumn(string name, int index)
            {
                Name = name ?? throw new ArgumentNullException(nameof(name));
                Index = index;
            }

            public string Name { get; }
            public int Index { get; }

            public override string ToString()
            {
                return $"[{Index}] {Name}";
            }
        }

        private static void ProcessingFilterEnabled(string value, List<UsingComboBox> collection, ref int valuesChanged, ExcelWorksheet worksheet, List<UsingExcelColumn> collectionUsingExcelColumn, ref string firstVendorCode, UsingExcelColumn vendorCodeExcelColumn, UsingExcelColumn newColumnExcelValue, int i)
        {
            var isUse = true;
            foreach (var item in collection)
            {
                var usingExcelColumn = GetUsingExcelColumn(collectionUsingExcelColumn, item.ExcelColumnName);
                var cellValue = worksheet.Cells[i, usingExcelColumn.Index].Text;

                if (string.IsNullOrWhiteSpace(item.ComboBoxValue))
                {
                    continue;
                }

                if (cellValue != null && !cellValue.Equals(item.ComboBoxValue, StringComparison.OrdinalIgnoreCase))
                {
                    isUse = false;
                    break;
                }
            }

            if (isUse)
            {
                if (string.IsNullOrWhiteSpace(firstVendorCode))
                {
                    var vendorCode = worksheet.Cells[i, vendorCodeExcelColumn.Index].Text;
                    firstVendorCode = vendorCode;
                }

                var newValue = $"{value}{firstVendorCode}";
                worksheet.Cells[i, newColumnExcelValue.Index].Value = newValue;

                valuesChanged++;
            }
        }

        private static void ProcessingFilterDisable(string value, List<UsingComboBox> collection, ref int valuesChanged, ExcelWorksheet worksheet, List<UsingExcelColumn> collectionUsingExcelColumn, ref string firstVendorCode, UsingExcelColumn vendorCodeExcelColumn, UsingExcelColumn newColumnExcelValue, int i)
        {
            var isUse = true;
            foreach (var item in collection)
            {







                var usingExcelColumn = GetUsingExcelColumn(collectionUsingExcelColumn, item.ExcelColumnName);
                var cellValue = worksheet.Cells[i, usingExcelColumn.Index].Text;

                if (string.IsNullOrWhiteSpace(item.ComboBoxValue))
                {
                    continue;
                }

                if (cellValue != null && !cellValue.Equals(item.ComboBoxValue, StringComparison.OrdinalIgnoreCase))
                {
                    isUse = false;
                    break;
                }
            }

            if (isUse)
            {
                if (string.IsNullOrWhiteSpace(firstVendorCode))
                {
                    var vendorCode = worksheet.Cells[i, vendorCodeExcelColumn.Index].Text;
                    firstVendorCode = vendorCode;
                }

                var newValue = $"{value}{firstVendorCode}";
                worksheet.Cells[i, newColumnExcelValue.Index].Value = newValue;

                valuesChanged++;
            }
        }


        private static UsingExcelColumn GetUsingExcelColumn(List<UsingExcelColumn> collectionUsingExcelColumn, object columnValue)
        {
            var usingExcelColumn = default(UsingExcelColumn);
            try
            {
                if (int.TryParse(columnValue?.ToString(), out int resultExcelColumnIndex))
                {
                    usingExcelColumn = collectionUsingExcelColumn.First(f => f.Index == resultExcelColumnIndex);
                }
                else
                {
                    usingExcelColumn = collectionUsingExcelColumn.First(f => f.Name.Equals(columnValue?.ToString(), StringComparison.OrdinalIgnoreCase));
                }
            }
            catch (InvalidOperationException ex)
            {
                var message = $"{ex.Message}.{Environment.NewLine}" +
                    $"Элемент ({nameof(columnValue)}): {columnValue}" +
                    $"{Environment.NewLine}" +
                    $"{Environment.NewLine}" +
                    $"Возможно указана не верная страница документа Excel.";
                throw new Exception(message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return usingExcelColumn;
        }

        private void btnSaveSetting_Click(object sender, EventArgs e)
        {
            SaveSetting();
        }
    }
}
