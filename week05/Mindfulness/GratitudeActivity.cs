public class GratitudeActivity : Activity
{
    private int _count;
    private List<string> _blessingPrompts;

    public GratitudeActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _blessingPrompts = new List<string>
        {
            "--- What are you thankful for today? ---",
            "--- What talents are you grateful for? ---",
            "--- What blessings have you received today? ---",
            "--- What things are you thankful for this year? ---",
            "--- What things are you grateful for in your life? ---",
            "--- What people in your life are you grateful for? ---",
            "--- What blessings of the Gospel have you received in your life? ---",
            "--- What are you thankful for now? ---"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);

        Console.WriteLine("\nList as many blessings you can to the following prompt:");
        GetRandomPrompt();

        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        List<string> entries = GetListFromUser();
        _count = entries.Count;
        Console.WriteLine($"\nYou listed {_count} blessings!");

        DisplayEndingMessage();
        ShowSpinner(5);

        Console.Clear();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int i = random.Next(_blessingPrompts.Count);
        string selectedPrompt = _blessingPrompts[i];
        Console.WriteLine(selectedPrompt);
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (true)
        {
            if (DateTime.Now >= endTime)
            {
                break;
            }

            Console.Write("> ");
            string entry = Console.ReadLine();

            userList.Add(entry);
        }

        return userList;
    }   
}