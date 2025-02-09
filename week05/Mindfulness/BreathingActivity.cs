class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Exercise", "This activity helps you relax by guiding your breathing.") { }

    protected override void Run()
    {
        int timeLeft = _duration;
        while (timeLeft > 0)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);
            timeLeft -= 3;
            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
            timeLeft -= 3;
        }
    }
}