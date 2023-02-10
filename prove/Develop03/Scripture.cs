public class Scripture{
    private string _scripture;
    private string _reference;


    public Scripture(){
        _scripture = "";
        _reference = "";
    }

    public Scripture(string scripture){
        _scripture = scripture;
        _reference = "";
    }

    public Scripture(string scripture, string reference){
        _scripture = scripture;
        _reference = reference;
    }
    public void SetScripture(string scripture){
        _scripture = scripture;
    }

    public void SetScripture(string scripture, string reference){
        _scripture = scripture;
        _reference = reference;
    }

    public void SetReference(string reference){
        _reference = reference;
    }

    public string GetScripture(){
        return _scripture;
    }

    public string GetReference(){
        return _reference;
    }
}