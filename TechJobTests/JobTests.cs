using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobID()
        {
            Job tester = new Job();
            Job testerPlus = new Job();

            int expected = tester.Id + 1;
            int actual = testerPlus.Id;

            Assert.AreEqual(expected, actual, .001);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Employer ACME = new Employer("ACME");
            Location Desert = new Location("Desert");
            PositionType QualityControl = new PositionType("Quality Control");
            CoreCompetency Persistence = new CoreCompetency("Persistence");

            Job tester = new Job("Product Tester", ACME, Desert, QualityControl, Persistence);

            Assert.IsNotNull(tester.Id);
            Assert.AreEqual("Product Tester", tester.Name);
            Assert.AreEqual(ACME, tester.EmployerName);
            Assert.AreEqual(Desert, tester.EmployerLocation);
            Assert.AreEqual(QualityControl, tester.JobType);
            Assert.AreEqual(Persistence, tester.JobCoreCompetency);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Employer aliens = new Employer("aliens");
            Location ocean = new Location("ocean");
            PositionType octopus = new PositionType("octopus");
            CoreCompetency punching = new CoreCompetency("punching fish");

            Job testerOne = new Job("Octopus Imposter", aliens, ocean, octopus, punching);
            Job testerTwo = new Job("Octopus Imposter", aliens, ocean, octopus, punching);

            // override object.Equals
            Assert.IsFalse(testerOne.Equals(testerTwo));
        }
    }
}
