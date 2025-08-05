public class RelaxingActivity : Activity
{
    public RelaxingActivity(string name, string description, int duration) : base(name, description, duration)
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
            Console.Write("\nRaise your arms and stretch them...");
            ShowCountDown(5);
            Console.Write("\nGently lower them sideways...");
            ShowCountDown(5);
            Console.WriteLine("");
            Console.Write("\nTilt your head to the right...");
            ShowCountDown(5);
            Console.Write("\nTilt your head to the left...");
            ShowCountDown(5);
            Console.WriteLine("");
        }

        DisplayEndingMessage();
        ShowSpinner(5);

        Console.Clear();
    }
}