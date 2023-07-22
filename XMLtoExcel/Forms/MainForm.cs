using Core.Controllers;
using Core.Models;
using Core.Models.Original;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace XMLtoExcel.Forms
{
    public partial class MainForm : Form
    {
        private List<string> _excelPathStock = new List<string>();
        private List<string> _excelPathY = new List<string>();
        private List<string> _excelPathO = new List<string>();

        public MainForm()
        {
            InitializeComponent();             
        }
        
        private void btnSelect_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFileDialog.FileName;
                    txtPath.Text = filePath;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool CheckExcelParamect(TextBox txtArticule, TextBox txtCurrentPrice, TextBox txtAddCurrentPrice, TextBox txtAddNewPrice, TextBox txtPercent)
        {
            if (string.IsNullOrWhiteSpace(txtArticule.Text) || txtArticule.Text == "Артикул")
            {
                MessageBox.Show("Укажите параметр Артикул", "Сообщение об операци", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtArticule.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCurrentPrice.Text) || txtCurrentPrice.Text == "Тек.цена")
            {
                MessageBox.Show("Укажите параметр Тек.цена", "Сообщение об операци", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCurrentPrice.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAddCurrentPrice.Text) || txtAddCurrentPrice.Text == "Ст.тек.цена")
            {
                MessageBox.Show("Укажите параметр Ст.тек.цена", "Сообщение об операци", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAddCurrentPrice.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAddNewPrice.Text) || txtAddNewPrice.Text == "Ст.нов.цена")
            {
                MessageBox.Show("Укажите параметр Ст.нов.цена", "Сообщение об операци", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAddNewPrice.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPercent.Text) || txtPercent.Text == "% (+/-)")
            {
                MessageBox.Show("Укажите параметр % (+/-)", "Сообщение об операци", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPercent.Focus();
                return false;
            }

            return true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            LoggerController.ClearMessage();

            var path = txtPath.Text;
            if (string.IsNullOrWhiteSpace(path))
            {
                MessageBox.Show("Укажите путь исходного файла", "Путь к файлу", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (_excelPathStock.Count == 0)
            {
                MessageBox.Show("Укажите пути для файлов Excel (stock)", "Путь к файлам", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (_excelPathY.Count == 0)
            {
                MessageBox.Show("Укажите пути для файлов (Price Y)", "Путь к файлам", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (_excelPathO.Count == 0)
            {
                MessageBox.Show("Укажите пути для файлов (Price O)", "Путь к файлам", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (CheckExcelParamect(txtArticuleExcelY, txtCurrentPriceExcelY, txtAddCurrentPriceExcelY, txtAddNewPriceExcelY, txtPercentExcelY) is false)
            {
                return;
            }

            if (CheckExcelParamect(txtArticuleExcelO, txtCurrentPriceExcelO, txtAddCurrentPriceExcelO, txtAddNewPriceExcelO, txtPercentExcelO) is false)
            {
                return;
            }

            var stock = default(decimal?);
            if (decimal.TryParse(txtStock.Text?.Replace(".", ","), out decimal result))
            {
                stock = result;
            }

            var query = default(Data);
            try
            {
                LoggerController.AddMessage($"Обработка XML: {path}");
                query = OriginalController.GetDataFromXML(path.Trim());
            }
            catch (Exception ex)
            {
                LoggerController.AddMessage($"{ex.Message}");
                MessageBox.Show(ex.Message?.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (query is null)
            {
                MessageBox.Show("Укажите пути для файлов Excel", "Путь к файлам", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var isDeleteColumnNumber = checkIsDeleteColumnNumber.Checked;

            ClearLableOut();

            foreach (var excelPath in _excelPathStock)
            {
                LoggerController.AddMessage($"Обработка EXCEL: {excelPath}");
                using (var excelWriter = new ExcelWriter(excelPath, isDeleteColumnNumber: isDeleteColumnNumber))
                {
                    excelWriter.Writer += ExcelWriter_Writer;
                    excelWriter.Log += ExcelWriter_Log;
                    if (checkIsEpplus.Checked)
                    {
                        excelWriter.StartWriterEPPlus(query, stock);
                    }
                    else
                    {
                        excelWriter.StartWriter(query, stock);
                    }
                    excelWriter.Writer -= ExcelWriter_Writer;
                    excelWriter.Log -= ExcelWriter_Log;
                    
                    var fileName = GetFileName(excelPath);
                    memoOutExcelStock.Text += $"{Environment.NewLine}Файл: {fileName} [{excelWriter.Count}]{Environment.NewLine}" +
                        $"Замены: {excelWriter.CountSubstitutions}{Environment.NewLine}" +
                        $"Замены на 0: {excelWriter.CountZeroSubstitutions}{Environment.NewLine}" +
                        $"Значение остатков (равное и меньше): {excelWriter.CountZeroStockSubstitutions}{Environment.NewLine}" +
                        $"--------------------{Environment.NewLine}";
                    memoOutExcelStock.Refresh();
                }
            }

            progressBar.Value = 0;

            SaveSetting();

            MessageBox.Show("Операция успешно завершена", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static string GetFileName(string excelPath)
        {
            try
            {
                return Path.GetFileName(excelPath);
            }
            catch (Exception ex)
            {
                LoggerController.AddMessage($"{ex.Message}");
                return excelPath;
            }
        }

        private void ClearLableOut()
        {
            memoOutExcelStock.Text = default(string);
        }

        private void ExcelWriter_Log(string message)
        {
            LoggerController.AddMessage($"{message}");
        }

        private void ExcelWriter_Writer(int position, int count, int countSubstitutions)
        {
            if (position == count)
            {
                progressBar.Value = 0;
            }

            progressBar.Value = position;
            progressBar.Maximum = count;
           
            //progressBar.CreateGraphics().DrawString($"{position}\t из\t{count}", 
            //    new Font("Arial", (float)8.50, FontStyle.Regular),
            //    Brushes.Black, 
            //    new PointF(progressBar.Width / 2 - 25, progressBar.Height / 2 - 7));
            
            progressBar.Update();
        }

        private void btnMenuLogger_Click(object sender, EventArgs e)
        {
            var form = new LoggerForm();
            form.ShowDialog();
        }

        private void checkIsEpplus_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox && checkBox.Checked)
            {
                checkIsInterop.Checked = false;
            }
            else
            {
                checkIsInterop.Checked = true;
            }
        }

        private void checkIsInterop_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox && checkBox.Checked)
            {
                checkIsEpplus.Checked = false;
            }
            else
            {
                checkIsEpplus.Checked = true;
            }
        }

        private void listViewExcelStock_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CreateMenu(e, _excelPathStock, listViewExcelStock);
            }
        }

        private void listViewExcelY_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CreateMenu(e, _excelPathY, listViewExcelY);
            }
        }

        private void listViewExcelO_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CreateMenu(e, _excelPathO, listViewExcelO);
            }
        }

        private void CreateMenu(MouseEventArgs e, List<string> list, ListView listView)
        {
            var contextMenu = new ContextMenu();

            var itemAdd = new MenuItem("Добавить");
            itemAdd.Click += (_sender, _e) => ItemAdd_Click(_sender, _e, list, listView);
            contextMenu.MenuItems.Add(itemAdd);

            var itemDel = new MenuItem("Удалить");
            itemDel.Enabled = false;
            if (listView.SelectedItems.Count > 0)
            {
                itemDel.Enabled = true;
            }
            itemDel.Click += (_sender, _e) => ItemDel_Click(_sender, _e, list, listView);
            contextMenu.MenuItems.Add(itemDel);

            contextMenu.Show(listView, new Point(e.X, e.Y));
        }

        public void AddExcelPatch(string path, List<string> list, ListView listView)
        {
            if (string.IsNullOrEmpty(path))
            {
                return;
            }

            if (!list.Contains(path))
            {
                list.Add(path);
                listView.Items.Add(path);
            }
        }

        private void RemoveExcelPatch(string obj, List<string> list, ListView listView)
        {
            if (!string.IsNullOrWhiteSpace(obj))
            {
                if (list.Contains(obj))
                {
                    var itemList = listView.Items.Cast<ListViewItem>()
                        .FirstOrDefault(f => !string.IsNullOrWhiteSpace(f.Text) && f.Text.Equals(obj));

                    if (itemList != null)
                    {
                        list.Remove(obj);
                        listView.Items.Remove(itemList);
                    }
                }
            }
        }

        private void ItemAdd_Click(object sender, EventArgs e, List<string> list, ListView listView)
        {
            ClearLableOut();

            using (var openFileDialog = new OpenFileDialog() { Multiselect = true })
            {
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (var filePath in openFileDialog.FileNames)
                    {
                        AddExcelPatch(filePath, list, listView);
                    }
                }
            }
        }

        private void ItemDel_Click(object sender, EventArgs e, List<string> list, ListView listView)
        {
            ClearLableOut();

            foreach (ListViewItem item in listView.SelectedItems)
            {
                var obj = item.Text;
                if (!string.IsNullOrWhiteSpace(obj))
                {
                    RemoveExcelPatch(obj, list, listView);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var setting = SettingController.Get();
            if (setting != null)
            {
                if (setting.ExcelSettingY != null)
                {
                    SetFirstParamentr(setting.ExcelSettingY, txtArticuleExcelY, txtCurrentPriceExcelY, txtAddCurrentPriceExcelY, txtAddNewPriceExcelY, txtPercentExcelY);
                }

                if (setting.ExcelSettingO != null)
                {
                    SetFirstParamentr(setting.ExcelSettingO, txtArticuleExcelO, txtCurrentPriceExcelO, txtAddCurrentPriceExcelO, txtAddNewPriceExcelO, txtPercentExcelO);
                }
            }
        }

        private void SetFirstParamentr(ExcelSetting setting, TextBox txtArticule, TextBox txtCurrentPrice, TextBox txtAddCurrentPrice, TextBox txtAddNewPrice, TextBox txtPercent)
        {
            txtArticule.Text = setting.ColumnArticle;
            txtCurrentPrice.Text = setting.ColumnCurrentPrice;
            txtAddCurrentPrice.Text = setting.ColumnSetCurrentPrice;
            txtAddNewPrice.Text = setting.ColumnSetNewPrice;
            txtPercent.Text = setting.Percent;
        }

        private void SetSettingParamentr(ExcelSetting setting, TextBox txtArticule, TextBox txtCurrentPrice, TextBox txtAddCurrentPrice, TextBox txtAddNewPrice, TextBox txtPercent)
        {
            setting.ColumnArticle = txtArticule.Text;
            setting.ColumnCurrentPrice = txtCurrentPrice.Text;
            setting.ColumnSetCurrentPrice = txtAddCurrentPrice.Text;
            setting.ColumnSetNewPrice = txtAddNewPrice.Text;
            setting.Percent = txtPercent.Text;
        }

        private void SaveSetting()
        {
            var setting = SettingController.GetOrCreateSetting();
            SetSettingParamentr(setting.ExcelSettingY, txtArticuleExcelY, txtCurrentPriceExcelY, txtAddCurrentPriceExcelY, txtAddNewPriceExcelY, txtPercentExcelY);
            SetSettingParamentr(setting.ExcelSettingO, txtArticuleExcelO, txtCurrentPriceExcelO, txtAddCurrentPriceExcelO, txtAddNewPriceExcelO, txtPercentExcelO);
            setting.Save();
        }
    }
}