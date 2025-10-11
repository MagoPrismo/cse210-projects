public class Activity
{
    protected string _name = "";
    protected string _description = "";
    protected int _duration = 0;
    private List<String> _listSpinner = new List<String>();

    public Activity()
    {
        _listSpinner.Add("|");
        _listSpinner.Add("/");
        _listSpinner.Add("-");
        _listSpinner.Add("\\");
        _listSpinner.Add("|");
        _listSpinner.Add("/");
        _listSpinner.Add("-");
        _listSpinner.Add("\\");
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity\n");
        Console.WriteLine(_description);
        Console.WriteLine("\nHow long, in seconds, would you like for your session? ");

        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well Done!");
        Thread.Sleep(1500);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity!\n");
        Console.WriteLine("Press Enter to access the Menu");
        Console.ReadLine();
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = _listSpinner[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;

            if (i >= _listSpinner.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = seconds;

        while (DateTime.Now < endTime)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i--;
        }
    }

    public void GetReady()
    {
        Console.WriteLine($"\nGet Ready...\n");
        ShowSpinner(5);
    }
}