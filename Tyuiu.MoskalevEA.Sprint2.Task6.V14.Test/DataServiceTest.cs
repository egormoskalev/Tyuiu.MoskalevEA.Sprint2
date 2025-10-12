using Tyuiu.MoskalevEA.Sprint2.Task6.V14.Lib;

namespace Tyuiu.MoskalevEA.Sprint2.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual("понедельник", ds.FindDayName(1 % 7, 1));
            Assert.AreEqual("вторник", ds.FindDayName(2 % 7, 2));
            Assert.AreEqual("среда", ds.FindDayName(3 % 7, 3));
            Assert.AreEqual("четверг", ds.FindDayName(4 % 7, 4));
            Assert.AreEqual("пятница", ds.FindDayName(5 % 7, 5));
            Assert.AreEqual("суббота", ds.FindDayName(6 % 7, 6));
            Assert.AreEqual("воскресенье", ds.FindDayName(7 % 7, 7));



        }
    }
}
