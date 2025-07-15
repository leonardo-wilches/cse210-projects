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
        "Did you solve any problem today?",
        "What challenged you today, and how did you handle it?",
        "What is something you wish you had done differently today?",
        "What is one small victory you achieved today?",
        "Did you help someone today? How did it feel?",
        "What inspired you today?",
        "What did you do for yourself today?",
        "Did anything surprise you today? Why was it unexpected?",
        "What is one thing you learned about yourself today?"
    };

    public Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}