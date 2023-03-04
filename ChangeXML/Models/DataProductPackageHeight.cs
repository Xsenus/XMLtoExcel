﻿using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ChangeXML.Models
{
    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class DataProductPackageHeight
    {

        private byte unitField;

        private decimal valueField;

        /// <remarks/>
        [XmlAttribute()]
        public byte unit
        {
            get
            {
                return unitField;
            }
            set
            {
                unitField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public decimal Value
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
