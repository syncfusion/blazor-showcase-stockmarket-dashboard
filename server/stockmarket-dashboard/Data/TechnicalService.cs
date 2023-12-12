namespace StockMarket.Data
{
    public class TechnicalService
    {
        public double GetStockProgress()
        {
            Random random = new Random();
            return random.NextDouble() * 100;
        }
    }
}
