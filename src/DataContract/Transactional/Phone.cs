using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace MaxiPago.DataContract.Transactional
{
    [Serializable]
    [XmlRoot("phone")]
    public class Phone
    {
        [XmlElement("phoneType")]
        public string PhoneType { get; set; }

        [XmlElement("phoneCountryCode")]
        public string PhoneCountryCode { get; set; }

        [XmlElement("phoneAreaCode")]
        public string PhoneAreaCode { get; set; }

        [XmlElement("phoneNumber")]
        public string PhoneNumber { get; set; }

        [XmlElement("phoneExtension")]
        public string PhoneExtension { get; set; }
    }
}
