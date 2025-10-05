using Tyuiu.MoskalevEA.Sprint2.Task2.V15.Lib;

namespace Tyuiu.MoskalevEA.Sprint2.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            Assert.IsTrue(ds.CheckDotInShadedArea(4, 3));  
            Assert.IsTrue(ds.CheckDotInShadedArea(5, 5));  
            Assert.IsTrue(ds.CheckDotInShadedArea(8, 6));  
            Assert.IsTrue(ds.CheckDotInShadedArea(6, 7));  
            Assert.IsTrue(ds.CheckDotInShadedArea(2, 6));  
            Assert.IsTrue(ds.CheckDotInShadedArea(2, 4)); 

            Assert.IsFalse(ds.CheckDotInShadedArea(1, 1)); 
            Assert.IsFalse(ds.CheckDotInShadedArea(9, 8));
            Assert.IsFalse(ds.CheckDotInShadedArea(1, 5)); 
            Assert.IsFalse(ds.CheckDotInShadedArea(9, 5)); 
            Assert.IsFalse(ds.CheckDotInShadedArea(5, 2)); 
            Assert.IsFalse(ds.CheckDotInShadedArea(5, 8)); 
        }

        [TestMethod]
        public void CheckBoundaryPoints()
        {
            DataService ds = new DataService();

            Assert.IsTrue(ds.CheckDotInShadedArea(3, 3));  
            Assert.IsTrue(ds.CheckDotInShadedArea(5, 3));  
            Assert.IsTrue(ds.CheckDotInShadedArea(8, 4)); 
            Assert.IsTrue(ds.CheckDotInShadedArea(8, 7)); 
            Assert.IsTrue(ds.CheckDotInShadedArea(4, 7)); 
            Assert.IsTrue(ds.CheckDotInShadedArea(7, 7));
            Assert.IsTrue(ds.CheckDotInShadedArea(2, 3)); 
            Assert.IsTrue(ds.CheckDotInShadedArea(2, 7)); 
        }
    }
}