using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherWebClient.Endpoints
{
    class WeatherBitEndAPIPoint : Endpoint
    {
        public WeatherBitEndAPIPoint() :
          base("https://api.weatherbit.io/v2.0/",
          "270d3f2205d4473a9247d7f701bce83c")
        { }

        //api.weatherbit.io/v2.0/current?city=Valletta&key=270d3f2205d4473a9247d7f701bce83c	
        //api.weatherbit.io/v2.0/forecast/hourly?city=Valletta&hours=5&key=270d3f2205d4473a9247d7f701bce83c

        public string getCityEndpoint(string city)
        {
            StringBuilder stringBuilder = new StringBuilder(baseEndpoint);
            string endPointType = getEndpointType();
            if(endPointType == "weather")
            {
                stringBuilder.Append("current?");
            }
            else
            {
                stringBuilder.Append(endPointType+"/hourly");
                stringBuilder.Append("?hourly=5&");
            }
            stringBuilder.Append("city=");
            stringBuilder.Append(city);
            stringBuilder.Append("&key=");
            stringBuilder.Append(apiKey);
            return stringBuilder.ToString();
        }

    }
}
