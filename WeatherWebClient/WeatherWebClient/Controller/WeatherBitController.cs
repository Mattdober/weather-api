using System;
using System.Collections.Generic;
using System.Text;
using WeatherWebClient.Models;
using WeatherWebClient.JSONParser;
using WeatherWebClient.Endpoints;
using WeatherWebClient.POCO;

namespace WeatherWebClient.Controller
{
    class WeatherBitController : Controller
    {
        private WeatherBitEndAPIPoint weatherBitEndAPIPoint;

        public WeatherBitController(): base()
        {
            weatherBitEndAPIPoint = new WeatherBitEndAPIPoint();
        }

        public float getCurrentWeather(string city)
        {
            float temperature = 0f;

            weatherBitEndAPIPoint.endpointType = EndpointType.WEATHER;

            string response = getResponse(weatherBitEndAPIPoint.getCityEndpoint(city));

            System.Diagnostics.Debug.WriteLine(response);
            using (JsonParser<WeatherBitAPIWeatherModel> jSONParser = new JsonParser<WeatherBitAPIWeatherModel>())
            {
                WeatherBitAPIWeatherModel weatherbitModel = new WeatherBitAPIWeatherModel();
                weatherbitModel = jSONParser.parse(response, netCoreVersion);

                temperature = weatherbitModel.data[0].temp;  
            }

            return temperature;
        }

        public List<WeatherBitForcast> getForcast(string city)
        {
            List<WeatherBitForcast> forcastList = new List<WeatherBitForcast>();
            weatherBitEndAPIPoint.endpointType = EndpointType.FORECAST;

            string response = getResponse(weatherBitEndAPIPoint.getCityEndpoint(city));

            using(JsonParser<WeatherBitAPIForecastModel> JsonParser = new JsonParser<WeatherBitAPIForecastModel>())
            {
                WeatherBitAPIForecastModel weatherBitAPIForecastModel = new WeatherBitAPIForecastModel();
                weatherBitAPIForecastModel = JsonParser.parse(response, netCoreVersion);

                foreach(Data data in weatherBitAPIForecastModel.data)
                {
                    forcastList.Add(new WeatherBitForcast(data.timestamp_local, data.temp));
                }
            }

            return forcastList;
        }
    }
}
