using System;

class Program
{
    static void Main(string[] args)
    {   
        //Ask the user the user his name
        Console.Write("What's your first name? ");
        string name =Console.ReadLine();


        //Ask the user the user his name
        Console.Write("What's your lastname? ");
        string lastname =Console.ReadLine();

        // Print the outputs
        Console.WriteLine($"Your name is {lastname}, {name} {lastname}.");

    }
}