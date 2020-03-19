using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace WeatherWebClient.Models
{
    [DataContract]
    class WeatherBitAPIForecastModel
    {
        [DataMember]
        public List<Data> data;
    }

    [DataContract]
    class Data
    {
        [DataMember]
        public float temp { get; set; }
        [DataMember]
        public string timestamp_local { get; set; }
    }

}
