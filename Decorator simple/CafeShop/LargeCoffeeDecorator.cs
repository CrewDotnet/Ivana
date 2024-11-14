using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeShop
{
    public class LargeCoffeeDecorator : ICoffee
    {
        protected ICoffee _coffee;

        public LargeCoffeeDecorator (ICoffee coffee)
        {
            _coffee = coffee;
        }

        public string Name()
        {
            return _coffee.Name() + ", Large";
        }

        public double CalculatePrice()
        {
            return _coffee.CalculatePrice() * 1.20;
        } 
    }
}