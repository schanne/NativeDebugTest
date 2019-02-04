using ManagedLibrary;
using NUnit.Framework;

namespace NativeDebugTests
{
    [TestFixture]
    public class TestFoo
    {
        [Test]
        public void TestBar()
        {
            var foo = new Foo();

            Assert.AreEqual(42, foo.Bar());
        }

        [Test]
        public void TestPass()
        {
            var foo = new Foo();

            Assert.AreEqual(0, 0);
        }

        [Test]
        public void TestFail()
        {
            var foo = new Foo();

            Assert.Fail();
        }
    }
}
