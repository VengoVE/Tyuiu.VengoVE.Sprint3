using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VengoVE.Sprint3.Task3.V29.Lib;

namespace Tyuiu.VengoVE.Sprint3.Task3.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidDeleteCharInString()
        {
            DataService ds = new DataService();
            string value = "chgr vhhtg hnht";
            char chr = 'h';

            double res = ds.DeleteCharInString(value, chr);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}
