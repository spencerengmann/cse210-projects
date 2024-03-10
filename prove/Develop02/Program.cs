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
            Console.WriteLine("5. Quit");
            Console.WriteLine();


            // collect response
            Console.WriteLine("What would you like to do?  ");
            int choice = int.Parse(Console.ReadLine());

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
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();

        }

    }


}
