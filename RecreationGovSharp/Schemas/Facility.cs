using System;
using System.Collections.Generic;
using System.Text;

namespace RecreationGovSharp.Schemas
{
    public class Facility
    {
        public string FacilityIf { get; set; }
        public string LegacyFacilityId { get; set; }
        public string OrgFacilityId { get; set; }
        public string ParentOrgId { get; set; }
        public string ParentRecAreaId { get; set; }
        public string FacilityName { get; set; }
        public string FacilityDescription { get; set; }
        public string FacilityTypeDescription { get; set; }
        public string FacilityUseFeeDescription { get; set; }
        public string FacilityDirections { get; set; }
        public string FacilityPhone { get; set; }
        public string FacilityEmail { get; set; }
        public string FacilityReservationUrl { get; set; }
        public string FacilityMapUrl { get; set; }
        public string FacilityAdaAccess { get; set; }
        public GeoJson GeoJson { get; set; } // GEOJSON HERE
        public double FacilityLongitude { get; set; }
        public double FacilityLatitude { get; set; }
        public string StayLimit { get; set; }
        public string Keywords { get; set; }
        public bool Reservable { get; set; }
        public bool Enabled { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public IList<Campsite> Campsites { get; set; }
        public IList<PermitEntrance> PermitEntrances { get; set; }
        public IList<Tour> Tours { get; set; }
        public IList<Organization> Organizations { get; set; }
        public IList<RecreationArea> RecAreas { get; set; }
        public IList<FacilityAddress> FacilityAddresses { get; set; }
        public IList<Activity> Activities { get; set; }
        public IList<Event> Events { get; set; }
        public IList<Link> Links { get; set; }
        public IList<Media> Media { get; set; }
    }
}
