public class EternalGoal : Goal{
    private int _count;
    public EternalGoal(string goal, int value, int count):base(goal,value){
        _count = count;
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