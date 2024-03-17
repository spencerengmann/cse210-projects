public class Reference
{
    string _book;

    int _chapter;

    List<int> _verses = new List<int>();

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verses.Add(verse);
    }

    public Reference(string book, int chapter, int starting_verse, int ending_verse)
    {
        _book = book;
        _chapter = chapter;
        _verses.Add(starting_verse);
        _verses.Add(ending_verse);

    }

    public string GetReference()
    {
        string verses = (_verses.Count() > 1) ? $"{_verses[0]}-{_verses[1]}" : $"{_verses[0]}";
        return ($"{_book} {_chapter}: {verses}");
    }
}