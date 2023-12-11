namespace StockMarket.Data
{
    public class PerformanceService
    {
        static double GetRandomPerformanceChange()
        {
            Random random = new Random();
            return Math.Round((random.NextDouble() * 30) - 10, 2);
        }
        public List<PerformanceData> GetPerformanceData()
        {
            List<PerformanceData> performanceDataList = new List<PerformanceData>
            {
                new PerformanceData
                {
                    PerformanceChange = GetRandomPerformanceChange(),
                    Period = "1w"
                },
                new PerformanceData
                {
                    PerformanceChange = GetRandomPerformanceChange(),
                    Period = "1m"
                },
                new PerformanceData
                {
                    PerformanceChange = GetRandomPerformanceChange(),
                    Period = "3m"
                },
                new PerformanceData
                {
                    PerformanceChange = GetRandomPerformanceChange(),
                    Period = "6m"
                },
                new PerformanceData
                {
                    PerformanceChange = GetRandomPerformanceChange(),
                    Period = "1y"
                },
                new PerformanceData
                {
                    PerformanceChange = GetRandomPerformanceChange(),
                    Period = "5y"
                }
            };

            return performanceDataList;
        }
    }
}
