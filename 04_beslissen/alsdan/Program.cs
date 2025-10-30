namespace alsdan;

class Program
{
    static void Main(string[] args)
    {
        bool isJumping;
        bool isMoving;

        Console.WriteLine("Is player moving? (y/n)");
        string movingInput = Console.ReadLine();
        isMoving = movingInput == "y";

        Console.WriteLine("Is player jumping? (y/n)");
        string jumpingInput = Console.ReadLine();
        isJumping = jumpingInput == "y";

        if (isJumping)
        {
            Console.WriteLine("jump");
        }
        else if (isMoving)
        {
            Console.WriteLine("walk");
        }
        else
        {
            Console.WriteLine("idle");
        }
    }
}
