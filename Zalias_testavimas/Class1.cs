using NUnit.Framework;

namespace Zalias_testavimas
{
    public class Class1
    {
        [Test]
        public void Dalyba_995_3()
        {
            int expectedResult = 331;

            int actualResult = Skaiciuotuvas.Skaiciuotuvas.SumaDu(0.1, 0.1);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}