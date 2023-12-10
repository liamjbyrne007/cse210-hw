using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        int i = 1;

        Video video1 = new Video("How to Prepare Your Rations", "Sgt. Hogryn", 132);
        video1.addComments("McBend", "Thanks for this great tutorial! They still taste terrible, but at least now they look good.");
        video1.addComments("Shlum", "I always love eating me rations. Happy to see someone else loves em.");
        video1.addComments("Mannick", "If that's how you use your rations, then I've got to do some thinking.");
        videos.Add(video1);

        Video video2 = new Video("Top Five Entertainers in Nuln", "Marius Volcus", 435);
        video2.addComments("MassiveMarkus", "This didn't work for me. Each one of them is booked for the next 5 months.");
        video2.addComments("xXCiceroXx", "This isn't funny. I should definitely have the top spot!");
        video2.addComments("DeliciousDante","Thank you so much, I was able to get my son's birthday party worked out.");
        videos.Add(video2);

        Video video3 = new Video("Light The World 2023", "The Church of Jesus Christ", 155);
        video3.addComments("Natalie", "I love this! I always look forward to this every year!");
        video3.addComments("Samson", "I love thinking about Christ during the holidays! This is just one more way to do that!");
        video3.addComments("Sariah", "Thank you for posting this! I really needed it!.");
        video3.addComments("Clement", "It's always refreshing for me when this time of year comes around.");
        videos.Add(video3);

        foreach (Video v in videos)
        {
            Console.WriteLine("\n————————————————————————————————————————————————————————————————————————————————————————————————————————");
            Console.WriteLine($"\nVideo number {i}\n");
            v.writeVideo();
            i++;
        }
    }
}