public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        string choice = null;

        do
        {
            DisplayPlayerInfo();

            if (_score >= 1000)
            {
                Levels();
            }

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");

            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("\nThanks for playing Eternal Quest!"); ;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        } while (choice != "6");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.");
    }

    public void ListGoalNames()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("There are no goals yet.");
            return;
        }

        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].Names}");
        }
    }

    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("There are no goals yet");
            return;
        }
        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        string goalChoice = null;

        do
        {
            Console.WriteLine("\nThe types of Goals are:");
            Console.WriteLine(" 1. Simple Goal");
            Console.WriteLine(" 2. Eternal Goal");
            Console.WriteLine(" 3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            goalChoice = Console.ReadLine();

            if (goalChoice != "1" && goalChoice != "2" && goalChoice != "3")
            {
                Console.WriteLine("Invalid option.");
            }

        } while (goalChoice != "1" && goalChoice != "2" && goalChoice != "3");

        Console.Write("\nWhat is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (goalChoice)
        {
            case "1":
                _goals.Add(new SimpleGoal(false, name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, description, points, 0, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("There are no goals yet.");
            return;
        }

        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        string recordChoice = Console.ReadLine();

        if (int.TryParse(recordChoice, out int goalIndex) && goalIndex >= 1 && goalIndex <= _goals.Count)
        {
            Goal g = _goals[goalIndex - 1];

            int pointsEarned = g.RecordEvent();

            _score += pointsEarned;
        }

        Console.WriteLine($"You now have {_score} points.");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _goals.Clear();

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(':');
            string type = parts[0];
            string data = parts[1];

            switch (type)
            {
                case "SimpleGoal":
                    var sgParts = data.Split(',');
                    bool isComplete = bool.Parse(sgParts[3]);
                    _goals.Add(new SimpleGoal(isComplete, sgParts[0], sgParts[1], int.Parse(sgParts[2])));
                    break;

                case "EternalGoal":
                    var egParts = data.Split(',');
                    _goals.Add(new EternalGoal(egParts[0], egParts[1], int.Parse(egParts[2])));
                    break;

                case "ChecklistGoal":
                    var cgParts = data.Split(',');
                    int amountCompleted = int.Parse(cgParts[3]);
                    int target = int.Parse(cgParts[4]);
                    int bonus = int.Parse(cgParts[5]);
                    _goals.Add(new ChecklistGoal(cgParts[0], cgParts[1], int.Parse(cgParts[2]), amountCompleted, target, bonus));
                    break;

                default:
                    Console.WriteLine($"Unknown goal type: {type}");
                    break;
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }

    public void Levels()
    {
        if (_score >= 1000 && _score < 2000)
        {
            Console.WriteLine("Congratulations, you are Iron level!");
        }
        else if (_score >= 2000 && _score < 3000)
        {
            Console.WriteLine("Congratulations, you are Copper level!");
        }
        else if (_score >= 3000 && _score < 4000)
        {
            Console.WriteLine("Congratulations, you are Bronze level!");
        }
        else if (_score >= 4000 && _score < 5000)
        {
            Console.WriteLine("Congratulations, you are Silver level!");
        }
        else if (_score >= 5000 && _score < 6000)
        {
            Console.WriteLine("Congratulations, you are Steel level!");
        }
        else if (_score >= 6000 && _score < 7000)
        {
            Console.WriteLine("Congratulations, you are Gold level!");
        }
        else if (_score >= 7000 && _score < 8000)
        {
            Console.WriteLine("Congratulations, you are Platinum level!");
        }
        else if (_score >= 8000 && _score < 9000)
        {
            Console.WriteLine("Congratulations, you are Sapphire level!");
        }
        else if (_score >= 9000 && _score < 10000)
        {
            Console.WriteLine("Congratulations, you are Ruby level!");
        }
        else if (_score >= 10000)
        {
            Console.WriteLine("Congratulations, you are Diamond level!");
        }
    }
}