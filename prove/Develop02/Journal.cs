using System.Text.RegularExpressions;

public class Journal {
    public List<Entry> _journal= new List<Entry>();
    
    public void NewEntry(){
        JournalPrompt Prompt = new JournalPrompt();
        Prompt.Prompter();
        Prompt._date = DateTime.Now.ToString("MMM dd, yyyy - HH:mm");
        Entry newEntry = new Entry();
        newEntry._entry.Add(Prompt._date);
        newEntry._entry.Add(Prompt._prompt);
        newEntry._entry.Add(Prompt._response);
        _journal.Add(newEntry);
    }

    public void Display(){
        Console.Clear();
        Console.WriteLine("==============================");
        foreach(Entry ent in _journal){
            Console.WriteLine("-------------------");
            foreach(string line in ent._entry){
                Console.WriteLine(line);
            }
            Console.WriteLine("-------------------");
        }
        Console.WriteLine("==============================");
    }

    public void SaveJournal(){
        string myJSON;
        string fileName;
        Console.WriteLine("What would you like to name your file? ");
        fileName = Console.ReadLine()+".json";
        List<string> assemble = new List<string>();
        foreach(Entry ent in _journal){
            assemble.Add("["+'"'+string.Join('"'+","+'"',ent._entry.ToArray())+'"'+"]"); 
        }
        myJSON = "["+string.Join(",",assemble.ToArray())+"]";
        using(FileStream fs = File.Create(fileName));
        File.WriteAllText(fileName,myJSON);
        Console.Clear();
        Console.WriteLine($"File saved as {fileName}");
    }

    public void LoadJournal(){
        string fileName;
        _journal.Clear();
        Console.WriteLine("What is your file named?");
        fileName = Console.ReadLine()+".json";
        string fileJSON = File.ReadAllText(fileName);
        List<string> importJournal = new List<string>();
        string[] entries = fileJSON.Split("],[");
        foreach(string entry in entries){
            string cleanEntry = Regex.Replace(entry,@"\[|\]","");
            Entry newEntry = new Entry();
            string[] entryPieces = cleanEntry.Split('"'+","+'"');
            foreach(string piece in entryPieces){
                string cleanpiece = Regex.Replace(piece,@"\"+'"'+"","");
                newEntry._entry.Add(cleanpiece);
            }
            _journal.Add(newEntry);
        }
        Console.Clear();
        Console.WriteLine($"{fileName} has been loaded");
    }
}