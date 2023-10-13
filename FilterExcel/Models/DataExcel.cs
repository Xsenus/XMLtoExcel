using System.Collections.Generic;

namespace FilterExcel.Models
{
    public class DataExcel
    {
        public DataExcel(int row, List<string> columnValues)
        {
            Row = row;
            ColumnValues = columnValues ?? new List<string>();
        }

        public int Row { get; }
        public List<string> ColumnValues { get; }
        public int ColumnValuesCount => ColumnValues?.Count ?? -1;

        public string GetValueByColumn(int columnIndex, bool isRealColumnIndex = false)
        {
            var index = columnIndex - 1;
            if (isRealColumnIndex)
            {
                index = columnIndex;
            }

            if (index > ColumnValuesCount || index == -1)
            {
                return default;
            }
            return ColumnValues[index]?.ToString();
        }

        public override string ToString()
        {
            return $"{Row}";
        }
    }
}
