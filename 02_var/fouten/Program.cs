namespace fouten;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        string naam = "Lena";  //double voor cijfers
        bool heeftRijbewijs = true;  // bool alleen voor true/false

        Console.WriteLine(naam);
        Console.WriteLine(heeftRijbewijs);

        Console.WriteLine("----------");

        //Oefening 2: Ongeldige variabelennamen
        int autoWielen = 4;
        double lengteInCm = 175.5;
        bool heeftRijbewijsen = false;

        Console.WriteLine(autoWielen);  //kan geen getallen bevatten
        Console.WriteLine(lengteInCm);  //kan geen koppelstreep bevatten
        Console.WriteLine(heeftRijbewijsen);  //kan geen spatie bevatten


        Console.WriteLine("----------");


        //Oefening 3: Dubbele declaratie / foute waarden
        int mijnLeeftijd = 20;
        string mijnleeftijd = "twintig";  //je kan niet hetzelfde namen gebruiken.

        Console.WriteLine(mijnleeftijd);
        Console.WriteLine(mijnLeeftijd);
    }
}
