class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "What did you learn from this experience?"
    };

    public ReflectingActivity() : base("Reflection Exercise", "This activity helps you reflect on your past strengths.") { }

    protected override void Run()
    {
        Random rnd = new Random();
        Console.WriteLine(_prompts[rnd.Next(_prompts.Count)]);
        ShowSpinner(3);
        int timeLeft = _duration;
        while (timeLeft > 0)
        {
            Console.WriteLine(_questions[rnd.Next(_questions.Count)]);
            ShowCountdown(5);
            timeLeft -= 5;
        }
    }
}
