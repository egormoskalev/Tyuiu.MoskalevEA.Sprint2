﻿using Tyuiu.MoskalevEA.Sprint2.Task5.V5.Lib;


namespace Tyuiu.MoskalevEA.Sprint2.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual("шестёрка", ds.FindCardValue(6));
            Assert.AreEqual("семёрка", ds.FindCardValue(7));
            Assert.AreEqual("восьмёрка", ds.FindCardValue(8));
            Assert.AreEqual("девятка", ds.FindCardValue(9));
            Assert.AreEqual("десятка", ds.FindCardValue(10));
            Assert.AreEqual("валет", ds.FindCardValue(11));
            Assert.AreEqual("дама", ds.FindCardValue(12));
            Assert.AreEqual("король", ds.FindCardValue(13));
            Assert.AreEqual("туз", ds.FindCardValue(14));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardValue(5);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardValue(15);
            });


        }
    }
}
