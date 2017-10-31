namespace NewspaperSellerModels
{
    public class SimulationCase
    {
        public int DayNo { get; set; }
        public int RandomNewsDayType { get; set; }
        public Enums.DayType NewsDayType { get; set; }
        public int RandomDemand { get; set; }
        public int Demand { get; set; }
        public double DailyCost { get; set; }
        public double SalesProfit { get; set; }
        public double LostProfit { get; set; }
        public double ScrapProfit { get; set; }
        public double DailyNetProfit { get; set; }
    }
}
