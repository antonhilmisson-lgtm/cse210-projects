public class Entry
{
    public string Date { get; set; }
    public string Time { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }
    public int Mood { get; set; }

    public Entry(string date, string time, string prompt, string response, int mood)
    {
        Date = date;
        Time = time;
        Prompt = prompt;
        Response = response;
        Mood = mood;
    }

    public void Display()
    {
        Console.WriteLine($"[{Date} {Time}] Mood: {Mood}/10");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine("------------------------------");
    }
}
