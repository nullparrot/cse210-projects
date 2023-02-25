using System.Diagnostics;
public class Activity{
    private int _duration;
    private string _activity;
    private string _description;

    public Activity(string activity, string description){
        _activity = activity;
        _description = description;
        ActivityWelcome();
    }

    private void ActivityWelcome(){
        Console.WriteLine($"Thank you for choosing the {_activity.ToLower()}.");
        Console.Write("How long would you like to participate in the activity (seconds): ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine($"Thank you. We'll stop the activity after {_duration} seconds.");
        Pause("Thinking",5,1);
        Console.Clear();
        Console.WriteLine(_description);
        Pause("Thinking",5,1);
    }
    public void ActivityGoodbye(){
        Console.Clear();
        Console.WriteLine("What would you like to do now?S");
    }
    public void Pause(string message, int time,double interval){
        Console.Write("\r"+message+"                          ");
        int messageLength = message.Length+1;
        int currentLine = Console.GetCursorPosition().Top;
        Stopwatch s = new Stopwatch();
        s.Start();
        int intervalCount = 1;
        do
        {
            Console.SetCursorPosition(messageLength,currentLine);
            switch (intervalCount%4){
                case 0:
                Console.Write(" || ");
                break;
                case 1:
                Console.Write(" // ");
                break;
                case 2:
                Console.Write(" == ");
                break;
                case 3:
                Console.Write(" \\\\ ");
                break;
            }
            intervalCount++;
            Thread.Sleep((int)Math.Round(interval*1000));
        } while (s.Elapsed < TimeSpan.FromSeconds(time));
    }

    public void CountDown(string message, int time){
        Console.Write("\r"+message+"                          ");
        int messageLength = message.Length+1;
        int currentLine = Console.GetCursorPosition().Top;
        do
        {
            Console.SetCursorPosition(messageLength,currentLine);
            Console.Write($" {time} ");
            time--;
            Thread.Sleep(1000);
        } while (time>-1);
    }


    public int GetDuration(){
        return _duration;
    }

    public string ChoosePrompt(List<string> prompts){
        // Console.Clear();
        // Console.WriteLine("Please choose a prompt for the provided list:");
        // int tempcount = 1;
        // foreach (string option in prompts)
        // {
        //     Console.WriteLine($"{tempcount} - {option}");
        //     tempcount++;
        // }
        // Console.Write("Choice (ex. 1): ");
        // return prompts[ int.Parse(Console.ReadLine())-1];
        Random rando = new Random();
        return prompts[rando.Next(prompts.Count())];
    }
}