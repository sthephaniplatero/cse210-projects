using System;
using System.Runtime.CompilerServices;

class Comment
{
    public string _name{get; set;}
    public string _text{get; set;}

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;

    }


    public void DisplayComment()
    {
        Console.WriteLine($"{_name}: {_text}");
        

    }
}


