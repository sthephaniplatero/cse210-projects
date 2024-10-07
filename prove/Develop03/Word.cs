public class Word
{
    public string Text { get; set; }
    public bool IsHidden { get; set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public string GetDisplayText()
    {
        return IsHidden ? "____" : Text;
    }
}
