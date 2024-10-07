public class Word
{
    private string _text { get; set; }
    public bool _hidden { get; set; }

    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }

    public string GetDisplayText()
    {
        return _hidden ? "___" : _text;
    }
}
