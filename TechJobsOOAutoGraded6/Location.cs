using System;

namespace TechJobsOOAutoGraded6
{
    public class Location
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public Location()
        {
            Id = nextId;
            nextId++;
        }
        // Second constructor using the first to initaialize Id
    public Location(string value) : this()
    {
        Value = value;
    }
    public Location(int id, string value)
    {
        Id =id;
        Value = value;
        if (id >= nextId)
        {
            nextId = id + 1;
        }
    }
        public override bool Equals(object obj)
        {
            return obj is Location location && Id == location.Id;
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
