using System;
using WeatherWebClient.Controller;
using WeatherWebClient.POCO;

namespace WeatherWebClient
{
    class Program
    {
        static void Main(string[] args)
        {
            /*OpenWeatherMapAPI();
            AccuWeatherAPI();*/
            WeatherbitAPI();
            Console.ReadKey();
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

        }
    }
}
