using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RecreationGovSharp
{
    public class JsonHandler<T> where T : class
    {
        private static JsonSerializerOptions GetSerializerOptions()
        {
            var options = new JsonSerializerOptions()
            {
                IgnoreNullValues = true,
                PropertyNameCaseInsensitive = true,
            };

            return options;
        }

        public static T Deserialize(string json)
        {
            var options = GetSerializerOptions();
            var result = JsonSerializer.Deserialize<T>(json, options);
            return result;
        }
    }
}
