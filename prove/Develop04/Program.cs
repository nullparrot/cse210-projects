using System;

class Program
{
    static void Main(string[] args)
    {
        Menu activityMenu = new Menu();
        switch (activityMenu.ChooseOne()){
            case "Breathing Activity":
                Breathing inhaleExhale = new Breathing();
                break;
                case "Listing Activity":
                Listing bullets = new Listing();
                break;
                case "Reflection Activity":
                Reflection mirror = new Reflection();
                break;
        }
    }
}