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

        [TestMethod]
        public void TestJobReturnsBlankLineBeforeInformation()
        {
            Employer aliens = new Employer("aliens");
            Location ocean = new Location("ocean");
            PositionType octopus = new PositionType("octopus");
            CoreCompetency punching = new CoreCompetency("punching fish");
            Job tester = new Job("Octopus", aliens, ocean, octopus, punching);
            string blankLine = " ";

            Assert.AreEqual(blankLine, tester.ToString().Substring(0,1));
        }

        [TestMethod]
        public void TestJobContainsLabelFollowedByDataOnOwnLine()
        {
            Employer aliens = new Employer("aliens");
            Location ocean = new Location("ocean");
            PositionType octopus = new PositionType("octopus");
            CoreCompetency punching = new CoreCompetency("punching fish");
            Job tester = new Job("Octopus", aliens, ocean, octopus, punching);

            string blankLine = " ";
            string newline = "\n";

            string toStringTester = blankLine + newline 
                + "ID: " + tester.Id + newline
                + "Name: " + tester.Name + newline
                + "Employer: " + tester.EmployerName + newline
                + "Location: " + tester.EmployerLocation + newline
                + "Position Type: " + tester.JobType + newline
                + "Core Competency: " + tester.JobCoreCompetency + newline +
                blankLine;

            Assert.AreEqual(toStringTester, tester.ToString());
        }

        [TestMethod]
        public void DataNotAvailableIfFieldIsEmpty()
        {
            string expectedUnavailable = "Data Not Available";
            Employer aliens = new Employer("aliens");
            Location ocean = new Location("ocean");
            PositionType octopus = new PositionType("octopus");
            CoreCompetency punching = new CoreCompetency("punching fish");
            Job tester = new Job("", aliens, ocean, octopus, punching);

            tester.ToString();

            Assert.AreEqual(expectedUnavailable, tester.Name);
        }

        //[TestMethod]
        //public void BONUSTestForOopsNoData()
        //{
        //    Employer aliens = new Employer("");
        //    Location ocean = new Location("");
        //    PositionType octopus = new PositionType("");
        //    CoreCompetency punching = new CoreCompetency("");
        //    Job tester = new Job("", aliens, ocean, octopus, punching);
        //    string missingAllData = "OOPS! This job does not seem to exist!";

        //    Assert.AreEqual(missingAllData, tester.ToString());
        //}
    }
}
