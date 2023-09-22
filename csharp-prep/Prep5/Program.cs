using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);
    }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your username: ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }
        static int SquareNumber(int userNumber)
        {
            int squareUserNumber = userNumber * userNumber;
            return squareUserNumber;
        }
        static void DisplayResult(string userName, int squareUserNumber)
        {
            Console.WriteLine($"Your name is: {userName}");
            Console.WriteLine($"Your number squared is {squareUserNumber}");
        }
}