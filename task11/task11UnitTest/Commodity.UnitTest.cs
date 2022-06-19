using System;
using task11;
using NUnit.Framework;

namespace task11.UnitTests
{
    [TestFixture]
    public class CommodityUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var chair = CreateTestCommodity();

            Assert.AreEqual(123456, chair.VendorCode);
            Assert.AreEqual("Стул деревянный", chair.Name);
            Assert.AreEqual(20000, chair.WholesaPricePerItem);
            Assert.AreEqual(40000, chair.RetailPricePerItem);
            Assert.AreEqual(TypeOfUnit.Number, chair.UnitOfGoods);
            Assert.AreEqual("Стул из красного дерева, выполненный в Италии", chair.Description);
            Assert.AreEqual(43, chair.StockAvailability);
        }
        [Test]
        public void ToString_Commodity_NameSpaceDescription()
        {
            var chair = CreateTestCommodity();

            Assert.AreEqual("Стул деревянный Стул из красного дерева, выполненный в Италии", chair.ToString());
        }
        private Commodity CreateTestCommodity()
        {
            return new Commodity(123456, "Стул деревянный", 20000, 40000, TypeOfUnit.Number);
        }

    }
}

