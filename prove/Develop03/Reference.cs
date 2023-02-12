public class Reference{
    private string _book;
    private string _chapter;
    private string _verseStart;
    private string _verseEnd;

    public void SetReference(string referenceString){
        string[] pieces = referenceString.Split(" ");
        _book = pieces[0];
        pieces = pieces[1].Split(":");
        _chapter = pieces[0];
        if (pieces[1].Contains("-")){
            pieces = pieces[1].Split("-");
            _verseStart = pieces[0];
            _verseEnd = pieces[1];
        }else{
            _verseStart = pieces[1];
            _verseEnd = pieces[1];
        }
    }

    public string ReturnReference(){
        string reference;
        if(_verseStart == _verseEnd){
            reference = $"{_book} {_chapter}:{_verseStart}";
        }else{
            reference = $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
        }
        return reference;
    }
}