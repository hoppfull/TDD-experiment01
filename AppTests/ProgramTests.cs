using Microsoft.VisualStudio.TestTools.UnitTesting;
using App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CheckAgeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DoubleAllTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void FizzBuzzTest()
        {
            Assert.AreEqual("Fizz", Program.FizzBuzz(9));
            Assert.AreEqual("Buzz", Program.FizzBuzz(20));
            Assert.AreEqual("FizzBuzz", Program.FizzBuzz(30));
            Assert.AreEqual("7", Program.FizzBuzz(7));
        }

        [TestMethod()]
        public void SumTest()
        {
            Assert.Fail();
        }
    }
}