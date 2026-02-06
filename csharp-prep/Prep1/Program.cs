using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("what is your name?");
        String first = Console.ReadLine();
        first = char.ToUpper(first[0]) + first.Substring(1);

        Console.WriteLine("what is your last name");
        String Last = Console.ReadLine();
        Last = char.ToUpper(Last[0]) + Last.Substring(1);

        Console.WriteLine($"so your name is {first} {Last}? ");
        Console.WriteLine($"It is nice to meet you {first}.");
    }
}