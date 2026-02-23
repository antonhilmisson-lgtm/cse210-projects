using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math = new MathAssignment(
            "Richard Ramirez",
            "Decimals",
            "7.5",
            "10-20"
        );

        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment writing = new WritingAssignment(
            "David Jones",
            "Music History",
            "Songs that changed History"
        );

        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}