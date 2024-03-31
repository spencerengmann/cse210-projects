using System;

namespace EternalQuest
{

    public abstract class Goal
    {
        public string Name { get; set; }

        public string Description { get; set; }
        public int Value { get; set; }
        public Goal(string name, string description, int value)
        {
            Name = name;
            Description = description;
            Value = value;
        }

        public abstract int MarkComplete();

        public abstract string CheckProgress();
    }
}