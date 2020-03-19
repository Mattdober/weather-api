using System;
using WeatherWebClient.Controller;
using WeatherWebClient.POCO;

namespace WeatherWebClient
{
    class Program
    {
        //Dark Sky API - https://darksky.net/dev/docs
        //Weather2020 - http://api.weather2020.com/
        static void Main(string[] args)
        {
            //OpenWeatherMapAPI();
            //AccuWeatherAPI();
            //WeatherbitAPI();
            DarkSkyAPI();
            Console.ReadKey();
        }

        private static void DarkSkyAPI()
        {
            //Dark sky api
            //Current weather
            
        }

        private static void OpenWeatherMapAPI()
        {
            string cityName = "Valletta";

            /**** Open Weather Map ****/
            /**** Current Weather ****/
            OpenWeatherMapController openWeatherMapController = new OpenWeatherMapController();

            Console.WriteLine("***** Open Weather Map *****");
            Console.WriteLine("***** Current Weather API *****");
            Console.WriteLine($"Current Temperature for {cityName}: {openWeatherMapController.getCurrentWeather(cityName)}");

            /**** FORECAST****/
            Console.WriteLine("***** Forecast API *****");
            Console.WriteLine($"Forecast for {cityName}: ");
            foreach (OpenWeatherMapForecast forecast in openWeatherMapController.getForecast(cityName))
            {
                Console.WriteLine($"{forecast.getDateTime().ToString()} Temperature: {forecast.getTemperature()}");
            }
        }

        private static void AccuWeatherAPI()
        {
            string cityName = "Valletta";

            /**** AccuWeather ****/
            /**** Current Weather ****/
            AccuWeatherController accuWeatherController = new AccuWeatherController();

            Console.WriteLine("***** AccuWeather *****");
            Console.WriteLine("***** Current Weather API *****");
            Console.WriteLine($"Current Temperature for {cityName}: {accuWeatherController.getCurrentWeather(cityName)}");

            /**** FORECAST****/
            Console.WriteLine("***** Forecast API *****");
            Console.WriteLine($"Forecast for {cityName}: ");
            foreach (AccuWeatherForecast forecast in accuWeatherController.getForecast(cityName))
            {
                Console.WriteLine($"{forecast.getDateTime().ToString()} Minimum: {forecast.getMinimum()} Maximum: {forecast.getMaximum()}");
            }

        }

        private static void WeatherbitAPI()
        {
            string cityName = "Valletta";
            /*** WeatherBit ***/
            /*** current weather ***/
            WeatherBitController weatherBitController = new WeatherBitController();
            AccuWeatherController accuWeatherControllerLocation = new AccuWeatherController();
            
            Console.WriteLine("_____ WeatherBit _____");
            Console.WriteLine("-_-_ Current Weather API _-_-");
            Console.WriteLine($"Current Temperature for {cityName}: {weatherBitController.getCurrentWeather(cityName)}");
            /*** Forcast ***/
            Console.WriteLine($"Forecast for {cityName}: ");
            foreach(WeatherBitForcast forcast in weatherBitController.getForcast(cityName))
            {
                Console.WriteLine($" Time {forcast.getDateTime()} Temprature: {forcast.getTemperature()}");
            }
            
        }
    }
}
