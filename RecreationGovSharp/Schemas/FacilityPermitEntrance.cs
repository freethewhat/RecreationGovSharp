using System;
using System.Collections.Generic;
using System.Text;

namespace RecreationGovSharp.Schemas
{
    class FacilityPermitEntrance
    {
        public string PermitEntranceId { get; set; }

        private string _permitEntranceName;
        public string PermitEntranceName { 
            get { return _permitEntranceName; } 
            set 
            {
                if (value.Length > 512)
                    throw new ArgumentOutOfRangeException("Permit entrance name cannot be longer than 512 characters.");

                _permitEntranceName = value;
            } 
        } 
        public string ResourceLink { get; set; }
    }
}
