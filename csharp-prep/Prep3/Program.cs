using System;

class Program
{
    static void Main(string[] args)
    
       
    {
          // Generate a random number between 1 and 100
        Random random = new Random();
        int magicNumber = random.Next(1, 101);

        // Ask the user for the magic number (commented out for the final version)
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        // Initialize variable to hold user's guess
        int guess = 0;

        // Loop until the user guesses the magic number
        while (guess != magicNumber)
        {
            // Ask the user for their guess
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            // Check if the guess is higher, lower, or correct
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
    }
}

    
