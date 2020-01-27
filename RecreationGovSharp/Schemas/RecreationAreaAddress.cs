using System;
using System.Collections.Generic;
using System.Text;

namespace RecreationGovSharp.Schemas
{
    public class RecreationAreaAddress
    {
        public string RecAreaAddressId { get; set; }
        public string RecAreaId { get; set; }
        public RecAreaAddressType RecAreaAddressType { get; set; }
        public string RecAreaAddress1 { get; set; }
        public string RecAreaAddress2 { get; set; }
        public string RecAreaAddress3 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string AddressStateCode { get; set; }
        public string AddressCountryCode { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }

    public enum RecAreaAddressType
    {
        Default,
        Mailing,
        Physical
    }
}
