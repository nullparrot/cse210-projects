public class Scripture{
    private string _scripture;
    private string _reference;


    public Scripture(){
        _scripture = "5 Trust in the Lord with all thine heart; and lean not unto thine own understanding.|6 In all thy ways acknowledge him, and he shall direct thy paths.";
        _reference = "Proverbs 3:5-6";
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