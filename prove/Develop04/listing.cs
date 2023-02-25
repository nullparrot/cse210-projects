public class Listing : Activity{
    private string _description = "Lets make a list of things so that we can be happy";
    private List<string> _prompts = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private string _prompt;
    private List<string> _responses = new List<string>();

    public Listing() :base("Listing Activity","Lets make a list of things so that we can be happy"){
        _prompt = ChoosePrompt(_prompts);
        Console.WriteLine(_prompt);
    }
}