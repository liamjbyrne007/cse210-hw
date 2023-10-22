using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading.Channels;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the scripture memorization program! ");
        Console.WriteLine("It will generate a scripture that it will help you memorize");
        Console.WriteLine("Click enter to start and continue the program or type 'quit' when you're finished");
        string input = Console.ReadLine();
        Words output = new Words();
        while (input != "quit")
        {
            Console.Clear();
            output.words();
            input = Console.ReadLine();
            if (output.count == output.length)
            {
                input = "quit";
                Console.Clear();
                output.words();
            }
        }
    }
}