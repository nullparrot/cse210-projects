public class ChecklistGoal : Goal{
    private int _count;
    private int _progress;
    private int _bonus;
    public ChecklistGoal(string goal, int value, int count, int progress, int bonus):base(goal,value){
        _count = count;
        _progress = progress;
        _bonus = bonus;
    }


    public override string DisplayGoal()
    {
        throw new NotImplementedException();
    }
}