using PolojitelnoOtricatelnoChislo;

namespace TestProjectIsPositiveOrNegative
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(3)]
        [TestCase(312525231)]
        [TestCase(4.233211)]
        [TestCase(1266643.3838813)]
        [TestCase(31235551.3)]
        public void TestIsPositiveReturnTrue(double num)
        {
            //arrange
            PositiveNegative test = new PositiveNegative();
            //act
            bool result = test.IsPositive(num);
            //assert
            Assert.IsTrue(result);
        }

        [TestCase(-7)]
        [TestCase(-36316889)]
        [TestCase(-7.313566321)]
        [TestCase(-634251.4324525)]
        [TestCase(31234512.6)]
        public void TestIsPositiveReturnFalse(double num)
        {
            //arrange
            PositiveNegative test = new PositiveNegative();
            //act
            bool result = test.IsPositive(num);
            //assert
            Assert.IsFalse(result);
        }

        [TestCase(0)]
        public void TestIsPositiveThrowException(double num)
        {
            //arrange
            PositiveNegative test = new PositiveNegative();
            //act

            //assert
            Assert.Throws<ArgumentException>(() => test.IsPositive(num));
        }
    }
}