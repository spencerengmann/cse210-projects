class Cycling : Activity
{
    private double speed;
    private int minutes;



    public Cycling(DateTime date, int minutes, double speed)
        : base(date, minutes)
    {
        this.speed = speed;
        this.minutes = minutes;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetDistance()
    {
        return speed * (double)minutes / 60;
    }

    public override double GetPace()
    {
        return 60 / speed;
    }
}