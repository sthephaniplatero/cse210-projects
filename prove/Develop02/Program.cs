// Journal Project
//Sthephani Yamileth Platero
// To exceed requirements I add an option to save and store the mood of the user.



using System;

    public class Program
    {
        static void Main(string[] args)
        {
            Journal myJournal = new Journal();
            PromptGenerator newPromptGenerator = new PromptGenerator();
            bool running = true;

            while (running)
            {
                Console.WriteLine("--------Welcome to Your Diary---------");
                Console.WriteLine("Please select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save ");
                Console.WriteLine("5. Exit");
                Console. Write("What would you like to do? ");

                string number = Console.ReadLine();

                switch (number)
                {
                    case "1":
                        string prompt = newPromptGenerator.GetRandomPrompt();
                        Console.WriteLine($"Prompt: {prompt}");
                        Console.Write("Write your entry: ");
                        string content = Console.ReadLine();
                        Console.WriteLine("How do you feel today:");
                        Console.WriteLine("1. Happy");
                        Console.WriteLine("2. Sad");
                        Console.WriteLine("3. Excited");
                        Console.WriteLine("4. Anxious");
                        Console.WriteLine("5. Relaxed");
                        Console.Write("Enter the number corresponding to your mood: ");
                        string moodOption = Console.ReadLine();
                        string mood = moodOption switch
                        {
                            "1" => "Happy",
                            "2" => "Sad",
                            "3" => "Excited",
                            "4" => "Anxious",
                            "5" => "Relaxed",
                            _ => "Unknown"
                        };
                        myJournal.AddEntry(new Entry(DateTime.Now, mood, prompt, content));
                        break;

                    case "2":
                        myJournal.DisplayAll();
                        break;

                    case "3":
                        Console.Write("Enter file path to load (e.g., journal.txt): ");
                        string loadPath = Console.ReadLine();
                        myJournal.LoadFromFile(loadPath);
                        break;

                    case "4":

                        Console.Write("Enter file path to save (e.g., journal.txt): ");
                        string savePath = Console.ReadLine();
                        myJournal.SaveToFile(savePath);
                        break;

                    case "5":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
    }

