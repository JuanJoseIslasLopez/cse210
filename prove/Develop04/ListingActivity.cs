class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int duration) : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration)
    {
    }

    public override void DisplayStartingMessage()
    {
        base.DisplayStartingMessage();
    }

    public override void DisplayEndingMessage()
    {
        base.DisplayEndingMessage();
    }

    public void Run()
    {
        DisplayStartingMessage();
        Random rnd = new Random();
        string prompt = _prompts[rnd.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        ShowSpinner(2);
        Console.WriteLine("Start listing. Press Enter after each item. Press Enter twice to finish: ");
        int count = 0;
        string item = Console.ReadLine();
        while (!string.IsNullOrWhiteSpace(item))
        {
            count++;
            item = Console.ReadLine();
        }
        Console.WriteLine($"Number of items listed: {count}");
        DisplayEndingMessage();
    }
}