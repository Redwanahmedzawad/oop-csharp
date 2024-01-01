using System;

namespace Swinadven
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name of the player: ");
            string name = Console.ReadLine();
            Console.WriteLine("Description of the player: ");
            string desc = Console.ReadLine();
            Player p = new Player(name, desc);
            Item gem = new Item(new string[]{"gem", "stone"}, "Kohinoor", "Curse of the kings");
            Item cloth = new Item(new string[] { "cloth","cotton", "silk" }, "Comfy", "Something to hide behind");
            Bag bag = new Bag(new string[] { "bag","leather" }, "Carrier", "Fits in additional things");
            p.Inventory.Put(bag);
            p.Inventory.Put(gem);
            p.Inventory.Put(cloth);
            Item book = new Item(new string[] {"book", "hardcopy", "magical" }, "Grimoire", "Book of spells");
            bag.Inventory.Put(book);
            string choice;
            LookCommand cmd = new LookCommand();
            Console.WriteLine("Enter ! to exit");
            choice=Console.ReadLine();
            while (choice != "!")
            {
                Console.WriteLine("{0}",cmd.Execute(p, choice.Split(" ")));
                choice = Console.ReadLine();
            }



        }
    }
}
