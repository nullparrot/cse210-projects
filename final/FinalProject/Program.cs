using System;

class Program
{
    static void Main(string[] args)
    {
        Menu mainMenu = new Menu("Drilling","Tapping","Quit");
        Menu drillMenu = new Menu("Search Drills","Add Drill","View Drills","Drill Instructions","Main Menu");
        Menu tapMenu = new Menu("Search Taps","Add Tap","View Taps","Tapping Instructions","Main Menu");
        bool mainLoop = true;
        do
        {
            Console.Clear();
            switch(mainMenu.ChooseOne("What would you like to do?")){
                case "Drilling":

                break;
                case "Tapping":
                break;
                case "Quit":
                mainLoop = false;
                break;
            }
        

        } while (mainLoop);
        
    }
}