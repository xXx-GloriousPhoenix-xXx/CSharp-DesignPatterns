namespace DesignPatterns.Strategy.Delivery
{
    public class StandardDelivery : IDeliveryStrategy
    {
        public decimal CalculatePrice(int orderWeightInKilograms, int distanceInKilometers)
        {
            return 5 + distanceInKilometers * 0.5m;
        }
    }
}
