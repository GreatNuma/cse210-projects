using System;

class Program
{
    static void Main(string[] args)
    {
        // Stretch Challenge: Outer loop to allow the user to play multiple times
        string playAgain = "yes";

        while (playAgain == "yes")
        {
            // Core Requirement: Generate a random number from 1 to 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101); // 101 is exclusive, so it goes up to 100

            int guess = -1;
            int guessCount = 0; // Stretch Challenge: Keep track of guesses

            // Core Requirement: Loop until the guess matches the magic number
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string guessInput = Console.ReadLine();
                guess = int.Parse(guessInput);
                
                // Increment the guess counter for every attempt
                guessCount++; 

                // Core Requirement: Determine higher, lower, or match
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            // Stretch Challenge: Display total guesses
            Console.WriteLine($"It took you {guessCount} guesses.");

            // Ask if they want to loop the whole game again
            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine();
        }
    }
}