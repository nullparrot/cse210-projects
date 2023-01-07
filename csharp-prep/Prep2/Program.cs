using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What grade did you get? (Ex: for '74%' type '74'): ");
        int grade = int.Parse(Console.ReadLine());
        int gradeDigit = grade % 10;
        string gradeLetter;
        string gradeSign = "";
        if (grade >= 90)
        {
            gradeLetter = "A";
        }
        else if (grade >= 80)
        {
            gradeLetter = "B";

        }
        else if (grade >= 70)
        {
            gradeLetter = "C";

        }
        else if (grade >= 60)
        {
            gradeLetter = "D";

        }
        else
        {
            gradeLetter = "F";
        }


        if (gradeDigit < 3 && grade > 60){
            gradeSign = "-";
        } else if (gradeDigit >= 7 && grade < 97){
            gradeSign = "+";
        }

        if (grade >= 70)
        {
            Console.WriteLine($"Congrats! You passed your class with an {gradeLetter}{gradeSign}!");
        }
        else
        {
            Console.WriteLine($"Your grade earned you a {gradeLetter}{gradeSign} in the class.");
        }
    }
}