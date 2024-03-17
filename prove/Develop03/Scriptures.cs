public class Scripture
{
    Reference _reference;

    List<Word> _words = new List<Word>();

    public Scripture(string book, int chapter, int verse, string scripture)
    {
        _reference = new Reference(book, chapter, verse);


        string[] parts = scripture.Split(" ");
        foreach (string part in parts)
        {
            Word A = new Word(part);
            _words.Add(A);
        }
        // this.InitializeOriginalText(text);
    }
    public void Display()
    {
        foreach (Word word in _words)
        {
            // word.HideWord();
            word.DisplayWord();
        }
    }
    public void HideRandomWord()
    {
        Random rnd = new Random();
        int rantnum = rnd.Next(_words.Count);
        _words[rantnum].HideWord();
    }
}