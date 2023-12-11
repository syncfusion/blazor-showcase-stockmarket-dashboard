namespace StockMarket.Data
{
    public class ChartService
    {
        private Random random;
        private DateTime currentDate;
        private double currentPrice;

        public ChartService()
        {
            random = new Random();
            currentDate = new DateTime(2024, 01, 01, 9, 0, 0);
            currentPrice = 150.0; 
        }

        public List<ChartData> GenerateSimulatedStockData(int numCandlesPerDay = 50, int minutesPerCandle = 5)
        {
            List<ChartData> candleData = new List<ChartData>();
            DateTime startdate = new DateTime(2023, 01, 01, 9, 0, 0);
            for (int day = 0; day < 365; day++)
            {
                double intradayHigh = currentPrice + (random.NextDouble() - 0.5) * 10.0; 
                double intradayLow = currentPrice - (random.NextDouble() - 0.5) * 10.0;  
                double intradayClose = intradayLow + (random.NextDouble() - 0.5) * 2.0;  

                ChartData candle = new ChartData
                {
                    X = startdate.AddDays(day),
                    Open = currentPrice,
                    High = intradayHigh,
                    Low = intradayLow,
                    Close = intradayClose,
                    Volume = random.Next(10000, 50000)
                };

                candleData.Add(candle);
                
                currentPrice = intradayClose;

                
            }

            return candleData;
        }
    }

}
