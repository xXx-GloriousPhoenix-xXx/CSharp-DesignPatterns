namespace DesignPatterns.Strategy.Delivery
{
    public interface IDeliveryStrategy
    {
        public decimal CalculatePrice(int orderWeightInKilograms, int distanceInKilometers);
    }
}
