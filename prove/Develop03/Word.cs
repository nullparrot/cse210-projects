using System.Text.RegularExpressions;
public class Words
{
    private List<string> _verse = new List<string>();
    private List<int> _versetracker = new List<int>();
    private string _completeverse;
    public Words(string scripture)
    {
        _completeverse = scripture;
        int tempcounter = 0;
        foreach (string word in scripture.Split(" "))
        {
            _verse.Add(word);
            if (Regex.IsMatch(word, "[|0-9]+"))
            {
                tempcounter++;
            }
            else
            {
                _versetracker.Add(tempcounter);
                tempcounter++;
            }
        };
    }
    public string GetVerse()
    {
        _completeverse = String.Join(" ", _verse);
        _completeverse = Regex.Replace(_completeverse, "[|]", Environment.NewLine);
        return _completeverse;
    }
    public void SetVerse(string scripture)
    {
        _completeverse = scripture;
        int tempcounter = 0;
        foreach (string word in scripture.Split(" "))
        {
            _verse.Add(word);
            _versetracker.Add(tempcounter);
            tempcounter++;
        };
    }
    public void RemoveWord()
    {
        bool keeppicking = true;
        Random rando = new Random();
        do
        {
            int removallocation = rando.Next(_verse.Count());
            string removalword = _verse[removallocation];
            if (Regex.IsMatch(removalword, "[A-Za-z]"))
            {
                string blankedword = Regex.Replace(removalword, "[A-z']", "_");
                _verse[removallocation] = blankedword;
                keeppicking = false;
            }
        } while (keeppicking);

    }
}