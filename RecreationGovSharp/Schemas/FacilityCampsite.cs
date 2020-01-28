using System;
using System.Collections.Generic;
using System.Text;

namespace RecreationGovSharp.Schemas
{
    public class FacilityCampsite
    {
        public string CampsiteId { get; set; }

        private string _campsiteName;
        public string CampsiteName { 
            get { return _campsiteName; } 
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException("Campsite name cannot be longer than 255 characters.");
            } 
        }
         
        public string ResourceLink { get; set; }
    }
}
