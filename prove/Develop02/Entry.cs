using System;

public class Entry
{
    public DateTime _date{ get; set; }
     public string _mood{get; set;}
    public string _prompt{ get; set; }

    public string _content{get; set;}

    public Entry(DateTime date, string prompt, string content, string mood)
    {
        _date = date;
        _prompt = prompt;
        _content = content;
        _mood = mood;
    } 

    public override string ToString()
    {
        return $"Date:{_date.ToShortDateString()} -Mood:{_mood} -Prompt: {_prompt} - Content: {_content}";
    }
}
