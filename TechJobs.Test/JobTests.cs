using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobs;
using System;


namespace TechJobs.Tests
{
    [TestClass]
    public class JobTests
    {
        //Testing Objects
        Job job1 = new Job();
        Job job2 = new Job();

        Job job3 = new Job(
            "Product tester",
            new Employer("ACME"),
            new Location("Desert"),
            new PositionType("Quality control"),
            new CoreCompetency("Persistence")
        );

        Job job4 = new Job(
            "Product tester",
            new Employer("ACME"),
            new Location("Desert"),
            new PositionType("Quality control"),
            new CoreCompetency("Persistence")
        );

        [TestMethod]
        public void TestSettingJobId()
        {
            //Check that Id's aren't the same
            Assert.AreNotEqual(job1.Id, job2.Id);

            //Check if the Difference between the Id's is exactly 1
            Assert.AreEqual(job1.Id + 1, job2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job selectedJob = job3;

            //Test if the constructor assigns the value of each field
            Assert.AreEqual("Product tester", selectedJob.Name);
            Assert.AreEqual("ACME", selectedJob.EmployerName.Value);
            Assert.AreEqual("Desert", selectedJob.EmployerLocation.Value);
            Assert.AreEqual("Quality control", selectedJob.JobType.Value);
            Assert.AreEqual("Persistence", selectedJob.JobCoreCompetency.Value);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job jobA = job1;
            Job jobB = job2;

            //Test that Equals() returns false
            Assert.IsFalse(jobA.Equals(jobB));
        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            Job job = new Job();

            string jobString = job.ToString();

            Assert.IsTrue(jobString.StartsWith(Environment.NewLine));
            Assert.IsTrue(jobString.EndsWith(Environment.NewLine));
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelAndData()
        {
            Job job = new Job(
                "Product tester",
                new Employer("ACME"),
                new Location("Desert"),
                new PositionType("Quality control"),
                new CoreCompetency("Presistence")
            );
            string jobString = job.ToString();

            Assert.IsTrue(jobString.Contains($": {job.Id}"));
            Assert.IsTrue(jobString.Contains($": {job.Name}"));
            Assert.IsTrue(jobString.Contains($": {job.EmployerName}"));
            Assert.IsTrue(jobString.Contains($": {job.EmployerLocation}"));
            Assert.IsTrue(jobString.Contains($": {job.JobType}"));
            Assert.IsTrue(jobString.Contains($": {job.JobCoreCompetency}"));
        }

        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            Job job = new Job(
                "",
                new Employer("ACME"),
                new Location("Desert"),
                new PositionType("Quality control"),
                new CoreCompetency("Persistence")
            );
            string jobString = job.ToString();

            Assert.IsTrue(jobString.Contains($"{Environment.NewLine}Name: Data not available{Environment.NewLine}"));
        }
    }
}
