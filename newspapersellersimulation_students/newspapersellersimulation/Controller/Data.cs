using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.SqlServer.Server;
using NewspaperSellerModels;

namespace NewspaperSellerSimulation.Controller
{
    class Data
    {
        public string _fileName;
        private string _tempLine;
        private readonly List<string> _linesList;
        public int NumOfNewspapers;
        public int NumOfRecords;
        public double PurchasePrice;
        public double ScrapPrice;
        public double SellingPrice;
        public double DayTypeDistributioGood;
        public double DayTypeDistributioFair;
        public double DayTypeDistributioPoor;
        public List<DemandDistribution> DemandDistributions;
        public Data()
        {
            DemandDistributions = new List<DemandDistribution>();
            _linesList = new List<string>();
        }

        public Data(string fileName)
        {
            _fileName = fileName;
            DemandDistributions = new List<DemandDistribution>();
            _linesList = new List<string>();
        }

        public void Process()
        {
            var streamReader = new StreamReader(_fileName);

            while ((_tempLine = streamReader.ReadLine()) != null)
            {
                _linesList.Add(_tempLine);
            }

            ///////////////
            for (var i = 0; i < _linesList.Count; i++)
            {
                if (_linesList[i].Contains("NumOfNewspapers"))
                {
                    NumOfNewspapers = Convert.ToInt32(_linesList[++i]);
                }
                else if (_linesList[i].Contains("NumOfRecords"))
                {
                    NumOfRecords = Convert.ToInt32(_linesList[++i]);
                }
                else if (_linesList[i].Contains("PurchasePrice"))
                {
                    PurchasePrice = Convert.ToDouble(_linesList[++i]);
                }
                else if (_linesList[i].Contains("ScrapPrice"))
                {
                    ScrapPrice = Convert.ToDouble(_linesList[++i]);
                }
                else if (_linesList[i].Contains("SellingPrice"))
                {
                    SellingPrice = Convert.ToDouble(_linesList[++i]);
                }
                else if (_linesList[i].Contains("DayTypeDistributions"))
                {
                    string[] split = _linesList[++i].Replace(" ", "").Split(',');
                    DayTypeDistributioGood = Convert.ToDouble(split[0]);
                    DayTypeDistributioFair = Convert.ToDouble(split[1]);
                    DayTypeDistributioPoor = Convert.ToDouble(split[2]);
                }
                else if (_linesList[i].Contains("DemandDistributions"))
                {
                    for (int j = 0; j < 7; j++)
                    {
                        string[] split = _linesList[++i].Replace(" ", "").Split(',');
                        var demandDistribution = new DemandDistribution { Demand = Convert.ToInt32(split[0]) };
                        demandDistribution.DayTypeDistributions.Add(new DayTypeDistribution()
                        {
                            DayType = Enums.DayType.Good,
                            Probability = Convert.ToDouble(split[1])
                        });
                        demandDistribution.DayTypeDistributions.Add(new DayTypeDistribution()
                        {
                            DayType = Enums.DayType.Fair,
                            Probability = Convert.ToDouble(split[2])
                        });
                        demandDistribution.DayTypeDistributions.Add(new DayTypeDistribution()
                        {
                            DayType = Enums.DayType.Poor,
                            Probability = Convert.ToDouble(split[3])
                        });
                        DemandDistributions.Add(demandDistribution);
                    }
                }
            }
            streamReader.Close();
        }

        public void SaveOuts(string numberOfNewspapres, string totalNet,string path)
        {
            if (!File.Exists(path))
            {
                StreamWriter sw = File.CreateText(path);

                //Write a line of text
                sw.WriteLine("NumOfNewspapers");
                sw.WriteLine(numberOfNewspapres);
                sw.WriteLine("TotalNetProfit");
                sw.WriteLine(totalNet);
                
                //Close the file
                sw.Close();
            }
            else
            {
                File.AppendAllText(path, Environment.NewLine + @"NumOfNewspapers" + Environment.NewLine + numberOfNewspapres +
                    Environment.NewLine + @"TotalNetProfit" + Environment.NewLine + totalNet + Environment.NewLine);
            }  
        }

    }
}
