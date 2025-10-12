using Tyuiu.MoskalevEA.Sprint2.Task7.V11.Lib;

namespace Tyuiu.DatskiyDE.Sprint2.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            Assert.IsTrue(ds.CheckDotInShadedArea(0, 1));

            Assert.IsTrue(ds.CheckDotInShadedArea(0, 0.6));

            Assert.IsFalse(ds.CheckDotInShadedArea(0, 0.4));

        }
    }
}
