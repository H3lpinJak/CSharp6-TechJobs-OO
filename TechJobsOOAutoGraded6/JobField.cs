using System;

namespace TechJonsOOAutoGraded6
{
    public abstract class JobField
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        protected JobField()
        {
            Id = nextId;
            nextId++;
        }
        protected JobField(string value) : this()
        {
            Value = value;
        }
        public override bool Equals(object obj)
        {
            return obj is JobField field &&
            Id == field.Id;
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