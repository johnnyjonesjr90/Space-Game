
using System;
using System.Collections.Generic;
using System.Text;



namespace GalaticBusinessLibrary
{
    public abstract class Planet
    {
        public Item Dilithium = new Item() { Weight = 1 };
        public Item Beryllium = new Item() { Weight = 5 };
        public Item Carbon = new Item() { Weight = 2 };
        public Item Neutronium = new Item() { Weight = 25 };
        public Item Thorium = new Item() { Weight = 10 };
        public Item Helium3 = new Item() { Weight = 3 };
        public Item WaterIce = new Item() { Weight = 1 };
        public Item Lead = new Item() { Weight = 25 };
        public Item Aether = new Item() { Weight = 5 };
        public Item Food = new Item() { Weight = 2 };
        public Item DarkMatter = new Item() { Weight = 50 };
        public enum PlanetName
        {
            Natotis,
            Otov,
            Gelara,
            Larvis,
            Aoclite,
            XaenidesStation
        }
        public string planetSize { get; set; }
        public string planetName { get; set; }
        
        public virtual string BuyWelcome(string planet)
        {
            
            string menu = $"Welcome to {planet} please browse our wares.";
            return menu;
        }
        
        public virtual void ItemCalculation()
        {

            Beryllium.BuyCalculation();
            Beryllium.SellCalculation();

            Dilithium.SellCalculation();
            Dilithium.BuyCalculation();

        }
        
        public virtual int DilithiumAvail()
        {

            Random itemchance = new Random();
            int dithavail = Dilithium.Availability(itemchance.Next(0, 10));
            return dithavail;
        }
        public virtual int BerylliumAvail()
        {
            Random itemchance = new Random();
            int berylavail = Beryllium.Availability(itemchance.Next(9, 10));
            return berylavail;
        }
        public virtual string Dithprice()
        {
            string dp;
            if (DilithiumAvail() > 0) dp = $"Item # 1 Dilithium - {Dilithium.SalePrice()} {Dilithium.Price:0}    {Dilithium.SaleQty()} {Dilithium.Qty}/{Dilithium.BaseQty}    {Dilithium.SaleWeight()} {Dilithium.Weight}";
            if (DilithiumAvail() == 0) Dilithium.Price = 0; Dilithium.Qty = 0; dp = $"Item # 1 Dilithium -{Dilithium.SalePrice()} {Dilithium.Price:0}    {Dilithium.SaleQty()} {Dilithium.Qty}/{Dilithium.BaseQty}    {Dilithium.SaleWeight()} {Dilithium.Weight}";
            return dp;
        }
        public virtual string Beryllprice()
        {
            string bp;
            if (BerylliumAvail() > 0) { bp = $"Item # 2 Beryllium - {Beryllium.SalePrice()} {Beryllium.Price:0}    {Beryllium.SaleQty()} {Beryllium.Qty}/{Beryllium.BaseQty}    {Beryllium.SaleWeight()} {Beryllium.Weight}"; }
            else if (BerylliumAvail() == 0) Beryllium.Price = 0; Beryllium.Qty = 0; bp = $"Item # 2 Beryllium - {Beryllium.SalePrice()} {Beryllium.Price:0}    {Beryllium.SaleQty()} {Beryllium.Qty}/{Beryllium.BaseQty}    {Beryllium.SaleWeight()} {Beryllium.Weight}";
            return bp;
        }
        public virtual double ItemTranslation(double input)
        {
            if (input == 1)
            { input = Dilithium.Price; }
            if (input == 2)
            { input = Beryllium.Price; }
            return input;
        }
        public virtual double WeightTranslation(double input)
        {
            if (input == 1)
            { input = Dilithium.Weight; }
            if (input == 2)
            { input = Beryllium.Weight; }
            return input;
        }
        public virtual double QtyTranslation(double input2)
        {
            if (input2 == 1)
            { input2 = Dilithium.Qty; }
            if (input2 == 2)
            { input2 = Beryllium.Qty; }
            return input2;
        }
        





    }
}
