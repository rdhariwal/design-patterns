using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FactoryPattern.Interfaces;

namespace FactoryPattern
{
    class NYPizzaStore : IPizzaStore
    {
        IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

        public IPizza createPizza(string pizzaType)
        {
            IPizza pizza = null;
            if(pizzaType.Equals("cheese", StringComparison.CurrentCultureIgnoreCase)) {
                pizza = new CheesePizza(ingredientFactory);
                pizza.name = "NY Cheese Pizza";                
            }
            return pizza;
        }
            
        public void orderPizza()
        {
            createPizza("cheese");
            throw new NotImplementedException();
        }
    }
}
