using System;

class Program
{
    static void Main(string[] args)
    {
        ///lwk dont know where to put the random number gnerator techinally but it works here.
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);   

        Console.Write("Hello Would you like to play a game? ");
        string gamestart = Console.ReadLine();
        if (gamestart == "yes" ||
            gamestart == "y" ||
            gamestart == "sure" ||
            gamestart == "ok" ||
            gamestart == "okay" ||
            gamestart == "alright" ||
            gamestart == "yeah" ||
            gamestart == "definitly" )///a little carried away prl coulda done this better
        {
            Console.WriteLine("Yay! Alright I've got a number from 1 to 11 and you need to guess it, what do you think it is?");
        }

        else
        {
            Console.WriteLine(" ok them :( ");
        }
         ////heres where the function happens (am i gonna get negative points for this being kind out of order?)
        
        int guess = 0;

        while (guess != number)
        {
            guess = int.Parse(Console.ReadLine());///psure if this isnt inside the while loop it will spam NOTQUITERIGHT)
            
            if (guess == number)
                {
                    Console.WriteLine("Congraulations you guessed the Number!!!" );
                }

            else
                {
                    Console.WriteLine("Not quite right, try again!");
                }
        }
    } 
}