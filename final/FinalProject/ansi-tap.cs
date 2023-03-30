public class ANSITap : Tap{
    public ANSITap(string size, string pitch, double minorMin, double minorMax):base(size,pitch,minorMin,minorMax){

    }
    public override string GetTapName()
    {
        return $"{base.GetSize()}-{base.GetPitch()}";
    }
}