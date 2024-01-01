using System;
using System.Collections.Generic;
using System.Text;

namespace Swinadven
{
    public class Move : Command
    {
        private string[] movid;
        public Move():base(new string[] { "move", "go", "ahead", "leave" })
        {
            movid = new string[] { "move", "go", "ahead", "leave" };
        }
        public override string Execute(Player p, string[] text)
        {
            if (cktxt(text)&&text.Length>1)
            {
                if(text.Length == 2)
                {
                    
                }
            }
            else
            {
                return "Invalid Move command";
            }
        }
        private bool cktxt(string[] text)
        {
            foreach(string m in movid)
            {
                if(m == text[0])
                {
                    return true;
                }
            }
            return false;
        }
        private string MovePl(Player p, string text)
        {
            if((p.Location.Locate(text)).GetType()== typeof(Paths))
            {
                GameObject destination = p.Location.Locate(text);
                destination.

            }
        }
    }
}
