class Entry
{
    private DateTime _date;
    private string _prompt;
    private string _response;

    public Entry(string prompt, string response)
    {
        _date = DateTime.Today;
        _prompt = prompt;
        _response = response;
    }

    public DateTime Date
    {
        get { return _date; }
        set { _date = value; }
    }

    public string Prompt
    {
        get { return _prompt; }
        set { _prompt = value; }
    }

    public string Response
    {
        get { return _response; }
        set { _response = value; }
    }
}