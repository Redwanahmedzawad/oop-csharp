using NUnit.Framework;

namespace Swinadven
{
    public class Tests
    {
        Player p;
        Locations location;
        Item gem;
        Item sand;
        [SetUp]
        public void Setup()
        {
            p = new Player("Robin", " Fading light");
            location = new Locations("Swinburne", "INEN305");
            gem = new Item(new string[] { "gem", "diamond" }, "Philosopher stone", "Key to Immortality");
            sand = new Item(new string[] { "sand", "silicon" }, "Quartz", "Property of Sahara");
            
        }

        [Test]
        public void TestLocate()
        {
            Assert.AreEqual(location, location.Locate("location"));

        }
        [Test]
        public void TestLocation()
        {

            location.Inventory.Put(sand);
            Assert.AreEqual(sand, location.Locate("sand"));
        }
        [Test]
        public void TestPlayer()
        {
            p.Location = location;
            p.Location.Inventory.Put(gem);
            Assert.AreEqual(gem, p.Location.Locate("gem"));
        }
    }
}