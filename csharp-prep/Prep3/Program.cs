using System;

class Program
{
    static void Main(string[] args)
    {
        /* Console.WriteLine("What is the magic number: ");
        string magicNumber = Console.ReadLine();
        int magicNumberInt = int.Parse(magicNumber); */

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int userGuess = 0;
        // I need this variable for the while loop
        int attemps = 1;
        // I use this variable to track the quantity of attemps
        
        while(userGuess != magicNumber)
        {
            Console.WriteLine("Guess the magic number: ");
            userGuess = int.Parse(Console.ReadLine());

            if (magicNumber > userGuess)
            {
                Console.WriteLine("Higher");
                attemps++;
            }
            else if (magicNumber < userGuess)
            {
                Console.WriteLine("Lower");
                attemps++;
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"You used {attemps} attemps for this game.");
            }

        }
        
    }
}