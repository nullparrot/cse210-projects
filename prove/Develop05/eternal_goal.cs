public class EternalGoal : Goal{
    private int _count;
    public EternalGoal(string goal, int value, int count):base(goal,value){
        _count = count;
    }
    public EternalGoal(){
        Console.Clear();
        Console.WriteLine("An eternal goal is something you need to be regularly doing.");
        Console.WriteLine("What would you like to make an eternal goal for?");
        Console.Write("> ");
        SetGoal(Console.ReadLine());
        Console.WriteLine("How many points should it be worth each time?");
        Console.Write("> ");
        SetValue(int.Parse(Console.ReadLine()));
        _count = 0;
    }
    public void SetCount(int count){
        _count = count;
    }
    public int GetCount(){
        return _count;
    }
    public override string DisplayGoal()
    {
        return $"{_count} time(s) - {GetGoal()} - {_count}*{GetValue()} = {_count*GetValue()} Point(s)";
    }
}