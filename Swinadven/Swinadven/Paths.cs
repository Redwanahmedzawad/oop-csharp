using System;
using System.Collections.Generic;
using System.Text;

namespace Swinadven
{
    public class Paths : IdentifiableObject
    {
        bool _unlock;
        public Paths(string[]idents) : base(idents)
        {
            _unlock=true;
        }
        
        public void PathDestination(Player p, Locations destination)
        {
            if (Unlock)
            {
                p.Location = destination;
            }
            

        }
        public bool Unlock
        {
            get
            {
                return _unlock;
            }
            set
            {
                _unlock = value;
            }
        }

    }
}
