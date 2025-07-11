public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        _date = DateTime.Now.ToShortDateString();

        PromptGenerator generator = new PromptGenerator();
        _promptText = generator.GetRandomPrompt();
        Console.WriteLine(_promptText);

        _entryText = Console.ReadLine();
    }
}