using NUnit.Framework;
using Skaičiavimai;
using System;

namespace Namu_darbai
{
    public class Class1
    {
        
    [Test]
        public void Testas_995_Dalijasi_Is_3()
        {
            // Arrange
            int skaicius = 995;

            // Act
            bool arDalijasi = skaicius % 3 == 0;

            // Assert
            Assert.IsTrue(arDalijasi, "Skaičius 995 neturėtų turėti liekanos dalijantis iš 3.");
        }

        [Test]
        public void Testas_Siandien_Treciadienis()
        {
            // Arrange
            DateTime siandien = DateTime.Now;

            // Act
            bool arTreciadienis = siandien.DayOfWeek == DayOfWeek.Wednesday;

            // Assert
            Assert.IsTrue(arTreciadienis, "Šiandien turėtų būti trečiadienis.");
        }

        [Test]
        public void Testas_Dabar_Yra_13h()
        {
            // Arrange
            DateTime dabar = DateTime.Now;

            // Act
            bool ar13val = dabar.Hour == 13;

            // Assert
            Assert.IsTrue(ar13val, "Dabar turėtų būti 13 valanda.");
        }

        [Test]
        public void Testas_Nuo_1_Iki_10_Yra_4_Lyginiai_Skaiciai()
        {
            // Arrange
            int lyginiuSkaiciuKiekis = 0;

            // Act
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    lyginiuSkaiciuKiekis++;
                }
            }

            // Assert
            Assert.AreEqual(4, lyginiuSkaiciuKiekis, "Nuo 1 iki 10 turėtų būti 4 lyginiai skaičiai.");
        }
    }
}
