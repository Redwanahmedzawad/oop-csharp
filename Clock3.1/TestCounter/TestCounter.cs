using NUnit.Framework;

namespace Clock3._1
{
    public class Tests
    {
        Counter i;
        [SetUp]
        public void Setup()
        {
            i = new Counter("Counter");
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(0, i.Ticks);

        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual("Counter", i.Name);
        }
        [TestCase(3,3)]
        [TestCase(11,11)]
        public void Test3(int j, int k)
        {
            while (i.Ticks < j)
            {
                i.Increment();
            }
            Assert.AreEqual(j, i.Ticks);
        }
        [Test]
        public void Test4()
        {
            i.Increment();
            i.Reset();
            Assert.AreEqual(0, i.Ticks);

        }
    }
}