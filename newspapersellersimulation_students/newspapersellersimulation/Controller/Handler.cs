using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NewspaperSellerModels;

namespace NewspaperSellerSimulation.Controller
{
    public class Handler
    {
        private readonly DataGridView _randomTypeDay;
        private readonly DataGridView _newspapersDemand;
        public NewspaperSellerModels.System _system;
        private readonly List<DayTypeDistribution> _dayTypeDistributions;
        private readonly List<DemandDistribution> _demandDistributions;
        private readonly List<SimulationCase> _simulationCases;
        private readonly int _numOfNewspapers;
        private readonly int _numOfRecords;
        private readonly double _purchasePrice;
        private readonly double _sellingPrice;
        private readonly double _scrapPrice;
        private readonly Random _rnd;
        private readonly PerformanceMeasures _performanceMeasures;

        public Handler()
        {

        }

        public Handler(DataGridView randomTypeDay, DataGridView newspapersDemand, int numOfNewspapers,
            int numOfRecords, double purchasePrice, double sellingPrice, double scrapPrice)
        {
            _system = new NewspaperSellerModels.System();
            _dayTypeDistributions = new List<DayTypeDistribution>();
            _demandDistributions = new List<DemandDistribution>();
            _simulationCases = new List<SimulationCase>();
            _randomTypeDay = randomTypeDay;
            _newspapersDemand = newspapersDemand;
            _numOfNewspapers = numOfNewspapers;
            _numOfRecords = numOfRecords;
            _purchasePrice = purchasePrice;
            _sellingPrice = sellingPrice;
            _scrapPrice = scrapPrice;
            _rnd = new Random();
            _performanceMeasures = new PerformanceMeasures();
        }

        /// <summary>
        /// Main purpose is to Handle and execute all of other functions
        /// </summary>
        public void Main_Handler()
        {
            ////////// Functions are executed consecutvly //////////
            //Function #1
            IntializingData();
            //Function #2
            Get_SimulationCases();
            //Function #3
            Get_Performance_Measures();
        }



