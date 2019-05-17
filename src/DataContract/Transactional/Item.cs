using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace MaxiPago.DataContract.Transactional
{
    [Serializable]
    [XmlRoot("item")]
    public class Item
    {
        [XmlElement("itemIndex")]
        public string ItemIndex { get; set; }

        [XmlElement("itemProductCode")]
        public string ItemProductCode { get; set; }

        [XmlElement("itemDescription")]
        public string ItemDescription { get; set; }

        [XmlElement("itemQuantity")]
        public string ItemQuantity { get; set; }

        [XmlElement("itemTotalAmount")]
        public double ItemTotalAmount { get; set; }

        [XmlElement("itemUnitCost")]
        public double ItemUnitCost { get; set; }
    }
}
