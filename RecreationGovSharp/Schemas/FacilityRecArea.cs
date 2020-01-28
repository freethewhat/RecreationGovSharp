using System;
using System.Collections.Generic;
using System.Text;

namespace RecreationGovSharp.Schemas
{
    public class FacilityRecArea
    {
        public string RecAreaId { get; set; }

        private string _recAreaName;
        public string RecAreaName { 
            get { return _recAreaName; } 
            set
            {
                if (value.Length > 256)
                    throw new ArgumentOutOfRangeException("Recreation area name cannot be longer than 256 characters.");

                _recAreaName = value;
            } 
        }
         
        public string ResourceLink { get; set; }
    }
}
