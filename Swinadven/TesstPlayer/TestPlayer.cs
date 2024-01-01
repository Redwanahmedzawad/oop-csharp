using NUnit.Framework;

namespace Swinadven
{
    public class TestsPlayer
    {
        Player _player;
        Item itm = new Item(new string[] { "club" }, "sadface", "cool name");
        [SetUp]
        public void Setup()
        {
            _player = new Player("MM","inventory");
        }

        [Test]
        public void TestPlayer()
        {
            Assert.IsTrue(_player.AreYou("inventory" +
                ""));
        }
        [Test]
        public void PlayerLocatesItems()
        {
            _player.Inventory.Put(itm);
            Assert.AreEqual(itm, _player.Locate(itm.Firstid));
        }
        [Test]
        public void PlayerLocatesItself()
        {
            Assert.AreEqual(_player, _player.Locate("me"));
        }
        [Test]
        public void PLayerLocatesNull()
        {
            _player.Location = new Locations("En305", "Oop lab");
            Assert.AreEqual(null,_player.Locate(itm.Firstid));
        }
        [Test]
        public void PlayerFullDescription()
        {
            _player = new Player("Fred", "the warrior");
            _player.Inventory.Put(itm);
            Assert.AreEqual("You are Fred the warrior.\n You are carrying:\n a sadface club\n", _player.FullDescription);
            
        }
    }
}