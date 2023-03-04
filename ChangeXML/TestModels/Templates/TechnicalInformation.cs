using System;
using System.Collections.Generic;

namespace ChangeXML.TestModels.Templates
{
    public partial class TechnicalInformation
    {
        public TechnicalInformation()
        {
            Parameters = new List<Parameter>();
        }

        public List<Parameter> Parameters { get; set; }

        public string GetXML()
        {
            var result = $"{Environment.NewLine}";
            foreach (var parameter in Parameters)
            {
                result += $"\t\t<{parameter.NameXmlElement} order=\"{parameter.Order}\" id=\"{parameter.Id}\">{Environment.NewLine}";
                result += $"\t\t\t<name>{parameter.Name}</name>{Environment.NewLine}";

                if (string.IsNullOrWhiteSpace(parameter.Unit))
                {
                    result += $"\t\t\t<unit/>{Environment.NewLine}";
                }
                else
                {
                    result += $"\t\t\t<unit>{parameter.Unit}</unit>{Environment.NewLine}";
                }

                if (parameter.Values.Count > 0)
                {
                    result += $"\t\t\t<values>{Environment.NewLine}";

                    foreach (var value in parameter.Values)
                    {
                        result += $"\t\t\t\t{value}{Environment.NewLine}";
                    }

                    result += $"\t\t\t</values>{Environment.NewLine}";

                    parameter.Values.Clear();
                }

                result += $"\t\t</{parameter.NameXmlElement}>{Environment.NewLine}";
            }
            return result;
        }
    }

    public partial class Parameter
    {
        public Parameter()
        {
            Values = new List<string>();
        }

        public string NameXmlElement { get; set; }

        public string Name { get; set; }

        public string Unit { get; set; }

        public long Order { get; set; }

        public long Id { get; set; }

        public List<string> Values { get; set; }
    }
}