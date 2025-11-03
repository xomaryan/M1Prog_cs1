namespace stappen;

class Program
{
    static void Main(string[] args)
    {
        int[] vector = { 6, 7, 8, 1, 4, 0 };
        int x = 0;
        Console.WriteLine($"Vector from index {x}: ({vector[x]}, {vector[x + 1]}, {vector[x + 2]})");
        Console.WriteLine($"Vector from index 3: ({vector[3]}, {vector[4]}, {vector[5]})");

        Array.Resize(ref vector, 7);
        vector[6] = 99;
        Console.WriteLine($"Fixed! Now index 6 exists: {vector[6]}");
    }
}
