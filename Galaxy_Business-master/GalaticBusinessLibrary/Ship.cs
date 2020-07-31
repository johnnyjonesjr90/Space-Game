using System;
using System.Collections.Generic;
using System.Text;


namespace GalaticBusinessLibrary
{
    public class Ship
    {
        #region 
        
        private Item _Beryllium = new Item() { Weight = 5 };
        private Item _Carbon = new Item() { Weight = 2 };
        private Item _Neutronium = new Item() { Weight = 25 };
        private Item _Thorium = new Item() { Weight = 10 };
        private Item _Helium3 = new Item() { Weight = 3 };
        private Item _WaterIce = new Item() { Weight = 1 };
        private Item _Lead = new Item() { Weight = 25 };
        private Item _Aether = new Item() { Weight = 5 };
        private Item _Food = new Item() { Weight = 2 };
        private Item _DarkMatter = new Item() { Weight = 50 };
        private Item _Zuronium = new Item() {Weight = 40, Price = 2000};
        private Item _Weapons = new Item() {Weight = 15, Price = 900};
        public int location;
        public string name;
        public double TotalCargo = 100;
        public double Cargo = 0;
        public double Credits = 5000;
        public double Hull = 100;
        public double Speed = 100;
        public double Attack = 100;
        public double Beryllium { get; set; }
        public double Carbon { get; set; }
        public double Neutronium { get; set; }
        public double Thorium { get; set; }
        public double Helium3 { get; set; }
        public double WaterIce { get; set; }
        public double Lead { get; set; }
        public double Aether { get; set; }
        public double Food { get; set; }
        public double DarkMatter { get; set; }
        public double Zuronium { get; set; }
        public double Weapons { get; set; }
        public string InventoryDisplay()
        {
            string display = $"" +
                $"Credits: {Credits}\n" +
                $"Cargo: {Cargo} / {TotalCargo}\n" +
                $"Item #1  Dilithium (Fuel): {Fuel}\n" +
                $"Item #2  Beryllium: {Beryllium}\n" +
                $"Item #3  Carbon: {Carbon}\n" +
                $"Item #4  Thorium: {Thorium}\n" +
                $"Item #5  Water/Ice: {WaterIce}\n" +
                $"Item #6  Lead: {Lead}\n" +
                $"Item #7  Aether: {Aether}\n" +
                $"Item #8  Food: {Food}\n" +
                $"Item #9  Neutronium {Neutronium}\n" +
                $"Item #10 Helium3 {Helium3}\n" +
                $"Item #11 Dark Matter {DarkMatter}\n";
            return display;
        }
        #endregion

        public double ItemTranslation(double input)

        {
            
            if (input == 2)
            { return Beryllium; }
            if (input == 3)
            { return Carbon; }
            if (input == 4)
            { return Thorium; }
            if (input == 5)
            { return WaterIce; }
            if (input == 6)
            { return Lead; }
            if (input == 7)
            { return Aether; }
            if (input == 8)
            { return Food; }
            if (input == 9)
            { return Neutronium; }
            if (input == 10)
            { return Helium3; }
            if (input == 11)
            { return DarkMatter; }
            return input;
        }

        public  double WeightTranslation(double input)
        {
            
            if (input == 2)
            { input = _Beryllium.Weight; }
            if (input == 3)
            { input = _Carbon.Weight; }
            if (input == 4)
            { return _Thorium.Weight; }
            if (input == 5)
            { return _WaterIce.Weight; }
            if (input == 6)
            { return _Lead.Weight; }
            if (input == 7)
            { return _Aether.Weight; }
            if (input == 8)
            { return _Food.Weight; }
            if (input == 9)
            { return _Neutronium.Weight; }
            if (input == 10)
            { return _Helium3.Weight; }
            if (input == 11)
            { return _DarkMatter.Weight; }
            return input;
        }


        public double Fuel = 100;


    }
}
