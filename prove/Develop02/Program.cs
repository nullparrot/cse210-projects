using System;
class Program
{
    static void Main(string[] args)
    {
        Journal myjournal = new Journal();
        int choice = 0;
        Console.Clear();
        do
        {
            Console.WriteLine($"\nMain Menu\nWhat would you like to do?\n1.New Journal Entry\n2. Display Journal\n3. Save Journal to File\n4. Load Journal from File\n5. Exit");
            Console.WriteLine("Please enter a number (1-5):");
            choice = int.Parse(Console.ReadLine());
            if(choice == 1){
                myjournal.NewEntry();
            } else if(choice == 2){
                myjournal.Display();
            } else if(choice == 3){
                myjournal.SaveJournal();
            } else if(choice == 4){
                myjournal.LoadJournal();
            }
        } while (choice !=5);
    }
}