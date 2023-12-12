using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.Data
{
    public class CardService
    {
        public CardData StockCardDetails { get; set; } = new CardData();

        public CardData StockCard { get; set; } = new CardData();

        private string GenerateRandomTime()
        {
            Random rand = new Random();
            int hours = rand.Next(1, 13); 
            int minutes = rand.Next(0, 60); 
            string amPm = rand.Next(2) == 0 ? "AM" : "PM"; 

            return $"{hours:D2}.{minutes:D2} {amPm}";
        }

        private double GenerateRandomSeriesChange()
        {
            Random random = new Random();
            return Math.Round(random.NextDouble() * 10, 2);
        }
        public Dictionary<string, List<CardData>> GetData()
        {
            Dictionary<string, List<CardData>> CardDataDictionary = new Dictionary<string, List<CardData>>();


            List<CardData> appleCardData = new List<CardData>
            {
                new CardData
                {
                    StockSymbol = "css/images/AAPL.png",
                    StockName = "Apple",
                    StockSubName = "Apple Inc",
                    StockCurrentPrice = 150.25,
                    UpDownPrice = 2.35,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Stocks",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/MSFT.jpg",
                    StockName = "Microsoft",
                    StockSubName = "Microsoft Corporation",
                    StockCurrentPrice = 300.50,
                    UpDownPrice = -1.25,
                    UpDownPriceColor = "Red",
                    LastUpdate =$"Last update at {GenerateRandomTime()}",
                    StockType = "Stocks",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/ALPHABET.png",
                    StockName = "Alphabet",
                    StockSubName = "Alphabet Inc",
                    StockCurrentPrice = 2700.00,
                    UpDownPrice = 5.25,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Stocks",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/FB.jpg",
                    StockName = "Facebook",
                    StockSubName = "Facebook, Inc.",
                    StockCurrentPrice = 340.75,
                    UpDownPrice = 3.25,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Stocks",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/TSL.png",
                    StockName = "Tesla, Inc.",
                    StockSubName = "Tesla, Inc.",
                    StockCurrentPrice = 700.50,
                    UpDownPrice = 2.75,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Stocks",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/ALBA.png",
                    StockName = "Alibaba",
                    StockSubName = "Alibaba Group Holding Limited",
                    StockCurrentPrice = 150.75,
                    UpDownPrice = 1.25,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Stocks",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/JPM.png",
                    StockName = "JPMorgan",
                    StockSubName = "JPMorgan Chase & Co.",
                    StockCurrentPrice = 170.25,
                    UpDownPrice = -0.75,
                    UpDownPriceColor = "Red",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Stocks",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/NFLX.png",
                    StockName = "Netflix",
                    StockSubName = "Netflix, Inc.",
                    StockCurrentPrice = 400.25,
                    UpDownPrice = 3.25,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Stocks",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/INTEL.png",
                    StockName = "Intel",
                    StockSubName = "Intel Corporation",
                    StockCurrentPrice = 50.75,
                    UpDownPrice = 0.25,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Stocks",
                    SeriesChange = GenerateRandomSeriesChange()
                },
            };
            CardDataDictionary.Add("Stocks", appleCardData);

            List<CardData> indicesCardData = new List<CardData>
            {
                new CardData
                {
                    StockSymbol = "css/images/S&P500.png",
                    StockName = "S&P 500",
                    StockSubName = "Standard & Poor's 500",
                    StockCurrentPrice = 4500.00,
                    UpDownPrice = 5.25,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Indices",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/DJIA.png",
                    StockName = "Dow Jones",
                    StockSubName = "Dow Jones Industrial Average",
                    StockCurrentPrice = 35000.00,
                    UpDownPrice = 2.75,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Indices",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/NASDAQ.png",
                    StockName = "NASDAQ",
                    StockSubName = "NASDAQ Composite",
                    StockCurrentPrice = 15000.00,
                    UpDownPrice = 4.50,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Indices",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/FTSE.png",
                    StockName = "FTSE",
                    StockSubName = "FTSE 100",
                    StockCurrentPrice = 7200.00,
                    UpDownPrice = 1.25,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Indices",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/NIKKEI.jpg",
                    StockName = "Nikkei",
                    StockSubName = "Nikkei 225",
                    StockCurrentPrice = 30000.00,
                    UpDownPrice = 3.00,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Indices",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/HANGSENG.png",
                    StockName = "Hang Seng",
                    StockSubName = "Hang Seng Index",
                    StockCurrentPrice = 25000.00,
                    UpDownPrice = -1.50,
                    UpDownPriceColor = "Red",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Indices",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/DAX.png",
                    StockName = "DAX",
                    StockSubName = "DAX 30",
                    StockCurrentPrice = 16000.00,
                    UpDownPrice = 1.75,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Indices",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/CAC.jpg",
                    StockName = "CAC",
                    StockSubName = "CAC 40",
                    StockCurrentPrice = 6500.00,
                    UpDownPrice = -0.50,
                    UpDownPriceColor = "Red",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Indices",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/RUSSELL.png",
                    StockName = "Russell",
                    StockSubName = "Russell 2000",
                    StockCurrentPrice = 2300.00,
                    UpDownPrice = 2.00,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Indices",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                // Add more data for other indices with StockSubName here
            };
            CardDataDictionary.Add("Indices", indicesCardData);

            // Data for Futures
            List<CardData> futuresCardData = new List<CardData>
            {
                new CardData
                {
                    StockSymbol = "css/images/CrudeOilFutures.png",
                    StockName = "Crude Oil Futures",
                    StockSubName = "Crude Oil",
                    StockCurrentPrice = 80.25,
                    UpDownPrice = -1.25,
                    UpDownPriceColor = "Red",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Futures",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/GoldFutures.png",
                    StockName = "Gold Futures",
                    StockSubName = "Gold",
                    StockCurrentPrice = 1800.00,
                    UpDownPrice = 5.25,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Futures",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/SilverFutures.png",
                    StockName = "Silver Futures",
                    StockSubName = "Silver",
                    StockCurrentPrice = 25.50,
                    UpDownPrice = 0.75,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Futures",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/CopperFutures.png",
                    StockName = "Copper Futures",
                    StockSubName = "Copper",
                    StockCurrentPrice = 4.00,
                    UpDownPrice = 0.25,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Futures",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/NaturalGasFutures.png",
                    StockName = "Natural Gas Futures",
                    StockSubName = "Natural Gas",
                    StockCurrentPrice = 3.00,
                    UpDownPrice = -0.15,
                    UpDownPriceColor = "Red",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Futures",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/WheatFutures.png",
                    StockName = "Wheat Futures",
                    StockSubName = "Wheat",
                    StockCurrentPrice = 7.50,
                    UpDownPrice = 0.35,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Futures",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/CornFutures.png",
                    StockName = "Corn Futures",
                    StockSubName = "Corn",
                    StockCurrentPrice = 5.00,
                    UpDownPrice = -0.25,
                    UpDownPriceColor = "Red",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Futures",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/SoybeanFutures.png",
                    StockName = "Soybean Futures",
                    StockSubName = "Soybean",
                    StockCurrentPrice = 14.00,
                    UpDownPrice = 1.25,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Futures",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/Futures.png",
                    StockName = "Cocoa Futures",
                    StockSubName = "Cocoa",
                    StockCurrentPrice = 2.00,
                    UpDownPrice = 0.10,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Futures",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/LeanHogsFutures.png",
                    StockName = "Lean Hogs Futures",
                    StockSubName = "Lean Hogs",
                    StockCurrentPrice = 70.00,
                    UpDownPrice = -0.50,
                    UpDownPriceColor = "Red",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Futures",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                // Add more data for other futures with StockSubName here
            };
            CardDataDictionary.Add("Futures", futuresCardData);

            // Data for Forex
            List<CardData> forexCardData = new List<CardData>
            {
                new CardData
                {
                    StockSymbol = "css/images/EUR_USD.png",
                    StockName = "EUR/USD",
                    StockSubName = "Euro/US Dollar",
                    StockCurrentPrice = 1.1500,
                    UpDownPrice = 0.0050,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Forex",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/USD_JPY.png",
                    StockName = "USD/JPY",
                    StockSubName = "US Dollar/Japanese Yen",
                    StockCurrentPrice = 110.50,
                    UpDownPrice = 0.75,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Forex",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/GBP_USD.png",
                    StockName = "GBP/USD",
                    StockSubName = "British Pound/US Dollar",
                    StockCurrentPrice = 1.3000,
                    UpDownPrice = -0.0025,
                    UpDownPriceColor = "Red",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Forex",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/AUD_USD.png",
                    StockName = "AUD/USD",
                    StockSubName = "Australian Dollar/US Dollar",
                    StockCurrentPrice = 0.7500,
                    UpDownPrice = 0.0030,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Forex",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/USD_CAD.png",
                    StockName = "USD/CAD",
                    StockSubName = "US Dollar/Canadian Dollar",
                    StockCurrentPrice = 1.2500,
                    UpDownPrice = -0.0015,
                    UpDownPriceColor = "Red",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Forex",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/NZD_USD.png",
                    StockName = "NZD/USD",
                    StockSubName = "New Zealand Dollar/US Dollar",
                    StockCurrentPrice = 0.7000,
                    UpDownPrice = 0.0025,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Forex",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/USD_CHF.png",
                    StockName = "USD/CHF",
                    StockSubName = "US Dollar/Swiss Franc",
                    StockCurrentPrice = 0.9200,
                    UpDownPrice = -0.0040,
                    UpDownPriceColor = "Red",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Forex",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/EUR_GBP.png",
                    StockName = "EUR/GBP",
                    StockSubName = "Euro/British Pound",
                    StockCurrentPrice = 0.8800,
                    UpDownPrice = 0.0020,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Forex",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/USD_SGD.png",
                    StockName = "USD/SGD",
                    StockSubName = "US Dollar/Singapore Dollar",
                    StockCurrentPrice = 1.3500,
                    UpDownPrice = 0.0055,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Forex",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/EUR_JPY.png",
                    StockName = "EUR/JPY",
                    StockSubName = "Euro/Japanese Yen",
                    StockCurrentPrice = 130.00,
                    UpDownPrice = 1.50,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Forex",
                    SeriesChange = GenerateRandomSeriesChange()
                },
            };
            CardDataDictionary.Add("Forex", forexCardData);

            // Data for Crypto
            List<CardData> cryptoCardData = new List<CardData>
            {
                new CardData
                {
                    StockSymbol = "css/images/Bitcoin.png",
                    StockName = "Bitcoin",
                    StockSubName = "Bitcoin Cryptocurrency",
                    StockCurrentPrice = 45000.00,
                    UpDownPrice = 500.00,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Crypto",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/Ethereum.png",
                    StockName = "Ethereum",
                    StockSubName = "Ethereum Cryptocurrency",
                    StockCurrentPrice = 3500.00,
                    UpDownPrice = 40.00,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Crypto",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/Cardano.png",
                    StockName = "Cardano",
                    StockSubName = "Cardano Cryptocurrency",
                    StockCurrentPrice = 2.50,
                    UpDownPrice = 0.10,
                    UpDownPriceColor = "Green",
                    StockType = "Crypto",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/Ripple.png",
                    StockName = "Ripple",
                    StockSubName = "Ripple Cryptocurrency",
                    StockCurrentPrice = 1.50,
                    UpDownPrice = 0.05,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Crypto",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/Litecoin.png",
                    StockName = "Litecoin",
                    StockSubName = "Litecoin Cryptocurrency",
                    StockCurrentPrice = 150.00,
                    UpDownPrice = 2.00,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Crypto",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/Chainlink.png",
                    StockName = "Chainlink",
                    StockSubName = "Chainlink Cryptocurrency",
                    StockCurrentPrice = 25.00,
                    UpDownPrice = 1.00,
                    UpDownPriceColor = "Green",
                    StockType = "Crypto",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/Polkadot.png",
                    StockName = "Polkadot",
                    StockSubName = "Polkadot Cryptocurrency",
                    StockCurrentPrice = 30.00,
                    UpDownPrice = 1.50,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Crypto",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/Binance.png",
                    StockName = "Binance Coin",
                    StockSubName = "Binance Coin Cryptocurrency",
                    StockCurrentPrice = 400.00,
                    UpDownPrice = 10.00,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Crypto",
                    SeriesChange = GenerateRandomSeriesChange()
                },

            };
            CardDataDictionary.Add("Crypto", cryptoCardData);


            return CardDataDictionary;
        }
    }
}
