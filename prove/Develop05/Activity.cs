public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;

    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nWelcome to the {_name}");
        Console.WriteLine(_description);
        Console.WriteLine("How long, in seconds, would you like for your session?");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready");
        Thread.Sleep(5000);



    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("You have done a good job!");
        ShowSpinner(5);
        Thread.Sleep(5000);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity");
        ShowSpinner(5);
        Thread.Sleep(5000);

    }
    public void ShowSpinner(int seconds)
    {
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        foreach (string s in animationString)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
       

    }

    public void ShowCountDown(int seconds)
    {
        for (int i = 5; i>0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }

    }
}