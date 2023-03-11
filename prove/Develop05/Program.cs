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
                    Console.WriteLine("This will export your goals to a file");
                    break;
                case "Load Goals":
                    Console.WriteLine("This will load your goals from a file");
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