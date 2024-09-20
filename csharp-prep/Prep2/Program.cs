using System;

class Program
{
    static void Main(string[] args)
    {   // Ask the user for the percentage
        Console.Write("Please type your grade percentage: ");
        string valueFromUser = Console.ReadLine();
        int grade = int.Parse(valueFromUser);

        //Create the variable letter to be use in the staments 
        string letter = "";
        
        
        if (grade >= 90)
        {
            letter = "A";
        
        }
        else if (grade >= 80)
         {
            letter = "B";
        
        }
          else if (grade >= 70)
         {
            letter = "C";
        
        }
          else if (grade >= 60)
         {
            letter = "D";
        
        }
        else
        {
            letter = "F";
        
        }
        // Print the grades
        Console.WriteLine($"Your grade is : {letter}");
        
        // Verify is the student pass the curse with 70
        if (grade >= 70)
         {
            Console.WriteLine("Congratulation you pass the course");
        
        }
        else
        {
            Console.WriteLine("You did not pass the course, You can try next semester.");
        
        }



    }
}