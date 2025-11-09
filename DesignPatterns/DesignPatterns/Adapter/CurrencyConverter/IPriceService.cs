namespace DesignPatterns.Adapter.CurrencyConverter
{
    public interface IPriceService
    {
        public decimal GetPriceInUSD(string productId);
    }
}
