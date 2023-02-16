using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment preCalc = new MathAssignment("Andrew Weist", "Triangles", "2.3", "3-15 Odds");
        Console.WriteLine(preCalc.GetSummary());
        Console.WriteLine(preCalc.GetHomeworkList());
        WritingAssignment thatEssay = new WritingAssignment("Andrew J Weist", "Analysis", "Analysis of 'You Are Not Special'");
        Console.WriteLine(thatEssay.GetSummary());
        Console.WriteLine(thatEssay.GetWritingInformation());
    }
}