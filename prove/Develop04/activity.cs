public class Activity{
    private int _duration;
    private long _startTime;
    private long _endTime;
    private string _activity;
    private string _description;

    public Activity(string activity, string description){
        _activity = activity;
        _description = description;
        ActivityWelcome();
        _startTime = DateTime.Now.Ticks/TimeSpan.TicksPerSecond;
        _endTime = _startTime+_duration;
    }

    private void ActivityWelcome(){
        Console.WriteLine($"Thank you for choosing the {_activity.ToLower()}.");
        Console.Write("How long would you like to participate in the activity (seconds): ");
        _duration = int.Parse(Console.ReadLine());
    }
    public void ActivityGoodbye(){
        Console.Clear();
        Console.WriteLine("Thanks for participating. Have a fantastic day!");
    }
    public void Pause(int time){
        long stoptime = DateTime.Now.Ticks/TimeSpan.TicksPerSecond + time;
        Console.Write("Waiting");
        int currentLine = Console.GetCursorPosition().Top;

        do
        {
            Console.SetCursorPosition(8,currentLine);
            Console.Write("      ");
            Thread.Sleep(300);
            Console.SetCursorPosition(8,currentLine);
            Console.Write(".     ");
            Thread.Sleep(234);
            Console.SetCursorPosition(8,currentLine);
            Console.Write(". .   ");
            Thread.Sleep(234);
            Console.SetCursorPosition(8,currentLine);
            Console.Write(". . . ");
            Thread.Sleep(234);
        } while (stoptime>DateTime.Now.Ticks/TimeSpan.TicksPerSecond);
    }

    public int GetDuration(){
        return _duration;
    }

    public string ChoosePrompt(List<string> prompts){
        Console.Clear();
        Console.WriteLine("Please choose a prompt for the provided list:");
        int tempcount = 1;
        foreach (string option in prompts)
        {
            Console.WriteLine($"{tempcount} - {option}");
            tempcount++;
        }
        Console.Write("Choice (ex. 1): ");
        return prompts[ int.Parse(Console.ReadLine())-1];
    }
}