using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ChangeXML.NET.TestModels.Parameters
{
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class data
    {
        private dataParameter[] parametersField;

        /// <remarks/>
        [XmlArrayItem("parameter", IsNullable = false)]
        public dataParameter[] parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataParameter
    {

        private ushort idField;

        private string nameField;

        private string unitField;

        private string typeField;

        private byte multipleField;

        private string modifiedField;

        private dataParameterMarking markingField;

        private string descriptField;

        private string categoryField;

        private dataParameterOption[] selectField;

        private dataParameterRange[] rangesField;

        private dataParameterProduct[] productsField;

        /// <remarks/>
        public ushort id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public byte multiple
        {
            get
            {
                return this.multipleField;
            }
            set
            {
                this.multipleField = value;
            }
        }

        /// <remarks/>
        public string modified
        {
            get
            {
                return this.modifiedField;
            }
            set
            {
                this.modifiedField = value;
            }
        }

        /// <remarks/>
        public dataParameterMarking marking
        {
            get
            {
                return this.markingField;
            }
            set
            {
                this.markingField = value;
            }
        }

        /// <remarks/>
        public string descript
        {
            get
            {
                return this.descriptField;
            }
            set
            {
                this.descriptField = value;
            }
        }

        /// <remarks/>
        public string category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        [XmlArrayItem("option", IsNullable = false)]
        public dataParameterOption[] select
        {
            get
            {
                return this.selectField;
            }
            set
            {
                this.selectField = value;
            }
        }

        /// <remarks/>
        [XmlArrayItem("range", IsNullable = false)]
        public dataParameterRange[] ranges
        {
            get
            {
                return this.rangesField;
            }
            set
            {
                this.rangesField = value;
            }
        }

        /// <remarks/>
        [XmlArrayItem("product", IsNullable = false)]
        public dataParameterProduct[] products
        {
            get
            {
                return this.productsField;
            }
            set
            {
                this.productsField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataParameterMarking
    {

        private string mimeField;

        private string valueField;

        /// <remarks/>
        [XmlAttribute()]
        public string mime
        {
            get
            {
                return this.mimeField;
            }
            set
            {
                this.mimeField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataParameterOption
    {

        private string valueField;

        private string valueField1;

        /// <remarks/>
        [XmlAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public string Value
        {
            get
            {
                return this.valueField1;
            }
            set
            {
                this.valueField1 = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataParameterRange
    {

        private string nameField;

        private decimal minField;

        private decimal maxField;

        /// <remarks/>
        [XmlAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public decimal min
        {
            get
            {
                return this.minField;
            }
            set
            {
                this.minField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public decimal max
        {
            get
            {
                return this.maxField;
            }
            set
            {
                this.maxField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataParameterProduct
    {

        private dataParameterProductValue[] valuesField;

        private string articleField;

        private byte param_orderField;

        /// <remarks/>
        [XmlArrayItem("value", IsNullable = false)]
        public dataParameterProductValue[] values
        {
            get
            {
                return this.valuesField;
            }
            set
            {
                this.valuesField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string article
        {
            get
            {
                return this.articleField;
            }
            set
            {
                this.articleField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public byte param_order
        {
            get
            {
                return this.param_orderField;
            }
            set
            {
                this.param_orderField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataParameterProductValue
    {

        /// <remarks/>
        [XmlAttribute()]
        public long order { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public decimal number { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool numberSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string text { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string color { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string min { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string typ { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string max { get; set; }

        /// <remarks/>
        [XmlText()]
        public string Value { get; set; }
    }


}
