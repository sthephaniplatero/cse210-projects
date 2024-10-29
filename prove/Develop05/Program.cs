using System;
using System.Collections.Generic;
using System.Threading;

public class Program
{
    public static void Main()
    {
        while (true) 
        {
            Console.WriteLine("Welcome to the Mindfulness App!");
            Console.WriteLine("Please choose an activity:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listening Activity");
            Console.WriteLine("4. Quit"); 

            Console.Write("Enter your choice (1, 2, 3, or 4): ");
            int choice;

            // Input validation for choice
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
            {
                Console.Write("Invalid input. Please enter 1, 2, 3, or 4: ");
            }

            if (choice == 4) 
            {
                Console.WriteLine("Thank you for using the Mindfulness App. Goodbye!");
                return; // Exit the program instead of using break
            }

            Activity activity = null;

            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing");
                    break;
                case 2:
                    activity = new ReflectingActivity();
                    break;
                case 3:
                    activity = new ListeningActivity();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    continue; 
            }

            
            activity.SetDuration(30); 

            try
            {
                activity.Run(); 
                Console.WriteLine("Thank you for participating in the activity!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while running the activity: " + ex.Message);
            }
        }
    }
}