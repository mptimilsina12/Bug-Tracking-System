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
    public class _3DRectangleTests
    {
        [TestMethod()]
        public void _3DRectangleTest()
        {
                var dr = new _3DRectangle();
                int x = 200, y = 200, width = 100, height = 100;
                dr.set(x, y, height, width);
                Assert.AreEqual(200, dr.x);
            }
        
    }
}