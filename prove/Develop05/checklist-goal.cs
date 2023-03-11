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
}