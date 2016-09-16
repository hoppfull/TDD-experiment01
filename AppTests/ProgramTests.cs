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
            Assert.Fail();
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

            Assert.AreEqual(App.Program.Sum(testArray1), actualResult);


            int[] testArray2 = { -5, -4, -3, -2, -1, 1, 2, 3, 4 };
            Assert.AreEqual(App.Program.Sum(testArray2), -5);

            //Empty condition
            int[] emptyArray = { };
            Assert.AreEqual(App.Program.Sum(emptyArray), null);

            //Null condition
            int[] nullArray = null;
            Assert.AreEqual(App.Program.Sum(nullArray), null);
        }
    }
}