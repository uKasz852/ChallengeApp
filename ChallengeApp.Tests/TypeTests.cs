namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TestDoubleType()
        {
            //arrange
            double length1 = 12.5;
            double length2 = 18.5;
            double length3 = 19.2;
            double length4 = 250.45;

            //act


            //assert
            Assert.AreEqual(length1*length2+length3, length4);
        }
        
        [Test]
        public void TestFloatType()
        {
            //arrange
            float temperature1 = 12.1F;
            float temperature2 = 18.1F;
            float temperature3 = 30.2F;
            
            //act


            //assert
            Assert.AreEqual(temperature2+temperature1, temperature3);
        }
        
        [Test]
        public void TestStringType()
        {
            //arrange
            string street1 = "Rataja";
            string street2 = "Mazowiecka";

            //act


            //assert
            Assert.AreNotEqual(street1, street2);
        }
        
        [Test]
        public void TestIntType()
        {
            //arrange
            int number1 = 1;
            int number2 = 1;

            //act


            //assert
            Assert.AreEqual(number1, number2);
        }  
        
        [Test]
        public void TestReferenceType()
        {
            //arrange
            var user1 = GetWorker("Adam", "Ziobro", "21");
            var user2 = GetWorker("Adam", "Ziobro", "21");

            //act


            //assert
            Assert.AreNotEqual(user1, user2);
        }

        private Worker GetWorker(string Name, string Surname, string Age)
        {
            return new Worker(Name, Surname, Age);
        }
    }
}
