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

        public CardData PreviousCompareCardData { get; set; } = new CardData();

        public CardData PreviousWatchlistCardData { get; set; } = new CardData();

        public CardData StockCard { get; set; } = new CardData();

        public bool IsMobileMode { get; set; } = false;

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

        private double GenerateCurrentStockPrice(double minimum, double maximum)
        {
            Random random = new Random();
            double currentStockPrice = random.NextDouble() * (maximum - minimum) + minimum;
            double roundOffStockPrice = Math.Round(currentStockPrice, 2);
            return roundOffStockPrice;
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
                    StockCurrentPrice = GenerateCurrentStockPrice(125.02, 197.96),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(222.31, 382.70),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(86.77, 142.82),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(124.74, 357.83),
                    UpDownPrice = 3.25,
                    UpDownPriceColor = "Green",
                    LastUpdate = $"Last update at {GenerateRandomTime()}",
                    StockType = "Stocks",
                    SeriesChange = GenerateRandomSeriesChange()
                },
                new CardData
                {
                    StockSymbol = "css/images/TSL.png",
                    StockName = "Tesla",
                    StockSubName = "Tesla, Inc.",
                    StockCurrentPrice = GenerateCurrentStockPrice(108.10, 293.34),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(71.46, 120.57),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(124.0, 169.2),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(292.76, 495.02),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(24.90, 50.76),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(3855.77, 4781.59),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(31819.14, 37656.53),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(10305.24, 15099.18),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(7256.94, 8012.53),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(182.67, 238.23),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(2073.79, 2904.18),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(0.14, 0.18),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(7339.11, 8454.61),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(1636.94, 2066.21),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(67.12, 93.68),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(1817.1, 2093.1),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(20.150, 26.225),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(3.5520, 4.2675),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(1.955, 4.804),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(578.71, 778.1),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(175, 261),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(1260, 1541),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(2572, 4280),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(64.19, 103.15),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(1.0480, 1.1237),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(127.89, 151.65),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(1.18, 1.31),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(0.62, 0.71),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(1.31, 1.38),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(0.57, 0.65),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(0.83, 0.94),
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
                    StockCurrentPrice =GenerateCurrentStockPrice(0.85, 0.90),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(1.30, 1.37),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(138.44, 164.14),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(16615, 44193),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(1200, 2399.9),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(0.2499, 0.6675),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(35.333, 82.810),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(58.75, 113.63),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(6.16, 17.22),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(25.02, 97.96),
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
                    StockCurrentPrice = GenerateCurrentStockPrice(15.02, 77.96),
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
