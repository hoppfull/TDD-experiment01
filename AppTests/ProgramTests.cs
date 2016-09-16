using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            int[] testArray1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int actualResult = 0;

            foreach (var item in testArray1)
            {
                actualResult += item;
            }

            Assert.AreEqual(actualResult, App.Program.Sum(testArray1));


            int[] testArray2 = { -5, -4, -3, -2, -1, 1, 2, 3, 4 };
            Assert.AreEqual(-5, App.Program.Sum(testArray2));

            //Empty condition
            int[] emptyArray = { };
            Assert.AreEqual(null, App.Program.Sum(emptyArray));

            //Null condition
            int[] nullArray = null;
            Assert.AreEqual(null, App.Program.Sum(nullArray));
        }
    }
}