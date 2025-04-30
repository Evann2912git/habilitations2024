using Microsoft.VisualStudio.TestTools.UnitTesting;
using habilitations2024.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace habilitations2024.dal.Tests
{
    [TestClass()]
    public class DeveloppeurAccessTests
    {
        [TestMethod()]
        public void GetLesDeveloppeursTest()
        {
            DeveloppeurAccess devAccessTest = new DeveloppeurAccess();
            //Test 1
            Assert.AreEqual(4,devAccessTest.GetLesDeveloppeurs("admin").Count);
            Assert.AreEqual(3, devAccessTest.GetLesDeveloppeurs("designer").Count);
            Assert.AreEqual(4, devAccessTest.GetLesDeveloppeurs("dev-front").Count);
            Assert.AreEqual(3, devAccessTest.GetLesDeveloppeurs("dev-back").Count);
            Assert.AreEqual(6, devAccessTest.GetLesDeveloppeurs("stagiaire").Count);
            //Test 2
            Assert.AreEqual(20, devAccessTest.GetLesDeveloppeurs("").Count);
        }
    }
}