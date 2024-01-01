using System;
using System.Collections.Generic;
using System.Text;

namespace Swinadven
{
    public class Locations:GameObject,IHaveInventory
    {

        private Inventory _inventory;
        private Paths _path;
        public Locations(string name, string desc) : base(new string[] { "location" },name,desc)
        {
            
            _inventory = new Inventory();
            

        }
        public GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }
            return _inventory.Fetch(id);
        }
        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }
        public Paths Path
        {
            get
            {
                return _path;
            }
            set
            {
                _path = value;
            }
        }


    }
}
