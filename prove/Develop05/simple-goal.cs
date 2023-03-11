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
}