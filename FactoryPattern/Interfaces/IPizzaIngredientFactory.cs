using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Interfaces
{
    public interface IPizzaIngredientFactory
    {
        IDough createDough();
        ISauce createSauce();
        ICheese createCheese();
        IEnumerable<IVegetable> createVeggies();
        IPepperoni createPepperoni();
        IClams createClams();
    }
}
