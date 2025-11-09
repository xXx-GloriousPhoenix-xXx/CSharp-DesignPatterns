namespace DesignPatterns.Adapter.CurrencyConverter
{
    public class EuroPriceAdapter(EuroPriceService euroPriceService) : IPriceService
    {
        private const decimal EuroToUSD = 1.2m;
        private readonly EuroPriceService euroPriceService = euroPriceService;
        public decimal GetPriceInUSD(string productId)
        {
            return euroPriceService.GetPriceInEuro(productId) / EuroToUSD;
        }
    }
}
