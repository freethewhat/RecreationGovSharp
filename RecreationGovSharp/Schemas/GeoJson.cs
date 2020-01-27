using System;
using System.Collections.Generic;
using System.Text;

namespace RecreationGovSharp.Schemas
{
    public class GeoJson
    {
        public string Type { get; set; }
        public IList<double> Coordinates { get; set; }
    }
}
