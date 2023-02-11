using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        Scripture myscripture = new Scripture();
        Words myword = new Words(myscripture.GetScripture());
        string moving = "";
        bool doloop = true;
        do
        {
            Console.Clear();
            Console.WriteLine(myscripture.GetReference());
            Console.WriteLine(myword.GetVerse());
            Console.WriteLine(Environment.NewLine+"Press enter to continue or 'quit' to finish:");
            moving = Console.ReadLine();
            if (moving == "quit")
            {
                doloop = false;
            }
            else
            {
                myword.RemoveWord();
                if (Regex.IsMatch(myword.GetVerse(), "[A-Za-z]") == false)
                {
                    Console.Clear();
                    Console.WriteLine(myscripture.GetReference());
                    Console.WriteLine(myword.GetVerse());
                    Console.WriteLine(Environment.NewLine+"Entire verse hidden");
                    Console.WriteLine(Environment.NewLine+"Exiting now");
                    doloop = false;
                }
            }
        } while (doloop);
    }
}