class Swimming : Activity
{
    private int laps;
    private const double LapLengthKm = 50.0 / 1000; // 50 meters per lap in km

    public Swimming(DateTime date, int duration, int laps)
        : base(date, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance() => laps * LapLengthKm;
    public override double GetSpeed() => (GetDistance() / GetDuration()) * 60;
    public override double GetPace() => GetDuration() / GetDistance();
}