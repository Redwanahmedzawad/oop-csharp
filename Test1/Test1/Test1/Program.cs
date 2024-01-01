using System;
using System.Collections.Generic;
namespace Test1
{
    class Program
    {
        public static void Main(string[] args)
        {
            DataAnalyser stid = new DataAnalyser(new List<int>() { 1, 0, 3, 5, 0, 1 }, "minmax");
            stid.Summarise();
            stid.AddNumber(8);
            stid.AddNumber(4);
            stid.AddNumber(9);
            stid.Strategy = "Average";
            stid.Summarise();
        }
    }
}
