using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeShop
{
    public class CreamCoffeeDecorator : ICoffee
    {
        protected ICoffee _coffee;

        public CreamCoffeeDecorator (ICoffee coffee)
        {
            _coffee = coffee;
        }

        public string Name()
        {
            return _coffee.Name() + ", Cream";
        }

        public double CalculatePrice()
        {
            return _coffee.CalculatePrice() * 1.20;
        } 
    }
}