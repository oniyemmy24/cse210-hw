using System;

class Program
{
    static void Main(string[] args)
        {
          // Initialize a flag for replaying the game
        bool playAgain = true;

        while (playAgain)
        {
            Console.WriteLine("Welcome to the Guess My Number game!");
            
            // Generate a random number between 1 and 100
            Random random = new Random();
            int magicNumber = random.Next(1, 101);

            int guess = 0;
            int attempts = 0; 

            Console.WriteLine("I have picked a number between 1 and 100. Try to guess it!");

            // Loop until the user guesses the correct number
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();

                // Validate input
                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                attempts++; // Increment the attempts counter

                // Provide feedback to the user
                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {attempts} attempts.");
                }
            }

            // Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().Trim().ToLower();
            playAgain = (response == "yes");
            // Provide a closing message if the user chooses not to play again
            if (!playAgain)
            {
                Console.WriteLine("Thanks for playing! Goodbye!");
            }
        }
    }
}