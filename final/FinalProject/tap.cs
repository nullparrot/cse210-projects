public class Tap
{
    private string _size;
    private string _pitch;
    private string _tapType;
    private double _minorMin;
    private double _minorMax;
    public Tap(string size, string pitch, string tapType, double mionrMin, double minorMax)
    {
        _size = size;
        _pitch = pitch;
        _tapType = tapType;
        _minorMin = mionrMin;
        _minorMax = minorMax;
    }
    public string GetSize()
    {
        return _size;
    }
    public void SetSize(string size)
    {
        _size = size;
    }
    public string GetPitch(){
        return _pitch;
    }
    public void SetPitch(string pitch){
        _pitch = pitch; 
    }
    public string GetTapType()
    {
        return _tapType;
    }
    public void SetTapType(string tapType)
    {
        _tapType = tapType;
    }
    public double GetMinorMin()
    {
        return _minorMin;
    }
    public void SetMinorMin(double minorMin)
    {
        _minorMin = minorMin;
    }
    public double GetMinorMax()
    {
        return _minorMax;
    }
    public void SetMinorMax(double minorMax)
    {
        _minorMax = minorMax;
    }
}