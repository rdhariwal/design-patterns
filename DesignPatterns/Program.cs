using StrategyPattern;
using ObserverPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            ObserverDesignPattern();

            
            StrategyDesignPattern();
            
            Console.WriteLine("Press any key to exit.....");
            Console.ReadKey();
        }

        private static void ObserverDesignPattern()
        {
            Console.WriteLine("Observer Pattern Example:");
            Console.WriteLine("-------------------------------------------------------------------");
            var weatherStation = new WeatherStation();

            var currentConditionsDisplay = new CurrentConditionsDisplay();
            var staticsDisplay = new StaticsDisplay();

            weatherStation.registerObserver(currentConditionsDisplay);
            weatherStation.registerObserver(staticsDisplay);

            weatherStation.setMeasurements(12, 23, 45);

            Console.WriteLine("-------------------------------------------------------------------");
        }

        private static void StrategyDesignPattern()
        {
            var queen = new Queen();
            var king = new King();
            var knight = new Knight();
            var troll = new Troll();

            var knife = new KnifeBehaviour();
            var bowAndArrow = new BowandArrowBehaviour();
            var sword = new SwordBehaviour();
            var axe = new AxeBehaviour();

            Console.WriteLine("Strategy Pattern Example:");
            Console.WriteLine("-------------------------------------------------------------------");

            /////QUEEN            
            Console.WriteLine("Character selected: Queen");
            queen.fight();
            queen.setWeapon(knife);
            queen.fight();

            //KING
            Console.WriteLine("Character selected: King");
            king.fight();
            king.setWeapon(bowAndArrow);
            king.fight();

            //KNIGHT
            Console.WriteLine("Character selected: Knight");
            knight.fight();
            knight.setWeapon(bowAndArrow);
            knight.fight();

            //TROLL
            Console.WriteLine("Character selected: Troll");
            troll.fight();
            troll.setWeapon(knife);
            troll.fight();

            Console.WriteLine("-------------------------------------------------------------------");
        }
    }
}
