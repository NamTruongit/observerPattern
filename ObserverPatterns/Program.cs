using System;

namespace ObserverPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
           WeatherData weatherData = new WeatherData();
           
            CurrentConditionsDisplay currentConditions = new CurrentConditionsDisplay(weatherData);
            StaticsDisplay staticsDisplay = new StaticsDisplay(weatherData);
            weatherData.SetMeasurements(12, 28, 9);
   
        }
    }
}
