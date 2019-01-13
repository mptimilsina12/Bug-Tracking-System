using Microsoft.VisualStudio.TestTools.UnitTesting;
using GraphicalProgrammingLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalProgrammingLanguage.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void drawTest()
        {
            var t = new Triangle();
            int x = 200, y = 200, height = 100, width = 100;
            t.set(x, y, height,width);
            Assert.AreEqual(200, t.x);
        }
    }
}