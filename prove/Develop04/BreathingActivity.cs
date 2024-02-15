class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base("Breathing", "", duration)
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
        ShowSpinner(_duration);
        Console.WriteLine($"Breathe in...");
        ShowCountdown(_duration);
        Console.WriteLine("Breathe out...");
        ShowCountdown(_duration);
        DisplayEndingMessage();
    }
}