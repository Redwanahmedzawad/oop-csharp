using System;
using System.Collections.Generic;
using System.Text;

namespace Clock3._1
{
    public class Counter
    {
        public int _count;
        public string _name;


        public Counter(string name)
        {
            _name = name;
            _count = 0;
        }
        public void Increment()
        {
            _count++;

        }
        public void Reset()
        {
            _count = 0;

        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int Ticks
        {
            get
            {
                return _count;
            }
        }
    }
}
