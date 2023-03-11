public abstract class Goal
{
    private int _value;
    private string _goal;
    public Goal(string goal, int value)
    {
        _goal = goal;
        _value = value;
    }

    public Goal(){
        
    }
    public void SetValue(int value)
    {
        _value = value;
    }
    public int GetValue()
    {
        return _value;
    }
    public void SetGoal(string goal)
    {
        _goal = goal;
    }
    public string GetGoal()
    {
        return _goal;
    }
    public abstract string DisplayGoal();
    public virtual int GiveReward(){
        return _value;
    }

}