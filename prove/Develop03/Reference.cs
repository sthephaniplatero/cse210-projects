public class Reference
{
    private string _book { get; set; }
    private int _chapter { get; set; }
    private int _verse { get; set; }

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public override string ToString()
    {
        return $"{_book} {_chapter}:{_verse}";
    }
}
