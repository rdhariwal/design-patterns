using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FactoryPattern.Interfaces;
using FactoryPattern.Ingredients;

namespace FactoryPattern
{
    public class NYPizzaIngredientFactory: IPizzaIngredientFactory
    {
        public IDough createDough()
        {
            return new ThinCrustDough();
        }

        public ISauce createSauce()
        {
            return new MarinaraSauce();
        }

        public ICheese createCheese()
        {
            return new ReggianoCheese();
        }

        public IEnumerable<IVegetable> createVeggies()
        {
            List<IVegetable> veggies = new List<IVegetable>();
            IVegetable garlic = new GarlicVegetable();
            veggies.Add(garlic);

            return veggies;
        }

        public IPepperoni createPepperoni()
        {
            return new PepperoniIngredient();
        }

        public IClams createClams()
        {
            return new Clams();
        }
    }
}
