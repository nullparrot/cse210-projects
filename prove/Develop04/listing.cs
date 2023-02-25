using System.Diagnostics;
public class Listing : Activity{
    private List<string> _prompts = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private string _prompt;
    private List<string> _responses = new List<string>();

    public Listing() :base("Listing Activity","In this activity you will be provided a prompt and then given time to list as many responses as you can."){
        _prompt = ChoosePrompt(_prompts);
        Console.Clear();
        Console.WriteLine(_prompt);
        Stopwatch s = new Stopwatch();
        int dura = GetDuration();
        s.Start();
        do
        {
            Console.Write("> ");
            _responses.Add(Console.ReadLine());
        } while (s.Elapsed < TimeSpan.FromSeconds(dura));
        Console.Clear();
        Console.WriteLine($"Thanks for participating.\nYou provided {_responses.Count} response(s).");
        Pause("Thinking",5,1);
        ActivityGoodbye();
    }
}