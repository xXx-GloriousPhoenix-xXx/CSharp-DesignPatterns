namespace DesignPatterns.Observer.NotificationManager
{
    public class AdminDashboard : IOrderObserver
    {
        public void Update(Order order)
        {
            Console.WriteLine($"Popping up notification about order with {order.Id}'s status is {order.Status} now");
        }
    }
}
