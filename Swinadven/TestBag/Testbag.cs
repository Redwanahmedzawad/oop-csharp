using NUnit.Framework;

namespace Swinadven
{
    public class TestBag
    {
        Bag _bag;
        Item _item = new Item(new string[] { "grain" }, "rice", "food");
        [SetUp]
        public void Setup()
        {
            _bag = new Bag(new string[] { "leather", "silk" }, "bagss", "purple");
            _bag.Inventory.Put(_item);
        }

        [Test]
        public void TestBagLocatesItems()
        {
            Assert.AreEqual(_item, _bag.Locate(_item.Firstid));
        }
        [Test]
        public void TestBaLocatesItself()
        {
            Assert.AreEqual(_bag, _bag.Locate(_bag.Firstid));
        }
        [Test]
        public void TestBagLocatesNothing()
        {
            Assert.AreEqual(null, _bag.Locate("uiii"));
        }
        [Test]
        public void BagFullDescription()
        {
            string a = "In the bagss you can see:\n" + _bag.Inventory.ItemList;
            Assert.AreEqual(a, _bag.FullDescription);
        }
        [Test]
        public void BaginBag()
        {
            Bag _bag1 = new Bag(new string[] { "cotton", "wool" }, "red", "small");
            _bag.Inventory.Put(_bag1);
            Assert.AreEqual(_bag1, _bag.Locate(_bag1.Firstid));
            Item _item1 = new Item(new string[] { "itin1", "itn2" }, "wool", "sweater");
            _bag1.Inventory.Put(_item1);
            Assert.AreEqual(_item, _bag.Locate(_item.Firstid));
            Assert.AreEqual(null, _bag.Locate(_item1.Firstid));

        }
       

        
        
    }
}