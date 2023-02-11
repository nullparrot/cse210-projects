using System;

class Program
{
    static void Main(string[] args)
    {
        TSVParser mytsv = new TSVParser("scriptures.txt");
        List<string> thescriptures = mytsv.GetLines();
        foreach(string line in thescriptures){
            Console.WriteLine(line);
        }
    }
}