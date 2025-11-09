using DesignPatterns.Strategy.Delivery;

namespace DesignPatterns
{
    public static class MyClass
    {
        public static void Main()
        {
            var order = new DeliveryContext(new StandardDelivery());
            Console.WriteLine(order.CalculatePrice(2, 10)); // Standard

            order.SetStrategy(new ExpressDelivery());
            Console.WriteLine(order.CalculatePrice(2, 10)); // Express

            order.SetStrategy(new InternationalDelivery());
            Console.WriteLine(order.CalculatePrice(2, 10)); // International
        }
    }
}