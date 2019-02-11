using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void Triangle_IsNotATriangle_True()
        {
            ThreeSideObject testTriangle = new ThreeSideObject();
            testTriangle.A = 10;
            testTriangle.B = 10;
            testTriangle.C = 21;

            Assert.AreEqual(true, testTriangle.IsNotATriangle());
        
        }
        [TestMethod]
        public void Triangle_IsEquilateral_True()
        {
            ThreeSideObject testTriangle = new ThreeSideObject();
            testTriangle.A = 10;
            testTriangle.B = 10;
            testTriangle.C = 10;

            Assert.AreEqual(true, testTriangle.IsEquilateral());
        }
        [TestMethod]
        public void Triangle_IsIsosceles_True()
        {
            ThreeSideObject testTriangle = new ThreeSideObject();
            testTriangle.A = 10;
            testTriangle.B = 10;
            testTriangle.C = 11;

            Assert.AreEqual(true, testTriangle.IsIsosceles());
        }
        [TestMethod]
        public void Triangle_IsScalene_True()
        {
            ThreeSideObject testTriangle = new ThreeSideObject();
            testTriangle.A = 10;
            testTriangle.B = 19;
            testTriangle.C = 11;

            Assert.AreEqual(true, testTriangle.IsScalene());
        }
    }
}