using CafeShop;

Console.WriteLine("Welcome!");

string name = "Cappucino with sugar and cream";
string size = "Large";

OrderResolver orderResolver = new OrderResolver();
ICoffee order = orderResolver.Resolve(name, size);

var price = order.CalculatePrice();
var orderName = order.Name();

Console.WriteLine($"Your order is:{orderName}, price: {price}");