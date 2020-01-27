using System;
using System.Collections.Generic;
using System.Text;

namespace RecreationGovSharp.Schemas
{
    public class FacilityAddress
    {
        public string FacilityAddressId { get; set; }
        public string FacilityId { get; set; }
        public FacilityAddressType FacilityAddressType { get; set; }
        public string FacilityStreetAddress1 { get; set; }
        public string FacilityStreetAddress2 { get; set; }
        public string FacilityStreetAddress3 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string AddressStateCode { get; set; }
        public string AddressCountryCode { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }

    public enum FacilityAddressType
    {
        Default,
        Mailing,
        Physical
    }
}
