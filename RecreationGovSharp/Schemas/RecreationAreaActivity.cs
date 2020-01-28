using System;
using System.Collections.Generic;
using System.Text;

namespace RecreationGovSharp.Schemas
{
    public class RecreationAreaActivity
    {
        public string ActivityId { get; set; }
        public string ActivityParentId { get; set; }
        public string RecAreaId { get; set; }
        
        private string _activityName;
        public string ActivityName { 
            get { return _activityName; } 
            set
            {
                if (value.Length > 60)
                    throw new ArgumentOutOfRangeException("Activity name cannot be longer than 60 characters.");
                
                _activityName = value;
            } 
        } // 60
        
        private string _recAreaActivityDescription;
        public string RecAreaActivityDescription { 
            get { return _recAreaActivityDescription; } 
            set
            {
                if (value.Length > 1024)
                    throw new ArgumentOutOfRangeException("Recreation area activity description cannot be longer than 1024 characters.");
                
                _recAreaActivityDescription = value;
            } 
        } // 1024
        
        private string _recAreaActivityFeeDescription;
        public string RecAreaActivityFeeDescription { 
            get { return _recAreaActivityFeeDescription; } 
            set
            {
                if (value.Length > 1024)
                    throw new ArgumentOutOfRangeException("Recreation area activity fee description cannot be longer than 1024 characters.");
                
                _recAreaActivityFeeDescription = value;
            } 
        } // 1024
    }
}
