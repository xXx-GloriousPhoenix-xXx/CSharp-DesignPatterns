namespace DesignPatterns.Adapter.CurrencyConverter
{
    public class EuroPriceService
    {
        public decimal GetPriceInEuro(string productId)
        {
            Thread.Sleep(500);
            return productId.Length * 1.2m;
        }
    }
}
