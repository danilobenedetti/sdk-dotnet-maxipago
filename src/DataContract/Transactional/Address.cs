using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace MaxiPago.DataContract.Transactional {
    
    [Serializable]
    public class Address {

        [XmlElement("id")]
        public string Id { get; set; }
        public bool ShouldSerializeId() { return !string.IsNullOrEmpty(this.Id); }

        [XmlElement("name")]
        public string Name { get; set; }
        public bool ShouldSerializeName() { return !string.IsNullOrEmpty(this.Name); }

        [XmlElement("address")]
        public string Address1 { get; set; }
        public bool ShouldSerializeAddress1() { return !string.IsNullOrEmpty(this.Address1); }

        [XmlElement("address2")]
        public string Address2 { get; set; }
        public bool ShouldSerializeAddress2() { return !string.IsNullOrEmpty(this.Address2); }

        [XmlElement("district")]
        public string District { get; set; }
        public bool ShouldSerializeDistrict() { return !string.IsNullOrEmpty(this.District); }

        [XmlElement("city")]
        public string City { get; set; }
        public bool ShouldSerializeCity() { return !string.IsNullOrEmpty(this.City); }

        [XmlElement("state")]
        public string State { get; set; }
        public bool ShouldSerializeState() { return !string.IsNullOrEmpty(this.State); }

        [XmlElement("postalcode")]
        public string Postalcode { get; set; }
        public bool ShouldSerializePostalcode() { return !string.IsNullOrEmpty(this.Postalcode); }

        [XmlElement("country")]
        public string Country { get; set; }
        public bool ShouldSerializeCountry() { return !string.IsNullOrEmpty(this.Country); }

        [XmlElement("phone")]
        public string Phone { get; set; }
        public bool ShouldSerializePhone() { return !string.IsNullOrEmpty(this.Phone); }

        [XmlElement("email")]
        public string Email { get; set; }
        public bool ShouldSerializeEmail() { return !string.IsNullOrEmpty(this.Email); }

        [XmlElement("type")]
        public string Type { get; set; }
        public bool ShouldSerializeType() { return !string.IsNullOrEmpty(this.Type); }

        [XmlElement("gender")]
        public string Gender { get; set; }
        public bool ShouldSerializeGender() { return !string.IsNullOrEmpty(this.Gender); }

        [XmlElement("birthDate")]
        public string BirthDate { get; set; }
        public bool ShouldSerializeBirthDate() { return !string.IsNullOrEmpty(this.BirthDate); }

    }
}
