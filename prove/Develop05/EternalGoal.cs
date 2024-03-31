using System;

namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int value) : base(name, description, value)
        {
        }
        public override int MarkComplete()
        {
            return Value;
        }

        public override string CheckProgress()
        {
            return $"You can always work on {Name}.";
        }
    }
}