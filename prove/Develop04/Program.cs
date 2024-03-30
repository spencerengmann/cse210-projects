//Added another activity for the user to do. The meditation program allows the user to spend time meditating.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string choice = "";
        while (choice != "4")
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("    1. Start breathing activity");
            Console.WriteLine("    2. Start reflecting activity");
            Console.WriteLine("    3. Start listing activity");
            Console.WriteLine("    4. Start meditation program");
            Console.WriteLine("    5. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Clear();
                Breathing breathing = new Breathing();
                breathing.DisplayWelcome();
                Console.WriteLine();
                breathing.DisplayDescription();
                Console.WriteLine();
                breathing.GetSeconds();
                Console.Clear();
                breathing.DoBreathingActivity();
            }
            else if (choice == "2")
            {
                Console.Clear();
                Reflecting reflecting = new Reflecting();
                reflecting.DisplayWelcome();
                Console.WriteLine();
                reflecting.DisplayDescription();
                Console.WriteLine();
                reflecting.GetSeconds();
                Console.Clear();
                reflecting.DoReflectingActivity();
            }
            else if (choice == "3")
            {
                Console.Clear();
                Listing listing = new Listing();
                listing.DisplayWelcome();
                Console.WriteLine();
                listing.DisplayDescription();
                Console.WriteLine();
                listing.GetSeconds();
                Console.Clear();
                listing.DisplayTodo();
            }
            else if (choice == "4")
            {
                Console.Clear();
                BodyScanMeditation meditation = new BodyScanMeditation();
                meditation.StartBodyScanMeditation();
            }
        }
    }
}
