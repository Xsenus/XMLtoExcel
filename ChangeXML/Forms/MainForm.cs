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

#if DEBUG
            btnProduct.EditValue = @"C:\Users\ilel\Downloads\products_u.xml";
            btnParameter.EditValue = @"C:\Users\ilel\Downloads\parameters_u.xml";
            btnShablon.EditValue = @"C:\Users\ilel\Downloads\shab_u.xml";
#endif
        }

        private void GetFilePath(object sender, ButtonPressedEventArgs e)
        {
            if (sender is ButtonEdit buttonEdit)
            {
                if (e.Button.Kind == ButtonPredefines.Ellipsis)
                {
                    using (var ofd = new XtraOpenFileDialog() { Filter = "XML Files (*.xml)|*.xml|All files (*.*)|*.*" })
                    {
                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                            buttonEdit.EditValue = ofd.FileName;
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                var pathProduct = GetFilePath(btnProduct);
                var pathParameter = GetFilePath(btnParameter);
                var pathShablon = GetFilePath(btnShablon);

                var products = Controllers.OriginalController.GetObjFromXML<ChangeXML.TestModels.Products.data>(pathProduct);
                var parameters = Controllers.OriginalController.GetObjFromXML<ChangeXML.TestModels.Parameters.data>(pathParameter);
                var templates = Controllers.OriginalController.GetTechnicalInformation(pathShablon);

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
                                var productArticle = product.article;
                                var value = parameter.products.FirstOrDefault(f => f.article == productArticle);

                                if (value != null)
                                {
                                    foreach (var tempValue in value.values)
                                    {
                                        obj.Values.Add($"<value order=\"{tempValue.order}\" number=\"{tempValue.number}\">{tempValue.Value}</value>");
                                    }
                                }
                            }
                        }

                        product.techdata = templates.GetXML();
                    }
                }                

                var fileName = "new.xml";
                Controllers.OriginalController.Save(products, fileName);

                var text = File.ReadAllText(fileName);
                text = text
                    .Replace("xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" ", "")
                    .Replace("&lt;", "<")
                    .Replace("&gt;", ">");
                File.WriteAllText(fileName, text);

                var path = Path.GetFullPath(fileName);
                Clipboard.SetText(path);

                XtraMessageBox.Show(
                    $"Программа успешно обработала файлы.{Environment.NewLine}" +
                        $"Результат находится в корневой папке c программой.{Environment.NewLine}" +
                        $"Путь к файлу скопирован в буфер.{Environment.NewLine}{Environment.NewLine}" +
                        $"{path}",
                    "Обработка XML документов",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Обработка XML документов", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
