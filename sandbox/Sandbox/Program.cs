using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string path = @"stuff.txt";
  
        // Adding below contents to the file
        //string[] createText = { "GFG is a CS portal." };
        //File.WriteAllLines(path, createText);
  
        // Calling the ReadAllLines() function
        string[] readText = File.ReadAllLines(path);
        List<string> mytext = new List<string>();
        foreach(string s in readText)
        {
            mytext.Add(s);
        }

        foreach(string t in mytext){
            Console.WriteLine(t);
        }
    }
}