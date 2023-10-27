using System;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment me = new WritingAssignment("Liam", "Ancient Religious Literature", "Eusebius");
        Console.WriteLine(me.GetSummary());
        Console.WriteLine(me.GetWritingInformation());
        
    }
}