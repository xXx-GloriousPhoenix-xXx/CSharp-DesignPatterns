namespace DesignPatterns.Strategy.Delivery
{
    public class InternationalDelivery : IDeliveryStrategy
    {
        public decimal CalculatePrice(int orderWeightInKilograms, int distanceInKilometers)
        {
            return 25 + distanceInKilometers * 2m;
        }
    }
}
