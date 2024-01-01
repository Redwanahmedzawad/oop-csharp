using NUnit.Framework;

namespace Swinadven
{
    public class TestItem
    {
        Item _item;
        [SetUp]
        public void Setup()
        {
            _item = new Item(new string[] { "my"}, "name", "This is the limit");
        }

        [Test]
        public void Test1()
        {
            Assert.IsTrue(_item.AreYou("My"));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual("a name my", _item.ShortDescription);
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual("This is the limit", _item.FullDescription);
        }
    }
}