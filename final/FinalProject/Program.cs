using System;

class Program
{
    static void Main(string[] args)
    {
        Menu mainMenu = new Menu("Drilling","Tapping","Quit");
        Menu drillMenu = new Menu("Search Drills","Add Drill","View Drills","Drilling Instructions","Main Menu");
        Menu tapMenu = new Menu("Search Taps","Add Tap","View Taps","Tapping Instructions","Main Menu");
        bool mainLoop = true;
        do
        {
            Console.Clear();
            if (mainMenu.GetChoiceNumber() == -2){
                        Console.WriteLine("Error! Unexpected input!");
                    }
            switch(mainMenu.ChooseOne($"Main Menu\nWhat would you like to do?")){
                case "Drilling":
                bool drillingLoop = true;
                do
                {
                    Console.Clear();
                    if (drillMenu.GetChoiceNumber() == -2){
                        Console.WriteLine("Error! Unexpected input!");
                    }
                    switch(drillMenu.ChooseOne($"Drilling Menu:\nWhat would you like to do?")){
                        case "Search Drills":
                        break;
                        case "Add Drill":
                        break;
                        case "View Drills":
                        break;
                        case "Drilling Instructions":
                        break;
                        case "Main Menu":
                        drillingLoop = false;
                        break;
                        // default:
                        // break;
                    }
                } while (drillingLoop);
                break;
                case "Tapping":
                break;
                case "Quit":
                mainLoop = false;
                break;
                // default:
                //         break;
            }
        

        } while (mainLoop);
        
    }
}