using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int numberSum = 0;
        float numberAver;
        int numberMax = 0;
        int newNum;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter a number: ");
            newNum = int.Parse(Console.ReadLine());
            if (newNum != 0)
            {
                numbers.Add(newNum);
            }
        } while (newNum != 0);

        foreach (int number in numbers){
            numberSum += number;
            if (number > numberMax){
                numberMax = number;
            }
        }
        Console.WriteLine($"The sum is: {numberSum}");
        numberAver = numberSum/numbers.Count;
        Console.WriteLine($"The average is: {numberAver}");
        Console.WriteLine($"The largest number is: {numberMax}");
    }
}