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
    }
}
