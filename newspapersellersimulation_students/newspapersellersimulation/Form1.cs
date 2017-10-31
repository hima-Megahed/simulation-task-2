using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerModels;
using NewspaperSellerSimulation.Controller;


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
        }

        
    }
}
