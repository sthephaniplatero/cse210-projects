public class BreathingActivity : Activity
{

    public BreathingActivity(string name, string description): base(name,description)
    {
    }

    public void Run()
    {
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
        
        for (int i = 1 ; i < _duration; i+=10){
            Console.WriteLine($"Breath in...");
            ShowCountDown(5);

            Console.WriteLine($"Now breath in...");
            ShowCountDown(5);
        }  
        DisplayEndingMessage();     
    }
     
}