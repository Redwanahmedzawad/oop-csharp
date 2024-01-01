using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    public class DataAnalyser
    {
        private List<int> _numbers;
        private AverageSummary _avgSummariser;
        private MinMaxSummary _minMaxSummariser;
        private SummaryStrategy _strategy;
        public DataAnalyser(List<int> numbers,string strategy)
        {
            _numbers = numbers;
            _avgSummariser = new AverageSummary();
            _minMaxSummariser = new MinMaxSummary();
            if (strategy.ToLower() == "average")
            {
                _strategy = _avgSummariser;
            }
            else
            {
                _strategy = _minMaxSummariser;
            }

        }
        public DataAnalyser() : this(new List<int>() { 1,0,3,5,0,1},"average")
        {

        }
        public void AddNumber(int num)
        {
            _numbers.Add(num);
        }
        public void Summarise()
        {
            _strategy.PrintSummary(_numbers);

        }
        public String Strategy
        {
            set
            {
                if (value.ToLower() == "average")
                {
                    _strategy = _avgSummariser;
                }
                else
                {
                    _strategy = _minMaxSummariser;
                }
            }
        }
    }
}
