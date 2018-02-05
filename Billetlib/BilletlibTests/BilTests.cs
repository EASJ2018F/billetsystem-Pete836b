using Microsoft.VisualStudio.TestTools.UnitTesting;
using Billetlib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetlib.Tests
{
    [TestClass()]
    public class BilTests
    {
        [TestMethod()]
        public void BilletPrisTest()
        {
            var bil = new Bil();
            int result = bil.BilletPris();
            Assert.AreEqual(240, result);
        }

        [TestMethod()]
        public void KøretøjTest()
        {
            var bil = new Bil();
            string result = bil.Køretøj();
            Assert.AreEqual(result, "Bil");
        }
    }

    
}