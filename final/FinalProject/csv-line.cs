public class CSVLine{
    private List<string> _csvLine = new List<string>();
    public CSVLine(params string[] fields)
    {
        foreach (string option in fields)
        {
            _csvLine.Add(option);
        }
    }
    public List<string> GetFields(){
        return _csvLine;
    }
}