public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreath in...");
            ShowCountDown(4);
            Console.Write("\nBreath out...");
            ShowCountDown(6);
            Console.WriteLine("");
        }

        DisplayEndingMessage();
        ShowSpinner(5);

        Console.Clear();
    }
}