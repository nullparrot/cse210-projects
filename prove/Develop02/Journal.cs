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
        Console.WriteLine("");
        foreach(Entry ent in _journal){
            Console.WriteLine("-------------------");
            foreach(string line in ent._entry){
                Console.WriteLine(line);
            }
            Console.WriteLine("-------------------");
        }
    }
}