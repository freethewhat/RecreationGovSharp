using System;
using System.Collections.Generic;
using System.Text;

namespace RecreationGovSharp.Schemas
{
    public class FacilityTour
    {
        public string TourId { get; set; }

        private string _tourName;
        public string TourName { 
            get { return _tourName; } 
            set
            {
                if (value.Length > 256)
                    throw new ArgumentOutOfRangeException("Tour name cannot be longer than 256 characters.");
            } 
        } 
        
        public string ResourceLink { get; set; }
    }
}
