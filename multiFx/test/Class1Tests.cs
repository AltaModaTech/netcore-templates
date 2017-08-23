using Microsoft.VisualStudio.TestTools.UnitTesting;
using src;


namespace test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sut = new Class1();
            sut.Message = "Hello!";

            Assert.AreEqual("Hello!", sut.Message);
        }
    }
}
