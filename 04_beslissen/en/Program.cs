using System.Runtime.CompilerServices;

namespace en;

class Program
{
    static void Main(string[] args)
    {
         Console.Write("doorNeedsKey? y/n: ");
        string input1 = Console.ReadLine();
        bool doorNeedsKey = input1 == "y";

        Console.Write("player hasKey? y/n: ");
        string input2 = Console.ReadLine();
        bool hasKey = input2 == "y";

        Console.WriteLine("je staat voor een deur");

        if (doorNeedsKey && hasKey)
        {
            Console.WriteLine("de deur zit op slot");
            Console.WriteLine("je gebruikt de sleutel om de deur te openen");
        }
        else if (doorNeedsKey && !hasKey)
        {
            Console.WriteLine("de deur zit op slot");
        }
    }
}
