using System;
using System.Collections.Generic;
using System.Text;

namespace RecreationGovSharp.Schemas
{
    public class FacilityActivity
    {
        public string ActivityId { get; set; }
        public string FacilityId { get; set; }

        private string _activityName;
        public string ActivityName { 
            get { return _activityName; }
            set
            {
                if (value.Length > 60)
                    throw new ArgumentOutOfRangeException("Activity name cannot be longer than 60 characters.");

                _activityName = value;
            } 
        } 

        private string _facilityActivityDescription;
        public string FacilityActivityDescription { 
            get { return _facilityActivityDescription; } 
            set 
            {
                if (value.Length > 1024)
                    throw new ArgumentOutOfRangeException("Facility activity description cannot be longer than 1024 characters.");

                _facilityActivityDescription = value;
            } 
        } 

        private string _facilityActivityFeeDescription;
        public string FacilityActivityFeeDescription { 
            get { return _facilityActivityFeeDescription; } 
            set 
            {
                if (value.Length > 1024)
                    throw new ArgumentOutOfRangeException("Facility activity fee description cannot be longer than 1024 characters.");

                _facilityActivityFeeDescription = value;
            } 
        } 
    }
}
