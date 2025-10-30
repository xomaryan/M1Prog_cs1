namespace als;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Je zoekt je sleutel");
        Console.WriteLine("heb je de sleutel gevonden? (Y/N) ");
        bool sleutelKwijt = Console.ReadLine() =="Y";
        bool sleutelKwijt1 = Console.ReadLine() =="N";

        if (sleutelKwijt)
        {
            Console.WriteLine("Je bent je sleutel gevonden!");
            Console.WriteLine("de deur is open.");
        }

        else
        {
            Console.WriteLine("Je zoekt je sleutel");
            Console.WriteLine("Je bent je sleutel kwijt!");
            Console.WriteLine("de deur is gesloten.");
        }

    }
}
