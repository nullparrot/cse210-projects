public class JournalPrompt{
    public string _prompt;
    public string _response;
    public string _date;
    public void Prompter()
    {
        List<string> prompts = new List<string>{
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "How did I serve others today?"
        };
        Random rnd = new Random();
        _prompt = prompts[rnd.Next(prompts.Count-1)];
        Console.WriteLine($"\n{_prompt} ");
        _response = Console.ReadLine();
        Console.Clear();
    }
}