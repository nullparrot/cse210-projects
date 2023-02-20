using System;

class Program
{
    static void Main(string[] args)
    {
        Menu activityMenu = new Menu();
        string chosenActivity = activityMenu.ChooseOne();
        Console.WriteLine(Environment.NewLine+chosenActivity);
        Activity letsGo = new Activity(chosenActivity,"Empty EDEsctipion");
        letsGo.Pause(10);
    }
}