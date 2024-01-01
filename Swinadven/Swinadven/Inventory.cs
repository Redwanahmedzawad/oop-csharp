using System;
using System.Collections.Generic;
using System.Text;

namespace Swinadven
{

    public class Inventory
    {
        private List<Item> _item;
        public Inventory()
        {
            _item = new List<Item>();
        }
        public bool HasItem(string id)
        {
            foreach (Item i in _item)
            {
                if (i.AreYou(id))
                {
                    return true;
                }
            }
            return false;
        }
        public void Put(Item itm)
        {
            _item.Add(itm);
        }
        public Item Take(string id)
        {
            foreach (Item i in _item)
            {
                if (i.AreYou(id))
                {
                    _item.Remove(i);
                    return i;
                }
            }
            return null;
        }
        public Item Fetch(string id)
        {
            foreach (Item i in _item)
            {
                if (i.AreYou(id))
                {
                    return i;
                }
            }
            return null;

        }
        public String ItemList
        {
            get
            {
                string a = null;
                foreach (Item i in _item)
                {
                     a =a+" " +i.ShortDescription+"\n";
                }
                return a;
            }
        }
    }
}
