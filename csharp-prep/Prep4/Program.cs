using System;

class Program
{
    static void Main(string[] args)
    {
        int number = -1;
        int total = 0;
        int maximum = 0;
        int amount = 0;
        List<int> numbers = new List<int>();
        Console.WriteLine("Input a list of numbers. 0 will end the list.");
        while (number != 0)
        {
            Console.Write("What is your number? ");
            string input = Console.ReadLine();
            number = int.Parse(input);
            if (number != 0)
            {
                numbers.Add(number);
                total += number;
                amount += 1;
                if (number > maximum)
                {
                    maximum = number;
                }
            }
        }

        Console.WriteLine($"The sum of the list is {total}.");
        Console.WriteLine($"The largest number was {maximum}.");
        int average = total / amount;
        Console.WriteLine($"The average number is {average}.");
    }
}