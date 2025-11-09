namespace DesignPatterns.Observer.NotificationManager
{
    public class EmailNotifier : IOrderObserver
    {
        public void Update(Order order)
        {
            if (order.Status == OrderStatus.Shipped || order.Status == OrderStatus.Delivered)
            {
                Console.WriteLine($"Sending email about order with {order.Id}'s status is {order.Status} now");
            }
        }
    }
}
