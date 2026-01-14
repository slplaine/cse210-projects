using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random random = new Random();
        string keepPlaying = "yes";
        while (keepPlaying == "yes")
        {
            int secretNumber = random.Next(1, 101);
            // This line reveals the secret number to simplify testing.
            Console.WriteLine($"What is the magic number? {secretNumber}");
            int guessCount = 0;
            int guess = -1;
            while (guess != secretNumber)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();
                bool ok = int.TryParse(input, out guess);
                if (!ok)
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }
                guessCount++;
                if (guess < secretNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You got it in {guessCount} guesses!");
                    Console.Write("Would you like to play again (yes/no)? ");
                    keepPlaying = Console.ReadLine().Trim().ToLower();
                    if (keepPlaying == "no")
                {
                    Console.WriteLine("Thank you for playing. Goodbye.");
                }
                else if (keepPlaying != "yes")
                {
                    Console.WriteLine("Unrecognized answer. Exiting the game.");
                    keepPlaying = "no";
                }
                break;
                }
                
            }
        }
    }
}