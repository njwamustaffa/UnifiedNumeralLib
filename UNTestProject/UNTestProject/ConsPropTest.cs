using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnifiedNumeral;

namespace UNTestProject
{
    [TestClass]
    public class ConsPropTest
    {
        [TestMethod]
        public void TestConstructor1()
        {
            UnifiedNumeral.UnifiedNumeral a = new UnifiedNumeral.UnifiedNumeral();

            Assert.AreEqual(a.Value, 0);
        }

        [TestMethod]
        public void SetterGetterTest()
        {
            UnifiedNumeral.UnifiedNumeral a = new UnifiedNumeral.UnifiedNumeral();

            a.Value = 5;
            Assert.AreEqual(a.Value, 5);
        }

        [TestMethod]
        public void AdditionTest()
        {
            UnifiedNumeral.UnifiedNumeral a1 = new UnifiedNumeral.UnifiedNumeral();
            UnifiedNumeral.UnifiedNumeral a2 = new UnifiedNumeral.UnifiedNumeral();
            UnifiedNumeral.UnifiedNumeral result;

            a1.Value = 5;
            a2.Value = 10;

            result = a1 + a2;

            Assert.AreEqual(result.Value, 15);
        }

        [TestMethod]
        public void SubtractionTest()
        {
            UnifiedNumeral.UnifiedNumeral a1 = new UnifiedNumeral.UnifiedNumeral();
            UnifiedNumeral.UnifiedNumeral a2 = new UnifiedNumeral.UnifiedNumeral();
            UnifiedNumeral.UnifiedNumeral result;

            a1.Value = 10;
            a2.Value = 5;

            result = a1 - a2;

            Assert.AreEqual(result.Value, 5);
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            UnifiedNumeral.UnifiedNumeral a1 = new UnifiedNumeral.UnifiedNumeral();
            UnifiedNumeral.UnifiedNumeral a2 = new UnifiedNumeral.UnifiedNumeral();
            UnifiedNumeral.UnifiedNumeral result;

            a1.Value = 5;
            a2.Value = 10;

            result = a1 * a2;

            Assert.AreEqual(result.Value, 50);
        }

        [TestMethod]
        public void DivisonTest()
        {
            UnifiedNumeral.UnifiedNumeral a1 = new UnifiedNumeral.UnifiedNumeral();
            UnifiedNumeral.UnifiedNumeral a2 = new UnifiedNumeral.UnifiedNumeral();
            UnifiedNumeral.UnifiedNumeral result;

            a1.Value = 10;
            a2.Value = 5;

            result = a1 / a2;

            Assert.AreEqual(result.Value, 2);
        }
    }
}
