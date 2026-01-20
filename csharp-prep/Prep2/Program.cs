using System;

class Program
{
    static void Main(string[] args)

///A code to convert percentage grades into letter grades

    {
        Console.WriteLine("Place input the percentage grade you have recivced recive.");
        int x = int.Parse(Console.ReadLine());

        if (x>=90) 
        {
            Console .WriteLine("Great Job you've recived an A");
        };

        if (x>= 80)
        {
            Console.WriteLine("Good Job your you've recived a B");
        };

        if (x >= 70)
        {
            Console.WriteLine("You have recived a C");
        };

        if (x >= 60)
        {
            Console.WriteLine("You have recived a D");
        };

        if (x < 60)
        {
            Console.WriteLine("You've recived an F");
        };
    }
}
