public class Reference
{
    private string Book { get; set; }
    private int Chapter { get; set; }
    private int Verse { get; set; }

    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
    }

    public override string ToString()
    {
        return $"{Book} {Chapter}:{Verse}";
    }
}
