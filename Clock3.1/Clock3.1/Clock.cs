using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Clock3._1
{
    public class Clock
    {
        private Counter hour, minute, second;
        
        public Clock()
        {
            hour = new Counter("hh");
            minute = new Counter("mm");
            second = new Counter("ss");
            
        }

        public void Tick()
        {
            second.Increment();
            
            if(second.Ticks >= 60)
            {
                minute.Increment();
                second.Reset();
                if (minute.Ticks >= 60)
                {
                    hour.Increment();
                    minute.Reset();
                    if(hour.Ticks >= 24)
                    {
                        hour.Reset();
                    }
                }
            }
                
         
        }
        public string Format
        {
            get
            {
                return hour.Ticks.ToString("D2")+":"+ minute.Ticks.ToString("D2")+":"+second.Ticks.ToString("D2");
            }
        }


        
    }
}
