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
            
            int a = 324;
            int b = 696;
            int c = 254;
            int d = 155;

            bool[] res = ds.GetLogicOperations( a, b, c, d);
            bool[] wait = { true, true, true, false, false, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
