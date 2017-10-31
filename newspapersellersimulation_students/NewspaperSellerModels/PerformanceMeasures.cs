namespace NewspaperSellerModels
{
    public class PerformanceMeasures
    {
        public PerformanceMeasures()
        {
        }

        public double TotalSalesProfit { get; set; }
        public double TotalCost { get; set; }
        public double TotalLostProfit { get; set; }
        public double TotalScrapProfit { get; set; }
        public double TotalNetProfit { get; set; }
        public int DaysWithMoreDemand { get; set; }
        public int DaysWithUnsoldPapers { get; set; }
    }
}
