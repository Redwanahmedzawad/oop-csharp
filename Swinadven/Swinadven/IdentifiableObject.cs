using System;
using System.Collections.Generic;
using System.Text;

namespace Swinadven
{
    public class IdentifiableObject
    {
        private List<string> _identifiers;
        
        public IdentifiableObject(string[] idents)
        {
            _identifiers = new List<string>(idents);
        }
        public bool AreYou(string id)
        {
            bool r = false;
            foreach (string c in _identifiers)
            {
                if (id.ToLower()==c)
                {
                    
                    r = true;

                    break;

                }
            }
            return r;

        }
        public string Firstid
        {

            get
            {
                if (_identifiers.Count!=0)
                {
                    return _identifiers[0];
                }
                else
                {
                    return "";
                }
            }
        }
        public void AddIdentifier(string id)
        {
            id = id.ToLower();
            _identifiers.Add(id);
        }
    }
}
