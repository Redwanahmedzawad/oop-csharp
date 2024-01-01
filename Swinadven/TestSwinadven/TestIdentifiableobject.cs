using NUnit.Framework;
using Swinadven;
namespace Swinadven
{
    public class TestIdentifiableobject
    {

        IdentifiableObject id;
        [SetUp]
        public void Setup()
        {
            id = new IdentifiableObject(new string[] { "fred", "bob" });
         
        }

        [Test]
        public void TestAreYou()
        {
            
            
            Assert.IsTrue(id.AreYou("fred"));
            
            Assert.IsTrue(id.AreYou("bob"));
            

        }
        [Test]
        public void TestNotAreYou()
        {
            
            
            Assert.IsFalse(id.AreYou("wilma"));
            
            Assert.IsFalse(id.AreYou("boby"));

        }
        [Test]
        public void TestCaseSensitive()
        {
            
            Assert.IsTrue(id.AreYou("FRED"));
            
            Assert.IsTrue(id.AreYou("bOB"));

        }
        [Test]
        public void TestFirstId()
        {
            Assert.IsTrue(id.Firstid == "fred");
        }
        [Test]
        public void TestFirstIdwithNoIDs()
        {
            IdentifiableObject id= new IdentifiableObject(new string[] {});
            Assert.IsTrue(id.Firstid == "");
        }
        [Test]
        public void TestAddId()
        {
            id.AddIdentifier("wilma");
            Assert.IsTrue(id.AreYou("fred"));
            Assert.IsTrue(id.AreYou("bob"));
            Assert.IsTrue(id.AreYou("wilma"));
        }

    }
}