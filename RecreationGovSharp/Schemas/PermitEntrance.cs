using System;
using System.Collections.Generic;
using System.Text;

namespace RecreationGovSharp.Schemas
{
    public class PermitEntrance
    {
        public string PermitEntranceId { get; set; }
        public string FacilityId { get; set; }

        private string _permitEntranceName;
        public string PermitEntranceName
        {
            get { return _permitEntranceName; }
            set
            {
                if (value.Length > 512)
                    throw new ArgumentOutOfRangeException("Permit entrance name cannot be longer than 512 characters.");

                _permitEntranceName = value;
            }
        }

        private string _permitEntranceDescription;
        public string PermitEntranceDescription
        {
            get { return _permitEntranceDescription; }
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException("Permit entrance description cannot be longer than 255 characters.");

                _permitEntranceDescription = value;
            }
        }

        private string _district;
        public string District
        {
            get { return _district; }
            set
            {
                if (value.Length > 60)
                    throw new ArgumentOutOfRangeException("District cannot be longer than 60 characters.");

                _district = value;
            }
        }

        private string _town;
        public string Town
        {
            get { return _town; }
            set
            {
                if (value.Length > 60)
                    throw new ArgumentOutOfRangeException("Town cannot be longer than 60 characters.");

                _town = value;
            }
        }

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
