public class ListeningActivity : Activity
{
    private List<string> _prompts;
    private Random _random;

    public ListeningActivity() : base("Listening", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area .")
    {
        _prompts = new List<string>
        {
            "Listen carefully and recall a moment when someone shared a valuable life lesson with you.",
            "Think of a time someone told you something that changed your perspective.",
            "Reflect on a conversation that had a lasting impact on you."
        };
        _random = new Random();
    }

    public override void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        List<string> responses = GetFromUser();
        DisplayResponses(responses);
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetFromUser()
    {
        List<string> responses = new List<string>();
        
        Console.WriteLine("Enter your thoughts (type 'exit' to finish):");
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "exit") break;
            responses.Add(input);
        }

        return responses;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Prompt: " + GetRandomPrompt());
    }

    public void DisplayResponses(List<string> responses)
    {
        Console.WriteLine("Your Responses:");
        foreach (var response in responses)
        {
            Console.WriteLine("- " + response);
        }
    }
}