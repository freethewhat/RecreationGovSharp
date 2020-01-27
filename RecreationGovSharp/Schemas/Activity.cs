using System;
using System.Collections.Generic;
using System.Text;

namespace RecreationGovSharp.Schemas
{
    public class Activity
    {
        public int ActivityId { get; set; }
        public int ActivityParentId { get; set; }

        private string _activityName;
        public string ActivityName {
            get
            {
                return _activityName;
            }
            set 
            {
                if (value.Length > 60)
                    throw new ArgumentOutOfRangeException("Activity name cannot be greater than 60 characters");

                _activityName = value;
            } 
        }

        public int ActivityLevel { get; set; }
    }
}
