using System;

public class Entry
{
    public DateTime _date{ get; set; }
     public string _mood{get; set;}
    public string _prompt{ get; set; }

    public string _content{get; set;}

    public Entry(DateTime date, string mood, string prompt, string content)
    {
        _date = date;
        _prompt = prompt;
        _content = content;
        _mood = mood;
    } 

    public override string ToString()
    {
        return $"Date:{_date.ToShortDateString()} -Mood:{_prompt} -Prompt: {_prompt} - Content: {_content}";
    }
}