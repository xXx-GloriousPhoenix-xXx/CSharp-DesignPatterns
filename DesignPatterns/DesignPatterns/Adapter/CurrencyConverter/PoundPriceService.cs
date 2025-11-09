namespace DesignPatterns.Adapter.CurrencyConverter
{
    public class PoundPriceService
    {
        public decimal GetPriceInPound(string productId)
        {
            Thread.Sleep(500);
            return productId.Length * 1.7m;
        }
    }
}
