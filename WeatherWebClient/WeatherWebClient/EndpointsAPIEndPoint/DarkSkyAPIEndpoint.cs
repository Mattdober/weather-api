using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherWebClient.Endpoints
{
    class DarkSkyAPIEndpoint : Endpoint
    {
        public DarkSkyAPIEndpoint() : 
            base("https://api.darksky.net/forecast/",
            "df4324ed121048af1cba8658e790e82b") { }
        //example-https://api.darksky.net/forecast/df4324ed121048af1cba8658e790e82b/37.8267,-122.4233

        public string getLocationEndPoint()
        {
            StringBuilder stringBuilder = new StringBuilder(baseEndpoint);
            
            return stringBuilder.ToString();
        }
    }
}
