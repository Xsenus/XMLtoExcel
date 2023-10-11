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

            var collection = GetUsingComboBoxControls(false);
            if (collection.Count == 0)
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

            foreach (var item in collection)
            {
                //var filterValue = item.ComboBox.Text;
                //if (string.IsNullOrWhiteSpace(filterValue))
                //{
                //if (MessageBox.Show(
                //    $"Не задано значение фильтра для столбца № {item.FilterPosition}. Продолжить с пустым значением?",
                //    "Информационное сообщение",
                //    MessageBoxButtons.OKCancel,
                //    MessageBoxIcon.Question) != DialogResult.OK)
                //{
                //    return;
                //}
                //}
            }

            SaveSetting();

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
                }

                var firstVendorCode = default(string);
                var vendorCodeExcelColumn = GetUsingExcelColumn(collectionUsingExcelColumn, vendorCodeColumn);
                var newColumnExcelValue = GetUsingExcelColumn(collectionUsingExcelColumn, newColumnValue);
                var countDataTableRow = worksheet.Dimension.End.Row;

                for (int i = resultRowPosition; i < countDataTableRow; i++)
                {
                    generalMeaning++;

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

            MessageBox.Show(
                    $"Отработка Excel успешно завершена.{Environment.NewLine}" +
                        $"Обработано записей: {generalMeaning}{Environment.NewLine}" +
                        $"Установлено новых значений: {valuesChanged}",
                    "Информационное сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private static UsingExcelColumn GetUsingExcelColumn(List<UsingExcelColumn> collectionUsingExcelColumn, object columnValue)
        {
            var usingExcelColumn = default(UsingExcelColumn);
            if (int.TryParse(columnValue?.ToString(), out int resultExcelColumnIndex))
            {
                usingExcelColumn = collectionUsingExcelColumn.First(f => f.Index == resultExcelColumnIndex);
            }
            else
            {
                usingExcelColumn = collectionUsingExcelColumn.First(f => f.Name.Equals(columnValue?.ToString(), StringComparison.OrdinalIgnoreCase));
            }

            return usingExcelColumn;
        }

        private void btnSaveSetting_Click(object sender, EventArgs e)
        {
            SaveSetting();
        }
    }
}
