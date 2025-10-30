namespace varindex;

class Program
{
    static void Main(string[] args)
    {
        string[] namen = new string[3];
        namen[0] = "mario";
        namen[1] = "sonic";
        namen[2] = "spyro";

        Console.WriteLine($"0: {namen[0]}");
        Console.WriteLine($"1: {namen[1]}");
        Console.WriteLine($"2: {namen[2]}");

        Console.WriteLine("maak een keuze");
        string keuze = Console.ReadLine();

        int gekozenIndex = int.Parse(keuze);
        Console.WriteLine($"jij koos voor {namen[gekozenIndex]}");
    }
}
