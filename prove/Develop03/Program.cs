using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture myscripture = new Scripture();
        Words myword = new Words(myscripture.GetScripture());
        string moving;
        bool doloop = true;
        string progresscheck;
        string removedword = "";
        do
        {
            Console.Clear();
            Console.WriteLine(myscripture.GetReference());
            Console.WriteLine(myword.GetVerse());
            Console.WriteLine(Environment.NewLine+"We removed the word: '"+removedword+"'");
            Console.WriteLine(Environment.NewLine+"Press enter to continue or 'quit' to finish:");
            moving = Console.ReadLine();
            if(moving == "quit"){
                doloop = false;
            } else{
                progresscheck = myword.GetVerse();
                removedword = myword.RemoveWord();
                removedword = myword.RemoveWord();
                removedword = myword.RemoveWord();
                if(progresscheck == myword.GetVerse()){
                    doloop = false;
                }
            }
        } while (doloop);
    }
}