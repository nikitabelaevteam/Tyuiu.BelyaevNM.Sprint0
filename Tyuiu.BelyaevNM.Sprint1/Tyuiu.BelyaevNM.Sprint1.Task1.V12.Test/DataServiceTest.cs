using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BelyaevNM.Sprint1.Task1.V12.Lib;
namespace Tyuiu.BelyaevNM.Sprint1.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid()
        {
            double res = DataService.Calculate();
            Assert.AreEqual(6.0, res);
        }
    }
}
