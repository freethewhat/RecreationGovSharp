using System;
using System.Collections.Generic;
using System.Text;

namespace RecreationGovSharp.Schemas
{
    public class RecreationArea
    {
        public string RecAreaId { get; set; }
        public string OrgRecAreaId { get; set; }
        public string ParentOrgId { get; set; }
        public string RecAreaName { get; set; }
        public string RecAreaDescription { get; set; }
        public string RecAreaFeeDescription { get; set; }
        public string RecAreaDirections { get; set; }
        public string RecAreaPhone { get; set; }
        public string RecAreaEmail { get; set; }
        public string RecAreaReservationUrl { get; set; }
        public string RecAreaMapUrl { get; set; }
        public GeoJson GeoJson { get; set; }
        public double RecAreaLongitude { get; set; }
        public double RecAreaLatitude { get; set; }
        public string StayLimit { get; set; }
        public string Keywords { get; set; }
        public bool Reservable { get; set; }
        public bool Enabled { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public IList<Organization> Organizations { get; set; }
        public IList<Facility> Facilities { get; set; }
        public IList<RecAreaAddress> RecAreaAddresses { get; set; }
        public IList<Activity> Activities { get; set; }
        public IList<Event> Events { get; set; }
        public IList<Media> Media { get; set; }
        public IList<Link> Links { get; set; }
    }
}
