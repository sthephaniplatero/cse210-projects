public class Program
{
    private static Scripture scripture;
    private static Timer timer;

    public static void Main()
    {
        Reference reference1 = new Reference("John", 3,16);
        scripture = new Scripture(reference1,"For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        scripture.DisplayScripture();

        timer = new Timer(HideWordCallback, null, 10000, 10000);


        Console.WriteLine("Press 'Enter' to stop the timer and stop the program");
        Console.ReadLine();

        timer.Dispose();
    }

    private static void HideWordCallback(object state)
    {
        scripture.HideRandomWord();
        scripture.DisplayScripture();
    }
}