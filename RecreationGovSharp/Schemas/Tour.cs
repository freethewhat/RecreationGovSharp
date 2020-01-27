using System;
using System.Collections.Generic;
using System.Text;

namespace RecreationGovSharp.Schemas
{
    public class Tour
    {
        public string TourId { get; set; }
        public string FacilityId { get; set; }
        public string TourName { get; set; }
        public string TourType { get; set; }
        public string TourDescription { get; set; }
        public int TourDuration { get; set; }
        public bool TourAccessible { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public IList<Attribute> Attributes { get; set; }
        public IList<Media> EntityMedia { get; set; }
        public IList<int> MemberTours { get; set; }
    }
}
