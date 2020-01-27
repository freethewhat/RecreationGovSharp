using System;
using System.Collections.Generic;
using System.Text;

namespace RecreationGovSharp.Schemas
{
    public class Campsite
    {
        public string CampsiteId { get; set; }
        public string FacilityId { get; set; }

        private string _campsiteName;
        public string CampsiteName { 
            get { return _campsiteName; }
            set 
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException("Campsite name cannot be longer than 255 characters.");

                _campsiteName = value;
            } 
        }

        private string _campsiteType;
        public string CampsiteType { 
            get { return _campsiteType; }
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException("Campsite type cannot be longer than 255 characters.");

                _campsiteType = value;
            }
        }

        private string _typeOfUse;
        public string TypeOfUse {
            get { return _typeOfUse; }
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException("Type of use cannot be longer than 255 characters.");

                _typeOfUse = value;
            }
        }

        private string _loop;
        public string Loop {
            get { return _loop; }
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException("Loop cannot be longer than 255 characters.");

                _loop = value;
            }
        } 

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
