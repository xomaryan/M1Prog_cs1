namespace math;

class Program
{
    static void Main(string[] args)
    {
        double kleiner = 9;
        double groter = 19;

        double welkeIsKleiner = Math.Min(kleiner, groter);
        Console.WriteLine($"{welkeIsKleiner} is de kleinste van {kleiner} en {groter}");


        double kleiner1 = 9;
        double groter1 = 14;

        double welkeIsGroter = Math.Max(kleiner1, groter1);
        Console.WriteLine($"{welkeIsGroter} is de grootste van {kleiner1} en {groter1}");

        double mijnGetal = 16;
        double geklemd = Math.Clamp(mijnGetal, 20, 30);
        Console.WriteLine($"Het clamp resultaat van {mijnGetal} met min 20 en max 30 is de {geklemd}");

        double wortel = Math.Sqrt(16);
        Console.WriteLine($"De Sqrt van 16 is de {wortel}");
    }
}
