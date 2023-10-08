using System;
using System.ComponentModel.Design;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program.");
        Journal j = new Journal();
        string choice = "";
        while (choice != "5")
        {
            choice = j.Display();
            if (choice == "1")
            {
                Prompts p = new Prompts();
                string randomPrompt = p.Prompt();
                Console.WriteLine(randomPrompt);
                string response = Console.ReadLine();
                Entry e = new Entry();
                string date = e.Date();
                e._responseDate = date;
                e._response = response;
                e._responsePrompt = randomPrompt;
                j._entry.Add(e);
            }
            if (choice == "2")
            {
                j.Entries();
            }
            if (choice == "3")
            {
                Console.Write("What file would you like to load from? ");
                j.filename = Console.ReadLine();
                List<Entry> loadedEntries = j.ReadEntries();
                foreach (Entry l in loadedEntries)
                {
                    j._entry.Add(l);
                }
            }
            if (choice == "4")
            {
                Console.Write("What file would you like to save to? ");
                j.filename = Console.ReadLine();
                j.WriteEntries(j._entry);
            }
            if (choice != "1" || choice != "2" || choice != "3" || choice != "4" || choice != "5")
            {
                Console.WriteLine("Invalid input, please input a proper option.");
            } 
        }
    }
}