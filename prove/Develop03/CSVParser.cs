public class CSVParser{
    
    private string _filepath;
    private List<string> _filecontents = new List<string>();
    public CSVParser(string FilePath){
        _filepath = FilePath;
    }
    public List<string> GetLines(){
        foreach(string line in File.ReadAllLines(_filepath)){
            _filecontents.Add(line);
        }
        return _filecontents;
    }
    public string GetFilePath(){
        return _filepath;
    }
    public void SetFilePath(string FilePath){
        _filepath = FilePath;
    }
}