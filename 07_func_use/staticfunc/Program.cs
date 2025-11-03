using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

namespace staticfunc;

class Program
{
    static void SayHelloWorld()
    {
        Console.WriteLine("hello, world");
        AfterIntro();
    }
    static void AfterIntro()
    {
        Console.WriteLine("Would you like to see the intro again? (y/n)");
        string input = Console.ReadLine();

        if (input == "y")
        {
            RestartApp();
        }
        else
        {
            StopApp();
        }
    }
    static void RestartApp()
    {
        SayHelloWorld();
    }
    static void StopApp()
    {
        Console.WriteLine("Thank you, the app will close now.");

    }
    static void Main()
    {
        SayHelloWorld();
    }

}
