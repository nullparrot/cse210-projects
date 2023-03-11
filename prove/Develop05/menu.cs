public class Menu{
    private string _choice;
    private List<string> _options = new List<string>();

    public Menu(params string[] options){
        foreach (string option in options)
        {
            _options.Add(option);
        }
    }
    public List<string> ListOptions(){
        return _options;
    }
    public string GetChoice(){
        return _choice;
    }
    public string ChooseOne(string prompt){
        Console.WriteLine(prompt);
        int tempcount = 1;
        foreach (string option in _options)
        {
            Console.WriteLine($"{tempcount} - {option}");
            tempcount++;
        }
        Console.Write("Choice (ex. 1): ");
        _choice = _options[ int.Parse(Console.ReadLine())-1];
        return _choice;
    }
}