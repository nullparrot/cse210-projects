public class Tap
{
    private string _name;
    private string _tapType;
    private float _minorMin;
    private float _minorMax;
    public Tap(string name, string tapType, float mionrMin, float minorMax)
    {
        _name = name;
        _tapType = tapType;
        _minorMin = mionrMin;
        _minorMax = minorMax;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetTapType()
    {
        return _tapType;
    }
    public void SetTapType(string tapType)
    {
        _tapType = tapType;
    }
    public float GetMinorMin()
    {
        return _minorMin;
    }
    public void SetMinorMin(float minorMin)
    {
        _minorMin = minorMin;
    }
    public float GetMinorMax()
    {
        return _minorMax;
    }
    public void SetMinorMax(float minorMax)
    {
        _minorMax = minorMax;
    }
}