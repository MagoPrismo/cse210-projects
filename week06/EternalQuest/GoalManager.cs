using System.IO;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Selec an option from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    DisplayPlayerInfo();
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
                    return;
                default:
                    Console.WriteLine("Invalid choice, try again a valid number!");
                    break;

            }
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Select one type for your goal: ");

        string goal = Console.ReadLine();

        Console.Write("What's the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What's a short description? ");
        string description = Console.ReadLine();
        Console.Write("What's the amount of points associated with this goal? ");
        int point = int.Parse(Console.ReadLine());

        switch (goal)
        {
            case "1":
                SimpleGoal sGoal = new SimpleGoal(name, description, point);
                _goals.Add(sGoal);
                break;
            case "2":
                EternalGoal eGoal = new EternalGoal(name, description, point);
                _goals.Add(eGoal);
                break;
            case "3":
                Console.Write("What's the target for this goal? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What's the bonus associated with this goal? ");
                int bonus = int.Parse(Console.ReadLine());
                ChecklistGoal cGoal = new ChecklistGoal(name, description, point, target, bonus);
                _goals.Add(cGoal);
                break;
            default:
                Console.WriteLine("Invalid choice, try again a valid number!");
                break;

        }
        Console.WriteLine("\nYour goal has been created!\n");
    }

    public void ListGoalNames()
    {
        int c = 1;

        foreach (var i in _goals)
        {
            Console.WriteLine($"{c}. {i.GetName()}");
            c++;
        }
    }

    public void ListGoalDetails()
    {
        foreach (var i in _goals)
        {
            Console.WriteLine(i.GetDetailsString());
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYour current score is: {_score}");
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("What goal did you complete? ");
        int index = int.Parse(Console.ReadLine());

        _goals[index - 1].RecordEvent();
        _score += _goals[index - 1].GetPoints();
    }

    public void SaveGoals()
    {
        Console.Write("What's the name of your file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine(_score);

            // You can use the $ and include variables just like with Console.WriteLine
            foreach (var i in _goals)
            {
                outputFile.WriteLine(i.GetStringRepresentation());

            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What's the name of your file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            String[] parts = line.Split(",");
            if (parts.Count() <= 1)
            {
                _score = int.Parse(parts[0]);
            }
            else if (parts.Count() == 3)
            {
                EternalGoal eGoall = new EternalGoal(parts[0], parts[1], int.Parse(parts[2]));
                _goals.Add(eGoall);
            }
            else if (parts.Count() == 4)
            {
                SimpleGoal sGoall = new SimpleGoal(parts[0], parts[1], int.Parse(parts[2]));
                sGoall.SetComplete(bool.Parse(parts[3]));
                _goals.Add(sGoall);
            }
            else if (parts.Count() == 7)
            {
                ChecklistGoal cGoall = new ChecklistGoal(parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]));
                cGoall.SetComplete(bool.Parse(parts[5]));
                cGoall.SetAmount(int.Parse(parts[6]));
                _goals.Add(cGoall);
            }

        }
    }
}