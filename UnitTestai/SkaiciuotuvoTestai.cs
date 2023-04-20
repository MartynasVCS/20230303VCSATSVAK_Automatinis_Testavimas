using NUnit.Framework;

namespace UnitTestai
{
    public class SkaiciuotuvoTestai
    {
        [Test]
        public void Dalyba_1_3()
        {
            double expectedResult = 0.33333333333333333;

            double actualResult = Skaiciuotuvas.Skaiciuotuvas.Dalyba(1, 3);
            
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
