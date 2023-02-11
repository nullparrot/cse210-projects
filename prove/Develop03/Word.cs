using System.Text.RegularExpressions;
public class Words{
    private List<string> _verse = new List<string>();
    private List<int> _versetracker = new List<int>();
    private string _completeverse;
    public Words(string scripture){
        _completeverse = scripture;
        int tempcounter = 0;
        foreach(string word in scripture.Split(" ")){
            _verse.Add(word);
            if(Regex.IsMatch(word,"[|0-9]+")){
                tempcounter++;
            }else{_versetracker.Add(tempcounter);
            tempcounter++;}
        };
    }
    public string GetVerse(){
        _completeverse = String.Join(" ",_verse);
        _completeverse = Regex.Replace(_completeverse,"[|]",Environment.NewLine);
        return _completeverse;
    }
    public void SetVerse(string scripture){
        _completeverse = scripture;
        int tempcounter = 0;
        foreach(string word in scripture.Split(" ")){
            _verse.Add(word);
            _versetracker.Add(tempcounter);
            tempcounter++;
        };
    }
    public string RemoveWord(){
        if(_versetracker.Count()>0){
        int wordsleft = _versetracker.Count();
        Random rando = new Random();
        int removalchoicestep = rando.Next(wordsleft);
        int removalchoice = _versetracker[removalchoicestep];
        _versetracker.RemoveAt(removalchoicestep);
        string chosenword = _verse[removalchoice];
        string blankedword = Regex.Replace(chosenword,"[A-z']","_");
        _verse[removalchoice] = blankedword;
        return chosenword;}else{
            return "false";
        }
    }
}