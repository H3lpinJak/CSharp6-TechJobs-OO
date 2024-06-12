using System;

namespace TechJobsOOAutoGraded6
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        //Constructor 1: Initialize the Id property
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        //Constructor 2: Initialize All properties
        public Job(
            string name,
            Employer employerName,
            Location employerLocation,
            PositionType jobtype,
            CoreCompetency jobCoreCompetency
        )
            : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobtype;
            JobCoreCompetency = jobCoreCompetency;
        }

        public override string ToString()
        {
            string nameValue = string.IsNullOrEmpty(Name) ? "Data not available" : Name;
            string employerValue = EmployerName == null || string.IsNullOrEmpty(EmployerName.Value) ? "Data not available" : EmployerName.Value;
            string locationValue = EmployerLocation == null || string.IsNullOrEmpty(EmployerLocation.Value) ? "Data not available" : EmployerLocation.Value;
            string positionTypeValue = JobType == null || string.IsNullOrEmpty(JobType.Value) ? "Data not available" : JobType.Value;
            string coreCompetencyValue = JobCoreCompetency == null || string.IsNullOrEmpty(JobCoreCompetency.Value) ? "Data not available" : JobCoreCompetency.Value;

            string nl = Environment.NewLine;
            string result = $"ID: {Id}{nl}" +
                            $"Name: {nameValue}{nl}" +
                            $"Employer: {employerValue}{nl}" +
                            $"Location: {locationValue}{nl}" +
                            $"Position Type: {positionTypeValue}{nl}" +
                            $"Core Competency: {coreCompetencyValue}{nl}";

            return result;
        }

        public override bool Equals(object obj)
        {
            return obj is Job job && Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
