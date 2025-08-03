public class RefletingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public RefletingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get Ready...");
        Console.WriteLine("\nConsider the following prompt:");

        Console.WriteLine("");
        DisplayPrompt();

        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            ShowSpinner(5);
            Console.WriteLine("");
        }

        DisplayEndingMessage();
        ShowSpinner(5);

        Console.Clear();
    }

    public string GetRandomPrompt()
    {
        _prompts = new List<string>();
        _prompts.Add("--- Think of a time when you stood up for someone else. ---");
        _prompts.Add("--- Think of a time when you did something really difficult. ---");
        _prompts.Add("--- Think of a time when you helped someone in need. ---");
        _prompts.Add("--- Think of a time when you did something truly selfless. ---");

        Random random = new Random();
        int i = random.Next(_prompts.Count);

        string selectedPrompt = _prompts[i];

        return selectedPrompt;
    }

    public string GetRandomQuestion()
    {
        _questions = new List<string>();
        _questions.Add("> Why was this experience meaningful to you? ");
        _questions.Add("> Have you ever done anything like this before? ");
        _questions.Add("> How did you get started? ");
        _questions.Add("> How did you feel when it was complete? ");
        _questions.Add("> What made this time different than other times when you were not as successful? ");
        _questions.Add("> What is your favorite thing about this experience? ");
        _questions.Add("> What could you learn from this experience that applies to other situations? ");
        _questions.Add("> What did you learn about yourself through this experience? ");
        _questions.Add("> How can you keep this experience in mind in the future? ");

        Random random = new Random();
        int i = random.Next(_questions.Count);

        string selectedQuestion = _questions[i];

        return selectedQuestion;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestion()
    {
        Console.Write(GetRandomQuestion());
    }
}