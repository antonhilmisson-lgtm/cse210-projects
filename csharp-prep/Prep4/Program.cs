using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> integers = new List<int>();

        Console.WriteLine("Please input integers, type 0 when done.");

        int input;
        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                integers.Add(input);
            }
        } while (input != 0);

        /// ^^input and loop function^^ ///

        if (integers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            Console.ReadLine();
            return;
        }

        /// vv analysis of all inputs vv ///
        int total = 0;
        foreach (int number in integers)
        {
            total += number;
        }

        /// vv smallest and largest functions vv ///
        int smallest = integers[0];
        foreach (int number in integers)
        {
            if (number < smallest)
            {
                smallest = number;
            }
        }

        int largest = integers[0];
        foreach (int number in integers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        /// vv creating the average vv ///
        float average = (float)total / integers.Count;

        /// vv printing the results vv ///
        Console.WriteLine($"The total is: {total}");
        Console.WriteLine($"The smallest is: {smallest}");
        Console.WriteLine($"The largest is: {largest}");
        Console.WriteLine($"The average is: {average}");

        Console.ReadLine();
    }
}
