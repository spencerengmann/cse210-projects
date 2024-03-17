using System;

class Program
{
    public static void Main(string[] args)
    {
        // Create an object
        Scripture scripture = new Scripture("John", 3, 16, "For God so loved the world that he gave his only son, that whosoever believeth in him should not perish, but have everlasting life. ");

        while (true)
        {
            scripture.Display();
            Console.WriteLine("\nPress Enter to erase the word or type 'quit' to end the program:");
            string userInput = Console.ReadLine();

            if (string.IsNullOrEmpty(userInput))
            {
                scripture.HideRandomWord();
            }
            else if (userInput.ToLower() == "quit")
            {
                break; // Exit the loop and end the program
            }
        }
    }
}
