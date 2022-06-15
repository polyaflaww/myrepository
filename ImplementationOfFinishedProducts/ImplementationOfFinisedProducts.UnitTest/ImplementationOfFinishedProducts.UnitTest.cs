using System;
using ImplementationOfFinisedProducts;
using NUnit.Framework;

namespace ImplementationOfFinisedProducts.UnitTest
{
    class Program
    {
        [Test]
        public void ConstructorTest()
        {
            var chair = CreateTestImplementationOfFinishedProducts();

            Assert.AreEqual(1234567890, chair.Vendorcode);
            Assert.AreEqual("Стул из красного дерева", chair.Name);
            Assert.AreEqual(20000, chair.WholesaPricePerItem);
            Assert.AreEqual(40000, chair.RetailPricePerItem);
            Assert.AreEqual(TypeOfUnit.Number, chair.UnitOfGoods);
            Assert.AreEqual(, chair.FinishTime);
            Assert.AreEqual("200$", john.TourPrise);
            Assert.AreEqual(PaymentType.Cash, john.Payment);
                    public readonly int VendorCode;
        public string Name;
        public double WholesaPricePerItem;
        public double RetailPricePerItem;
        public TypeOfUnit UnitOfGoods;
        public string Description;
        public int StockAvailability;
    }
        [Test]
        public void ToString_Tourist_NameSpaceSurname()
        {
            var john = CreateTestTourist();

            Assert.AreEqual("John Johnson", john.ToString());
        }
        private Tourist CreateTestTourist()
        {
            return new Tourist("123456", "John", "Johnson", "06:00", "6", "12:00", "200$", PaymentType.Cash);
        }
    }
}
        
