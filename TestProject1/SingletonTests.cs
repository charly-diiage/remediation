using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetSingleton()
        {
            var s1 = Singleton.GetInstance();
            var s2 = Singleton.GetInstance();
            Assert.AreEqual(s1, s2);
        }
    }
}
