using System.Collections.Generic;

namespace Core.Models
{
    public class ExcelSetting
    {
        public bool Use { get; set; }

        public string ColumnArticle { get; set; }
        public string ColumnCurrentPrice { get; set; }
        public string ColumnSetCurrentPrice { get; set; }
        public string ColumnSetNewPrice { get; set; }
        public string Percent { get; set; }

        public string ExcelListName { get; set; }
        public List<string> Paths { get; set; } = new List<string>();
    }
}
