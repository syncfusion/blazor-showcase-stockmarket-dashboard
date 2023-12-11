using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.Data
{
    public class CardData
    {
        public string StockType { get; set; }
        public string StockName { get; set; }
        public string StockSubName { get; set; }
        public string StockSymbol { get; set; }
        public double StockCurrentPrice { get; set; }
        public double UpDownPrice { get; set; }
        public string UpDownPriceColor { get; set; }
        public string LastUpdate { get; set; }
        public double SeriesChange { get; set; }

    }
}
