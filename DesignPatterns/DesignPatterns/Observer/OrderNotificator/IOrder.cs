namespace DesignPatterns.Observer.NotificationManager
{
    public interface IOrder
    {
        public void Attach(IOrderObserver observer);
        public void Detach(IOrderObserver observer);
        public void Notify();
    }
}
