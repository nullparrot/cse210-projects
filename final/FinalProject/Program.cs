using System;

class Program
{
    static void Main(string[] args)
    {
        Menu mainMenu = new Menu("Drilling","Tapping","Quit");
        Menu drillMenu = new Menu("Search Drills","Add Drill","View Drills","Drilling Instructions","Main Menu");
        Menu tapMenu = new Menu("View Taps","Tapping Instructions","Main Menu");
        Menu tapTypeMenu = new Menu("Metric","ANSI");
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
                Drilling letsDrill = new Drilling();
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
                    }
                } while (drillingLoop);
                break;
                case "Tapping":
                bool tappingLoop = true;
                string tapType = "ansi";
                switch(tapTypeMenu.ChooseOne("Metric or ANSI tap?")){
                    case "Metric":
                    tapType = "metric";
                    break;
                    case "ANSI":
                    tapType = "ansi";
                    break;
                }
                Tapping letsTap = new Tapping(tapType);
                do
                {
                    Console.Clear();
                    if (drillMenu.GetChoiceNumber() == -2){
                        Console.WriteLine("Error! Unexpected input!");
                    }
                    switch(tapMenu.ChooseOne($"Tapping Menu:\nWhat would you like to do?")){
                        case "View Taps":
                        letsTap.DisplayAllTaps();
                        tappingLoop = false;
                        mainLoop = false;
                        break;
                        case "Tapping Instructions":
                        letsTap.CutTap(letsTap.ChooseTap());
                        tappingLoop = false;
                        mainLoop = false;
                        break;
                        case "Main Menu":
                        tappingLoop = false;
                        break;
                    }
                } while (tappingLoop);
                break;
                case "Quit":
                mainLoop = false;
                break;
            }
        

        } while (mainLoop);
        
    }
}