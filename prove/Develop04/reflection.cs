using System.Diagnostics;
public class Reflection : Activity
{
    private string _description = "Think about your day, and try not to reflect on the bad things...";
    private List<string> _prompts = new List<string>{
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private string _prompt;
    private List<string> _questions = new List<string>{
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private int _questionGap = 10;

    public Reflection() : base("Reflection Activity", "In this activity you will be given a random prompt and then have time top reflect on it and ponder your answers.\nYou will also be provide with follow up questions to consider.")
    {
        _prompt = ChoosePrompt(_prompts);
        Console.Clear();
        Console.WriteLine(_prompt);
        Stopwatch s = new Stopwatch();
        int dura = GetDuration();
        Pause("Please use this time to ponder",10,1);
        s.Start();
        do
        {
            Console.Write("\r                                          \n");
            Console.WriteLine(ChoosePrompt(_questions));
            Pause("Please use this time to ponder",10,1);
        } while (s.Elapsed < TimeSpan.FromSeconds(dura-10));
        Console.Clear();
        Console.WriteLine($"Thanks for participating.\nWe hope you enjoyed your reflecting!");
        Pause("Thinking",5,1);
    }
}