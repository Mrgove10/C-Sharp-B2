using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MonCode.UnitTests
{
    [TestClass]
    public class CompteurTest : TestBase
    {
        [TestMethod]
        public void Test_Null()
        {
            Assert.IsTrue(Test(null) == 0);
        }

        [TestMethod]
        public void Test_Minuscule()
        {
            Assert.IsTrue(Test("bonjour je suis un chat qui est pas noir mais blanc?") == 4);
        }

        [TestMethod]
        public void Test_Majuscule()
        {
            Assert.IsTrue(Test("bonjour je suis un chAt qui est pAs noir mais blanc?") == 4);
        }

        [TestMethod]
        public void Test_Accent()
        {
            Assert.IsTrue(Test("Je vais à la mer") == 2);
        }

        [TestMethod]
        public void Test_Chiffre()
        {
            Assert.IsTrue(Test("561348634783451487373426842379825") == 0);
        }
    }
}