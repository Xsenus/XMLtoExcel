using System;

namespace FilterExcel.Models
{
    public class UsingExcelColumn
    {
        public UsingExcelColumn(string name, int index)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Index = index;
        }

        public string Name { get; }
        public int Index { get; }

        public override string ToString()
        {
            return $"[{Index}] {Name}";
        }
    }
}
