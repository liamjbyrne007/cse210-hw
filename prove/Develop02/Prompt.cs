using Microsoft.VisualBasic;

public class Prompts
{
    static Random random = new Random();
    public List<string> PromptList = new List<string>
    {
        "What did you eat for lunch today?",
        "What is one song you listened to today? How did you like it?",
        "What is something new that you learned today?",
        "How have you improved yourself today?",
        "How did you serve someone today? Or how did someone serve you?",
        "What have you done to fulfill a goal today?",
        "What did you learn from you scripture study today?",
        "How did you see the hand of the Lord in your life today?"
    };
    public string Prompt()
    {
    int _randomPrompt = random.Next(PromptList.Count);
    return PromptList[_randomPrompt];
    }
}