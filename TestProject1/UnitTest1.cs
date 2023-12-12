using TeamCity;
using static TeamCity.Program;


namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.IsTrue(sum(1,2)==3);
            Assert.IsTrue(sum(0,0) == 0);
            Assert.IsTrue(sum(0, -2) == -2);
            Assert.IsTrue(sum(5, 1000) == 1005);
            Assert.IsTrue(sum(7, -7) == 0);
        }
    }
}