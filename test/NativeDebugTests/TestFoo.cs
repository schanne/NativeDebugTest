using ManagedLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NativeDebugTests
{
    [TestClass]
    public class TestFoo
    {
        [TestMethod]
        public void TestBar()
        {
            var foo = new Foo();

            Assert.AreEqual(42, foo.Bar());
        }

        [TestMethod]
        public void TestPass()
        {
            var foo = new Foo();

            Assert.AreEqual(0, 0);
        }

        [TestMethod]
        public void TestFail()
        {
            var foo = new Foo();

            Assert.Fail();
        }
    }
}
