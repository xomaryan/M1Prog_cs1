namespace forit;

class Program
{
    static void Main(string[] args)
    {
        int[] nummers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        for (int i = 3; i <= 7; i++)
        {
            Console.WriteLine($"{i}: {nummers[i]}");
        }
    }
}
