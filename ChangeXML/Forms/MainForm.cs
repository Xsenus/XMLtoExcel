using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ChangeXML.Forms
{
    public partial class MainForm : XtraForm
    {
        public MainForm()
        {
            InitializeComponent();

            Text += $" v{Application.ProductVersion}";
#if DEBUG
            btnProduct.EditValue = @"C:\Users\User16\Desktop\test\products_b.xml";
            btnParameter.EditValue = @"C:\Users\User16\Desktop\test\parameters_b.xml";
            btnShablon.EditValue = @"C:\Users\User16\Desktop\test\shab_b.xml";
#endif
        }

        private string lastOpenFolder = Environment.CurrentDirectory;
        private void GetFilePath(object sender, ButtonPressedEventArgs e)
        {
            if (sender is ButtonEdit buttonEdit)
            {
                if (e.Button.Kind == ButtonPredefines.Ellipsis)
                {
                    using (var ofd = new XtraOpenFileDialog() 
                    {
                        InitialDirectory = lastOpenFolder,
                        Filter = "XML Files (*.xml)|*.xml|All files (*.*)|*.*" 
                    })
                    {
                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                            buttonEdit.EditValue = ofd.FileName;
                            lastOpenFolder = Path.GetDirectoryName(ofd.FileName);
                        }
                    }
                }
            }
        }

        private void btnProduct_ButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            GetFilePath(sender, e);
        }

        private void btnParameter_ButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            GetFilePath(sender, e);
        }

        private void btnShablon_ButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            GetFilePath(sender, e);
        }

        private string GetFilePath(object sender)
        {
            if (sender is ButtonEdit buttonEdit)
            {
                if (!string.IsNullOrWhiteSpace(buttonEdit.Text))
                {
                    return buttonEdit.Text;
                }

                buttonEdit.Focus();
            }

            throw new Exception("Пожалуйста укажите путь к файлу.");
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                var pathProduct = GetFilePath(btnProduct);
                var pathParameter = GetFilePath(btnParameter);
                var pathShablon = GetFilePath(btnShablon);

                var tempFileProduct = GetTempFileFromPathProduct(pathProduct);

                var products = Controllers.OriginalController.GetObjFromXML<ChangeXML.TestModels.Products.data>(tempFileProduct);
                var parameters = Controllers.OriginalController.GetObjFromXML<ChangeXML.TestModels.Parameters.data>(pathParameter);
                var templates = Controllers.OriginalController.GetTechnicalInformation(pathShablon);

                var countProduct = 0;
                var countFindParametrs = 0;
                var countAddValue = 0;
                if (products.product != null)
                {
                    foreach (var product in products.product)
                    {
                        foreach (var obj in templates.Parameters)
                        {
                            var id = obj.Id;
                            var parameter = parameters.parameters.FirstOrDefault(f => f.id == id);

                            if (parameter != null)
                            {
                                countFindParametrs++;
                                var productArticle = product.article;
                                var value = parameter.products.FirstOrDefault(f => f.article == productArticle);

                                if (value != null)
                                {
                                    foreach (var tempValue in value.values)
                                    {
                                        obj.Values.Add($"<value order=\"{tempValue.order}\" number=\"{tempValue.number}\">{tempValue.Value}</value>");
                                        countAddValue++;
                                    }
                                }
                            }
                        }

                        product.techdata = templates.GetXMLWithDelete();
                        countProduct++;
                    }
                }

                var fileName = SaveAndEditNewFile(products);
                var path = Path.GetFullPath(fileName);
                Clipboard.SetText(path);
                
                await DeleteTempFile(tempFileProduct);

                XtraMessageBox.Show(
                    $"Программа успешно обработала файлы.{Environment.NewLine}" +
                        $"Результат находится в корневой папке c программой.{Environment.NewLine}" +
                        $"Путь к файлу скопирован в буфер.{Environment.NewLine}{Environment.NewLine}" +
                        $"{path}{Environment.NewLine}{Environment.NewLine}" +
                        $"Обработано товаров: {countProduct}{Environment.NewLine}" +
                        $"Найдено параметров по ID: {countFindParametrs}{Environment.NewLine}" +
                        $"Добавлено значений к товарам: {countAddValue}",
                    "Обработка XML документов",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Обработка XML документов", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async System.Threading.Tasks.Task DeleteTempFile(string tempFileProduct)
        {
            try
            {
                await System.Threading.Tasks.Task.Run(() =>
                {
                    File.Delete(tempFileProduct);
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private static string SaveAndEditNewFile(TestModels.Products.data products)
        {
            var fileName = "new.xml";
            Controllers.OriginalController.Save(products, fileName);

            var text = File.ReadAllText(fileName);
            text = text
                .Replace("xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" ", "")
                .Replace("&lt;", "<")
                .Replace("&gt;", ">")
                .Replace("{REPLACER_LT}", "&lt;")
                .Replace("{REPLACER_GT}", "&gt;");
            File.WriteAllText(fileName, text);
            return fileName;
        }

        private static string GetTempFileFromPathProduct(string pathProduct)
        {
            var tempFileProduct = Path.GetTempFileName();
            var productText = File.ReadAllText(pathProduct);
            productText = productText
                .Replace("&lt;", "{REPLACER_LT}")
                .Replace("&gt;", "{REPLACER_GT}");
            File.WriteAllText(tempFileProduct, productText);
            return tempFileProduct;
        }
    }
}
