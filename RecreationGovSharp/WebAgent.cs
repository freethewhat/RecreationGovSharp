using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security;
using System.Text;

namespace RecreationGovSharp
{
    public class WebAgent
    {
        private readonly string _baseUrl = "https://ridb.recreation.gov/api/v1/";

        public SecureString ApiKey { get; set; }
        public HttpWebRequest Request { get; set; }

        public WebAgent(SecureString apiKey)
        {
            ApiKey = apiKey;
        }

        private HttpWebRequest CreateRequest(string url, string method)
        {
            HttpWebRequest request;

            request = (HttpWebRequest)WebRequest.Create(url);

            request.ContentType = "application/json";
            request.Accept = "application/json";
            request.Method = method;

            request.Headers.Add("apikey", ApiKey.ToString());
            return request;
        }

        public WebAgent CreateGetRequest(string url)
        {
            Request = CreateRequest(url, "GET");
            return this; 
        }

        public string GetResponse()
        {
            var response = (HttpWebResponse)Request.GetResponse();
            string message;

            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                message = streamReader.ReadToEnd();
            }

            return message;
        }
    }
}
