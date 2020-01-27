using System;
using System.Collections.Generic;
using System.Text;

namespace RecreationGovSharp.Schemas
{
    public class Campsite
    {
        public string CampsiteId { get; set; }
        public string FacilityId { get; set; }
        public string CampsiteName { get; set; }
        public string CampsiteType { get; set; }
        public string TypeOfUse { get; set; }
        public string Loop { get; set; }
        public bool CampsiteAccessible { get; set; }
        public double CampsiteLongitude { get; set; }
        public double CampsiteLatitude { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public IList<Attribute> Attributes { get; set; }
        public IList<PermittedEquipment> PermittedEquipment { get; set; }
        public IList<Media> EntityMedia { get; set; }
    }
}
