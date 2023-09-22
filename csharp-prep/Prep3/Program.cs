using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        int i = -1;
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1,100);
        while (i != randomNumber)
        {
            Console.Write("What is your guess? ");
            i = int.Parse(Console.ReadLine());

            if (randomNumber > i)
            {
                Console.WriteLine("Too low, guess higher.");
            }
            if (randomNumber < i)
            {
                Console.WriteLine("Too high, guess lower.");
            }
        }
        Console.WriteLine($"Good job, you got it, the number was {randomNumber}.");
    }
}