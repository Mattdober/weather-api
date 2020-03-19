using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherWebClient.POCO
{
    class WeatherBitForcast
    {
        private string datetime;
        private float temprature;

        public WeatherBitForcast(string dt, float temprature)
        {
            this.datetime = dt;
            this.temprature = temprature;
        }

        public string getDateTime()
        {
            return datetime;
        }

        public float getTemperature()
        {
            return temprature;
        }
    }
}
