using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.Data
{
    public class WatchListData
    {
        public string StockName { get; set; }
        public double Last { get; set; }
        public double Change { get; set; }
        public double ChangePercent { get; set; }
        public string StockType { get; set; }
    }
}
