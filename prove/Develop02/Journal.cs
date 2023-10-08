using System.Collections;
using System.IO;

public class Journal 
{
    // public class EntryCall
    public string Display()
    {
        Console.WriteLine("Please choose one of the following options");
        Console.WriteLine("1. Create a journal Entry.");
        Console.WriteLine("2. View previous journal entries.");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        string choice = Console.ReadLine();
        return choice;
    }
    public List<Entry> _entry = new List<Entry>();
    public void Entries()
    {
        foreach (Entry entry in _entry)
        {
            entry.Display();
        }
    }
    public string filename;
    public List<Entry> ReadEntries()
    {
        Console.WriteLine("Reading list from file. . .");
        List<Entry> savedEntries = new List<Entry>();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Entry loadedEntry = new Entry();
            loadedEntry._response = parts[0];
            loadedEntry._responseDate = parts[1];
            loadedEntry._responsePrompt = parts[2];
            savedEntries.Add(loadedEntry);
        }
        return savedEntries;
    }
    public void WriteEntries(List<Entry> _entry)
    {
        Console.WriteLine("Saving to file . . .");
        using (StreamWriter outputFile = File.AppendText(filename))
        {
            foreach (Entry entry in _entry)
            {
                outputFile.WriteLine($"{entry._response},{entry._responseDate},{entry._responsePrompt}");
            }
        }
    }
}