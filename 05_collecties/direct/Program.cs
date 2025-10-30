namespace uitvragen;

class Program
{
    static void Main()
    {
        double[] percentages = new double[] { 0.8, 1.2, 2.4, 3.6, 4.8, 5.0 };
        percentages[0] = 0.8;
        percentages[1] = 1.2;
        percentages[2] = 2.4;
        percentages[3] = 3.6;
        percentages[4] = 4.8;
        percentages[5] = 5.0;
        Console.WriteLine($"Eerste item in de array op index 0 heeft de waarde {percentages[0]}");
        Console.WriteLine($"Tweede item in de array op index 1 heeft de waarde {percentages[1]}");
        Console.WriteLine($"Derde item in de array op index 2 heeft de waarde {percentages[2]}");
        Console.WriteLine($"Vierde item in de array op index 3 heeft de waarde {percentages[3]}");
        Console.WriteLine($"Vijfde item in de array op index 4 heeft de waarde {percentages[4]}");
        Console.WriteLine($"Zesde item in de array op index 5 heeft de waarde {percentages[5]}");

    }
}

