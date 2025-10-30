namespace sommen;

class Program
{
    static void Main(string[] args)
    {
        int plus = 9;
        int plus1 = 9;
        plus1++;
        Console.WriteLine($"plus stat op {plus}");
        Console.WriteLine($"plus is nu {plus1}");

        Console.WriteLine($"plus is nu {plus}");

        int plus2 = 9;
        plus2--;
        Console.WriteLine($"plus is nu {plus2}");

        int voorbeeld1 = 20;
        voorbeeld1 += 10;
        Console.WriteLine($"voorbeeld1 is nu 30, zie: {voorbeeld1}");

        int voorbeeld2 = 20;
        int result = voorbeeld2 + 10;
        Console.WriteLine($"voorbeeld2 is nu 20, zie: {voorbeeld2}, wie is wel 30?");

        int voorbeeld3 = 20;
        int result2 = voorbeeld3 += 10;
        Console.WriteLine($"voorbeeld3 is nu 30, zie: {voorbeeld3}, result2 ook {result2}");


        //zelf maak
        int voorbeeld4 = 17;
        int result3 = voorbeeld4 -= 7;
        Console.WriteLine($"voorbeeld4 is nu 10, zie: {voorbeeld4}, result3 ook {result3}");

        double voorbeeld5 = 12.5;
        double result4 = voorbeeld5 *= 5;
        Console.WriteLine($"voorbeeld5 is nu 62.5, zie: {voorbeeld5}, result4 ook {result4}");

        float voorbeeld6 = 5.12f;
        float result5 = voorbeeld6 /= 2;
        Console.WriteLine($"voorbeeld6 is nu 2,56, zie: {voorbeeld6}, result5 ook {result5}");

    }
}