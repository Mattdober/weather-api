using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace WeatherWebClient.Models
{
    [DataContract]
    class AccuWeatherAPILocationModel
    {
        [DataMember]
        public string Key { get; set; }
    }
}
