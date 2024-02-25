class ScriptureReference
{
    public string Book { get; private set; }
    public int Chapter { get; private set; }
    public int VerseStart { get; private set; }
    public int VerseEnd { get; private set; }

    public ScriptureReference(string reference)
    {
        string[] parts = reference.Split(':');
        Book = parts[0];
        string[] verseParts = parts[1].Split('-');
        Chapter = int.Parse(verseParts[0]);
        VerseStart = int.Parse(verseParts[1]);
        VerseEnd = verseParts.Length > 1 ? int.Parse(verseParts[1]) : VerseStart;
    }

    public override string ToString()
    {
        return $"{Book} {Chapter}:{VerseStart}-{VerseEnd}";
    }
}
