namespace StockMarket.Data
{
    public class KeyStatisticsService
    {
       public List<KeyStatisticsData> GetKeyStatisticsData()
       {
            Random random = new Random();
            List<KeyStatisticsData> keyStatisticsDataList = new List<KeyStatisticsData>
            {
                new KeyStatisticsData { Text = "Market Capitalisation", Value = (random.NextDouble() * 5000 + 500).ToString("F2") + "T" },
                new KeyStatisticsData { Text = "Dividends yield(FY)", Value = (random.NextDouble() * 10).ToString("F2") + "%"},
                new KeyStatisticsData { Text = "Price to earnings Ratio (TTM)", Value = (random.NextDouble() * 50).ToString("F2") },
                new KeyStatisticsData { Text = "Basic EPS (TTM)", Value = (random.NextDouble() * 10).ToString("F2") },
                new KeyStatisticsData { Text = "Net Income", Value = (random.NextDouble() * 100 + 50).ToString("F2") + "B" },
                new KeyStatisticsData { Text = "Revenue", Value = (random.NextDouble() * 500 + 200).ToString("F2") + "B" },
                new KeyStatisticsData { Text = "Shares float", Value = (random.NextDouble() * 20 + 10).ToString("F2") + "B" },
                new KeyStatisticsData { Text = "Beta", Value = (random.NextDouble() * 2).ToString("F2") }
            };

            return keyStatisticsDataList;
        } 
    }
}
