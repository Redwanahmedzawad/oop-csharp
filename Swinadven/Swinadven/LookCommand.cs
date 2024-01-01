using System;
using System.Collections.Generic;
using System.Text;

namespace Swinadven
{
    public class LookCommand: Command
    {
        public LookCommand():base(new string[] { "look" })
        {

        }
        public override string Execute(Player p, string[] text)
        {
            IHaveInventory _container;
            if (text[0] == "look")
            {
                if (text[1] == "at")
                {
                    if (Array.Find(text, element => element == "location")== null)
                    {
                        if (text.Length == 3)
                        {
                            _container = p as IHaveInventory;

                        }
                        else if (text.Length == 5 && text[3] == "in")
                        {
                            _container = FetchContainer(p, text[4]);
                        }
                        else
                        {
                            return "What do you want to look in?";
                        }
                    }
                    else
                    {
                        return Look(p.Location);
                    }
                }
                else
                {
                    return "What do you want to look at?";
                }
            }
            else
            {

                return "Error in look input";
            }
            if (_container != null)
            {
                return LookAtin(text[2], _container);
            }
            return "I can't find the " + text[4];

        }
        public IHaveInventory FetchContainer(Player p, string containerid)
        {
            

             return p.Locate(containerid) as IHaveInventory;
            

        }
        public string LookAtin(string thingid, IHaveInventory container)
        {
           if (container.Locate(thingid) != null)
            {
                
                return container.Locate(thingid).FullDescription;
            }
            return "I can't find the " + thingid;
        }
        public string Look(Locations location)
        {
            return location.FullDescription;
        }
    }
}
