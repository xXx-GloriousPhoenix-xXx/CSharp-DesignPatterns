namespace DesignPatterns.Strategy.Delivery
{
    public class DeliveryContext(IDeliveryStrategy strategy)
    {
        private IDeliveryStrategy strategy = strategy;
        public void SetStrategy(IDeliveryStrategy newStrategy) =>
            strategy = newStrategy;
        public decimal CalculatePrice(int orderWeightInKilograms, int distanceInKilometers) =>
            strategy.CalculatePrice(orderWeightInKilograms, distanceInKilometers);
    }
}
