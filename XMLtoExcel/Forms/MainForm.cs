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

//#if DEBUG
//            txtPath.Text = "C:\\Users\\ilel\\Desktop\\TEST\\30992026\\1010.xml";

//            _excelPathStock.Add(@"C:\Users\ilel\Desktop\TEST\30992026\ТЕСТ-stock.xlsx");
//            _excelPathY.Add(@"C:\Users\ilel\Desktop\TEST\30992026\Пример1.xlsx");
//            _excelPathO.Add(@"C:\Users\ilel\Desktop\TEST\30992026\Пример1.xlsx");
//#endif
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

            if (checkStock.Checked)
            {
                if (_excelPathStock.Count == 0)
                {
                    MessageBox.Show("Укажите пути для файлов Excel (stock)", "Путь к файлам", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if (checkY.Checked)
            {
                if (_excelPathY.Count == 0)
                {
                    MessageBox.Show("Укажите пути для файлов (Price Y)", "Путь к файлам", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (CheckPercentValue(txtPercentExcelY) is false)
                {
                    return;
                };

                if (CheckExcelParamect(txtArticuleExcelY, txtCurrentPriceExcelY, txtAddCurrentPriceExcelY, txtAddNewPriceExcelY, txtPercentExcelY) is false)
                {
                    return;
                }
            }

            if (checkO.Checked)
            {
                if (_excelPathO.Count == 0)
                {
                    MessageBox.Show("Укажите пути для файлов (Price O)", "Путь к файлам", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (CheckPercentValue(txtPercentExcelO) is false)
                {
                    return;
                };

                if (CheckExcelParamect(txtArticuleExcelO, txtCurrentPriceExcelO, txtAddCurrentPriceExcelO, txtAddNewPriceExcelO, txtPercentExcelO) is false)
                {
                    return;
                }
            }

            var stock = GetStock();
            var isDeleteColumnNumber = checkIsDeleteColumnNumber.Checked;
            var query = GetXMLData(path);

            if (query is null)
            {
                MessageBox.Show("Не удалось получить информации из XML файла.", "Информациооное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ClearLableOut();

            if (checkStock.Checked)
            {
                TreatmentStock(stock, isDeleteColumnNumber, query, txtListNameStock.Text);
            }

            if (checkY.Checked && CheckExcelPath(_excelPathY))
            {
                TreatmentExcel(query,
                               _excelPathY,
                               SettingController.Get().ExcelSettingY,
                               memoOutExcelY,
                               txtListNameY.Text,
                               checkPricePerSet.Checked);
            }

            if (checkO.Checked && CheckExcelPath(_excelPathO))
            {
                TreatmentExcel(query,
                               _excelPathO,
                               SettingController.Get().ExcelSettingO,
                               memoOutExcelO,
                               txtListNameO.Text,
                               checkPricePerSet.Checked);
            }

            SaveSetting();

            MessageBox.Show("Все операции завершены.", "Информациооное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool CheckExcelPath(List<string> paths)
        {
            foreach (var path in paths)
            {
                if (System.IO.File.Exists(path) is false)
                {
                    MessageBox.Show($"Файла по следующему пути не существует ({path}).", "Информациооное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }            

            return true;
        }

        private bool CheckPercentValue(object obj)
        {
            if (obj is TextBox text)
            {
                if (string.IsNullOrWhiteSpace(text.Text)
                                || text.Text == "0"
                                || ((text.Text.Contains("+") || text.Text.Contains("-"))
                                    && int.TryParse(text.Text, out int result)))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show($"Не правильно оформлено поле с процентом.{Environment.NewLine}" +
                                        $"Укажите [0], либо значение с [+] или [-].{Environment.NewLine}" +
                                        $"Например: 0, +5, -10 и т.д.",
                                    "Путь к файлам",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    text.Focus();
                }
            }

            return false;
        }

        private bool TreatmentExcel(Data query,
                                    List<string> list,
                                    ExcelSetting excelSetting,
                                    RichTextBox richTextBox,
                                    string sheetName,
                                    bool pricePerSet = false)
        {
            var result = true;
            foreach (var excelPath in list)
            {
                try
                {
                    LoggerController.AddMessage($"Обработка EXCEL: {excelPath}");

                    var excelWriter = default(ExcelWriterPrice);
                    
                    if (string.IsNullOrWhiteSpace(sheetName))
                    {
                        excelWriter = new ExcelWriterPrice(excelPath, excelSetting, pricePerSet: pricePerSet);
                    }
                    else
                    {
                        excelWriter = new ExcelWriterPrice(excelPath, excelSetting, pricePerSet: pricePerSet, sheetName: sheetName);
                    }

                    excelWriter.Writer += ExcelWriter_Writer;
                    excelWriter.Log += ExcelWriter_Log;

                    excelWriter.StartWriterEPPlus(query);

                    excelWriter.Writer -= ExcelWriter_Writer;
                    excelWriter.Log -= ExcelWriter_Log;

                    var fileName = GetFileName(excelPath);
                    richTextBox.Text += $"Файл: {fileName} [{excelWriter.Total}]{Environment.NewLine}" +
                        $"Общее количесвто: {excelWriter.Total}{Environment.NewLine}" +
                        $"Замены: {excelWriter.CountSubstitutions}{Environment.NewLine}" +
                        $"Нет цены: {excelWriter.CountNoPrice}{Environment.NewLine}" +
                        $"[PricePerSet]" +
                        $"Текущая цена меньше новой: {excelWriter.CountCurrentPriceLessThanNew}{Environment.NewLine}" +
                        $"Текущая цена больше новой: {excelWriter.CountCurrentPriceHigherThanNew}{Environment.NewLine}" +
                        $"Применен %: {excelWriter.CountPercentageApplied}{Environment.NewLine}" +
                        $"--------------------{Environment.NewLine}";

                    if (pricePerSet)
                    {
                        richTextBox.Text = richTextBox.Text.Replace("[PricePerSet]", 
                            $"Нет qty: {excelWriter.NoQty}{Environment.NewLine}" +
                                $"Нет price: {excelWriter.NoPrice}{Environment.NewLine}");
                    }
                    else
                    {
                        richTextBox.Text = richTextBox.Text.Replace("[PricePerSet]", "");
                    }

                    richTextBox.Refresh();
                }
                catch (Exception ex)
                {
                    ExcelWriter_Log(ex.Message);
                    MessageBox.Show(ex.Message, "Сообщение об операци", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = false;
                }
            }

            progressBar.Value = 0;
            return result;
        }


        private bool TreatmentStock(decimal? stock, bool isDeleteColumnNumber, Data query, string sheetName)
        {
            var result = true;
            foreach (var excelPath in _excelPathStock)
            {
                try
                {
                    LoggerController.AddMessage($"Обработка EXCEL: {excelPath}");
                    using (var excelWriter = new ExcelWriterStock(excelPath, isDeleteColumnNumber: isDeleteColumnNumber, sheetName: sheetName))
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
                        memoOutExcelStock.Text += $"Файл: {fileName} [{excelWriter.Count}]{Environment.NewLine}" +
                            $"Замены: {excelWriter.CountSubstitutions}{Environment.NewLine}" +
                            $"Замены на 0: {excelWriter.CountZeroSubstitutions}{Environment.NewLine}" +
                            $"Значение остатков (равное и меньше): {excelWriter.CountZeroStockSubstitutions}{Environment.NewLine}" +
                            $"--------------------{Environment.NewLine}";
                        memoOutExcelStock.Refresh();
                    }
                }
                catch (Exception ex)
                {
                    ExcelWriter_Log(ex.Message);
                    result = false;
                }
            }

            progressBar.Value = 0;
            return result;
        }

        private decimal? GetStock()
        {
            var stock = default(decimal?);
            if (decimal.TryParse(txtStock.Text?.Replace(".", ","), out decimal result))
            {
                stock = result;
            }

            return stock;
        }

        private Data GetXMLData(string path)
        {            
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
                return default;
            }

            if (query is null)
            {
                MessageBox.Show("Укажите пути для файлов Excel", "Путь к файлам", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default;
            }

            return query;
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
            memoOutExcelY.Text = default(string);
            memoOutExcelO.Text = default(string);
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
                    SetFirstParamentr(setting.ExcelSettingY,
                                      txtArticuleExcelY,
                                      txtCurrentPriceExcelY,
                                      txtAddCurrentPriceExcelY,
                                      txtAddNewPriceExcelY,
                                      txtPercentExcelY,
                                      
                                      txtListNameY,
                                      ref _excelPathY,
                                      listViewExcelY);
                }

                if (setting.ExcelSettingO != null)
                {
                    SetFirstParamentr(setting.ExcelSettingO,
                                      txtArticuleExcelO,
                                      txtCurrentPriceExcelO,
                                      txtAddCurrentPriceExcelO,
                                      txtAddNewPriceExcelO,
                                      txtPercentExcelO,

                                      txtListNameO,
                                      ref _excelPathO,
                                      listViewExcelO);
                }
            }
        }

        private void SetFirstParamentr(ExcelSetting setting,
                                       TextBox txtArticule,
                                       TextBox txtCurrentPrice,
                                       TextBox txtAddCurrentPrice,
                                       TextBox txtAddNewPrice,
                                       TextBox txtPercent,
                                       TextBox txtListName,
                                       ref List<string> paths,
                                       ListView listView)
        {
            txtArticule.Text = setting.ColumnArticle;
            txtCurrentPrice.Text = setting.ColumnCurrentPrice;
            txtAddCurrentPrice.Text = setting.ColumnSetCurrentPrice;
            txtAddNewPrice.Text = setting.ColumnSetNewPrice;
            txtPercent.Text = setting.Percent;
            txtListName.Text = setting.ExcelListName;

            paths = setting.Paths;
            foreach (var path in paths)
            {
                listView.Items.Add(path);
            }
        }

        private void SetSettingParamentr(ExcelSetting setting,
                                         TextBox txtArticule,
                                         TextBox txtCurrentPrice,
                                         TextBox txtAddCurrentPrice,
                                         TextBox txtAddNewPrice,
                                         TextBox txtPercent,
                                         TextBox txtListName,
                                         List<string> paths)
        {
            setting.ColumnArticle = txtArticule.Text;
            setting.ColumnCurrentPrice = txtCurrentPrice.Text;
            setting.ColumnSetCurrentPrice = txtAddCurrentPrice.Text;
            setting.ColumnSetNewPrice = txtAddNewPrice.Text;
            setting.Percent = txtPercent.Text;
            setting.ExcelListName = txtListName.Text;
            setting.Paths = paths;
        }

        private void SaveSetting()
        {
            var setting = SettingController.GetOrCreateSetting();

            if (checkY.Checked)
            {
                SetSettingParamentr(setting.ExcelSettingY, txtArticuleExcelY, txtCurrentPriceExcelY, txtAddCurrentPriceExcelY, txtAddNewPriceExcelY, txtPercentExcelY, txtListNameY, _excelPathY);
            }

            if (checkO.Checked)
            {
                SetSettingParamentr(setting.ExcelSettingO, txtArticuleExcelO, txtCurrentPriceExcelO, txtAddCurrentPriceExcelO, txtAddNewPriceExcelO, txtPercentExcelO, txtListNameO, _excelPathO);
            }

            setting.Save();
        }

        private static void ShowToolTip(TextBox textBox, string message)
        {
            var visibleTime = 1500;  //in milliseconds

            var toolTip = new ToolTip();
            toolTip.Show(message, textBox, 0, 25, visibleTime);
        }

        private void txtArticuleExcel_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                ShowToolTip(textBox, "Артикул");
            }
        }

        private void txtCurrentPriceExcel_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                ShowToolTip(textBox, "Текущая цена");
            }
        }

        private void txtAddCurrentPriceExcel_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                ShowToolTip(textBox, "Устанавливаем текущую цену");
            }
        }

        private void txtAddNewPriceExcel_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                ShowToolTip(textBox, "Устанавливаем новую цену");
            }
        }

        private void txtPercentExcel_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                ShowToolTip(textBox, "Увеличить на % (+поднять, -снизить)");
            }
        }

        private void txtListName_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                ShowToolTip(textBox, $"Поле для установки наименования листа обработки.{Environment.NewLine}" +
                    $"Если пусто, то используются параметры по умолчанию.");
            }
        }
    }
}