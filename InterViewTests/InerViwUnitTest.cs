using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterViewLibrary;
namespace InterViewTests
{
    [TestClass]
    public class InerViwUnitTest
    {
        Interview interv;

        [TestInitialize]
        public void SetUp()
        {
            interv = new Interview();
        }

        [TestMethod]
        public void Hookup()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void FirstTest()
        {
            Assert.AreEqual(0, interv.test1(2, 1));
        }
    }
}
