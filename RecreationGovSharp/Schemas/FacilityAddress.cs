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

        private string _facilityStreetAddress1;
        public string FacilityStreetAddress1 { 
            get { return _facilityStreetAddress1; } 
            set 
            {
                if (value.Length > 256)
                    throw new ArgumentOutOfRangeException("Facility street address 1 cannot be longer than 256 characters.");

                _facilityStreetAddress1 = value;
            } 
        } 

        private string _facilityStreetAddress2;
        public string FacilityStreetAddress2 { 
            get { return _facilityStreetAddress1; } 
            set 
            {
                if (value.Length > 256)
                    throw new ArgumentOutOfRangeException("Facility street address 1 cannot be longer than 256 characters.");

                _facilityStreetAddress1 = value;
            } 
        } 

        private string _facilityStreetAddress3;
        public string FacilityStreetAddress3 { 
            get { return _facilityStreetAddress3; } 
            set
            {
                if (value.Length > 256)
                    throw new ArgumentOutOfRangeException("Facility street address 1 cannot be longer than 256 characters.");

                _facilityStreetAddress3 = value;
            } 
        } 

        private string _city;
        public string City { 
            get { return _city; } 
            set 
            {
                if (value.Length > 60)
                    throw new ArgumentOutOfRangeException("City cannot be longer than 60 characters.");

                _city = value;
            }
        }

        private string _postalCode;
        public string PostalCode { 
            get { return _postalCode; } 
            set 
            {
                if (value.Length > 20)
                    throw new ArgumentOutOfRangeException("Postal code cannot be longer than 20 characters.");
            }
        }

        private string _addressStateCode;
        public string AddressStateCode { 
            get { return _addressStateCode; } 
            set
            {
                if (value.Length > 20)
                    throw new ArgumentOutOfRangeException("Address state code cannot be longer than 20 characters.");

                _addressStateCode = value;
            } 
        } 

        private string _addressCountryCode;
        public string AddressCountryCode { 
            get { return _addressCountryCode; } 
            set 
            {
                if (value.Length > 20)
                    throw new ArgumentOutOfRangeException("Address country code cannot be longer than 20 characters.");

                _addressCountryCode = value;
            } 
        }
        public DateTime LastUpdatedDate { get; set; }
    }

    public enum FacilityAddressType
    {
        Default,
        Mailing,
        Physical
    }
}
