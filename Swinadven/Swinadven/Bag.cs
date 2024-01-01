using System;
using System.Collections.Generic;
using System.Text;

namespace Swinadven
{
    public class Bag : Item,IHaveInventory
    {
        Inventory inventory;
        public Bag(string[]ids, string name, string desc):base(ids,name, desc)
        {
            inventory = new Inventory();
        }
        public GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }
            return inventory.Fetch(id);
        }
        public override string FullDescription
        {
            get
            {
                return "In the " + Name + " you can see:\n" + inventory.ItemList;
            }
        }
        public Inventory Inventory
        {
            get
            {
                return inventory;
            }
        }
    }
}
