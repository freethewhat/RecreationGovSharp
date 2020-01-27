using System;
using System.Collections.Generic;
using System.Text;

namespace RecreationGovSharp.Schemas
{
    public class Facility
    {
        public string FacilityId { get; set; }
        public string LegacyFacilityId { get; set; }
        public string OrgFacilityId { get; set; }
        public string ParentOrgId { get; set; }
        public string ParentRecAreaId { get; set; }

        private string _facilityName;
        public string FacilityName {
            get { return _facilityName; }
            set
            {
                if (value.Length > 256)
                    throw new ArgumentOutOfRangeException("Facility name cannot be longer than 256 characters.");

                _facilityName = value;
            } 
        }

        private string _facilityDescription;
        public string FacilityDescription {
            get { return _facilityDescription; }
            set
            {
                if (value.Length > 4000)
                    throw new ArgumentOutOfRangeException("Facility description cannot be longer than 4000 characters.");

                _facilityDescription = value;
            }
        }

        private string _facilityTypeDescription;
        public string FacilityTypeDescription {
            get { return _facilityTypeDescription; }
            set
            {
                if (value.Length > 1024)
                    throw new ArgumentOutOfRangeException("Facility type description cannot be longer than 1024 characters.");

                _facilityTypeDescription = value;
            }
        } 

        public string FacilityUseFeeDescription { get; set; }

        private string _facilityDirections;
        public string FacilityDirections {
            get { return _facilityDirections; }
            set
            {
                if (value.Length > 4000)
                    throw new ArgumentOutOfRangeException("Facility directions cannot be longer than 4000 characters.");
            }
        }

        private string _facilityPhone;
        public string FacilityPhone {
            get { return _facilityPhone; }
            set
            {
                if (value.Length > 256)
                    throw new ArgumentOutOfRangeException("Facility phone cannot be longer than 256 characters.");

                _facilityPhone = value;
            }
        }

        private string _facilityEmail;
        public string FacilityEmail {
            get { return _facilityEmail; }
            set
            {
                if (value.Length > 60)
                    throw new ArgumentOutOfRangeException("Facility email cannot be longer than 60 characters.");

                _facilityEmail = value;
            }
        }

        private string _facilityReservationUrl;
        public string FacilityReservationUrl {
            get { return _facilityReservationUrl; }
            set
            {
                if (value.Length > 256)
                    throw new ArgumentOutOfRangeException("Facility reservation URL cannot be longer than 256 characters.");

                _facilityReservationUrl = value;
            }
        } 

        private string _facilityMapUrl;
        public string FacilityMapUrl {
            get { return _facilityMapUrl; }
            set
            {
                if (value.Length > 256)
                    throw new ArgumentOutOfRangeException("Facility map URL cannot be longer than 256 characters.");

                _facilityMapUrl = value;
            }
        }

        private string _facilityAdaAccess;
        public string FacilityAdaAccess {
            get { return _facilityAdaAccess; }
            set
            {
                if (value.Length > 1024)
                    throw new ArgumentOutOfRangeException("Facility ADA access cannot be longer than 1024 characters.");

                _facilityAdaAccess = value;
            }
        } 

        public GeoJson GeoJson { get; set; }
        public double FacilityLongitude { get; set; }
        public double FacilityLatitude { get; set; }

        private string _stayLimit;
        public string StayLimit {
            get { return _stayLimit; }
            set
            {
                if (value.Length > 500)
                    throw new ArgumentOutOfRangeException("Stay limit cannot be longer than 500 characters.");

                _stayLimit = value;
            }
        }

        private string _keywords;
        public string Keywords {
            get { return _keywords; }
            set
            {
                if (value.Length > 4000)
                    throw new ArgumentOutOfRangeException("Keywords cannot be longer than 4000 characters.");

                _stayLimit = value;
            }
        } 

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
