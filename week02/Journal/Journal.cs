using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry display in _entries)
        {
            Console.WriteLine("");
            Console.WriteLine(display._date);
            Console.WriteLine(display._promptText);
            Console.WriteLine(display._entryText);
            Console.WriteLine("");
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry._date);
                outputFile.WriteLine(entry._promptText);
                outputFile.WriteLine(entry._entryText);
                outputFile.WriteLine("");
            }
        }
        Console.WriteLine("Your file was save");
    }

    public void LoadToFile(string file)
    {
    if (File.Exists(file))
    {
        _entries.Clear();

        string[] lines = System.IO.File.ReadAllLines(file);

        for (int i = 0; i < lines.Length; i += 4)
        {
            Entry entry = new Entry();
            entry._date = lines[i];
            entry._promptText = lines[i + 1];
            entry._entryText = lines[i + 2];
            _entries.Add(entry);
        }

        Console.WriteLine("File loaded.");
    }
    else
    {
        Console.WriteLine("The file don't exist.");
    }
    }

}