using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    public class AverageSummary:SummaryStrategy
    {
        private float Average(List<int> numbers)
        {
            float i = 0;
            foreach(int n in numbers)
            {
                i += n;
            }
            return i/numbers.Count;
        }
        public override void PrintSummary(List<int> numbers)
        {
            Console.WriteLine("Average is: {0}", Average(numbers));
        }
    }
}
