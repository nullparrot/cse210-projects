using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Menu mainMenu = new Menu("See Goals", "Create Goals","Update Goal","Export Goals", "Load Goals", "Quit");
        Menu goalMenu = new Menu("Simple Goal", "Checklist Goal", "Eternal Goal");
        List<Goal> myGoals = new List<Goal>();
        List<string> writtenGoals = new List<string>();
        bool keepGoing = true;
        int points = 0;
        string goalsExport = "my-goals-list.txt";
        do
        {
            switch (mainMenu.ChooseOne("Please choose one:"))
            {
                case "See Goals":
                    Console.Clear();
                    points = 0;
                    foreach (Goal oneGoal in myGoals)
                    {
                        Console.WriteLine(oneGoal.DisplayGoal());
                        points += oneGoal.GiveReward();
                    }
                    Console.WriteLine($"Total Points: {points}");
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
                    case "Update Goal":
                    Console.Clear();
                    writtenGoals.Clear();
                    foreach (Goal oneGoal in myGoals)
                    {
                        writtenGoals.Add(oneGoal.DisplayGoal());
                    }
                    Menu currentGoalsMenu = new Menu(writtenGoals);
                    currentGoalsMenu.ChooseOne("Please choose from your list of goals:");
                    myGoals[currentGoalsMenu.GetChoiceNumber()-1].UpdateGoal();
                    break;
                case "Export Goals":
                    Console.Clear();
                    Console.WriteLine("Exporting your goals...");
                    using(StreamWriter outputFile = new StreamWriter(goalsExport)){
                        foreach (Goal oneGoal in myGoals)
                        {
                            outputFile.WriteLine(oneGoal.ExportGoal());
                        }
                    }
                    Console.WriteLine("Done! Export complete!");
                    break;
                case "Load Goals":
                    Console.WriteLine("Loading your goals from the file...");
                    myGoals.Clear();
                    string[] lines = System.IO.File.ReadAllLines(goalsExport);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split("||");
                        switch(parts[0]){
                            case "SIMPLE GOAL":
                            myGoals.Add(new SimpleGoal(parts[1],int.Parse(parts[2]),bool.Parse(parts[3])));
                            break;
                            case "ETERNAL GOAL":
                            myGoals.Add(new EternalGoal(parts[1],int.Parse(parts[2]),int.Parse(parts[3])));
                            break;
                            case "CHECKLIST GOAL":
                            myGoals.Add(new ChecklistGoal(parts[1],int.Parse(parts[2]),int.Parse(parts[3]),int.Parse(parts[4]),int.Parse(parts[5])));
                            break;
                            default:
                            Console.WriteLine("ERROR! Unrecognized goal found... Skipping.");
                            break;
                        }
                    }
                    Console.WriteLine("Done! Loading complete!");
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