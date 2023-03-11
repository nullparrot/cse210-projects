using System;

class Program
{
    static void Main(string[] args)
    {
        // ChecklistGoal testGoal = new ChecklistGoal("Complete the assigment",100,4,1,200);
        // Console.WriteLine(testGoal.DisplayGoal());
        // testGoal.SetProgress(4);
        // Console.WriteLine(testGoal.DisplayGoal());

        Menu mainMenu = new Menu("See Goals", "Create Goals", "Export Goals", "Load Goals", "Quit");
        Menu goalMenu = new Menu("Simple Goal", "Checklist Goal", "Eternal Goal");
        List<Goal> myGoals = new List<Goal>();
        bool keepGoing = true;
        do
        {
            switch (mainMenu.ChooseOne("Please choose one:"))
            {
                case "See Goals":
                Console.Clear();
                    foreach (Goal oneGoal in myGoals)
                    {
                        Console.WriteLine(oneGoal.DisplayGoal());
                    }
                    break;
                case "Create Goals":
                    Console.WriteLine("This will start the process of creating a new goal");
                    switch (goalMenu.ChooseOne("What type of goal would you like to make?"))
                    {
                        case "Simple Goal":
                            myGoals.Add(new SimpleGoal());
                            break;
                        case "Checklist Goal":
                            myGoals.Add(new ChecklistGoal());
                            break;
                        case "Eternal Goal":
                            myGoals.Add(new EternalGoal());
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Incorrect value entered. Please enter a number.");
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
                default:
                    Console.Clear();
                    Console.WriteLine("Incorrect value entered. Please enter a number.");
                    break;
            }
        } while (keepGoing);
        Console.WriteLine("Goodbye!");
    }
}