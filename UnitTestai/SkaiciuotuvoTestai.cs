using NUnit.Framework;

[assembly: LevelOfParallelism(3)]
namespace UnitTestai
{
    [Parallelizable(scope: ParallelScope.Children)]
    public class SkaiciuotuvoTestai
    {
        [TestCase(1, 3, 0.33333333333333333)]
        [TestCase(10, 2, 5)]
        [TestCase(8, 4, 2)]
        [TestCase(9, 3, 3)]
        [TestCase(8, 2, 4)]
        [TestCase(10, 5, 2)]
        public void Dalyba(int number1, int number2, double expectedResult)
        {
            double actualResult = Skaiciuotuvas.Skaiciuotuvas.Dalyba(number1, number2);
            System.Threading.Thread.Sleep(4000);

            Assert.AreEqual(expectedResult, actualResult);
        }
        
        [Test]
        public void Suma_01_01()
        {
            double expectedResult = 0.2;

            double actualResult = Skaiciuotuvas.Skaiciuotuvas.SumaDu(0.1, 0.1);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Suma_01_01_01()
        {
            double expectedResult = 0.3;

            double actualResult = Skaiciuotuvas.Skaiciuotuvas.SumaTrys(0.1, 0.1, 0.1);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Suma_01_01_01_Rounded()
        {
            double expectedResult = 0.3;

            double actualResult = Skaiciuotuvas.Skaiciuotuvas.SumaTrysRounded(0.1, 0.1, 0.1);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Suma_01_01_01_Decimal()
        {
            decimal expectedResult = 0.3m;

            decimal actualResult = Skaiciuotuvas.Skaiciuotuvas.SumaTrysDecimal(0.1m, 0.1m, 0.1m);
            
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
