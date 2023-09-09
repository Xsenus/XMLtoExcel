using ChangeXML.NET.Controllers;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ChangeXML.NET.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
#if DEBUG
            txtProduct.Text = @"C:\Users\ilel\Downloads\products.xml";
            txtParameter.Text = @"C:\Users\ilel\Downloads\parameters.xml";
            txtShablon.Text = @"C:\Users\ilel\Downloads\shablon.xml";
#endif
        }

        private void GetFilePath(object sender)
        {
            if (sender is TextBox textBox)
            {
                using (var ofd = new OpenFileDialog() { Filter = "XML Files (*.xml)|*.xml|All files (*.*)|*.*" })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        textBox.Text = ofd.FileName;
                    }
                }
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            GetFilePath(txtProduct);
        }

        private void btnParameter_Click(object sender, EventArgs e)
        {
            GetFilePath(txtParameter);
        }

        private void btnShablon_Click(object sender, EventArgs e)
        {
            GetFilePath(txtShablon);
        }

        private string GetFilePathText(object sender)
        {
            if (sender is TextBox textBox)
            {
                if (!string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return textBox.Text;
                }

                textBox.Focus();
            }

            throw new Exception("Пожалуйста укажите путь к файлу.");
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                var pathProduct = GetFilePathText(txtProduct);
                var pathParameter = GetFilePathText(txtParameter);
                var pathShablon = GetFilePathText(txtShablon);

                var tempFileProduct = GetTempFileFromPathProduct(pathProduct);

                var products = OriginalController.GetObjFromXML<CnahgeXML.Core.TestModels.Products.data>(pathProduct);
                var parameters = OriginalController.GetObjFromXML<CnahgeXML.Core.TestModels.Parameters.data>(pathParameter);
                var templates = OriginalController.GetTechnicalInformation(pathShablon);

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

                var fileName = "new.xml";
                OriginalController.Save(products, fileName);

                var text = File.ReadAllText(fileName);
                text = text
                    .Replace("xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" ", "")
                    .Replace("&lt;", "<")
                    .Replace("&gt;", ">");
                File.WriteAllText(fileName, text);

                var path = Path.GetFullPath(fileName);
                Clipboard.SetText(path);

                await DeleteTempFile(tempFileProduct);

                MessageBox.Show(
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
                MessageBox.Show(ex.Message, "Обработка XML документов", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
