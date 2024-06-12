﻿using System;

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
            Id = nextId++;
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobtype;
            JobCoreCompetency = jobCoreCompetency;
        }

        public override bool Equals(object obj)
        {
            return obj is Job job && Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string nameValue = string.IsNullOrEmpty(Name) ? "" : Name;
            string employerValue = EmployerName == null ? "" : EmployerName.Value;
            string locationValue = EmployerLocation == null ? "" : EmployerLocation.Value;
            string positionTypeValue = JobType == null ? "" : JobType.Value;
            string coreCompetencyValue = JobCoreCompetency == null ? "" : JobCoreCompetency.Value;

            return $"{Environment.NewLine}ID: {Id}{Environment.NewLine}Name: {nameValue}{Environment.NewLine}Employer: {employerValue}{Environment.NewLine}Location: {locationValue}{Environment.NewLine}Position Type: {positionTypeValue}{Environment.NewLine}Core Competency: {coreCompetencyValue}{Environment.NewLine}";
        }
    }
}
