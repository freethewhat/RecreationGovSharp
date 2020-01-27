using System;
using System.Collections.Generic;
using System.Net;
using System.Security;
using System.Text;

namespace RecreationGovSharp
{
    public class WebAgent
    {
        private readonly string _baseUrl = "https://ridb.recreation.gov/api/v1/";

        public SecureString ApiKey { get; set; }

        public WebAgent()
        {

        }
    }
}
