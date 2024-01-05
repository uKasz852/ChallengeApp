namespace ChallengeApp.Tests
{
    public class Tests
    {
       [Test]
        public void WhenWorkerHasPositivePoints()
        {
            //arrange
            var user = new Worker("Adam", "Ziobro", "21");
            user.AddScore(8);
            user.AddScore(1);
            user.AddScore(5);

            //act
            var result = user.Result;

            //assert
            Assert.AreEqual(14, result);
        }

        [Test]
        public void WhenWorkerHasNegativePoints()
        {
            //arrange
            var user = new Worker("Zuzia", "Lewandowska", "23");
            user.AddScore(-1);
            user.AddScore(-4);
            user.AddScore(-5);

            //act
            var result = user.Result;

            //assert
            Assert.AreEqual(-10, result);
        }

        [Test]
        public void WhenWorkerHasPositiveAndNegativePoints()
        {
            //arrange
            var user = new Worker("Gabrysia", "Wysocka", "19");
            user.AddScore(8);
            user.AddScore(-2);
            user.AddScore(5);

            //act
            var result = user.Result;

            //assert
            Assert.AreEqual(11, result);
        }
    }
}