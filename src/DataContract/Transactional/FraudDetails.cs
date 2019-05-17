using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace MaxiPago.DataContract.Transactional
{
    [Serializable]
    [XmlRoot("fraudDetails")]
    public class FraudDetails
    {
        [XmlElement("fraudProcessorID")]
        public string FraudProcessorID { get; set; }

        [XmlElement("captureOnLowRisk")]
        public string CaptureOnLowRisk { get; set; }

        [XmlElement("voidOnHighRisk")]
        public string VoidOnHighRisk { get; set; }

        [XmlElement("websiteId")]
        public string WebsiteId { get; set; }

        [XmlElement("fraudToken")]
        public string FraudToken { get; set; }
    }
}
