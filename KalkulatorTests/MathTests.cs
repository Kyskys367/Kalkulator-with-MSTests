using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Kalkulator;

namespace KalkulatorTests
{
    [TestClass]
    public class MathTests
    {
        Random r = new Random();
        [TestMethod]
        public void TestPlus()
        {
            Maths m = new Maths();
            float first = r.Next(int.MinValue, int.MaxValue);
            float second = r.Next(int.MinValue, int.MaxValue);

            float expected = first + second;
            float result = m.plus(first.ToString(), second.ToString());

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMinus()
        {
            Maths m = new Maths();
            float first = r.Next(int.MinValue, int.MaxValue);
            float second = r.Next(int.MinValue, int.MaxValue);

            float expected = first - second;
            float result = m.minus(first.ToString(), second.ToString());

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestDiv()
        {
            Maths m = new Maths();
            float first = r.Next(int.MinValue, int.MaxValue);
            float second = r.Next(int.MinValue, int.MaxValue);

            float expected = first / second;
            float result = m.div(first.ToString(), second.ToString());

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMulti()
        {
            Maths m = new Maths();
            float first = r.Next(int.MinValue, int.MaxValue);
            float second = r.Next(int.MinValue, int.MaxValue);

            float expected = first * second;
            float result = m.multi(first.ToString(), second.ToString());

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestStringPlus()
        {
            Maths m = new Maths();
            string first = "a";
            string second = "a";

            float result = m.plus(first, second);

            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void TestStringMinus()
        {
            Maths m = new Maths();
            string first = "a";
            string second = "a";

            float result = m.minus(first, second);

            Assert.AreEqual(result, 0);
        }
        [TestMethod]
        public void TestStringDiv()
        {
            Maths m = new Maths();
            string first = "a";
            string second = "a";

            float result = m.div(first, second);

            Assert.AreEqual(result, 0);
        }
        [TestMethod]
        public void TestStringMulti()
        {
            Maths m = new Maths();
            string first = "a";
            string second = "a";

            float result = m.multi(first, second);

            Assert.AreEqual(result, 0);
        }
    }
}
