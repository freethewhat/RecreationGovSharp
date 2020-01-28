using System;
using System.Collections.Generic;
using System.Text;

namespace RecreationGovSharp.Schemas
{
    public class Zone
    {
        public string PermitEntranceZoneId { get; set; }

        private string _zoneName;
        public string ZoneName { 
            get { return _zoneName; } 
            set 
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException("Zone name cannot be longer than 255 characters.");

                _zoneName = value;
            } 
        } // 255
    }
}
