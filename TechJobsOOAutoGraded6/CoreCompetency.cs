using System;

namespace TechJobsOOAutoGraded6
{
	public class CoreCompetency
	{
        public int Id { get; } = 0; // using initalizer make this auto-implemented
        private static int nextId = 1; 
        public string Value { get; } //Make this Auto-implemented


        public CoreCompetency()
        {
            Id = nextId;
            nextId++;
        }

        public CoreCompetency(string v) : this()
        {
            Value = v;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}

