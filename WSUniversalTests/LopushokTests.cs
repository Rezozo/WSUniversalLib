using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;

namespace WSUniversalTests
{
    [TestClass]
    public class LopushokTests
    {
        private Lopushok lopushok = new Lopushok();

        [TestMethod]
        public void GetProductQuantity_InvalidType()
        {
            Assert.AreEqual(-1, lopushok.GetProductQuantity(-1, 1, 1, 1, 1));
        }

        [TestMethod]
        public void GetProductQuantity_InvalidMaterial()
        {
            Assert.AreEqual(-1, lopushok.GetProductQuantity(1, -1, 1, 1, 1));
        }

        [TestMethod]
        public void GetProductQuantity_InvalidCount()
        {
            Assert.AreEqual(-1, lopushok.GetProductQuantity(1, 1, -1, 1, 1));
        }

        [TestMethod]
        public void GetProductQuantity_InvalidWidth()
        {
            Assert.AreEqual(-1, lopushok.GetProductQuantity(1, 1, 1, -1, 1));
        }

        [TestMethod]
        public void GetProductQuantity_InvalidLength()
        {
            Assert.AreEqual(-1, lopushok.GetProductQuantity(1, 1, 1, 1, -1));
        }

        [TestMethod]
        public void GetProductQuantity_Valid()
        {
            Assert.AreEqual(2, lopushok.GetProductQuantity(1, 1, 1, 1, 1));
        }

        [TestMethod]
        public void GetProductQuantity_InvalidTypeZero()
        {
            Assert.AreEqual(-1, lopushok.GetProductQuantity(0, 1, 1, 1, 1));
        }

        [TestMethod]
        public void GetProductQuantity_InvalidMaterialZero()
        {
            Assert.AreEqual(-1, lopushok.GetProductQuantity(1, 0, 1, 1, 1));
        }

        [TestMethod]
        public void GetProductQuantity_InvalidCountZero()
        {
            Assert.AreEqual(-1, lopushok.GetProductQuantity(1, 1, 0, 1, 1));
        }

        [TestMethod]
        public void GetProductQuantity_InvalidWidthZero()
        {
            Assert.AreEqual(-1, lopushok.GetProductQuantity(1, 1, 1, 0, 1));
        }

        [TestMethod]
        public void GetProductQuantity_InvalidLengthZero()
        {
            Assert.AreEqual(-1, lopushok.GetProductQuantity(1, 1, 1, 1, 0));
        }

        [TestMethod]
        public void GetProductQuantity_ValidDoubleWidth()
        {
            Assert.AreEqual(38690, lopushok.GetProductQuantity(2, 2, 55, 23.42, 12));
        }

        [TestMethod]
        public void GetProductQuantity_ValidDoubleLength()
        {
            Assert.AreEqual(331956, lopushok.GetProductQuantity(1, 2, 55, 234, 23.42));
        }

        [TestMethod]
        public void GetProductQuantity_ValidDoubleWidthLength()
        {
            Assert.AreEqual(101276825, lopushok.GetProductQuantity(3, 1, 55, 1532.324, 142.123));
        }

        [TestMethod]
        public void GetProductQuantity_ValidBigValues()
        {
            Assert.AreEqual(56909652, lopushok.GetProductQuantity(1, 1, 3, 53231, 323));
        }
    }
}
