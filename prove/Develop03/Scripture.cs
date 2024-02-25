public class Scripture
{
    private List<Word> words;

    public string Reference { get; private set; }

    public Scripture(string reference, string text)
    {
        Reference = reference;
        words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void Display()
    {
        Console.WriteLine($"Reference: {Reference}");
        foreach (var word in words)
        {
            Console.Write($"{word.Display()} ");
        }
        Console.WriteLine();
    }

    public void HideRandomWords()
    {
        Random rnd = new Random();
        int numToHide = rnd.Next(1, words.Count(w => !w.Hidden)); // Choose number of words to hide
        int wordsHidden = 0;
        while (wordsHidden < numToHide)
        {
            int index = rnd.Next(words.Count);
            if (!words[index].Hidden)
            {
                words[index].Hidden = true;
                wordsHidden++;
            }
        }
    }

    public bool AllWordsHidden()
    {
        return words.All(w => w.Hidden);
    }
}
