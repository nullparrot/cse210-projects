public class TSVParser{
    
    private string _filepath;
    private List<string> _filecontents = new List<string>();
    public TSVParser(string FilePath){
        _filepath = FilePath;
        foreach(string line in File.ReadAllLines(_filepath)){
            _filecontents.Add(line);
        }
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
    public string GetRandomLine(){
        Random rando = new Random();
        string line  = _filecontents[rando.Next(_filecontents.Count())];
        return line;
        
    }
}