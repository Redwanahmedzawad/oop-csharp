using System;
using System.Collections.Generic;
using System.Text;

namespace Swinadven
{
    public class Player : GameObject,IHaveInventory
    {
       Inventory _inventory;
        Locations _location;
        public Player(string name, string desc) :
            base(new string[] { "me", "inventory" }, name, desc)
        {
            _inventory = new Inventory();
            
        }
        public GameObject Locate(string id)
        {
            if (id == "inventory"||id=="me")
            {
                return this;
            }
            else if (_inventory.Fetch(id) != null)
            {
                return _inventory.Fetch(id);
            }
            return _location.Locate(id);

        }

        public override string FullDescription
        {
            
            get
            {
                
                return "You are " + Name +" "+base.FullDescription+"." +"\n You are carrying:\n"+_inventory.ItemList;

            }
        }
        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }
        public Locations Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
            }
             

        }
        
    }
}    
