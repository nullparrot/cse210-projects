public class Drill
{
    private float _size;
    private string _fraction;
    private string _gauge;
    private float _metric;
    public Drill(float size, string fraction, string gauge, float metric)
    {
        _size = size;
        _fraction = fraction;
        _gauge = gauge;
        _metric = metric;
    }
    public float GetSize(){
        return _size;
    }
    public void SetSize(float size){
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
    public float GetMetric(){
        return _metric;
    }
    public void SetMetric(float metric){
        _metric = metric;
    }
}