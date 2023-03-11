public class SimpleGoal : Goal{
    private bool _complete;
    public SimpleGoal(string goal, int value, bool complete):base(goal,value){
        _complete = complete;
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