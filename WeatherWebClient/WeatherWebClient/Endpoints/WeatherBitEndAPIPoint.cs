using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherWebClient.Endpoints
{
    class WeatherBitEndAPIPoint : Endpoint
    {
        public WeatherBitEndAPIPoint() :
          base("http://dataservice.accuweather.com",
          "270d3f2205d4473a9247d7f701bce83c")
        { }
    }
}
