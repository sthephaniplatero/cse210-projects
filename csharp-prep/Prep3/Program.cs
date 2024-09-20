using System;

class Program
{
    static void Main(string[] args)
    {   // Add ramdon generator
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int guess = -1;

        while (guess != magicNumber )
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

             if (guess > magicNumber)

        {
           Console.WriteLine("Lower"); 
        }

        else if (guess < magicNumber)

        {
           Console.WriteLine("Higher"); 
        }

        else
        {
            Console.WriteLine("You guess it!"); 
           
        }


        

        }


       


       

    }
}