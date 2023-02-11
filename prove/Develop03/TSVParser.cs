public class TSVParser{
    
    private string _filePath;
    private List<string> _fileContents = new List<string>();
    public TSVParser(string FilePath){
        _filePath = FilePath;
        foreach(string line in File.ReadAllLines(_filePath)){
            _fileContents.Add(line);
        }
    }
    public List<string> GetLines(){
        foreach(string line in File.ReadAllLines(_filePath)){
            _fileContents.Add(line);
        }
        return _fileContents;
    }
    public string GetFilePath(){
        return _filePath;
    }
    public void SetFilePath(string FilePath){
        _filePath = FilePath;
    }
    public string GetRandomLine(){
        Random rando = new Random();
        string line  = _fileContents[rando.Next(_fileContents.Count())];
        return line;
        
    }
}