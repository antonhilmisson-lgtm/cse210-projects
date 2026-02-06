using System;

public class Program
{
    public static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool running = true;

        Console.WriteLine("Welcome to Your Journal!");

        while (running)
        {
            Console.WriteLine("\nMENU");
            Console.WriteLine("1 Write a new entry");
            Console.WriteLine("2 Display all saved entries");
            Console.WriteLine("3 Quit");
            Console.Write("Please choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string date = DateTime.Now.ToShortDateString();
                string time = DateTime.Now.ToShortTimeString();

                string prompt = journal.PromptMaker();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                Console.Write("Enter your mood (1-10): ");
                int mood = int.Parse(Console.ReadLine());

                Entry entry = new Entry(date, time, prompt, response, mood);
                journal.AddEntry(entry);

                Console.WriteLine("Entry saved.");
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                running = false;
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
            }
        }
    }
}
