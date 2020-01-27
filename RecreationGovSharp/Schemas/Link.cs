using System;
using System.Collections.Generic;
using System.Text;

namespace RecreationGovSharp.Schemas
{
    public class Link
    {
        public string EntityLinkId { get; set; }
        public string LinkType { get; set; }
        public string EntityId { get; set; }
        public string EntityType { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
    }
}
