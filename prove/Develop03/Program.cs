using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture myscripture = new Scripture();
        Words myword = new Words(myscripture.GetScripture());
        string moving = "";
        bool doloop = true;
        string progresscheck = "";
        string removedword = "";
        do
        {
            Console.Clear();
            Console.WriteLine(progresscheck);
            Console.WriteLine(myscripture.GetReference());
            Console.WriteLine(myword.GetVerse());
            Console.WriteLine(Environment.NewLine+"We removed the word: '"+removedword+"'");
            Console.WriteLine(Environment.NewLine+"Press enter to continue or 'quit' to finish:");
            //moving = Console.ReadLine();
            if(moving == "quit"){
                doloop = false;
            } else{
                progresscheck = myword.GetVerse();
                removedword = myword.RemoveWord();
                if(String.Compare(progresscheck,myword.GetVerse())<0){
                    doloop = false;
                }
            }
        } while (doloop);
    }
}