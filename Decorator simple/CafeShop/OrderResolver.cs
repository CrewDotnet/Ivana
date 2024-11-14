using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeShop
{
    public class OrderResolver
    {
        public ICoffee Resolve(string name, string size)
        {
            ICoffee coffee = new Coffee();

            if (size == "Large")
            {
                coffee = new LargeCoffeeDecorator(coffee);
            }

            if (name.Contains("sugar"))
            {
                coffee = new SugarCoffeeDecorator(coffee);
            }

            if (name.Contains("cream"))
            {
                coffee = new CreamCoffeeDecorator(coffee);
            }

            return coffee;
        }
    }
}