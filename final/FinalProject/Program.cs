using System;

class Program
{
    static void Main(string[] args)
    {
        Menu tapMenu = new Menu("View Taps", "Tapping Instructions", "Change Tap Type");
        Menu tapTypeMenu = new Menu("Metric", "ANSI", "Quit");
        bool mainLoop = true;
        string tapType = "ansi";

        do
        {
            Console.Clear();
            if (tapTypeMenu.GetChoiceNumber() == -2)
            {
                Console.WriteLine("Error! Unexpected input!");
            }
            switch (tapTypeMenu.ChooseOne("Metric or ANSI tap?"))
            {
                case "Metric":
                    tapType = "metric";
                    break;
                case "ANSI":
                    tapType = "ansi";
                    break;
                case "Quit":
                    mainLoop = false;
                    break;
            }
            if (mainLoop)
            {
                Tapping letsTap = new Tapping(tapType);
                bool tappingLoop = true;
                do
                {
                    Console.Clear();
                    if (tapMenu.GetChoiceNumber() == -2)
                    {
                        Console.WriteLine("Error! Unexpected input!");
                    }
                    switch (tapMenu.ChooseOne($"{tapTypeMenu.GetChoice()} Tapping Menu:\nWhat would you like to do?"))
                    {
                        case "View Taps":
                            Console.Clear();
                            letsTap.DisplayAllTaps();
                            Console.ReadKey();
                            break;
                        case "Tapping Instructions":
                            Console.Clear();
                            letsTap.CutTap(letsTap.ChooseTap());
                            Console.ReadKey();
                            break;
                        case "Change Tap Type":
                            tappingLoop = false;
                            break;
                    }
                } while (tappingLoop);
            }

        } while (mainLoop);



    }
}