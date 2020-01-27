using System;
using System.Collections.Generic;
using System.Text;

namespace RecreationGovSharp.Schemas
{
    public class Organization
    {
        public string OrgId { get; set; }
        public string OrgName { get; set; }
        public string OrgImageUrl { get; set; }
        public string OrgUrlText { get; set; }
        public string OrgUrlAddress { get; set; }
        public string OrgType { get; set; }
        public string OrgAbbrevName { get; set; }
        public string OrgJurisdictionType { get; set; }
        public string OrgParentId { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
