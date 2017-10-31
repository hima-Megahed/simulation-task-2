using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NewspaperSellerModels;

namespace NewspaperSellerSimulation.Controller
{
    public class Handler
    {
        private readonly DataGridView _randomTypeDay;
        private DataGridView _newspapersDemand;
        private readonly NewspaperSellerModels.System _system;
        private readonly List<DayTypeDistribution> _dayTypeDistributions;
        private List<DemandDistribution> _demandDistributions;
        private readonly int _numOfNewspapers;
        private readonly int _numOfRecords;
        private readonly double _purchasePrice;
        private readonly double _sellingPrice;
        private readonly double _scrapPrice;

        public Handler()
        {
            
        }

        public Handler(DataGridView randomTypeDay, DataGridView newspapersDemand, int numOfNewspapers,
            int numOfRecords, double purchasePrice, double sellingPrice, double scrapPrice)
        {
            _system = new NewspaperSellerModels.System();
            _dayTypeDistributions = new List<DayTypeDistribution>();
            _demandDistributions = new List<DemandDistribution>();
            _randomTypeDay = randomTypeDay;
            _newspapersDemand = newspapersDemand;
            _numOfNewspapers = numOfNewspapers;
            _numOfRecords = numOfRecords;
            _purchasePrice = purchasePrice;
            _sellingPrice = sellingPrice;
            _scrapPrice = scrapPrice;

        }

        /// <summary>
        /// Main purpose is to Handle and execute all of other functions
        /// </summary>
        public void Main_Handler()
        {
            ////////// Functions are executed consecutvly //////////
            //Function #1
            IntializingData();


        }

        /// <summary>
        /// This Function is responsible of Assigning the data into System
        /// </summary>
        private void IntializingData()
        {
            _system.NumOfNewspapers = _numOfNewspapers;
            _system.NumOfRecords = _numOfRecords;
            _system.PurchasePrice = _purchasePrice;
            _system.SellingPrice = _sellingPrice;
            _system.ScrapPrice = _scrapPrice;
            _system.UnitProfit = _system.SellingPrice - _system.PurchasePrice;

            ////////////// Random-Digit Assignment for Type of Newsday //////////////
            {
                // filling Day Type Distribution
                for (int i = 0; i < _randomTypeDay.RowCount - 1; i++)
                {
                    var dtd = new DayTypeDistribution();
                    // filling Day Type
                    var value = _randomTypeDay.Rows[i].Cells[0].Value;
                    if (value != null && value.ToString() == "Good")
                    {
                        dtd.DayType = Enums.DayType.Good;
                    }
                    else if (value != null && value.ToString() == "Fair")
                    {
                        dtd.DayType = Enums.DayType.Fair;
                    }
                    else // Poor
                    {
                        dtd.DayType = Enums.DayType.Poor;
                    }
                    // filling Probability
                    dtd.Probability = Convert.ToDouble(_randomTypeDay.Rows[i].Cells[1].Value);
                    _dayTypeDistributions.Add(dtd);
                }
                //  filling CummProbability & MinRange & MaxRange
                Cummulative_DayTypeDistributions();
            }
            ////////////// Distribution of Newspapers Demanded //////////////
            {
                
            }
        }
        private void Cummulative_DayTypeDistributions()
        {
            //good day propability dist
            _dayTypeDistributions[0].CummProbability = _dayTypeDistributions[0].Probability;
            _dayTypeDistributions[0].MinRange = 1;
            _dayTypeDistributions[0].MaxRange = Convert.ToInt32(_dayTypeDistributions[0].CummProbability * 100);

            //fair day propability dist
            _dayTypeDistributions[1].CummProbability = _dayTypeDistributions[0].CummProbability + _dayTypeDistributions[1].Probability;
            _dayTypeDistributions[1].MinRange = _dayTypeDistributions[0].MaxRange + 1;
            _dayTypeDistributions[1].MaxRange = Convert.ToInt32(_dayTypeDistributions[1].CummProbability * 100);

            //poor day propability dist
            _dayTypeDistributions[2].CummProbability = _dayTypeDistributions[1].CummProbability + _dayTypeDistributions[2].Probability;
            _dayTypeDistributions[2].MinRange = _dayTypeDistributions[1].MaxRange + 1;
            _dayTypeDistributions[2].MaxRange = Convert.ToInt32(_dayTypeDistributions[2].CummProbability * 100);
        }
    }
}
