using Tyuiu.MoskalevEA.Sprint2.Task0.V17.Lib;

namespace Tyuiu.MoskalevEA.Sprint2.Task0.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 1065;
            int y = 755;
            bool[] res = ds.GetCompareOperations(x, y);
            bool[] wait = { true, false, false, false, false, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
