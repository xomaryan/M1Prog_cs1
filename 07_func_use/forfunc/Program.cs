namespace forfunc;

class Program
{
    static void Main()
    {
        double[] basis = { 2, 5, 78, 98 };

        foreach (double getal in basis)
        {
            double resultaat = Math.Pow(getal, 2);
            Console.WriteLine($"{getal} keer zichzelf {resultaat}");
            }
        
    }
}
