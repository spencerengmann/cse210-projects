using System;

namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        public SimpleGoal(string name, string description, int value) : base(name, description, value)
        {
        }
        public override int MarkComplete()
        {
            return Value;
        }
        public override string CheckProgress()
        {
            return $"You have not completed {Name} yet.";
        }
    }
}