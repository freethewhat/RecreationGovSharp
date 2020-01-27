using System;
using System.Collections.Generic;
using System.Text;

namespace RecreationGovSharp.Schemas
{
    public class PermitEntrance
    {
        public string PermitEntranceId { get; set; }
        public string FacilityId { get; set; }
        public string PermitEntranceName { get; set; }
        public string PermitEntranceDescription { get; set; }
        public string District { get; set; }
        public string Town { get; set; }
        public bool PermitEntranceAccessible { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public GeoJson GeoJson { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public IList<Attribute> Attributes { get; set; }
        public IList<Media> EntityMedia { get; set; }
        public IList<Zone> Zones { get; set; }
    }
}
