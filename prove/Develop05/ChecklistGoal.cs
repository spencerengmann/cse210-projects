using System;

namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        public int Count { get; set; }
        public int Target { get; set; }
        public int Bonus { get; set; }
        public ChecklistGoal(string name, string description, int value, int target, int bonus) : base(name, description, value)
        {
            Count = 0;
            Target = target;
            Bonus = bonus;
        }
        public override int MarkComplete()
        {
            Count++;
            CheckCount();
            return Value;
        }
        public override string CheckProgress()
        {
            return $"You have completed {Count} out of {Target} times for {Name}.";
        }

        private void CheckCount()
        {
            if (Count >= Target)
            {
                User.Score += Bonus;
                Console.WriteLine($"Congratulations! You have finished {Name} and earned a bonus of {Bonus} points!");
            }
        }
    }
}