public class ChecklistGoal : Goal
{
    private int _count;
    private int _progress;
    private int _bonus;
    public ChecklistGoal(string goal, int value, int count, int progress, int bonus) : base(goal, value)
    {
        _count = count;
        _progress = progress;
        _bonus = bonus;
    }
    public ChecklistGoal(){
        Console.Clear();
        Console.WriteLine("A checklist goal is something you need to do a set number of times.");
        Console.WriteLine("What would you like to make a checklist goal for?");
        Console.Write("> ");
        SetGoal(Console.ReadLine());
        Console.WriteLine("How many times do you need to do this goal?");
        Console.Write("> ");
        _count = int.Parse(Console.ReadLine());
        Console.WriteLine("How many points should it be worth each time?");
        Console.Write("> ");
        SetValue(int.Parse(Console.ReadLine()));
        Console.WriteLine("How many points should your completion bonus be?");
        Console.Write("> ");
        _bonus = int.Parse(Console.ReadLine());
        _progress = 0;
    }
    public void SetCount(int count)
    {
        _count = count;
    }
    public int GetCount()
    {
        return _count;
    }
    public void SetProgress(int progress)
    {
        _progress = progress;
    }
    public int GetProgress()
    {
        return _progress;
    }
    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public override string DisplayGoal()
    {
        if (_progress == _count)
        {
            return $"[{_progress}/{_count}] - {GetGoal()} - {(_progress * GetValue()) + _bonus} Point(s)";
        }
        else
        {
            return $"[{_progress}/{_count}] - {GetGoal()} - {_progress * GetValue()} Point(s)";
        }
    }
    public override int GiveReward()
    {
        if (_progress == _count)
        {
            return (_progress*GetValue())+_bonus;
        }
        else
        {
            return _progress * GetValue();
        }
    }
    public override void UpdateGoal()
    {
        Console.Clear();
        Console.WriteLine(GetGoal());
        Console.Write("Did you just complete this goal? (Yes or No)");
        switch(Console.ReadLine()){
            case "Yes":
            case "y":
            case "Y":
            case "YES":
            case "yes":
            _progress++;
            break;
            case "No":
            case "n":
            case "N":
            case "NO":
            case "no":
            break;
            default:
            Console.WriteLine("Error, unexpected response.");
            break;
        }
    }
    public override string ExportGoal()
    {
        return $"SIMPLE GOAL||{GetGoal()}||{GetValue()}||{_count}||{_progress}||{_bonus}";
    }
}