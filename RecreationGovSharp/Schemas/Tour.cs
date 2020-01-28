using System;
using System.Collections.Generic;
using System.Text;

namespace RecreationGovSharp.Schemas
{
    public class Tour
    {
        public string TourId { get; set; }
        public string FacilityId { get; set; }
        
        private string _tourName;
        public string TourName { 
            get { return _tourName; }
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException("Tour name cannot be longer than 255 characters.");

                _tourName = value;
            } 
        } // 255
        
        private string _tourType;
        public string TourType { 
            get { return _tourType; }
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException("Tour type cannot be longer than 255 characters.");

                _tourType = value;
            } 
        } // 255
        
        private string _tourDescription;
        public string TourDescription { 
            get { return _tourDescription; }
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException("Tour description cannot be longer than 255 characters.");

                _tourDescription = value;
            } 
        } // 255
        public int TourDuration { get; set; }
        public bool TourAccessible { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public IList<Attribute> Attributes { get; set; }
        public IList<Media> EntityMedia { get; set; }
        public IList<int> MemberTours { get; set; }
    }
}
