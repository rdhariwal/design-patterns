using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Interfaces
{
    public interface IPizza
    {
        string name { get; set; }
        IDough dough { get; set; }
        ISauce sauce { get; set; }
        IEnumerable<IVegetable> veggies { get; set; }
        ICheese cheese { get; set; }
        IPepperoni pepperoni { get; set; }
        IClams Clam { get; set; }

        void prepare();
        void bake();
        void cut();
        void box();
    }
}
