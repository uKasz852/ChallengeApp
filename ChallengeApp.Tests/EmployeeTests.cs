namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMax()
        {
            //arrange
            var employee = new Employee("Łukasz", "Wysocki");
            employee.AddGrade(8);
            employee.AddGrade(4);
            employee.AddGrade(9);


            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(9, statistics.Max);
        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMin()
        {
            //arrange
            var employee = new Employee("Łukasz", "Wysocki");
            employee.AddGrade(8);
            employee.AddGrade(4);
            employee.AddGrade(9);


            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(4, statistics.Min);
        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectAvarage()
        {
            //arrange
            var employee = new Employee("Łukasz", "Wysocki");
            employee.AddGrade(8);
            employee.AddGrade(4);
            employee.AddGrade(9);


            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(7, statistics.Average);
        }
    }
}
