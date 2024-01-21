using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        Console.WriteLine("The Magic Number is between 1 - 100");

        int guess = 0;
        
        while (guess != magicNumber) {

            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber) {
                Console.WriteLine("Lower");
            } else if (guess < magicNumber) {
                Console.WriteLine("Higher");
            } else {
                Console.WriteLine("You guessed it!");
            }
        }

    }
}