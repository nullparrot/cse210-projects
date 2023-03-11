using System;

class Program
{
    static void Main(string[] args)
    {
        Menu goalMenu = new Menu("Choice 1","Choice 2","Choice 3");
        switch(goalMenu.ChooseOne("Please choose one:")){
            case "Choice 1":
                Console.WriteLine("You picked the first choice!");
                break;
                case "Choice 2":
                Console.WriteLine("You picked the second choice!");
                break;
                case "Choice 3":
                Console.WriteLine("You picked the third choice!");
                break;
        }
    }
}