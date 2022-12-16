using Core.Controllers;
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
        private List<string> _excelPath = new List<string>();
        
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            LogerController.ClearMessage();

            var path = txtPath.Text;
            if (string.IsNullOrWhiteSpace(path))
            {
                MessageBox.Show("Укажите путь исходного файла", "Путь к файлу", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (_excelPath.Count == 0)
            {
                MessageBox.Show("Укажите пути для файлов Excel", "Путь к файлам", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                LogerController.AddMessage($"Обработка XML: {path}");
                query = OriginalController.GetDataFromXML(path.Trim());
            }
            catch (Exception ex)
            {
                LogerController.AddMessage($"{ex.Message}");
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

            foreach (var excelPath in _excelPath)
            {
                LogerController.AddMessage($"Обработка EXCEL: {excelPath}");
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
                    memoOut.Text += $"{Environment.NewLine}Файл: {fileName} [{excelWriter.Count}]{Environment.NewLine}" +
                        $"Замены: {excelWriter.CountSubstitutions}{Environment.NewLine}" +
                        $"Замены на 0: {excelWriter.CountZeroSubstitutions}{Environment.NewLine}" +
                        $"Значение остатков (равное и меньше): {excelWriter.CountZeroStockSubstitutions}{Environment.NewLine}" +
                        $"--------------------{Environment.NewLine}";
                    memoOut.Refresh();
                }
            }

            progressBar.Value = 0;
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
                LogerController.AddMessage($"{ex.Message}");
                return excelPath;
            }
        }

        private void ClearLableOut()
        {
            memoOut.Text = default(string);
        }

        private void ExcelWriter_Log(string message)
        {
            LogerController.AddMessage($"{message}");
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

        private void listView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var contextMenu= new ContextMenu();
                
                var itemAdd = new MenuItem("Добавить");
                itemAdd.Click += ItemAdd_Click;
                contextMenu.MenuItems.Add(itemAdd);

                var itemDel = new MenuItem("Удалить");
                itemDel.Enabled = false;
                if (listView.SelectedItems.Count > 0)
                {
                    itemDel.Enabled = true;
                }
                itemDel.Click += (_sender, _e) => ItemDel_Click(_sender, _e);
                contextMenu.MenuItems.Add(itemDel);

                contextMenu.Show(listView, new Point(e.X, e.Y));
            }
        }

        public void AddExcelPatch(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return;
            }

            if (!_excelPath.Contains(path))
            {
                _excelPath.Add(path);
                listView.Items.Add(path);
            }
        }

        private void RemoveExcelPatch(string obj)
        {
            if (!string.IsNullOrWhiteSpace(obj))
            {
                if (_excelPath.Contains(obj))
                {
                    var itemList = listView.Items.Cast<ListViewItem>()
                        .FirstOrDefault(f => !string.IsNullOrWhiteSpace(f.Text) && f.Text.Equals(obj));

                    if (itemList != null)
                    {
                        _excelPath.Remove(obj);
                        listView.Items.Remove(itemList);
                    }
                }
            }
        }

        private void ItemAdd_Click(object sender, EventArgs e)
        {
            ClearLableOut();

            using (var openFileDialog = new OpenFileDialog() { Multiselect = true })
            {
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (var filePath in openFileDialog.FileNames)
                    {
                        AddExcelPatch(filePath);
                    }
                }
            }
        }

        private void ItemDel_Click(object sender, EventArgs e)
        {
            ClearLableOut();

            foreach (ListViewItem item in listView.SelectedItems)
            {
                var obj = item.Text;
                if (!string.IsNullOrWhiteSpace(obj))
                {
                    RemoveExcelPatch(obj);
                }
            }
        }
    }
}