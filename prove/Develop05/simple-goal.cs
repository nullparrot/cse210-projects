public class SimpleGoal : Goal{
    private bool _complete;
    public SimpleGoal(string goal, int value, bool complete):base(goal,value){
        _complete = complete;
    }
    public SimpleGoal(){
        Console.Clear();
        Console.WriteLine("A simple goal is something you need to complete just once.");
        Console.WriteLine("What would you like to make a simple goal for?");
        Console.Write("> ");
        SetGoal(Console.ReadLine());
        Console.WriteLine("How many points should it be worth?");
        Console.Write("> ");
        SetValue(int.Parse(Console.ReadLine()));
        _complete = false;
    }
    public void SetComplete(bool copmlete){
        _complete = copmlete;
    }
    public bool GetComplete(){
        return _complete;
    }
    public override string DisplayGoal()
    {
        switch(_complete){
            case true:
            return $"[Complete] - {GetGoal()} - {GetValue()}/{GetValue()} Point(s)";
            case false:
            return $"[Incomplete] - {GetGoal()} - 0/{GetValue()} Point(s)";
        }
        
    }
    public override int GiveReward()
    {
        switch(_complete){
            case true:
            return GetValue();
            case false:
            return 0;
        }
    }
    public override void UpdateGoal()
    {
        Console.Clear();
        Console.WriteLine(GetGoal());
        Console.Write("Have you completed this goal? (Yes or No)");
        switch(Console.ReadLine()){
            case "Yes":
            case "y":
            case "Y":
            case "YES":
            case "yes":
            _complete = true;
            break;
            case "No":
            case "n":
            case "N":
            case "NO":
            case "no":
            _complete = false;
            break;
            default:
            Console.WriteLine("Error, unexpected response.");
            break;
        }
    }
}