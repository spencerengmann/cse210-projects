class Running : Activity
{
    private double distance;
     private int minutes;
    public Running(DateTime date, int minutes, double distance)
        : base(date, minutes)
    {
        this.distance = distance;
        this.minutes = minutes;

    }
    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / (double)minutes * 60 * 0.62;
    }
    
    public override double GetPace()
    {
        return (double)minutes / distance;
    }
}