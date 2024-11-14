using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeShop
{
    public class SugarCoffeeDecorator : ICoffee
    {
        protected ICoffee _coffee;

        public SugarCoffeeDecorator (ICoffee coffee)
        {
            _coffee = coffee;
        }        
        public string Name()
        {
            return _coffee.Name() + ", Sugar";
        }

        public double CalculatePrice()
        {
            return _coffee.CalculatePrice() * 1.20;
        }
    }
}