using EditingXML.Controllers;
using EditingXML.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace EditingXML.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            GetFilePath(txtProduct);
        }

        private void btnParameter_Click(object sender, EventArgs e)
        {
            GetFilePath(txtParameter);
        }

        private void txtProduct_DoubleClick(object sender, EventArgs e)
        {
            GetFilePath(txtProduct);
        }

        private void txtParameter_DoubleClick(object sender, EventArgs e)
        {
            GetFilePath(txtParameter);
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

        public class ChangeNumber
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public int Count { get; set; }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                var pathProduct = GetFilePathText(txtProduct);
                var pathParameter = GetFilePathText(txtParameter);

                if (File.Exists(pathProduct) is false)
                {
                    throw new Exception($"Не найден файл по следующему пути: {pathProduct}");
                }

                if (File.Exists(pathParameter) is false)
                {
                    throw new Exception($"Не найден файл по следующему пути: {pathParameter}");
                }

                var fileInfoProduct = new FileInfo(pathProduct);
                var folder = fileInfoProduct.DirectoryName;
                var fileName = fileInfoProduct.Name.Replace(fileInfoProduct.Extension, "");

                var newPathFile = $"{fileName}_{DateTime.Now:dd_MM_yyyy_HH_mm_ss}.xml";
                var pathOut = Path.Combine(folder, newPathFile);

                var relations = OriginalController.GetObjFromXML<RootRelation>(pathParameter);
                var relastionsObj = relations?.Relations?.Relation;

                var changeNumbers = new List<ChangeNumber>();
                if (relastionsObj != null)
                {
                    foreach (var obj in relastionsObj)
                    {
                        var changeNumber = new ChangeNumber()
                        {
                            Name = obj.Name,
                            Description = obj.Marking
                        };

                        changeNumbers.Add(changeNumber);
                    }
                }

                var xmlDocument = new XmlDocument();
                xmlDocument.Load(pathProduct);

                var countProduct = 0;
                var productList = xmlDocument.SelectNodes("//product");
                progressBar.Maximum = productList.Count;
                foreach (XmlNode productXmlNode in productList)
                {
                    var article = productXmlNode.SelectSingleNode("article");
                    var articleValue = article.InnerText?.Trim();
                    if (!string.IsNullOrWhiteSpace(articleValue))
                    {
                        countProduct++;
                        progressBar.Value = countProduct;
                        var relastions = relations?.Relations?.Relation;
                        foreach (var relation in relastions)
                        {
                            var product = relation.Products?.Product?.FirstOrDefault(f => f.Article == articleValue);
                            if (product != null)
                            {
                                var newXmlElementName = xmlDocument.CreateElement(relation.Marking);
                                var articles = product.Related?.Article;

                                if (articles != null && !articles.Contains(articleValue))
                                {
                                    var changeNumberObj = changeNumbers.FirstOrDefault(f => f.Description == relation.Marking);
                                    if (changeNumberObj != null)
                                    {
                                        changeNumberObj.Count++;
                                    }

                                    foreach (var articleNumber in product.Related.Article)
                                    {
                                        var articleNode = xmlDocument.CreateElement("article");
                                        articleNode.InnerText = articleNumber;
                                        newXmlElementName.AppendChild(articleNode);
                                    }

                                    productXmlNode.AppendChild(newXmlElementName);
                                }

                            }
                        }
                    }
                }

                xmlDocument.Save(pathOut);

                var message = $"" +
                    $"XML файл [{pathProduct}] успешно обработан.{Environment.NewLine}{Environment.NewLine}" +
                    $"Создан новый XML файл с учетом всех изменений: {Environment.NewLine}{pathOut}{Environment.NewLine}{Environment.NewLine}" +
                    $"Всего обработано: {countProduct}{Environment.NewLine}{Environment.NewLine}";

                foreach (var item in changeNumbers)
                {
                    message += $"{item.Name} ({item.Description}) - {item.Count}{Environment.NewLine}";
                }

                MessageBox.Show(message, "Информационное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Информационное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            progressBar.Value = 0;
        }
    }
}
