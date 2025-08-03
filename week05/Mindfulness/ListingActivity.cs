public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);

        Console.WriteLine("\nList as many responses you can to the following prompt:");
        GetRandomPrompt();

        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        List<string> entries = GetListFromUser();
        _count = entries.Count;
        Console.WriteLine($"\nYou listed {_count} items!");

        DisplayEndingMessage();
        ShowSpinner(5);

        Console.Clear();
    }

    public void GetRandomPrompt()
    {
        _prompts = new List<string>();
        _prompts.Add("--- Who are people that you appreciate? ---");
        _prompts.Add("--- What are personal strengths of yours? ---");
        _prompts.Add("--- Who are people that you have helped this week? ---");
        _prompts.Add("--- When have you felt the Holy Ghost this month? ---");
        _prompts.Add("--- Who are some of your personal heroes? ---");

        Random random = new Random();
        int i = random.Next(_prompts.Count);

        string selectedPrompt = _prompts[i];

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

            if (DateTime.Now >= endTime)
            {
                break;
            }
        }

        return userList;
    }   
}