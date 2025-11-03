using System.Net.NetworkInformation;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.Clear();
        Console.Write("....X....");
        Console.SetCursorPosition(4, 0);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("?");
        Console.ResetColor();
    }
}