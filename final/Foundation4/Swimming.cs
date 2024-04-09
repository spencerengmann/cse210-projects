class Swimming : Activity
{
    private int laps;
    private int minutes;
    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        this.laps = laps;
        this.minutes = minutes;
    }
    public override double GetDistance()
    {
        return (laps * 50.0 / 1000) ;
    }
    public override double GetSpeed()
    {
        return GetDistance() / (double)minutes * 60;
    }
    public override double GetPace()
    {
        return GetDistance() / (double)minutes * 60;
    }
}