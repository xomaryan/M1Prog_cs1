namespace output;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int a = 1;
        double b = 1.9;
        float vx = 9.87f;
        bool ja = true;

        Console.WriteLine($"Mijn int met de naam a heeft als waarde {a} ");
        Console.WriteLine($"Mijn double met de naam b heeft als waarde {1.8} ");
        Console.WriteLine($"Mijn float met de naam vx heeft als waarde {vx}");
        Console.WriteLine($"Mijn bool met de naam ja heeft als waard {ja}");

        string c = "Lena";
        string d = "Miroslav";

        Console.WriteLine($"Mijn string met de naam c als waarde {c}");
        Console.WriteLine($"Mijn string met de naam d als waarde {d}");
    }
}
