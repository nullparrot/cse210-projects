public class Drill
{
    private double _size;
    private string _fraction;
    private string _gauge;
    private double _metric;
    public Drill(double size, string fraction, string gauge, double metric)
    {
        _size = size;
        _fraction = fraction;
        _gauge = gauge;
        _metric = metric;
    }
    public double GetSize(){
        return _size;
    }
    public void SetSize(double size){
        _size = size;
    }
    public string GetFraction(){
        return _fraction;
    }
    public void SetFraction(string fraction){
        _fraction = fraction;
    }
    public string GetGauge(){
        return _gauge;
    }
    public void SetGauge(string gauge){
        _gauge = gauge;
    }
    public double GetMetric(){
        return _metric;
    }
    public void SetMetric(double metric){
        _metric = metric;
    }
}