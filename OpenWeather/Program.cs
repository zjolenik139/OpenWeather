using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace OpenWeatherApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var apiKey = "c1eee7593bc8363dd3021e5a3a7fe110";

            Console.WriteLine("What city would you like the weather for?");
            var cityName = Console.ReadLine();

            string weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=imperial";
            string weatherResponse = client.GetStringAsync(weatherURL).Result;
            var weatherObject = JObject.Parse(weatherResponse);
            Console.WriteLine(weatherObject["main"]["temp"]);
        }
    }
}

