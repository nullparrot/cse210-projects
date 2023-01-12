using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int magicNumber;
        int guessNumber;
        int guesses;
        bool playing = true;
        string playingQuest;

        while (playing)
        {
            magicNumber = rnd.Next(1, 100);
            guesses = 0;
            Console.WriteLine("I'm thinking of a number. Try to guess it!");
            do
            {
                Console.Write("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());
                guesses += 1;
                if (guessNumber == magicNumber)
                {
                    Console.WriteLine($"You guessed it in {guesses} guess(es)!");
                    Console.Write("Would you like to keep playing? (Yes/No): ");
                    playingQuest = Console.ReadLine().ToLower();
                    if (playingQuest != "yes"){
                        playing = false;
                        Console.WriteLine("Thanks for playing!");
                        Console.WriteLine("Goodbye!");
                    }
                }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Too much magic! Something broke!");
                }
            } while (guessNumber != magicNumber);
        }

    }
}