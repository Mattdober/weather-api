using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace WeatherWebClient.Models
{
    [DataContract]
    class WeatherBitAPIWeatherModel
    {
        [DataMember]
        public List<unnamedObject> data { get; set; }
    }

    [DataContract]
    class unnamedObject
    {
        [DataMember]
        public float temp { get; set; }
    }
}
