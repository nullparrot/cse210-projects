public class Menu{
    private string _choice;
    private List<string> _options = new List<string>{"Reflection Activity","Listing Activity","Breathing Activity"};
    public List<string> ListOptions(){
        return _options;
    }
    public string GetChoice(){
        return _choice;
    }
    public string ChooseOne(){
        Console.Clear();
        Console.WriteLine("Please choose an activity to do:");
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