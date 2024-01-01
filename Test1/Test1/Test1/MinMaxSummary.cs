using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    public class MinMaxSummary:SummaryStrategy
    {
       private int Minimum(List<int> numbers)
        {
            int i = numbers[0];
            foreach (int n in numbers)
            {
                if (i > n)
                {
                    i = n;
                }
            }
            return i;
        }
        private int Maximum(List<int> numbers)
        {
            int i = 0;
            foreach(int n in numbers)
            {
                if (i < n)
                {
                    i = n;
                }
            }
            return i;
        }
        public override void PrintSummary(List<int> numbers)
        {
            Console.WriteLine("Maximum number in the list: {0}", Maximum(numbers));
            Console.WriteLine("Minimum number in the list: {0}", Minimum(numbers));

        }
    }
}
