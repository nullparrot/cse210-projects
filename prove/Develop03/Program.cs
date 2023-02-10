using System;

class Program
{
    static void Main(string[] args)
    {
        CSVParser mycsv = new CSVParser("scriptures.csv");
        List<string> thescriptures = mycsv.GetLines();
        foreach(string line in thescriptures){
            Console.WriteLine(line);
        }
    }
}