        /// <summary>
        /// This Function is responsible of Assigning the data into System
        /// </summary>
        private void IntializingData()
        {
            ////////////// Checkbox values
            {
                _system.NumOfNewspapers = _numOfNewspapers;
                _system.NumOfRecords = _numOfRecords;
                _system.PurchasePrice = _purchasePrice;
                _system.SellingPrice = _sellingPrice;
                _system.ScrapPrice = _scrapPrice;
                _system.UnitProfit = _system.SellingPrice - _system.PurchasePrice;
            }
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
                Cummulative_DayTypeDistributions(_dayTypeDistributions);
                //Assigning Data to System's Day Type Distributions Table
                _system.DayTypeDistributions = _dayTypeDistributions;
            }
            ////////////// Distribution of Newspapers Demanded //////////////
            {
                for (int i = 0; i < _newspapersDemand.RowCount - 1; i++)
                {
                    var demandDist = new DemandDistribution
                    {
                        //Demand Value
                        Demand = Convert.ToInt32(_newspapersDemand.Rows[i].Cells[0].Value)
                    };
                    //Demand DayType = Good & It's Probability
                    var listDayType = new List<DayTypeDistribution>();
                    //Demand DayType = Good & It's Probability
                    var dayTypeDist = new DayTypeDistribution
                    {
                        DayType = Enums.DayType.Good,
                        Probability = Convert.ToDouble(_newspapersDemand.Rows[i].Cells[1].Value)
                    };
                    listDayType.Add(dayTypeDist);
                    //Demand DayType = Fair & It's Probability
                    dayTypeDist = new DayTypeDistribution
                    {
                        DayType = Enums.DayType.Fair,
                        Probability = Convert.ToDouble(_newspapersDemand.Rows[i].Cells[2].Value)
                    };
                    listDayType.Add(dayTypeDist);
                    //Demand DayType = Poor & It's Probability
                    dayTypeDist = new DayTypeDistribution
                    {
                        DayType = Enums.DayType.Poor,
                        Probability = Convert.ToDouble(_newspapersDemand.Rows[i].Cells[3].Value)
                    };
                    listDayType.Add(dayTypeDist);
                    //Demand day type distributions
                    demandDist.DayTypeDistributions = listDayType;
                    //Adding _demandDist into my Demand Distributions
                    _demandDistributions.Add(demandDist);
                }
                //Demand Distributions
                Cummulative_DemandDistributions(_demandDistributions);
                //Assigning Data to System's Demand Distributions 
                _system.DemandDistributions = _demandDistributions;
            }
        }
        /// <summary>
        /// This Function Calculates Demand Distribution
        /// </summary>
        /// <param name="demandDistributions"></param>
        private void Cummulative_DemandDistributions(List<DemandDistribution> demandDistributions)
        {
            /////// Intializing First Row ///////
            {
                //good day propability dist
                demandDistributions[0].DayTypeDistributions[0].CummProbability =
                    demandDistributions[0].DayTypeDistributions[0].Probability;
                demandDistributions[0].DayTypeDistributions[0].MinRange = 1;
                demandDistributions[0].DayTypeDistributions[0].MaxRange =
                    Convert.ToInt32(demandDistributions[0].DayTypeDistributions[0].CummProbability * 100);

                //fair day propability dist
                demandDistributions[0].DayTypeDistributions[1].CummProbability =
                    demandDistributions[0].DayTypeDistributions[1].Probability;
                demandDistributions[0].DayTypeDistributions[1].MinRange = 1;
                demandDistributions[0].DayTypeDistributions[1].MaxRange =
                    Convert.ToInt32(demandDistributions[0].DayTypeDistributions[1].CummProbability * 100);

                //poor day propability dist
                demandDistributions[0].DayTypeDistributions[2].CummProbability =
                    demandDistributions[0].DayTypeDistributions[2].Probability;
                demandDistributions[0].DayTypeDistributions[2].MinRange = 1;
                demandDistributions[0].DayTypeDistributions[2].MaxRange =
                    Convert.ToInt32(demandDistributions[0].DayTypeDistributions[2].CummProbability * 100);
            }

            for (int i = 1; i < demandDistributions.Count; i++)
            {
                //good day
                demandDistributions[i].DayTypeDistributions[0].CummProbability =
                    demandDistributions[i - 1].DayTypeDistributions[0].CummProbability +
                    demandDistributions[i].DayTypeDistributions[0].Probability;
                demandDistributions[i].DayTypeDistributions[0].MinRange =
                    demandDistributions[i - 1].DayTypeDistributions[0].MaxRange + 1;
                demandDistributions[i].DayTypeDistributions[0].MaxRange = Convert.ToInt32(demandDistributions[i].DayTypeDistributions[0].CummProbability * 100);
                //fair day
                demandDistributions[i].DayTypeDistributions[1].CummProbability =
                    demandDistributions[i - 1].DayTypeDistributions[1].CummProbability +
                    demandDistributions[i].DayTypeDistributions[1].Probability;
                demandDistributions[i].DayTypeDistributions[1].MinRange =
                    demandDistributions[i - 1].DayTypeDistributions[1].MaxRange + 1;
                demandDistributions[i].DayTypeDistributions[1].MaxRange = Convert.ToInt32(demandDistributions[i].DayTypeDistributions[1].CummProbability * 100);
                //poor day
                demandDistributions[i].DayTypeDistributions[2].CummProbability =
                    demandDistributions[i - 1].DayTypeDistributions[2].CummProbability +
                    demandDistributions[i].DayTypeDistributions[2].Probability;
                demandDistributions[i].DayTypeDistributions[2].MinRange =
                    demandDistributions[i - 1].DayTypeDistributions[2].MaxRange + 1;
                demandDistributions[i].DayTypeDistributions[2].MaxRange = Convert.ToInt32(demandDistributions[i].DayTypeDistributions[2].CummProbability * 100);
            }
        }
        /// <summary>
        /// This Function Calculates Day Type Distribution
        /// </summary>
        /// <param name="prop"></param>
        private void Cummulative_DayTypeDistributions(List<DayTypeDistribution> prop)
        {
            //good day propability dist
            prop[0].CummProbability = prop[0].Probability;
            prop[0].MinRange = 1;
            prop[0].MaxRange = Convert.ToInt32(prop[0].CummProbability * 100);

            //fair day propability dist
            prop[1].CummProbability = prop[0].CummProbability + prop[1].Probability;
            prop[1].MinRange = prop[0].MaxRange + 1;
            prop[1].MaxRange = Convert.ToInt32(prop[1].CummProbability * 100);

            //poor day propability dist
            prop[2].CummProbability = prop[1].CummProbability + prop[2].Probability;
            prop[2].MinRange = prop[1].MaxRange + 1;
            prop[2].MaxRange = Convert.ToInt32(prop[2].CummProbability * 100);
        }
        /// <summary>
        /// This function Generate Simulation Cases
        /// </summary>
        private void Get_SimulationCases()
        {
            for (int i = 0; i < _system.NumOfRecords; i++)
            {
                SimulationCase simCase = new SimulationCase
                {
                    DayNo = i+1,
                    RandomNewsDayType = _rnd.Next(1, 101),
                    RandomDemand = _rnd.Next(1, 101)
                };
                simCase.NewsDayType = Get_DayType(simCase.RandomNewsDayType);
                simCase.Demand = Get_Demand(simCase.NewsDayType, simCase.RandomDemand);
                simCase.DailyCost = _system.NumOfNewspapers * _system.PurchasePrice;
                if (simCase.Demand > _system.NumOfNewspapers)
                {
                    simCase.SalesProfit = _system.NumOfNewspapers * _system.SellingPrice;
                }
                else
                {
                    simCase.SalesProfit = simCase.Demand * _system.SellingPrice;
                }

                if (simCase.Demand > _system.NumOfNewspapers)
                {
                    simCase.LostProfit = (simCase.Demand - _system.NumOfNewspapers) * _system.UnitProfit;
                    simCase.ScrapProfit = 0;
                }
                else
                {
                    simCase.LostProfit = 0;
                    simCase.ScrapProfit = (_system.NumOfNewspapers - simCase.Demand) * _system.ScrapPrice;
                }
                simCase.DailyNetProfit =
                    simCase.SalesProfit - simCase.DailyCost - simCase.LostProfit + simCase.ScrapProfit;
                
                _simulationCases.Add(simCase);
            }

            _system.SimulationCases = _simulationCases;
        }
        /// <summary>
        /// This Function Generate Randome Day Type based on probability
        /// </summary>
        /// <param name="randomNewsDayType"></param>
        /// <returns></returns>
        private Enums.DayType Get_DayType(int randomNewsDayType)
        {
            if (randomNewsDayType <= _system.DayTypeDistributions[0].MaxRange)
            {
                return Enums.DayType.Good; //GOOD
            }
            if (randomNewsDayType <= _system.DayTypeDistributions[1].MaxRange)
            {
                return Enums.DayType.Fair; //Fair
            }

            return Enums.DayType.Poor; //Poor

        }
        /// <summary>
        /// This Function Gets Demand based on day type and randome demand probability
        /// </summary>
        /// <param name="dayType"></param>
        /// <param name="randomDemand"></param>
        /// <returns></returns>
        private int Get_Demand(Enums.DayType dayType, int randomDemand)
        {
            if (dayType == Enums.DayType.Good)
            {
                foreach (DemandDistribution dd in _system.DemandDistributions)
                {
                    if (randomDemand >= dd.DayTypeDistributions[0].MinRange &&
                        randomDemand <= dd.DayTypeDistributions[0].MaxRange)
                    {
                        return dd.Demand;
                    }
                }
            }
            else if (dayType == Enums.DayType.Fair)
            {
                foreach (DemandDistribution dd in _system.DemandDistributions)
                {
                    if (randomDemand >= dd.DayTypeDistributions[1].MinRange &&
                        randomDemand <= dd.DayTypeDistributions[1].MaxRange)
                    {
                        return dd.Demand;
                    }
                }
            }
            else
            {
                foreach (DemandDistribution dd in _system.DemandDistributions)
                {
                    if (randomDemand >= dd.DayTypeDistributions[2].MinRange &&
                        randomDemand <= dd.DayTypeDistributions[2].MaxRange)
                    {
                        return dd.Demand;
                    }
                }
            }
            return 1;
        }

