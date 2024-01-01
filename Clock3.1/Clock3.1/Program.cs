using System;
using System.Windows.Input;

namespace Clock3._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Clock clk = new Clock();
            while (true){
                Console.WriteLine("{00}", clk.Format);
                clk.Tick();
                
            }

        }
    }
}
