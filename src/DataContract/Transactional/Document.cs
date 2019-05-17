using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace MaxiPago.DataContract.Transactional
{
    [Serializable]
    [XmlRoot("document")]
    public class Document
    {
        [XmlElement("documentType")]
        public string DocumentType { get; set; }

        [XmlElement("documentValue")]
        public string DocumentValue { get; set; }
    }
}
