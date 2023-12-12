using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.Data
{
    public class WatchListService
    {
        public List<WatchListData> GetWatchListDatas()
        {
            List<WatchListData> watchListDatas = new List<WatchListData>();

            watchListDatas.Add(new WatchListData
            {
                StockName = "Apple",
                Last = 150.0,
                Change = 2.0,
                ChangePercent = 1.33,
                StockType = "Stocks"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Microsoft",
                Last = 300.0,
                Change = 3.0,
                ChangePercent = 1.0,
                StockType = "Stocks"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Amazon",
                Last = 3500.0,
                Change = 20.0,
                ChangePercent = 0.57,
                StockType = "Stocks"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Google",
                Last = 2800.0,
                Change = 15.0,
                ChangePercent = 0.54,
                StockType = "Stocks"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Tesla",
                Last = 750.0,
                Change = 7.5,
                ChangePercent = 1.0,
                StockType = "Stocks"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Facebook",
                Last = 350.0,
                Change = 5.0,
                ChangePercent = 1.45,
                StockType = "Stocks"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Netflix",
                Last = 550.0,
                Change = 8.0,
                ChangePercent = 1.46,
                StockType = "Stocks"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Intel",
                Last = 55.0,
                Change = 0.5,
                ChangePercent = 0.91,
                StockType = "Stocks"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Nvidia",
                Last = 230.0,
                Change = 4.0,
                ChangePercent = 1.77,
                StockType = "Stocks"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Boeing",
                Last = 220.0,
                Change = 2.5,
                ChangePercent = 1.14,
                StockType = "Stocks"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Nasdaq",
                Last = 15500.0,
                Change = 8.0,
                ChangePercent = 0.05,
                StockType = "Indices"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "FTSE",
                Last = 7200.0,
                Change = 3.0,
                ChangePercent = 0.04,
                StockType = "Indices"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "DAX",
                Last = 15500.0,
                Change = 7.0,
                ChangePercent = 0.05,
                StockType = "Indices"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Nikkei",
                Last = 28000.0,
                Change = 6.0,
                ChangePercent = 0.02,
                StockType = "Indices"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Hang Seng",
                Last = 25000.0,
                Change = 5.0,
                ChangePercent = 0.02,
                StockType = "Indices"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "CAC 40",
                Last = 6500.0,
                Change = 2.0,
                ChangePercent = 0.03,
                StockType = "Indices"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Shanghai Composite",
                Last = 3600.0,
                Change = 1.0,
                ChangePercent = 0.03,
                StockType = "Indices"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "SENSEX",
                Last = 58000.0,
                Change = 12.0,
                ChangePercent = 0.02,
                StockType = "Indices"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Russell 2000",
                Last = 2300.0,
                Change = 6.0,
                ChangePercent = 0.26,
                StockType = "Indices"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "VIX (Volatility Index)",
                Last = 15.5,
                Change = -0.5,
                ChangePercent = -0.03,
                StockType = "Indices"
            });


            // Add data for Futures
            watchListDatas.Add(new WatchListData
            {
                StockName = "Crude Oil Futures",
                Last = 70.0,
                Change = 1.5,
                ChangePercent = 2.17,
                StockType = "Futures"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Gold Futures",
                Last = 1800.0,
                Change = 5.0,
                ChangePercent = 0.28,
                StockType = "Futures"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "S&P 500 E-Mini",
                Last = 4505.0,
                Change = 2.0,
                ChangePercent = 0.04,
                StockType = "Futures"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Nasdaq 100 E-Mini",
                Last = 15000.0,
                Change = 10.0,
                ChangePercent = 0.07,
                StockType = "Futures"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Dow Jones E-Mini",
                Last = 35050.0,
                Change = 5.0,
                ChangePercent = 0.02,
                StockType = "Futures"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Euro FX",
                Last = 1.175,
                Change = 0.002,
                ChangePercent = 0.17,
                StockType = "Futures"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Treasury Bonds",
                Last = 145.5,
                Change = -0.2,
                ChangePercent = -0.14,
                StockType = "Futures"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Natural Gas",
                Last = 4.8,
                Change = 0.2,
                ChangePercent = 0.04,
                StockType = "Futures"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Wheat",
                Last = 750.0,
                Change = 3.0,
                ChangePercent = 0.40,
                StockType = "Futures"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Corn",
                Last = 550.0,
                Change = 2.0,
                ChangePercent = 0.36,
                StockType = "Futures"
            });


            // Add data for Forex
            watchListDatas.Add(new WatchListData
            {
                StockName = "EUR/USD",
                Last = 1.1500,
                Change = 0.0050,
                ChangePercent = 0.43,
                StockType = "Forex"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "USD/JPY",
                Last = 110.50,
                Change = 0.20,
                ChangePercent = 0.18,
                StockType = "Forex"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "GBP/USD",
                Last = 1.3100,
                Change = -0.0020,
                ChangePercent = -0.15,
                StockType = "Forex"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "AUD/USD",
                Last = 0.7350,
                Change = 0.0030,
                ChangePercent = 0.41,
                StockType = "Forex"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "USD/CAD",
                Last = 1.2800,
                Change = -0.0010,
                ChangePercent = -0.08,
                StockType = "Forex"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "EUR/GBP",
                Last = 0.8800,
                Change = 0.0010,
                ChangePercent = 0.11,
                StockType = "Forex"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "USD/CHF",
                Last = 0.9200,
                Change = 0.0020,
                ChangePercent = 0.22,
                StockType = "Forex"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "NZD/USD",
                Last = 0.6900,
                Change = -0.0040,
                ChangePercent = -0.58,
                StockType = "Forex"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "EUR/JPY",
                Last = 130.50,
                Change = -0.50,
                ChangePercent = -0.38,
                StockType = "Forex"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "GBP/JPY",
                Last = 145.00,
                Change = 1.00,
                ChangePercent = 0.69,
                StockType = "Forex"
            });


            // Add data for Crypto
            watchListDatas.Add(new WatchListData
            {
                StockName = "Bitcoin",
                Last = 45000.0,
                Change = 500.0,
                ChangePercent = 1.12,
                StockType = "Crypto"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Ethereum",
                Last = 3200.0,
                Change = 40.0,
                ChangePercent = 1.25,
                StockType = "Crypto"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Ripple (XRP)",
                Last = 1.25,
                Change = 0.05,
                ChangePercent = 4.17,
                StockType = "Crypto"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Cardano (ADA)",
                Last = 2.35,
                Change = 0.10,
                ChangePercent = 4.44,
                StockType = "Crypto"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Litecoin (LTC)",
                Last = 150.0,
                Change = 5.0,
                ChangePercent = 3.45,
                StockType = "Crypto"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Polkadot (DOT)",
                Last = 35.0,
                Change = 2.0,
                ChangePercent = 6.06,
                StockType = "Crypto"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Binance Coin (BNB)",
                Last = 420.0,
                Change = 12.0,
                ChangePercent = 2.94,
                StockType = "Crypto"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Chainlink (LINK)",
                Last = 30.0,
                Change = 0.50,
                ChangePercent = 1.69,
                StockType = "Crypto"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Stellar (XLM)",
                Last = 0.35,
                Change = 0.02,
                ChangePercent = 6.06,
                StockType = "Crypto"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Dogecoin (DOGE)",
                Last = 0.25,
                Change = 0.01,
                ChangePercent = 4.17,
                StockType = "Crypto"
            });

            watchListDatas.Add(new WatchListData
            {
                StockName = "Solana (SOL)",
                Last = 160.0,
                Change = 8.0,
                ChangePercent = 5.26,
                StockType = "Crypto"
            });


            // Add more data points for each category as needed

            return watchListDatas;

            return watchListDatas;

        }
    }
}
