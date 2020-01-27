using System;
using System.Collections.Generic;
using System.Text;

namespace RecreationGovSharp.Schemas
{
    public class FacilityActivity
    {
        public string ActivityId { get; set; }
        public string FacilityId { get; set; }
        public string ActivityName { get; set; }
        public string FacilityActivityDescription { get; set; }
        public string FacilityActivityFeeDescription { get; set; }
    }
}
