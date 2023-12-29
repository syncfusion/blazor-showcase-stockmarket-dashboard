using StockMarket.Data;
using Syncfusion.Blazor.Charts;
using Syncfusion.Blazor.Grids;
using Microsoft.AspNetCore.Components;

namespace StockMarket.Pages
{
    public partial class ChartComponent: ComponentBase
    {
        private string selectedStockType = "US Stocks";

        public DialogSettings DialogParams = new DialogSettings { MinHeight = "400px", Width = "450px" };

        public List<ChartData> ChartDatas { get; set; } = new List<ChartData>();

        public List<ChartData> StockComparisonData { get; set; } = new List<ChartData>();

        public List<CardData> CardDatas = new List<CardData>();

        public Dictionary<string, List<CardData>> CardData { get; set; } = new Dictionary<string, List<CardData>>();

        public List<WatchListData> watchListDatas = new List<WatchListData>();

        public List<TrendlineTypes> TrendlineType = new List<TrendlineTypes>();
        public List<TechnicalIndicators> Indicator = new List<TechnicalIndicators>();
        public List<ChartSeriesType> SeriesType = new List<ChartSeriesType>() { ChartSeriesType.Line, ChartSeriesType.Hilo, ChartSeriesType.HiloOpenClose, ChartSeriesType.Candle, ChartSeriesType.Spline };

        protected override void OnInitialized()
        {
            CardData = CardService.GetData();
            CardDatas = CardData.Values.SelectMany(x => x).ToList();
            if (!CardService.IsMobileMode) {
                CardService.StockCard = CardService.PreviousCompareCardData = CardDatas.FirstOrDefault();
            }
            watchListDatas = WatchListService.GetWatchListDatas();
            ChartDatas = ChartService.GenerateSimulatedStockData();
            //CardService.OnMessageUpdate += UpdateMessage;
        }

        private void HandleStockSelection(ChangeEventArgs eventArgs)
        {
            selectedStockType = eventArgs.Value.ToString();
            StateHasChanged();
        }
    }
}
