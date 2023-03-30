using System;

class Program
{
    static void Main(string[] args)
    {
        Menu tapMenu = new Menu("View Taps", "Tapping Instructions", "Quit");
        Menu tapTypeMenu = new Menu("Metric", "ANSI");
        Console.Clear();
        bool tappingLoop = true;
        string tapType = "ansi";
        switch (tapTypeMenu.ChooseOne("Metric or ANSI tap?"))
        {
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
            if (tapMenu.GetChoiceNumber() == -2)
            {
                Console.WriteLine("Error! Unexpected input!");
            }
            switch (tapMenu.ChooseOne($"Tapping Menu:\nWhat would you like to do?"))
            {
                case "View Taps":
                    letsTap.DisplayAllTaps();
                    Console.ReadKey();
                    break;
                case "Tapping Instructions":
                    letsTap.CutTap(letsTap.ChooseTap());
                    Console.ReadKey();
                    break;
                case "Quit":
                    tappingLoop = false;
                    break;
            }
        } while (tappingLoop);

    }
}