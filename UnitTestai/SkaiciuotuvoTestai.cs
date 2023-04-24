using NUnit.Framework;

namespace UnitTestai
{
    public class SkaiciuotuvoTestai
    {
        
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
