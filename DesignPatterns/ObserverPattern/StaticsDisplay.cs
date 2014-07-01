using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class StaticsDisplay:Observer, Display
    {

        public void update(int humidity, int temperature, int pressure)
        {
            this.display(humidity, temperature, pressure);
        }

        public void display(int humidity, int temperature, int pressure)
        {
            Console.WriteLine("StaticsDisplay: humidity = {0}, temperature = {1}, pressure = {2}", humidity, temperature, pressure);
        }

        public StaticsDisplay()
        {

        }
    }
}
