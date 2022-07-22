using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatterns
{
    public class StaticsDisplay:IObserver,IDisplayElement
    {
        private float temprature;
        private float humidity;
        private float pressure;
        private ISubject weatherData;

        public StaticsDisplay(ISubject weatherdata)
        {
            this.weatherData = weatherdata;
            weatherData.RegisterObserver(this);
        }


        public void Display()
        {
            Console.WriteLine("weather is:" + temprature + " C Degree, " + humidity + " % humidity, " + pressure + " Apmosphare.");
        }

        public void Update(float temp, float humidity, float pressure)
        {
           this.temprature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }
    }
}
