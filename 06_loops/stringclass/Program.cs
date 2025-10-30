namespace stringclass;

class Program
{
    static void Main(string[] args)
    {


        string[] geenCaps = { "global", "variable", "class" };
        for (int i = 0; i < geenCaps.Length; i++)
        {
            string woord = geenCaps[i];
            string hoofdletters = woord.ToUpper();
            int lengte = woord.Length;

            Console.WriteLine($"is een string die {lengte} lang is");
            Console.WriteLine(hoofdletters);
        }

    }
}
