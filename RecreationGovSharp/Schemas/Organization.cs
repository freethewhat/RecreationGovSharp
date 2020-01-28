using System;
using System.Collections.Generic;
using System.Text;

namespace RecreationGovSharp.Schemas
{
    public class Organization
    {
        public string OrgId { get; set; }

        private string _orgName;
        public string OrgName { 
            get { return _orgName; } 
            set
            {
                if (value.Length > 60)
                    throw new ArgumentOutOfRangeException("Orginization name cannot be longer than 60 characters.");

                _orgName = value;
            }
        }

        private string _orgImageUrl;
        public string OrgImageUrl
        {
            get { return _orgImageUrl; }
            set
            {
                if (value.Length > 256)
                    throw new ArgumentOutOfRangeException("Organization image URL cannot be longer than 256 characters.");

                _orgImageUrl = value;
            }
        }

        private string _orgUrlText;
        public string OrgUrlText { 
            get { return _orgUrlText; } 
            set
            {
                if (value.Length > 256)
                    throw new ArgumentOutOfRangeException("Orginization Url text cannot be longer than 256 characters.");

                _orgUrlText = value;
            }
        }
        
        public string OrgUrlAddress { get; set; }

        private string _orgType;
        public string OrgType
        {
            get { return _orgType; }
            set
            {
                if (value.Length > 40)
                    throw new ArgumentOutOfRangeException("Orginization type cannot be longer than 40 characters.");

                _orgType = value;
            }
        }

        private string _orgAbbrevName;
        public string OrgAbbrevName { 
            get { return _orgAbbrevName; } 
            set
            {
                if (value.Length > 20)
                    throw new ArgumentOutOfRangeException("Orginization abbreviation name cannot be longer than 20 characters.");

                _orgAbbrevName = value;
            }
        }

        private string _orgJurisdictionType;
        public string OrgJurisdictionType { 
            get { return _orgJurisdictionType; } 
            set
            {
                if (value.Length > 20)
                    throw new ArgumentOutOfRangeException("Orginization jurisdiction type cannot be longer than 20 characters.");

                _orgJurisdictionType = value;
            }
        }

        public string OrgParentId { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
