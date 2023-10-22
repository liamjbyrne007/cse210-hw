using System.Runtime.Intrinsics.Arm;

public class Words
{
    private double chance = 0;
    private int scriptureIndex;
    private List<string> _scriptureList;
    private double accumulate = 0;
    public int length = 0;
    public int count = 0;
    private int randomIndex()
    {
        Random rndScrpt = new Random();
        return rndScrpt.Next(0, 5);
    }
    public Words()
    {
        scriptureIndex = randomIndex();
        _scriptureList = new List<string>();
        Scripture scripture1 = new Scripture();
        string scripture = scripture1.getScripture(scriptureIndex);
        string[] words = scripture.Split(" ");
        _scriptureList.AddRange(words);

    }
    public void words()
    {
        Reference reference1 = new Reference();
        string reference = reference1.getReference(scriptureIndex);
        Console.WriteLine(reference);
        Random rnd = new Random();
        length = _scriptureList.Count;
        for (int i = 0; i < _scriptureList.Count; i++)
        {
            string word = _scriptureList[i];
            chance = rnd.NextDouble() + accumulate;
            int len = word.Length;
            if (chance >= 0.9 && !word.Contains("_"))
            {
                string blank = new string('_', len);
                _scriptureList[i] = blank;
                count += 1;
            }
            Console.Write($"{word} ");
        }
        accumulate += 0.1;
        Console.WriteLine();
    }
}