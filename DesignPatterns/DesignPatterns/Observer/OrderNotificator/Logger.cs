namespace DesignPatterns.Observer.NotificationManager
{
    public class Logger : IOrderObserver
    {
        public void Update(Order order)
        {
            Console.WriteLine($"{DateTime.Now:HH:mm:ss} - Order with {order.Id}'s status is {order.Status} now");
        }
    }
}
