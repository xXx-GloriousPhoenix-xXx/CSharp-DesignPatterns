namespace DesignPatterns.Observer.NotificationManager
{
    public class Order : IOrder
    {
        public Guid Id { get; } = Guid.NewGuid();
        public OrderStatus Status { get; private set; } = OrderStatus.Created;
        private readonly List<IOrderObserver> observers = [];

        public void Attach(IOrderObserver observer)
        {
            observers.Add(observer);
        }
        public void Detach(IOrderObserver observer)
        {
            observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(this);
            }
        }

        public void NextState()
        {
            if (Status != OrderStatus.Delivered)
            {
                Status++;
                Notify();
            }
        }
        public void ResetState()
        {
            Status = OrderStatus.Created;
        }
        public void SetState(OrderStatus status)
        {
            Status = status;
        }
    }
}