        private void Get_Performance_Measures()
        {
            _performanceMeasures.TotalSalesProfit = GetTotalSalesProfit();
            _performanceMeasures.TotalCost = GetTotalCost();
            _performanceMeasures.TotalLostProfit = GetTotalLostProfit();
            _performanceMeasures.TotalScrapProfit = GetTotalScrapProfit();
            _performanceMeasures.TotalNetProfit = GetTotalNetProfit();
            _performanceMeasures.DaysWithMoreDemand = GetDaysMoreDemand();
            _performanceMeasures.DaysWithUnsoldPapers = GetDaysUnsoldPapers();

            _system.PerformanceMeasures = _performanceMeasures;
        }

        private double GetTotalSalesProfit()
        {
            double sum = 0;
            foreach (SimulationCase simCase in _simulationCases)
            {
                sum += simCase.SalesProfit;
            }
            return sum;
        }

        private double GetTotalCost()
        {
            double sum = 0;
            foreach (SimulationCase simCase in _simulationCases)
            {
                sum += simCase.DailyCost;
            }
            return sum;
        }

        private double GetTotalLostProfit()
        {
            double sum = 0;
            foreach (SimulationCase simCase in _simulationCases)
            {
                sum += simCase.LostProfit;
            }
            return sum;
        }

        private double GetTotalScrapProfit()
        {
            double sum = 0;
            foreach (SimulationCase simCase in _simulationCases)
            {
                sum += simCase.ScrapProfit;
            }
            return sum;
        }

        private double GetTotalNetProfit()
        {
            double sum = 0;
            foreach (SimulationCase simCase in _simulationCases)
            {
                sum += simCase.DailyNetProfit;
            }
            return sum;
        }

        private int GetDaysUnsoldPapers()
        {
            int sum = 0;
            foreach (SimulationCase simCase in _simulationCases)
            {
                if (Math.Abs(simCase.ScrapProfit) > 0)
                    sum++;
            }
            return sum;
        }

        private int GetDaysMoreDemand()
        {
            int sum = 0;
            foreach (SimulationCase simCase in _simulationCases)
            {
                if (Math.Abs(simCase.LostProfit) > 0)
                    sum++;
            }
            return sum;
        }
    }
}
