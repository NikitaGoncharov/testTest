using testTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        Test t = new Test();
        [TestMethod]
        public void TestSum()
        {
            int a=3, b=2;
            int exp = 5;
            int tmp = t.Exmpl1(a, b);
            Assert.AreEqual(tmp, exp);
        }
        [TestMethod]
        public void TestSecret()
        {
            int a = 6;
            bool b = t.Exmpl2(a);
            Assert.AreEqual(b, true);
        }
        [TestMethod]
        public void TestOther()
        {
            int a = 3, b = 2;
            int exp = 6;
            int tmp = t.Exmpl3(a, b);
            Assert.AreEqual(tmp, exp);
        }
    }
}
