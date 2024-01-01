using System;
using System.Collections.Generic;
using System.Text;

namespace Swinadven
{
    public class GameObject:IdentifiableObject
    {
        private string _description, _name;
        public GameObject(string[]ids, string name, string desc):base(ids)
        {
            _name = name;
            _description = desc;
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public string ShortDescription
        {
            get
            {
                return "a " + _name + " "+Firstid; 
            }
        }
        public virtual string FullDescription
        {
            get
            {
                return _description;
            }
        }


    }
}
