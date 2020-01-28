using System;
using System.Collections.Generic;
using System.Text;

namespace RecreationGovSharp.Schemas
{
    public class RecreationAreaFacility
    {
        public string FacilityId { get; set; }

        private string _facilityName;
        public string FacilityName { 
            get { return _facilityName; } 
            set 
            {
                if (value.Length > 256)
                 throw new ArgumentOutOfRangeException("Facility name cannot be longer than 256 characters.");

                _facilityName = value;
            } 
        }
        
        public string ResourceLink { get; set; }
    }
}
