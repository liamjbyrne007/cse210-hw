using System;

class Program
{
    static void Main(string[] args)
    {
        // First event: Lecture
        Address a = new Address();
        a.setAddress("2534 W Imperial Blvd", "Room 7", "Altdorf", "25673", "Reikland");
        string address = a.address();
        Lecture l = new Lecture();
        l.setdetails("Lecture", "The Myth of the Skaven", "Learn all about how there are no Skaven, never have been, and never will be!", "5/6/2519", "7:30 PM", address);
        l.setLecture("Balthasar Gelt", 250);
        l.standardDetails();
        Console.WriteLine();
        l.fullDetails();
        Console.WriteLine();
        l.shortDetails();
        Console.WriteLine();

        // Second Event: Outdoor Gathering
        Address b = new Address();
        b.setAddress("S 2nd W & 3rd W", "", "Rexbur", "83440", "ID");
        string outdoorAddress = b.address();
        Gathering g = new Gathering();
        g.setdetails("Outdoor Gathering", "Ward Barbecue", "Come join the ward for our annual outdoor Chritmas barbecue!", "12/17/2023", "6:00 PM", outdoorAddress);
        g.setWeather("Cold");
        g.standardDetails();
        Console.WriteLine();
        g.fullDetails();
        Console.WriteLine();
        g.shortDetails();
        Console.WriteLine();

        // Third Event: Reception
        Address c = new Address();
        c.setAddress("133 Joshua St", "Suite 3", "Wicklow", "A67", "Ireland");
        string venueAddress = c.address();
        Reception r = new Reception();
        r.setdetails("Reception", "Lobster Contest", "Come and compete to see who can eat the most lobster!", "17/12/2023", "18:00", venueAddress);
        r.setReception("+353-254-234-7849", 3, "The Black Castle");
        r.standardDetails();
        Console.WriteLine();
        r.fullDetails();
        Console.WriteLine();
        r.shortDetails();
        Console.WriteLine();
    }
}