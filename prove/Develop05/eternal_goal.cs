public class EternalGoal : Goal{
    private int _count;
    public EternalGoal(string goal, int value, int count):base(goal,value){
        _count = count;
    }


    public override string DisplayGoal()
    {
        throw new NotImplementedException();
    }
}