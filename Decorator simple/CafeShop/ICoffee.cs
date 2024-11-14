using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeShop
{
    public interface ICoffee
    {
        public string Name();
        public double CalculatePrice();
    }
}