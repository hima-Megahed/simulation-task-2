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
        private Data _data;
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            _data = new Data();
        }


        private void RunSystem()
        {
            ReadDate(@"F:\College Year 4\Year 4 [CS]\simulation\Labs\Lab 5\simulation-task-2\newspapersellersimulation_students\newspapersellersimulation\TestCases\TestCase1.txt");
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

        private void ReadDate(string fileName)
        {
            _data._fileName = fileName;
            _data.Process();
            purch_num_txt.Text = _data.NumOfNewspapers.ToString();
            days_count_txt.Text = _data.NumOfRecords.ToString();
            purch_price_txt.Text = _data.PurchasePrice.ToString(CultureInfo.CurrentCulture);
            selling_price_txt.Text = _data.SellingPrice.ToString(CultureInfo.CurrentCulture);
            scrap_price_txt.Text = _data.ScrapPrice.ToString(CultureInfo.CurrentCulture);

            ///////
            input_GV.Rows.Add(Enums.DayType.Good.ToString(),_data.DayTypeDistributioGood.ToString(CultureInfo.CurrentCulture));
            input_GV.Rows.Add(Enums.DayType.Fair.ToString(),_data.DayTypeDistributioFair.ToString(CultureInfo.CurrentCulture));
            input_GV.Rows.Add(Enums.DayType.Poor.ToString(),_data.DayTypeDistributioPoor.ToString(CultureInfo.CurrentCulture));

            ///////
            foreach (DemandDistribution dataDemand in _data.DemandDistributions)
            {
                input2_GV.Rows.Add(dataDemand.Demand.ToString(),
                    dataDemand.DayTypeDistributions[0].Probability.ToString(CultureInfo.CurrentCulture),
                    dataDemand.DayTypeDistributions[1].Probability.ToString(CultureInfo.CurrentCulture),
                    dataDemand.DayTypeDistributions[2].Probability.ToString(CultureInfo.CurrentCulture));
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(KeyEvent);
        }
        private void KeyEvent(object sender, KeyEventArgs e) //Keyup Event 
        {
            if (e.KeyCode == Keys.F5)
            {
                RunSystem();
            }
            else if (e.KeyCode == Keys.F1)
            {
                GetResults();
            }
            else if (e.KeyCode == Keys.F7)
            {
                string path =
                    @"F:\College Year 4\Year 4 [CS]\simulation\Labs\Lab 5\simulation-task-2\newspapersellersimulation_students\newspapersellersimulation\TestCases\Outs.txt";
                GetBestProfit(purch_num_txt.Text, net_profit_txt.Text,path);
                MessageBox.Show(@"Saved Successfully", @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        private void GetResults()
        {
            int numOfNewspapers = Convert.ToInt32(purch_num_txt.Text);
            int numOfRecords = Convert.ToInt32(days_count_txt.Text);
            double purchasePrice = Convert.ToDouble(purch_price_txt.Text);
            double sellingPrice = Convert.ToDouble(selling_price_txt.Text);
            double scrapPrice = Convert.ToDouble(scrap_price_txt.Text);
            _handler = new Handler(input_GV, input2_GV, numOfNewspapers, numOfRecords, purchasePrice, sellingPrice, scrapPrice);
            _handler.Main_Handler();
            ShowData();
            string testResult = TestingManager.Test(_handler._system, Constants.FileNames.TestCase1);
            MessageBox.Show(testResult);
        }

        private void GetBestProfit(string numOfNewspapers, string totalNet,String FilePath)
        {
            _data.SaveOuts(numOfNewspapers,totalNet,FilePath);
        }

        private void readFromFileF5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunSystem();
        }

        private void saveOutsF7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path =
                @"F:\College Year 4\Year 4 [CS]\simulation\Labs\Lab 5\simulation-task-2\newspapersellersimulation_students\newspapersellersimulation\TestCases\Outs.txt";
            GetBestProfit(purch_num_txt.Text, net_profit_txt.Text, path);
            MessageBox.Show(@"Saved Successfully", @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void runSimulationF1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetResults();
        }
    }
}
