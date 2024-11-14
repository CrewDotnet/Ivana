using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace CafeShop.Tests
{
    public class OrderResolverTest
    {
        private OrderResolver orderResolver = new OrderResolver();

        [Fact]
        public void OrderResolver_CoffeeSmall_ReturnsJustCoffee()
        {
            string name = "Espresso";
            string size = "Small";

            ICoffee coffee = orderResolver.Resolve(name, size);

            Assert.Equal("Coffee", coffee.Name());
            Assert.Equal(2.00, coffee.CalculatePrice());
        }

        [Fact]
        public void OrderResolver_CoffeeLarge_ReturnsLargeCoffee()
        {
            string name = "Espresso";
            string size = "Large";

            ICoffee coffee = orderResolver.Resolve(name, size);

            Assert.Equal("Coffee, Large", coffee.Name());
            Assert.Equal(2.40, coffee.CalculatePrice());
        }

        [Fact]
        public void OrderResolver_CoffeeSmallSugarCream_ReturnsCoffeeSmallSugarCream()
        {
            string name = "Espresso with sugar and with cream";
            string size = "Small";

            ICoffee coffee = orderResolver.Resolve(name, size);

            Assert.Equal("Coffee, Sugar, Cream", coffee.Name());
            Assert.Equal(2.88, coffee.CalculatePrice());
        }

        [Fact]
        public void OrderResolver_CoffeeLargeSugarCream_ReturnsCoffeeLargeSugarCream()
        {
            string name = "Espresso with sugar and with cream";
            string size = "Large";

            ICoffee coffee = orderResolver.Resolve(name, size);

            Assert.Equal("Coffee, Large, Sugar, Cream", coffee.Name());
            Assert.Equal(3.456, coffee.CalculatePrice());
        }

        [Fact]
        public void OrderResolver_CoffeeSmallCream_ReturnsCoffeeSmallCream()
        {
            string name = "Espresso with cream";
            string size = "Small";

            ICoffee coffee = orderResolver.Resolve(name, size);

            Assert.Equal("Coffee, Cream", coffee.Name());
            Assert.Equal(2.40, coffee.CalculatePrice());
        }

        [Fact]
        public void OrderResolver_CoffeeLargeCream_ReturnsCoffeeLargeCream()
        {
            string name = "Espresso with cream";
            string size = "Large";

            ICoffee coffee = orderResolver.Resolve(name, size);

            Assert.Equal("Coffee, Large, Cream", coffee.Name());
            Assert.Equal(2.88, coffee.CalculatePrice());
        }

    }
}