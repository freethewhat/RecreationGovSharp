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

        private string _recAreaName;
        public string RecAreaName
        {
            get { return _recAreaName; }
            set
            {
                if (value.Length > 256)
                    throw new ArgumentOutOfRangeException("Recreation area name cannot be longer than 256 characters.");

                _recAreaName = value;
            }
        } 

        private string _recAreaDescription;
        public string RecAreaDescription
        {
            get { return _recAreaDescription; }
            set
            {
                if (value.Length > 4000)
                    throw new ArgumentOutOfRangeException("Recreation area description cannot be longer than 4000 characters.");

                _recAreaDescription = value;
            }
        } 
        public string RecAreaFeeDescription { get; set; }

        private string _recAreaDirections;
        public string RecAreaDirections
        {
            get { return _recAreaDirections; }
            set
            {
                if (value.Length > 4000)
                    throw new ArgumentOutOfRangeException("Recreation area directions cannot be longer than 4000 characters.");

                _recAreaDirections = value;
            }
        } 

        private string _recAreaPhone;
        public string RecAreaPhone
        {
            get { return _recAreaPhone; }
            set
            {
                if (value.Length > 256)
                    throw new ArgumentOutOfRangeException("Recreation area phone cannot be longer than 256 characters.");

                _recAreaPhone = value;
            }
        } 

        private string _recAreaEmail;
        public string RecAreaEmail
        {
            get { return _recAreaEmail; }
            set
            {
                if (value.Length > 256)
                    throw new ArgumentOutOfRangeException("Recreation area email cannot be longer than 256 characters.");

                _recAreaEmail = value;
            }
        } 

        private string _recAreaReservationUrl;
        public string RecAreaReservationUrl
        {
            get { return _recAreaReservationUrl; }
            set
            {
                if (value.Length > 256)
                    throw new ArgumentOutOfRangeException("Recreation area reservation URL cannot be longer than 256 characters.");

                _recAreaReservationUrl = value;
            }
        } 

        private string _recAreaMapUrl;
        public string RecAreaMapUrl
        {
            get { return _recAreaMapUrl; }
            set
            {
                if (value.Length > 256)
                    throw new ArgumentOutOfRangeException("Recreation area map URL cannot be longer than 256 characters.");

                _recAreaMapUrl = value;
            }
        } 

        public GeoJson GeoJson { get; set; }
        public double RecAreaLongitude { get; set; }
        public double RecAreaLatitude { get; set; }

        private string _stayLimit;
        public string StayLimit
        {
            get { return _stayLimit; }
            set
            {
                if (value.Length > 500)
                    throw new ArgumentOutOfRangeException("Stay limit cannot be longer than 500 characters.");

                _stayLimit = value;
            }
        } 

        private string _keywords;
        public string Keywords
        {
            get { return _keywords; }
            set
            {
                if (value.Length > 4000)
                    throw new ArgumentOutOfRangeException("Keywords cannot be longer than 4000 characters.");

                _keywords = value;
            }
        } 

        public bool Reservable { get; set; }
        public bool Enabled { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public IList<Organization> Organizations { get; set; }
        public IList<Facility> Facilities { get; set; }
        public IList<RecreationAreaAddress> RecAreaAddresses { get; set; }
        public IList<Activity> Activities { get; set; }
        public IList<Event> Events { get; set; }
        public IList<Media> Media { get; set; }
        public IList<Link> Links { get; set; }
    }
}
