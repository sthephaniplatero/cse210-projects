public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description) { }

    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing");

        for (int i = 0; i < _duration; i += 10)
        {
            Console.WriteLine($"Breath in...");
            ShowCountDown(5);
            Console.WriteLine($"Now breath out...");
            ShowCountDown(5);
        }
        
        DisplayEndingMessage();
    }
}
