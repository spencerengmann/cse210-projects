//Added the option for the user to quickly see their scores.
using System;

namespace EternalQuest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Eternal Quest!");
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            User user = new User(name);

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Delete an existing goal");
            Console.WriteLine("3. Update an existing goal");
            Console.WriteLine("4. Record an event");
            Console.WriteLine("5. Show your goals");
            Console.WriteLine("6. Show your score");
            Console.WriteLine("7. Save your data");
            Console.WriteLine("8. Load your data");
            Console.WriteLine("9. Exit the program");

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Please enter your choice (1-9):");
                string choice = Console.ReadLine();
                int option;
                if (!int.TryParse(choice, out option) || option < 1 || option > 9)
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
                }

                switch (option)
                {
                    case 1:
                        CreateGoal(user);
                        break;
                    case 2:
                        DeleteGoal(user);
                        break;
                    case 3:
                        UpdateGoal(user);
                        break;
                    case 4:
                        RecordEvent(user);
                        break;
                    case 5:
                        user.ShowGoals();
                        break;
                    case 6:
                        user.ShowScore();
                        break;
                    case 7:
                        SaveData(user);
                        break;
                    case 8:
                        LoadData(user);
                        break;
                    case 9:
                        exit = true;
                        break;
                }
            }

            Console.WriteLine($"Thank you for using Eternal Quest, {user.Name}!");
        }

        public static void CreateGoal(User user)
        {
            Console.WriteLine("What type of goal do you want to create?");
            Console.WriteLine("Simple, Eternal, or Checklist?");
            string type = Console.ReadLine();
            if (type != "Simple" && type != "Eternal" && type != "Checklist")
            {
                Console.WriteLine("Invalid type of goal. Please try again.");
                return;
            }

            Console.WriteLine("What is the name of your goal?");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid name of goal. Please try again.");
                return;
            }

            Console.WriteLine("What is the description of your goal?");
            string description = Console.ReadLine();
            if (string.IsNullOrEmpty(description))
            {
                Console.WriteLine("Invalid description of goal. Please try again.");
                return;
            }

            Console.WriteLine("What is the value of your goal?");
            string valueString = Console.ReadLine();
            int value;
            if (!int.TryParse(valueString, out value) || value <= 0)
            {
                Console.WriteLine("Invalid value of goal. Please try again.");
                return;
            }

            int target = 0;
            int bonus = 0;
            if (type == "Checklist")
            {
                Console.WriteLine("How many times do you need to complete this goal?");
                string targetString = Console.ReadLine();
                if (!int.TryParse(targetString, out target) || target <= 0)
                {
                    Console.WriteLine("Invalid target of goal. Please try again.");
                    return;
                }

                Console.WriteLine("What is the bonus value of your goal?");
                string bonusString = Console.ReadLine();
                if (!int.TryParse(bonusString, out bonus) || bonus <= 0)
                {
                    Console.WriteLine("Invalid bonus of goal. Please try again.");
                    return;
                }
            }

            user.CreateGoal(type, name, description, value, target, bonus);
        }

        public static void DeleteGoal(User user)
        {
            Console.WriteLine("What is the name of the goal you want to delete?");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid name of goal. Please try again.");
                return;
            }

            user.DeleteGoal(name);
        }

        public static void UpdateGoal(User user)
        {
            Console.WriteLine("What is the name of the goal you want to update?");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid name of goal. Please try again.");
                return;
            }

            Console.WriteLine("What is the new name of your goal? (Press enter to skip)");
            string newName = Console.ReadLine();
            Console.WriteLine("What is the new description of your goal? (Press enter to skip)");
            string newDescription = Console.ReadLine();
            Console.WriteLine("What is the new value of your goal? (Enter 0 to skip)");
            string valueString = Console.ReadLine();
            int newValue;
            if (!int.TryParse(valueString, out newValue) || newValue < 0)
            {
                Console.WriteLine("Invalid value of goal. Please try again.");
                return;
            }

            int newTarget = 0;
            int newBonus = 0;
            foreach (Goal goal in user.Goals)
            {
                if (goal.Name == name && goal is ChecklistGoal)
                {
                    Console.WriteLine("What is the new target of your goal? (Enter 0 to skip)");
                    string targetString = Console.ReadLine();
                    if (!int.TryParse(targetString, out newTarget) || newTarget < 0)
                    {
                        Console.WriteLine("Invalid target of goal. Please try again.");
                        return;
                    }

                    Console.WriteLine("What is the new bonus value of your goal? (Enter 0 to skip)");
                    string bonusString = Console.ReadLine();
                    if (!int.TryParse(bonusString, out newBonus) || newBonus < 0)
                    {
                        Console.WriteLine("Invalid bonus of goal. Please try again.");
                        return;
                    }
                }
            }

            user.UpdateGoal(name, newName, newDescription, newValue, newTarget, newBonus);
        }

        public static void RecordEvent(User user)
        {
            Console.WriteLine("What is the name of the goal you have completed?");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid name of goal. Please try again.");
                return;
            }

            user.RecordEvent(name);
        }

        public static void SaveData(User user)
        {
            Console.WriteLine("What is the name of the file you want to save your data to?");
            string fileName = Console.ReadLine();
            if (string.IsNullOrEmpty(fileName))
            {
                Console.WriteLine("Invalid file name. Please try again.");
                return;
            }

            user.SaveData(fileName);
        }

        public static void LoadData(User user)
        {
            Console.WriteLine("What is the name of the file you want to load your data from?");
            string fileName = Console.ReadLine();
            if (string.IsNullOrEmpty(fileName))
            {
                Console.WriteLine("Invalid file name. Please try again.");
                return;
            }

            user.LoadData(fileName);
        }
    }
}