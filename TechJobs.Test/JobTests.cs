using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobs;


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
        public void Test_TestJobConstructorSetsAllFields()
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
    }
}
