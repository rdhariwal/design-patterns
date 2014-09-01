using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FactoryPattern.Interfaces;

namespace FactoryPattern
{
    public abstract class Pizza : IPizza
    {

        public abstract void prepare();

        public void bake()
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Starting baking process....; baking at 350 @ 15 mins");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------");
        }

        public void cut()
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("cut pizza for easier consumption....");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------");
        }

        public void box()
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("boxing pizza using special pizza box");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------");
        }

        public string name { get; set;}

        public IDough dough { get; set; }

        public ISauce sauce { get; set; }

        public IEnumerable<IVegetable> veggies { get; set; }

        public ICheese cheese { get; set; }

        public IPepperoni pepperoni { get; set; }

        public IClams Clam { get; set; }
    }
}
