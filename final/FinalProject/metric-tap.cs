public class MetricTap : Tap{
    public MetricTap(string size, string pitch, double minorMin, double minorMax):base(size,pitch,minorMin,minorMax){

    }
    public override double GetMinorMin()
    {
        return Math.Round(base.GetMinorMin()/25.4,4);
    }
    public override double GetMinorMax()
    {
        return Math.Round(base.GetMinorMax()/25.4,4);
    }
    public override string GetTapName()
    {
        return $"{base.GetSize()}x{base.GetPitch()}";
    }
}