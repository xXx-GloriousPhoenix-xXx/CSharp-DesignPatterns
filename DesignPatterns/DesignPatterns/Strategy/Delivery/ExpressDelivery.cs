namespace DesignPatterns.Strategy.Delivery
{
    public class ExpressDelivery : IDeliveryStrategy
    {
        public decimal CalculatePrice(int orderWeightInKilograms, int distanceInKilometers)
        {
            return 10 + distanceInKilometers * 1m;
        }
    }
}
