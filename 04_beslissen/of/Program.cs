namespace of;

class Program
{
    static void Main(string[] args)
    {
        int keuze = int.Parse(Console.ReadLine());
        int bleh = 2;
        int favoriet1 = 1;
        int favoriet2 = 0;
        int chomp1 = 3;
        int chomp2 = 4;

        if (keuze == favoriet1 || keuze == favoriet2)
        {
            Console.WriteLine("JUM JUM");
        }

        else if (keuze == bleh)
        {
            Console.WriteLine("BLEH!");
        }
        else if (keuze == chomp1 || keuze == chomp2)
        {
            Console.WriteLine("CHOMP");
        }
        else
        {
            Console.WriteLine("Hmm... geen reactie.");
        }
    }
}
