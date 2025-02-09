class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "List people that you appreciate.",
        "List your personal strengths.",
        "List people you have helped this week.",
        "List times you felt peaceful recently."
    };

    public ListingActivity() : base("Listing Exercise", "This activity helps you list positive aspects of your life.") { }

    protected override void Run()
    {
        Random rnd = new Random();
        Console.WriteLine(_prompts[rnd.Next(_prompts.Count)]);
        ShowCountdown(3);
        List<string> items = new List<string>();
        int timeLeft = _duration;
        while (timeLeft > 0)
        {
            Console.Write("Enter an item: ");
            items.Add(Console.ReadLine());
            timeLeft -= 3;
        }
        Console.WriteLine($"You listed {items.Count} items!");
        Console.WriteLine("Well done!");
    }
}
