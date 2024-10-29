public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random;

    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strengh and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you overcame a challenge.",
            "Remember a moment you felt truly happy.",
            "Consider a time you learned something valuable from failure."
        };

        _questions = new List<string>
        {
            "Why do you think that experience impacted you so deeply?",
            "What did you learn from that moment?",
            "How can you apply what you learned to your current life?"
        };

        _random = new Random();
    }

    public override void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        ShowSpinner(10);
        DisplayQuestions();
        ShowSpinner(10);
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        int index = _random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine("Prompt: " + GetRandomPrompt());

    }

    public void DisplayQuestions()
    {
        Console.WriteLine("Reflect on the following questions:");
        foreach (var question in _questions)
        {
            Console.WriteLine("- " + question);
        }
    }
}