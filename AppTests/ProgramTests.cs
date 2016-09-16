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
            CollectionAssert.AreEqual(Program.DoubleAll(new[] { 1, 2, 3, 4 }),
                new[] { 2, 4, 6, 8 });
            CollectionAssert.AreEqual(Program.DoubleAll(new int[] { }),
                new int[] { });
            CollectionAssert.AreEqual(Program.DoubleAll(new[] { 1 }),
                new[] { 2 });
            CollectionAssert.AreEqual(Program.DoubleAll(new[] { 9, 3, 64, 9, 8, 23 }),
                new[] { 18, 6, 128, 18, 16, 46 });
            CollectionAssert.AreEqual(Program.DoubleAll(new[] { 94, 632, 4, 8230 }),
                new[] { 188, 1264, 8, 16460 });
            CollectionAssert.AreEqual(Program.DoubleAll(new[] { 74, 93, 2, 5, 2, 6 }),
                new[] { 144, 186, 4, 10, 4, 12 });
            CollectionAssert.AreEqual(Program.DoubleAll(new[] { 2, 384, 92, 38, 892 }),
                new[] { 4, 768, 184, 76, 1784 });
            CollectionAssert.AreEqual(Program.DoubleAll(new[] { 74, 89, 39 }),
                new[] { 148, 178, 78 });
            CollectionAssert.AreEqual(Program.DoubleAll(new[] { 5492, 9 }),
                new[] { 10984, 18 });
            CollectionAssert.AreEqual(Program.DoubleAll(new[] { 5, 8, 7, 2 }),
                new[] { 10, 16, 14, 4 });
            
        }

        [TestMethod()]
        public void FizzBuzzTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SumTest()
        {
            Assert.Fail();
        }
    }
}