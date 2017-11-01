using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerModels;
using NewspaperSellerSimulation.Controller;
using NewspaperSellerTesting;


namespace NewspaperSellerSimulation
{
    public partial class Form1 : Form
    {
        private Handler _handler;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            int numOfNewspapers = Convert.ToInt32(purch_num_txt.Text);
            int numOfRecords = Convert.ToInt32(days_count_txt.Text);
            double purchasePrice = Convert.ToDouble(purch_price_txt.Text);
            double sellingPrice = Convert.ToDouble(selling_price_txt.Text);
            double scrapPrice = Convert.ToDouble(scrap_price_txt.Text);
            _handler = new Handler(input_GV, input2_GV, numOfNewspapers, numOfRecords, purchasePrice, sellingPrice, scrapPrice);
            _handler.Main_Handler();
            //ShowData();
            string TestResult = TestingManager.Test(_handler._system, Constants.FileNames.TestCase1);
            MessageBox.Show(TestResult);
        }

        private void ShowData()
        {
            foreach (var simCase in _handler._system.SimulationCases)
            {
                out_GV.Rows.Add(simCase.DayNo.ToString(),
                    simCase.RandomNewsDayType.ToString(),
                    simCase.NewsDayType.ToString(),
                    simCase.RandomDemand.ToString(),
                    simCase.Demand.ToString(),
                    simCase.SalesProfit.ToString(CultureInfo.CurrentCulture),
                    simCase.LostProfit.ToString(CultureInfo.CurrentCulture),
                    simCase.ScrapProfit.ToString(CultureInfo.InvariantCulture),
                    simCase.DailyNetProfit.ToString(CultureInfo.InvariantCulture));
            }
            revenue_txt.Text = _handler._system.PerformanceMeasures.TotalSalesProfit.ToString(CultureInfo.CurrentCulture);
            cost_txt.Text = _handler._system.PerformanceMeasures.TotalCost.ToString(CultureInfo.CurrentCulture);
            excess_lost_txt.Text =
                _handler._system.PerformanceMeasures.TotalLostProfit.ToString(CultureInfo.CurrentCulture);
            scrap_txt.Text = _handler._system.PerformanceMeasures.TotalScrapProfit.ToString(CultureInfo.CurrentCulture);
            net_profit_txt.Text = _handler._system.PerformanceMeasures.TotalNetProfit.ToString(CultureInfo.CurrentCulture);
            excess_days_txt.Text =
                _handler._system.PerformanceMeasures.DaysWithMoreDemand.ToString(CultureInfo.CurrentCulture);
            scrap_days_txt.Text = _handler._system.PerformanceMeasures.DaysWithUnsoldPapers.ToString();
        }
    }
}
