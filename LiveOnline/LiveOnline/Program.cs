using System;
using System.Collections.Generic;
namespace Collectionclass

{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> mylist = new List<string>();
            mylist.Add("Redwan");
            mylist.Add("Dependecies");
            mylist.Add("Program");
            mylist.Add("Program");
            Console.WriteLine(mylist[0]);
            for(int i = 0; i < mylist.Count; i++)
            {
                Console.WriteLine("list {0} is {1}",i,mylist[i]);

            }
            mylist.Remove("Program");
            mylist.RemoveAt(0);
            foreach (string name in mylist)
            {
                Console.WriteLine("List {0}", name);
            }
            Dictionary<string , int> mydict = new Dictionary<string, int>();
            mydict.Add("dfsdf", 9898);
            mydict.Add("sddfsd", 3383);
            mydict.Add("dfdf", 343484);
            foreach (string key in mydict.Keys)
            {
                Console.WriteLine("Key {0} and value {1}", key, mydict[key]);
            }
        }
    }
}
