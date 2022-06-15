using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationOfFinishedProducts
{
    public class Commodity
    {
        public readonly int VendorCode;
        public string Name;
        public double WholesaPricePerItem;
        public double RetailPricePerItem;
        public TypeOfUnit UnitOfGoods;
        public string Description;
        public int StockAvailability;

        public Commodity(int code, string name, double whosale, double retail, TypeOfUnit unitofgoods, string description, int stockavailability)
        {
            VendorCode = code;
            Name = name;
            WholesaPricePerItem = whosale;
            RetailPricePerItem = retail;
            UnitOfGoods = unitofgoods;
        }

        public override string ToString()
        {
            return $"{VendorCode} {Name} {WholesaPricePerItem} {RetailPricePerItem}";
        }

        public void PrintInfo()
        {
            Console.WriteLine(this);

            var unitofgoods = "";
            switch (UnitOfGoods)
            {
                case TypeOfUnit.Number:
                    unitofgoods = "Штуки";
                    break;
                case TypeOfUnit.Packs:
                    unitofgoods = "Упаковки";
                    break;
                case TypeOfUnit.Kilograms:
                    unitofgoods = "Килограммы";
                    break;
                case TypeOfUnit.Tons:
                    unitofgoods = "Тонны";
                    break;
            }
            Console.WriteLine($"Артикул: {VendorCode}. Наименование: {Name}. Оптовая цена: {WholesaPricePerItem}. Розничная цена: {RetailPricePerItem}. Тиа единицы товара: {UnitOfGoods}");
        }
    }
}
