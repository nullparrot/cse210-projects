public class Menu
{
    private string _choice;
    private int _choiceNumber = -1;
    private List<string> _options = new List<string>();

    public Menu(params string[] options)
    {
        foreach (string option in options)
        {
            _options.Add(option);
        }
    }

    public Menu(List<string> options)
    {
        _options = options;
    }
    public List<string> ListOptions()
    {
        return _options;
    }
    public string GetChoice()
    {
        return _choice;
    }
    public int GetChoiceNumber()
    {
        return _choiceNumber;
    }
    public string ChooseOne(string prompt)
    {
        Console.WriteLine(prompt);
        int tempcount = 1;
        foreach (string option in _options)
        {
            Console.WriteLine($"{tempcount} - {option}");
            tempcount++;
        }
        Console.Write("Choice (ex. 1): ");
        _choiceNumber = int.Parse(Console.ReadLine());
        try{
            _choice = _options[_choiceNumber - 1];
        }
        catch(Exception e){
            _choice = e.ToString();
            _choiceNumber = -2;
        }
        return _choice;
    }
}