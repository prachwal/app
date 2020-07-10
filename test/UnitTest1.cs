using NUnit.Framework;
using lib;

namespace test
{
    public class Tests
    {
        public Class1 Class { get; private set; }

        [SetUp]
        public void Setup()
        {
            this.Class = new Class1();
        }

        [Test]
        public void Test1()
        {
            if(!this.Class.Equals(null)) {
                Assert.Pass();
            };
        }
    }
}