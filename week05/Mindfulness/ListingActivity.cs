public class ListingActivity : Activity
{
    private int _count = 0;
    private List<String> _prompts = new List<String>();

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[index],"\n");
    }

    public void GetListFromUser()
    {
        List<String> _getList = new List<String>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string answer = Console.ReadLine();
            _getList.Add(answer);
        }

        _count = _getList.Count;
    }

    public void Run()
    {
        GetRandomPrompt();
        GetListFromUser();
        Console.WriteLine($"You wrote {_count} things!\n");
    }
}