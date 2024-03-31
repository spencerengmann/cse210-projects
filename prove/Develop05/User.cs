using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class User
    {
        public string Name { get; set; }
        public static int Score { get; set; }
        public int Level { get; set; }
        public List<Goal> Goals { get; set; }

        public User(string name)
        {
            Name = name;
            Score = 0;
            Level = 1;
            Goals = new List<Goal>();
        }

        // The method CreateGoal, which creates a new goal and adds it to the list of goals
        // It takes the type, name, description, value, target, and bonus as parameters
        public void CreateGoal(string type, string name, string description, int value, int target = 0, int bonus = 0)
        {
            Goal newGoal;
            switch (type)
            {
                case "Simple":
                    newGoal = new SimpleGoal(name, description, value);
                    break;
                case "Eternal":
                    newGoal = new EternalGoal(name, description, value);
                    break;
                case "Checklist":
                    newGoal = new ChecklistGoal(name, description, value, target, bonus);
                    break;
                default:
                    Console.WriteLine("Invalid type of goal.");
                    return;
            }
            Goals.Add(newGoal);
            Console.WriteLine($"You have created a new {type} goal: {name}.");
        }

        // The method DeleteGoal, which deletes an existing goal from the list of goals
        // It takes the name of the goal as a parameter
        public void DeleteGoal(string name)
        {
            foreach (Goal goal in Goals)
            {
                if (goal.Name == name)
                {
                    Goals.Remove(goal);
                    Console.WriteLine($"You have deleted the goal: {name}.");
                    return;
                }
            }
            Console.WriteLine("No such goal exists.");
        }

        // The method UpdateGoal, which updates an existing goal from the list of goals
        // It takes the name of the goal and the new attributes as parameters
        public void UpdateGoal(string name, string newName = null, string newDescription = null,
                               int newValue = 0, int newTarget = 0, int newBonus = 0)
        {
            foreach (Goal goal in Goals)
            {
                if (goal.Name == name)
                {
                    if (newName != null) goal.Name = newName;
                    if (newDescription != null) goal.Description = newDescription;
                    if (newValue != 0) goal.Value = newValue;
                    if (goal is ChecklistGoal checklistGoal)
                    {
                        if (newTarget != 0) checklistGoal.Target = newTarget;
                        if (newBonus != 0) checklistGoal.Bonus = newBonus;
                    }
                    Console.WriteLine($"You have updated the goal: {name}.");
                    return;
                }
            }
            Console.WriteLine("No such goal exists.");
        }

        // The method RecordEvent, which records an event where the user has completed a goal and gains points
        // It takes the name of the goal as a parameter
        public void RecordEvent(string name)
        {
            foreach (Goal goal in Goals)
            {
                if (goal.Name == name)
                {
                    Score += goal.MarkComplete();
                    CheckLevel();
                    Console.WriteLine($"You have completed {name} and earned {goal.Value} points!");
                    return;
                }
            }
            Console.WriteLine("No such goal exists.");
        }

        // The method ShowGoals, which shows a list of the goals that the user has created
        public void ShowGoals()
        {
            Console.WriteLine("Here are your goals:");
            foreach (Goal goal in Goals)
            {
                Console.WriteLine($"- {goal.Name}: {goal.Description} ({goal.CheckProgress()})");
            }
        }

        // The method ShowScore, which shows the score and level of the user
        public void ShowScore()
        {
            Console.WriteLine($"Your score is {Score} and your level is {Level}.");
        }

        // The method SaveData, which saves the user's data to a file
        // It takes the file name as a parameter
        public void SaveData(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(Name);
                writer.WriteLine(Score);
                writer.WriteLine(Level);
                writer.WriteLine(Goals.Count);
                foreach (Goal goal in Goals)
                {
                    writer.WriteLine(goal.GetType().Name);
                    writer.WriteLine(goal.Name);
                    writer.WriteLine(goal.Description);
                    writer.WriteLine(goal.Value);
                    if (goal is ChecklistGoal checklistGoal)
                    {
                        writer.WriteLine(checklistGoal.Count);
                        writer.WriteLine(checklistGoal.Target);
                        writer.WriteLine(checklistGoal.Bonus);
                    }
                }
            }
            Console.WriteLine($"Your data has been saved to {fileName}.");
        }

        // The method LoadData, which loads the user's data from a file
        // It takes the file name as a parameter
        public void LoadData(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                Name = reader.ReadLine();
                Score = int.Parse(reader.ReadLine());
                Level = int.Parse(reader.ReadLine());
                int goalCount = int.Parse(reader.ReadLine());
                Goals.Clear();
                for (int i = 0; i < goalCount; i++)
                {
                    string type = reader.ReadLine();
                    string name = reader.ReadLine();
                    string description = reader.ReadLine();
                    int value = int.Parse(reader.ReadLine());
                    Goal newGoal;
                    switch (type)
                    {
                        case "SimpleGoal":
                            newGoal = new SimpleGoal(name, description, value);
                            break;
                        case "EternalGoal":
                            newGoal = new EternalGoal(name, description, value);
                            break;
                        case "ChecklistGoal":
                            int count = int.Parse(reader.ReadLine());
                            int target = int.Parse(reader.ReadLine());
                            int bonus = int.Parse(reader.ReadLine());
                            newGoal = new ChecklistGoal(name, description, value, target, bonus);
                            ((ChecklistGoal)newGoal).Count = count;
                            break;
                        default:
                            Console.WriteLine("Invalid type of goal.");
                            return;
                    }
                    Goals.Add(newGoal);
                }
            }
            Console.WriteLine($"Your data has been loaded from {fileName}.");
        }

        // The private method CheckLevel, which checks if the user's score has reached a certain threshold and increases their level if so
        private void CheckLevel()
        {
            if (Score >= Level * 1000)
            {
                Level++;
                Console.WriteLine($"You have leveled up to level {Level}!");
            }
        }
    }
}