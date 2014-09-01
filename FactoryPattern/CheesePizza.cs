using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FactoryPattern.Interfaces;

namespace FactoryPattern
{
    class CheesePizza : Pizza
    {

        IPizzaIngredientFactory ingredientFactory;

        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void prepare()
        {
            ingredientFactory.createDough();
        }
    }
}
