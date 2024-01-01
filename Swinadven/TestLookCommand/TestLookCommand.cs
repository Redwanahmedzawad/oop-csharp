using NUnit.Framework;

namespace Swinadven
{
    public class Tests
    {
        Player p;
        
        Bag bag;
        Item gem;
        LookCommand cmd;
        [SetUp]
        public void Setup()
        {
            p = new Player("RED", "The ted");
            bag = new Bag(new string[] { "bag", "cotton" }, "carrier", "Carries all the stuff you want");
            gem = new Item(new string[] { "gem", "diamond" }, "Kohinoor", "Curse of kings");
            p.Location = new Locations("Swinburne", "University");

            cmd = new LookCommand();
        }

        [Test]
        public void TestLookAtme()
        {
            string[] thing = new string[] { "look", "at", "inventory" };
            Assert.AreEqual(p.FullDescription, cmd.Execute(p,thing ));

        }
        [Test]
        public void TestLookAtGem()
        {
            p.Inventory.Put(gem);
            string[] thing = new string[] { "look", "at", "gem" };
            Assert.AreEqual(gem.FullDescription, cmd.Execute(p, thing));

        }
        [Test]
        public void TestLookAtUnk()
        {
            
            string n = "I can't find the gem";
            string[] thing = new string[] { "look", "at", "gem" };
            Assert.AreEqual(n, cmd.Execute(p, thing));

        }
        [Test]
        public void TestLookatGeminBag()
        {
            string[] thing = new string[]{ "look", "at", "gem", "in", "bag" };
            bag.Inventory.Put(gem);
            p.Inventory.Put(bag);
            Assert.AreEqual(gem.FullDescription, cmd.Execute(p, thing));
        }
        [Test]
        public void TestLookatGeminNoBag()
        {
            
            string[] thing = new string[] { "look", "at", "gem", "in", "bag" };
            string n = "I can't find the bag";
            Assert.AreEqual(n, cmd.Execute(p, thing));

        }
        [Test]
        public void TestLookatNoGeminBag()
        {
            string[] thing = new string[] { "look", "at", "gem", "in", "bag" };
            string n = "I can't find the gem";
            p.Inventory.Put(bag);
            Assert.AreEqual(n, cmd.Execute(p, thing));
        }
        [Test]
        public void TestInvalidLook()
        {
            string n = "look around";
            string []thing = n.Split(" ");
            Assert.AreEqual("What do you want to look at?", cmd.Execute(p,thing));
            string r = "hello";
            Assert.AreEqual("Error in look input", cmd.Execute(p,r.Split(" ")));
            string k = "look at a at b";
            Assert.AreEqual("What do you want to look in?", cmd.Execute(p,k.Split(" ")));
        }
    }
}
