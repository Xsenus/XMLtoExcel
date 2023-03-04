using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ChangeXML.Models
{
    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class DataProductFile
    {

        private string typeField;

        private string mimeField;

        private DateTime modifiedField;

        private string md5Field;

        private string nameField;

        private string idField;

        private string valueField;

        /// <remarks/>
        [XmlAttribute()]
        public string type
        {
            get
            {
                return typeField;
            }
            set
            {
                typeField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string mime
        {
            get
            {
                return mimeField;
            }
            set
            {
                mimeField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public DateTime modified
        {
            get
            {
                return modifiedField;
            }
            set
            {
                modifiedField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string md5
        {
            get
            {
                return md5Field;
            }
            set
            {
                md5Field = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string name
        {
            get
            {
                return nameField;
            }
            set
            {
                nameField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string id
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public string Value
        {
            get
            {
                return valueField;
            }
            set
            {
                valueField = value;
            }
        }
    }
}
