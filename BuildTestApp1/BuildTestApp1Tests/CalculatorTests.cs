using BuildTestApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;
using System.IO;

namespace BuildTestApp1Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_WhenNumberIsTwo_TotalShouldBeGreaterByTwo()
        {
            //arrange
            var testCalc = Substitute.For<Calculator>();
            var initial = testCalc.Total;
            var addedValue = 2;
            var expected = initial + addedValue;

            //act
            testCalc.Add(addedValue);
            var actual = testCalc.Total;

            //assert 
            Assert.AreEqual(expected, actual);
        }

    }
}
