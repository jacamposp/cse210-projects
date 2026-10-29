using System;

class Program
{
    static void Main(string[] args)
    {
        string response;
        Random randomGenerator = new Random();
        do
        {
            int magicNumber = randomGenerator.Next(1, 101);
            int guess;
            int tries = 0;
            do
            {
                tries++;
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");

                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            } while (guess != magicNumber);

            Console.WriteLine($"You got it on {tries} tries");

            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        } while (response == "yes");
    }
}