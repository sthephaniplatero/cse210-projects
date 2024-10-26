using System;

   public class Program
{
    public static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();

        while (true)
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Display Player Info");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    goalManager.CreateGoal();
                    break;
                case "2":
                    goalManager.ListGoalNames();
                    break;
                case "3":
                    goalManager.RecordEvent();
                    break;
                case "4":
                    goalManager.DisplayPlayerInfo();
                    break;
                case "5":
                    goalManager.SaveGoals();
                    break;
                case "6":
                    goalManager.LoadGoals();
                    break;
                case "7":
                    Console.WriteLine("Exiting the program.");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
