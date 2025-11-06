using System.Reflection.Metadata;

namespace autoclass;

class Program
{
    static void Main(string[] args)
    {
        Auto mijnAuto = new Auto();
        mijnAuto.merk = "BMW";
        mijnAuto.bouwjaar = 2010;
        mijnAuto.merch = "volkswagen";
        mijnAuto.jaar = 2015;


        Console.WriteLine(mijnAuto);

        
        Console.WriteLine("Auto merk: " + mijnAuto.merk);
        Console.WriteLine("Auto bouwJaar: " + mijnAuto.bouwjaar);


        Console.WriteLine("tweede auto");
        Console.WriteLine("Auto merk: " + mijnAuto.merch);
        Console.WriteLine("Auto bouwjaar: " + mijnAuto.jaar);

        
    }
    
}

