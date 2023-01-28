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
        
        List<string> assemble = new List<string>();
        foreach(Entry ent in _journal){
            assemble.Add("["+'"'+string.Join('"'+","+'"',ent._entry.ToArray())+'"'+"]"); 
        }
        myJSON = "["+string.Join(",",assemble.ToArray())+"]";
        using(FileStream fs = File.Create("MyJournal.json"));
        File.WriteAllText("MyJournal.json",myJSON);
    }
}