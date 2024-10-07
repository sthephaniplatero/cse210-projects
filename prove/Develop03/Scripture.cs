public class Scripture
{
    private Reference _reference { get; set; }
    private List<Word> _words { get; set; }

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (var word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void DisplayScripture()
    {
        Console.Clear();
        Console.WriteLine($"{_reference}: {GetScriptureText()}");
    }

    private string GetScriptureText()
    {
        List<string> wordsText = new List<string>();
        foreach (var word in _words)
        {
            wordsText.Add(word.GetDisplayText());
        }
        return string.Join(" ", wordsText);
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        List<Word> visibleWords = _words.FindAll(word => !word._hidden);

        if (visibleWords.Count > 0)
        {
            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex]._hidden = true;
        }
    }
}
