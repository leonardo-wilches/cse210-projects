public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What was the best part of your day?",
        "What did you learn today?",
        "How did you feel today and why?",
        "What are you grateful for?",
        "Describe a moment that made you smile.",
        "Did you meet anyone today?",
        "Did you solve any problem today?"
    };

    public Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}