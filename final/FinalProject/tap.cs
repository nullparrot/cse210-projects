public abstract class Tap
{
    private string _size;
    private string _pitch;
    private double _minorMin;
    private double _minorMax;
    public Tap(string size, string pitch, double mionrMin, double minorMax)
    {
        _size = size;
        _pitch = pitch;
        _minorMin = mionrMin;
        _minorMax = minorMax;
    }
    public abstract string GetTapName();
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
    public virtual double GetMinorMin()
    {
        return _minorMin;
    }
    public void SetMinorMin(double minorMin)
    {
        _minorMin = minorMin;
    }
    public virtual double GetMinorMax()
    {
        return _minorMax;
    }
    public void SetMinorMax(double minorMax)
    {
        _minorMax = minorMax;
    }
}