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
    }
}
