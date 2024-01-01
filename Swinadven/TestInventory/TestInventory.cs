using NUnit.Framework;

namespace Swinadven 
{
    public class Tests
    {
        Item _item = new Item(new string[] { "sword" }, "Excalibure", "Legendary sword");
        Inventory _inven;
        Item _item1 = new Item(new string[] { "Axe" }, "BattleScar", "Terror of thunder");
        [SetUp]
        public void Setup()
        {
            _inven = new Inventory();
            _inven.Put(_item);
        }

        [Test]
        public void TestFindItem()
        {
            Assert.IsTrue(_inven.HasItem(_item.Firstid));

        }
        [Test]
        public void TestNoItemFind()
        {
            
            Assert.IsFalse(_inven.HasItem("Axe"));
        }
        [Test]
        public void TestFetchItem()
        {
            Assert.AreEqual(_item, _inven.Fetch(_item.Firstid));
        }
        [Test]
        public void TestTakeItem()
        {
            Assert.AreEqual(_item, _inven.Take(_item.Firstid));
            Assert.False(_inven.HasItem("shovel"));
        }
        [Test]
        public void TestListItem()
        {
            _inven.Put(_item1);
            Assert.AreEqual(" a Excalibure sword\n a BattleScar Axe\n", _inven.ItemList);
        }
    }
}