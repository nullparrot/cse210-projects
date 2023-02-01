using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction noFraction = new Fraction();
        Fraction halfFraction = new Fraction(6);
        Fraction fullFraction = new Fraction(6,7);
        Console.WriteLine(noFraction.GetDecimalValue());
        Console.WriteLine(halfFraction.GetFractionString());
        halfFraction.SetTop(3);
        halfFraction.SetBottom(6);
        Console.WriteLine(halfFraction.GetTop());
        Console.WriteLine(halfFraction.GetBottom());
        Console.WriteLine(halfFraction.GetFractionString());
        Console.WriteLine(fullFraction.GetDecimalValue());
    }
}