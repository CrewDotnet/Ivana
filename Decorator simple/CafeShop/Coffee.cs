using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeShop
{
    public class Coffee : ICoffee
    {

        public string Name()
        {
            return "Coffee";
        }

        public double CalculatePrice()
        {
            return 2.00;
        }
    }
}