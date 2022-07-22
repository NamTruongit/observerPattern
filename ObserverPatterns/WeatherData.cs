using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatterns
{
    public class WeatherData : ISubject
    {
        private ArrayList observers;

        private float temprature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new ArrayList();
        }


        public void NotifyObserver()
        {
            for (int i = 0; i < observers.ToArray().Length; i++)
            {
                int index = 0;
                IObserver observer = (IObserver)observers[i];
                observer.Update(temprature, humidity, pressure);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            int i = observers.IndexOf(o);
            if (i > 1)
            {
                observers.RemoveAt(i);
            }
        }

        public void Measurementchange()
        {
            NotifyObserver();
        }

        public void SetMeasurements(float temprature,float humidity,float pressure)
        {
            this.temprature = temprature;
            this.humidity = humidity;
            this.pressure = pressure;
            Measurementchange();
        }

    }
}
