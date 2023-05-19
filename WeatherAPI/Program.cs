using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace WeatherAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = File.ReadAllText("appsettings.json");
            string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();

            Console.WriteLine("Enter your zipcode");
            var zipcode = Console.ReadLine();

            var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipcode}&units=imperial&appid={APIKey}";

            Console.WriteLine($"It is currently {WeatherMap.GetTemp(apiCall)} degrees F in your location.");
        }
    }
}
