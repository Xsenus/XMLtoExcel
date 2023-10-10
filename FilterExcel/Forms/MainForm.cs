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
        public MainForm()
        {
            InitializeComponent();
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

            var collection = new List<UsingComboBox>();
            foreach (var item in Controls)
            {
                if (item is TextBox textBox && textBox.Name.Contains("txtCol"))
                {
                    var number = textBox.Name.Replace("txtCol", "");
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
                                    comboBox.Text = default;
                                    var obj = new UsingComboBox(numberResult, value, comboBox);
                                    collection.Add(obj);
                                }
                            }
                        }
                    }
                }
            }

            collection = collection.OrderBy(o => o.FilterPosition).ToList();
            if (collection.Count == 0)
            {
                MessageBox.Show(
                    $"Для поиска доступных параметров задайте номера столбцов.",
                    "Информационное сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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
                    $"Задайте номер номер первой строки, с которой будет происходить отбор значений.",
                    "Информационное сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtRowPosition.Focus();
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

                    var lastRow = worksheet.Cells.Last(c => c.Start.Column == usingExcelColumn.Index);
                    var lastRowAddress = string.Join("", lastRow.Address.Where(char.IsDigit));

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

            MessageBox.Show(
                    $"Значения для указанных столбцов успешно заполнены.",
                    "Информационное сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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

            public override string ToString()
            {
                return ExcelColumnName;
            }
        }

        private void btnWorkOutExcel_Click(object sender, EventArgs e)
        {

        }
    }
}
