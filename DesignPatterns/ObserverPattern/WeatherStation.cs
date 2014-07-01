using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface Observer
    {
        void update(int humidity, int temperature, int pressure);
    }
    public interface Subject
    {
        void registerObserver(Observer obj);
        void removeObserver(Observer obj);
        void notifyObserver();
    }

    public class WeatherStation:Subject
    {
        private int hunidity;
        private int temperature;
        private int pressure;

        private List<Observer> observers;

        public WeatherStation()
        {
            observers = new List<Observer>();
        }

        public void registerObserver(Observer obj)
        {
            observers.Add(obj);
        }

        public void removeObserver(Observer obj)
        {
            observers.RemoveAt(observers.IndexOf(obj));
        }

        public void notifyObserver()
        {
            foreach (var observer in observers)
            {
                observer.update(hunidity, temperature, pressure);
            }
        }

        public void updateObserver() 
        {
            this.notifyObserver();
        }

        public void setMeasurements(int humidityValue, int temp, int pressureValue)
        {
            this.temperature = temp;
            this.hunidity = humidityValue;
            this.pressure = pressureValue;
            this.updateObserver();
        }
    }
}
