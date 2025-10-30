namespace basicloop;

class Program
{
    static void Main(string[] args)
    {
        int[] nummers = { 5, 10, 15 };
        for (int i = 0; i < nummers.Length; i++)
        {
            int nummer = nummers[i];
            Console.WriteLine($"{i}: {nummer}");
        }
    
    }
}
