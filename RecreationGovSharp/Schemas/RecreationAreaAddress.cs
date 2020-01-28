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
        
        private string _recAreaAddress1;
        public string RecAreaAddress1 { 
            get { return _recAreaAddress1; }
            set
            {
                if (value.Length > 256)
                    throw new ArgumentOutOfRangeException("Recreation area address 1 cannot be longer than 256 characters.");

                _recAreaAddress1 = value;
            } 
        } 
        
        private string _recAreaAddress2;
        public string RecAreaAddress2 { 
            get { return _recAreaAddress2; }
            set
            {
                if (value.Length > 256)
                    throw new ArgumentOutOfRangeException("Recreation area address 2 cannot be longer than 256 characters.");

                _recAreaAddress2 = value;
            } 
        } 
        
        private string _recAreaAddress3;
        public string RecAreaAddress3 { 
            get { return _recAreaAddress3; }
            set
            {
                if (value.Length > 256)
                    throw new ArgumentOutOfRangeException("Recreation area address 3 cannot be longer than 256 characters.");

                _recAreaAddress3 = value;
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

                _postalCode = value;
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
                if (value.Length > 5)
                    throw new ArgumentOutOfRangeException("Address country code cannot be longer than 5 characters.");

                _addressCountryCode = value;
            } 
        } 

        public DateTime LastUpdatedDate { get; set; }
    }

    public enum RecAreaAddressType
    {
        Default,
        Mailing,
        Physical
    }
}
