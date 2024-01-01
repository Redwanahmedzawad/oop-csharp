using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Message myMessage = new Message("Hello World");
            myMessage.Print();
            string[] names = { "mark", "cuban", "che", "guevera", "kim" };
            Message[] messages= new Message[5];
            messages[0] = new Message("Hey, bro.");
            messages[1] = new Message("How are you?");
            messages[2] = new Message("I am fine");
            messages[3] = new Message("What about you");
            messages[4] = new Message("Lets go out to eat something");
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            int i = 0;
            int count=0;
            while (i < 5)
            {
                if (name.ToLower() == names[i])
                {
                    messages[i].Print();
                    count++;
                }
                i++;
            }

            if (count == 0)
            {
                Console.WriteLine("That's a silly name.");
            }
        }
    }
}
