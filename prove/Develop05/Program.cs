using System;

class Program
{
    static void Main(string[] args)
    {
        Menu mainMenu = new Menu("See Goals", "Create Goals", "Export Goals", "Load Goals", "Quit");
        Menu goalMenu = new Menu("Simple Goal", "Checklist Goal", "Eternal Goal");
        List<Goal> myGoals = new List<Goal>();
        bool keepGoing = true;
        do
        {
            switch (mainMenu.ChooseOne("Please choose one:"))
            {
                case "See Goals":
                    Console.WriteLine("This will display your active goals");
                    break;
                case "Create Goals":
                    Console.WriteLine("This will start the process of creating a new goal");
                    switch (goalMenu.ChooseOne("What type of goal would you like to make?"))
                    {
                        case "Simple Goal":
                            Console.WriteLine("Lets make a simple goal!");
                            break;
                        case "Checklist Goal":
                            Console.WriteLine("Lets make a checklist goal!");
                            break;
                        case "Eternal Goal":
                            Console.WriteLine("Lets make an eternal goal!");
                            break;
                    }
                    break;
                case "Export Goals":
                    Console.WriteLine("This will export your goals to a file");
                    break;
                case "Load Goals":
                    Console.WriteLine("This will load your goasl from a file");
                    break;
                case "Quit":
                    keepGoing = false;
                    break;
            }
        } while (keepGoing);
        Console.WriteLine("Goodbye!");
    }
}