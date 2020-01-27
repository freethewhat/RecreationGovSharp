using System;
using System.Collections.Generic;
using System.Text;

namespace RecreationGovSharp.Schemas
{
    public class Activity
    {
        public int ActivityId { get; set; }
        public int ActivityParentId { get; set; }
        public string ActivityName { get; set; } // is this an enum. If so what are the values?
        public int ActivityLevel { get; set; }
    }
}
