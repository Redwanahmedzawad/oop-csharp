using NUnit.Framework;

namespace Clock3._1
{
    public class TestClock
    {
        Clock clk;
        [SetUp]
        public void Setup()
        {
            clk = new Clock();
        }

        [Test]
        public void Testformat()
        {
            Assert.AreEqual("00:00:00", clk.Format);
        }
        [Test]
        public void Testtime1()
        {
            for (int i = 0; i < 86400; i++)
            {
                clk.Tick();
                Assert.AreNotEqual("60", clk.Format);


            }
        }
        [TestCase(0, "00:00:00")]
        [TestCase(3000, "00:50:00")]
        [TestCase(3800, "01:03:20")]
        public void Testtime2(int j, string result)
        {
            for(int i =0 ;i < j; i++)
            {
                clk.Tick();
            }
            Assert.AreEqual(result, clk.Format, "Incorret time");

        }
    }
}