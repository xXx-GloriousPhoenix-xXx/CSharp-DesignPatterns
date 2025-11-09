namespace DesignPatterns.Strategy.Delivery
{
    public class DroneDelivery : IDeliveryStrategy
    {
        public decimal CalculatePrice(int orderWeightInKilograms, int distanceInKilometers)
        {
            return 20 + orderWeightInKilograms * 3m;
        }
    }
}
