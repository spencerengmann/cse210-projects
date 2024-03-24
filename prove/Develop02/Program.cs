//I added the option for the user to add a prompt to the journal program. Sometimes we need to add more prompts to keep the enerygy of journal writing fresh.
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new journal
        Journal journal = new Journal();
        bool exit = false;

        while (!exit)
        {
            // Display the options menu
            Console.WriteLine("Welcome to the Journal Program! ");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load the Journal from a file");
            Console.WriteLine("5. Add Prompt");
            Console.WriteLine("6. Quit");
            Console.WriteLine();

            // Collect response
            Console.WriteLine("What would you like to do?  ");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    journal.WriteEntry();
                    break;
                case 2:
                    journal.DisplayJournal();
                    break;
                case 3:
                    journal.SaveJournal();
                    break;
                case 4:
                    journal.LoadJournal();
                    break;
                case 5:
                    Console.WriteLine("Enter the new prompt:");
                    string newPrompt = Console.ReadLine();
                    journal.AddPrompt(newPrompt);
                    break;
                case 6:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
