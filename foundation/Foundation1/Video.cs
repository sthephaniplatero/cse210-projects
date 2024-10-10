using System;

class Video
{
    public string _title{get; set;}
    public string _author{get; set;}
    public int _lengthSecond{get; set;}
    public List<Comment>_comments = new List<Comment>();

    public void DisplayResult()
    {
        Console.WriteLine($"Title: {_title} - Author:{_author} - Length:{_lengthSecond}");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }

    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to return the number of comments
    public int GetCommentCount()
    {
        return _comments.Count;
    }


}