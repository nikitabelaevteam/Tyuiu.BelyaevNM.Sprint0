using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BelyaevNM.Sprint0.Task2.V0.Lib;
namespace Tyuiu.BelyaevNM.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            string name = "Игорь";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Игорь", res);
        }
    }
}
