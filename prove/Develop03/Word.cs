using System;

public class Word
{
    private string _word;
    private bool _IsShown;

    public Word(string word)
    {
        _word = word;
        _IsShown = true;
    }

    public void DisplayWord()
    {
        if (_IsShown == false)
        {
            foreach (char letter in _word)
            {
                Console.Write("_");
            }
            Console.Write(" ");
        }
        else
        {
            Console.Write($"{_word} ");
        }
    }

    public void HideWord()
    {
        _IsShown = false;
    }

    public void HandleUserInput()
    {
        Console.WriteLine("\nPress Enter to erase the word or type 'quit' to end the program:");
        string userInput = Console.ReadLine();

        if (string.IsNullOrEmpty(userInput))
        {
            _word = string.Empty;
        }
        else if (userInput.ToLower() == "quit")
        {
            Environment.Exit(0); // Exit the program
        }
    }
}
