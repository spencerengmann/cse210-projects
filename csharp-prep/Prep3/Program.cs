using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        int guesses = 0;
        int guess = -2;
        while (guess != number)
        {
            Console.WriteLine("What is your guess?");
            string userInput2 = Console.ReadLine();
            guess = int.Parse(userInput2);
            guesses++;

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine($"You guessed it in {guesses} guesses!");
            }
        }

    }

}