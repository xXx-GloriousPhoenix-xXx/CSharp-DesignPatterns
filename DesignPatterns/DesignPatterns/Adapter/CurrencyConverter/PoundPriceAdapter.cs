namespace DesignPatterns.Adapter.CurrencyConverter
{
    public class PoundPriceAdapter(PoundPriceService poundPriceService) : IPriceService
    {
        private const decimal PoundToUSD = 1.7m;
        private readonly PoundPriceService poundPriceService = poundPriceService;

        public decimal GetPriceInUSD(string productId)
        {
            return poundPriceService.GetPriceInPound(productId) / PoundToUSD;
        }
    }
}
