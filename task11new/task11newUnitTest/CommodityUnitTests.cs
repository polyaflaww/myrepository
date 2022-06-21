using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task11new;
using NUnit.Framework;

namespace task11newUnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
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
        }
        [Test]
        public void ToString_Commodity_NameSpaceDescription()
        {
            var chair = CreateTestCommodity();

            Assert.AreEqual("123456 Стул деревянный 20000 40000", chair.ToString());
        }
        private Commodity CreateTestCommodity()
        {
            return new Commodity(123456, "Стул деревянный", 20000, 40000, TypeOfUnit.Number);
        }
    }
}
