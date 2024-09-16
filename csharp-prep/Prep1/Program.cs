using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What's your firstname? ");
        string name =Console.ReadLine();
        Console.Write("What's your lastname? ");
        string lastname =Console.ReadLine();
        Console.WriteLine($"Your name is {lastname}, {name} {lastname}.");

    }
}