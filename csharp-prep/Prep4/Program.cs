using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = -1;

        while (number != 0 )
        {
            Console.Write("Enter number: ");
            string newNumber = Console.ReadLine();
            number = int.Parse(newNumber);


            if (number != 0)

            {
                numbers.Add(number);       
            }

        }
  

    //Compute the sum
    int sum = 0;
    foreach (int i in numbers)
    {
        sum += i;
    }

    Console.WriteLine($"The sum is {sum}");


    //Compute the avarege

    float avarage = ((float)sum)/numbers.Count;
    Console.WriteLine($"The avarage is: {avarage}");

    //Compute max

    int largestNumber = numbers.Max();

    Console.WriteLine($"The largest number is:{largestNumber}");

    // Sort the list in ascending order
    numbers.Sort();

    //Find the positive smallest number
    int smallest = numbers.Where(n => n > 0).Min();
    Console.WriteLine($"The smallest positive number is:{smallest}");
    

    // Display the sorted list
    Console.WriteLine("The sorted list is: ");
    foreach (int i in numbers)
    {
        Console.WriteLine(i);
    }
    







    }
}