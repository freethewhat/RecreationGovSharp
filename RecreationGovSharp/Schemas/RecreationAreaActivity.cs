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
        public string ActivityName { get; set; }
        public string RecAreaActivityDescription { get; set; }
        public string RecAreaActivityFeeDescription { get; set; }
    }
}
