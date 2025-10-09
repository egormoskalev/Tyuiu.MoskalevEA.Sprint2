using Tyuiu.MoskalevEA.Sprint2.Task4.V14.Lib;

namespace Tyuiu.MoskalevEA.Sprint2.Task4.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 4;
            double res = ds.Calculate(x,y);
            double wait = 1;
            Assert.AreEqual(res, wait);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 16;
            double res = ds.Calculate(x,y);
            double wait = 431440;
            Assert.AreEqual(res, wait);
        }
    }
}
