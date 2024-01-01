using System;

namespace Counter
{
    class Program
    {
        private static void PrintCounters(Counter[] counters)
        {
            foreach (Counter c in counters)
            {
                Console.WriteLine("{0} is {1}", c.Name, c.Ticks);
            }
        }
        public static void Main(string[] args)
        {
            Counter[] mycounters = new Counter[3];
            mycounters[0] = new Counter("Counter 1");
            mycounters[1] = new Counter("Counter 2");
            mycounters[2] = mycounters[0];
            for(int j= 0; j < 10; j++)
            {
                mycounters[0].Increment();
            }
            for(int j=0; j <=14; j++)
            {
                mycounters[1].Increment();

            }
            
            PrintCounters(mycounters);
            
            
            mycounters[2].Reset();
            
            PrintCounters(mycounters);
        }
    }
}
