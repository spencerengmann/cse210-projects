class Lecture : Event
{
    private string speaker;
    private int capacity;
    private string title;
    private DateTime date;
    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
        this.title = title;
        this.date = date;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nType: Lecture \nSpeaker: {speaker}\nCapacity: {capacity}";
    }

    public override string GetShortDescription()
    {
        return $"Lecture: {title}, {date.ToShortDateString()}";
    }


}