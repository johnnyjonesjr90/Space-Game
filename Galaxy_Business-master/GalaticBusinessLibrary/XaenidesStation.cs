﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Text;

namespace GalaticBusinessLibrary
{
    public class XaenidesStation : Planet
    {
        public Item Dilithium = new Item() {Qty = 10000, Price = 200, BaseQty=10000, Weight = 1};
        public Item Beryllium = new Item(10, 1000) { BaseQty = 900, BasePrice = 150, Weight = 5};
        public Item Carbon = new Item(50 ,250) { BasePrice= 250, Weight = 2};
        public Item Neutronium = new Item(0, 5) {BaseQty = 3, BasePrice=2500, Weight = 25};
        public Item Thorium = new Item(50, 250) { BasePrice = 250, Weight = 10};
        public Item Helium3 = new Item(0,150) { BasePrice = 500, BaseQty=75, Weight = 3};
        public Item WaterIce = new Item(0,150) { BasePrice = 500, BaseQty = 75, Weight = 1};
        public Item Lead = new Item(0,20) { BasePrice = 500, BaseQty= 10, Weight = 25};
        public Item Aether = new Item(5,15) {BasePrice=750, BaseQty=9, Weight = 5};
        public Item Food = new Item(0,150) {BasePrice=50, Weight = 2};
        public Item DarkMatter = new Item(0,5) {BasePrice=6000, BaseQty=2, Weight =50 };
        public string Description()
        {
            string desc =
                "Xaenides Station is a very large hub that fuels most of the ships going between planets in the\n" +
                "system. As a penalty for its conveinience they charge to enter the station, and their fuel prices\n" +
                "are the highest in the system.";
            return desc;
        }
        public string BuyWelcome()
        {

            string menu = "Welcome to Xaenides Station please browse our wares. {Press 99 to Exit} ";
            return menu;
        }
        public string Tax()
        {
            string menu = "Xaenides Station imposes a 300 credit convenience tax... ";
            return menu;
        }
        public override void ItemCalculation()
        {

            Beryllium.BuyCalculation();
            Beryllium.SellCalculation();
            Dilithium.SellCalculation();
            Dilithium.BuyCalculation();
            Carbon.BuyCalculation();
            Carbon.SellCalculation();
            Thorium.SellCalculation();
            Thorium.BuyCalculation();
            WaterIce.BuyCalculation();
            WaterIce.SellCalculation();
            Lead.SellCalculation();
            Lead.BuyCalculation();
            Aether.BuyCalculation();
            Aether.SellCalculation();
            Food.SellCalculation();
            Food.BuyCalculation();
            Neutronium.SellCalculation();
            Neutronium.BuyCalculation();
            Helium3.BuyCalculation();
            Helium3.SellCalculation();
            DarkMatter.SellCalculation();
            DarkMatter.BuyCalculation();


        }
        #region
        public override int DilithiumAvail()
        {
            Random itemchance = new Random();
            int dithavail = Dilithium.Availability(itemchance.Next(9, 10));
            return dithavail;
        }
        public override string Dithprice()
        {
            int avail = DilithiumAvail();
            string dp="Failed Method";
            if (avail == 1) { dp = $"Item # 1 Dilithium - {Dilithium.SalePrice()} {Dilithium.Price:0}    {Dilithium.SaleQty()} {Dilithium.Qty}/ {Dilithium.BaseQty}    {Dilithium.SaleWeight()} {Dilithium.Weight}"; return dp; }
            else if (avail == 0) { Dilithium.Price = 0; Dilithium.Qty = 0; dp = $"Item # 1 Dilithium -{Dilithium.SalePrice()} {Dilithium.Price:0}    {Dilithium.SaleQty()} {Dilithium.Qty = 0}/{Dilithium.BaseQty}    {Dilithium.SaleWeight()} {Dilithium.Weight}"; return dp; }
            return dp;
        }
        public string DithSellprice()
        {
            string dp = $"Item # 1 Dilithium - {Dilithium.SalePrice()} {Dilithium.Price:0}"; 
            return dp; 
        }
        public override int BerylliumAvail()
        {
            Random itemchance = new Random();
            int berylavail = Beryllium.Availability(itemchance.Next(9, 10));
            return berylavail;
        }
        public override string Beryllprice()
        {
            int avail = BerylliumAvail();
            string bp="Failed Method";
            if (avail == 1) { bp = $"Item # 2 Beryllium - {Beryllium.SalePrice()} {Beryllium.Price:0}    {Beryllium.SaleQty()} {this.Beryllium.Qty}/ {Beryllium.BaseQty}    {Beryllium.SaleWeight()} {Beryllium.Weight}"; return bp; }
            else if (avail == 0) { Beryllium.Price = 0; Beryllium.Qty = 0; bp = $"Item # 2 Beryllium - {Beryllium.SalePrice()} {Beryllium.Price:0}    {Beryllium.SaleQty()} {Beryllium.Qty = 0}/{Beryllium.BaseQty}    {Beryllium.SaleWeight()} {Beryllium.Weight}"; return bp; }
                return bp;
        }
        public  string BeryllSellprice()
        {

            string bp = $"Item # 2 Beryllium - {Beryllium.SalePrice()} {Beryllium.Price:0}";
            return bp;
        }


        public int CarbonAvail()
        {
            Random itemchance = new Random();
            int carbonavail = Carbon.Availability(itemchance.Next(0, 10));
            return carbonavail;
        }
        public string Carbonprice()
        {
            int avail = CarbonAvail();
            string bp = "Failed Method";
            if (avail == 1) { bp = $"Item # 3 Carbon - {Carbon.SalePrice()} {Carbon.Price:0}    {Carbon.SaleQty()} {this.Carbon.Qty}/ {Carbon.BaseQty}    {Carbon.SaleWeight()} {Carbon.Weight}"; return bp; }
            else if (avail == 0) { Carbon.Price = 0; Carbon.Qty = 0; bp = $"Item # 3 Carbon - {Carbon.SalePrice()} {Carbon.Price:0}    {Carbon.SaleQty()} {Carbon.Qty = 0}/{Carbon.BaseQty}    {Carbon.SaleWeight()} {Carbon.Weight}"; return bp; }
            return bp;
        }
        public string CarbonSellprice()
        {

            string bp = $"Item # 3 Carbon - {Carbon.SalePrice()} {Carbon.Price:0}";
            return bp;
        }
        public int ThoriumAvail()
        {
            Random itemchance = new Random();
            int Thoriumavail = Thorium.Availability(itemchance.Next(0, 10));
            return Thoriumavail;
        }
        public string Thoriumprice()
        {
            int avail = ThoriumAvail();
            string bp = "Failed Method";
            if (avail == 1) { bp = $"Item # 4 Thorium - {Thorium.SalePrice()} {Thorium.Price:0}    {Thorium.SaleQty()} {this.Thorium.Qty}/ {Thorium.BaseQty}    {Thorium.SaleWeight()} {Thorium.Weight}"; return bp; }
            else if (avail == 0) { Thorium.Price = 0; Thorium.Qty = 0; bp = $"Item # 4 Thorium - {Thorium.SalePrice()} {Thorium.Price:0}    {Thorium.SaleQty()} {Thorium.Qty = 0}/{Thorium.BaseQty}    {Thorium.SaleWeight()} {Thorium.Weight}"; return bp; }
            return bp;
        }
        public string ThoriumSellprice()
        {

            string bp = $"Item # 4 Thorium - {Thorium.SalePrice()} {Thorium.Price:0}";
            return bp;
        }
        public int WaterIceAvail()
        {
            Random itemchance = new Random();
            int WaterIceavail = WaterIce.Availability(itemchance.Next(4, 10));
            return WaterIceavail;
        }
        public string WaterIceprice()
        {
            int avail = WaterIceAvail();
            string bp = "Failed Method";
            if (avail == 1) { bp = $"Item # 5 WaterIce - {WaterIce.SalePrice()} {WaterIce.Price:0}    {WaterIce.SaleQty()} {this.WaterIce.Qty}/ {WaterIce.BaseQty}    {WaterIce.SaleWeight()} {WaterIce.Weight}"; return bp; }
            else if (avail == 0) { WaterIce.Price = 0; WaterIce.Qty = 0; bp = $"Item # 5 WaterIce - {WaterIce.SalePrice()} {WaterIce.Price:0}    {WaterIce.SaleQty()} {WaterIce.Qty = 0}/{WaterIce.BaseQty}    {WaterIce.SaleWeight()} {WaterIce.Weight}"; return bp; }
            return bp;
        }
        public string WaterIceSellprice()
        {

            string bp = $"Item # 5 WaterIce - {WaterIce.SalePrice()} {WaterIce.Price:0}";
            return bp;
        }
        public int LeadAvail()
        {
            Random itemchance = new Random();
            int Leadavail = Lead.Availability(itemchance.Next(2, 10));
            return Leadavail;
        }
        public string Leadprice()
        {
            int avail = LeadAvail();
            string bp = "Failed Method";
            if (avail == 1) { bp = $"Item # 6 Lead - {Lead.SalePrice()} {Lead.Price:0}    {Lead.SaleQty()} {this.Lead.Qty}/ {Lead.BaseQty}    {Lead.SaleWeight()} {Lead.Weight}"; return bp; }
            else if (avail == 0) { Lead.Price = 0; Lead.Qty = 0; bp = $"Item # 6 Lead - {Lead.SalePrice()} {Lead.Price:0}    {Lead.SaleQty()} {Lead.Qty = 0}/{Lead.BaseQty}    {Lead.SaleWeight()} {Lead.Weight}"; return bp; }
            return bp;
        }
        public string LeadSellprice()
        {

            string bp = $"Item # 6 Lead - {Lead.SalePrice()} {Lead.Price:0}";
            return bp;
        }
        public int AetherAvail()
        {
            Random itemchance = new Random();
            int Aetheravail = Aether.Availability(itemchance.Next(2, 10));
            return Aetheravail;
        }
        public string Aetherprice()
        {
            int avail = AetherAvail();
            string bp = "Failed Method";
            if (avail == 1) { bp = $"Item # 7 Aether - {Aether.SalePrice()} {Aether.Price:0}    {Aether.SaleQty()} {this.Aether.Qty}/ {Aether.BaseQty}    {Aether.SaleWeight()} {Aether.Weight}"; return bp; }
            else if (avail == 0) { Aether.Price = 0; Aether.Qty = 0; bp = $"Item # 7 Aether - {Aether.SalePrice()} {Aether.Price:0}    {Aether.SaleQty()} {Aether.Qty = 0}/{Aether.BaseQty}    {Aether.SaleWeight()} {Aether.Weight}"; return bp; }
            return bp;
        }
        public string AetherSellprice()
        {

            string bp = $"Item # 7 Aether - {Aether.SalePrice()} {Aether.Price:0}";
            return bp;
        }
        public int FoodAvail()
        {
            Random itemchance = new Random();
            int Foodavail = Food.Availability(itemchance.Next(4, 10));
            return Foodavail;
        }
        public string Foodprice()
        {
            int avail = FoodAvail();
            string bp = "Failed Method";
            if (avail == 1) { bp = $"Item # 8 Food - {Food.SalePrice()} {Food.Price:0}    {Food.SaleQty()} {this.Food.Qty}/ {Food.BaseQty}    {Food.SaleWeight()} {Food.Weight}"; return bp; }
            else if (avail == 0) { Food.Price = 0; Food.Qty = 0; bp = $"Item # 8 Food - {Food.SalePrice()} {Food.Price:0}    {Food.SaleQty()} {Food.Qty = 0}/{Food.BaseQty}    {Food.SaleWeight()} {Food.Weight}"; return bp; }
            return bp;
        }
        public string FoodSellprice()
        {

            string bp = $"Item # 8 Food - {Food.SalePrice()} {Food.Price:0}";
            return bp;
        }

        public int NeutroniumAvail()
        {
            Random itemchance = new Random();
            int Neutroniumavail = Neutronium.Availability(itemchance.Next(4, 10));
            return Neutroniumavail;
        }
        public string Neutroniumprice()
        {
            int avail = NeutroniumAvail();
            string bp = "Failed Method";
            if (avail == 1) { bp = $"Item # 9 Neutronium - {Neutronium.SalePrice()} {Neutronium.Price:0}    {Neutronium.SaleQty()} {this.Neutronium.Qty}/ {Neutronium.BaseQty}    {Neutronium.SaleWeight()} {Neutronium.Weight}"; return bp; }
            else if (avail == 0) { Neutronium.Price = 0; Neutronium.Qty = 0; bp = $"Item # 9 Neutronium - {Neutronium.SalePrice()} {Neutronium.Price:0}    {Neutronium.SaleQty()} {Neutronium.Qty = 0}/{Neutronium.BaseQty}    {Neutronium.SaleWeight()} {Neutronium.Weight}"; return bp; }
            return bp;
        }
        public string NeutroniumSellprice()
        {

            string bp = $"Item # 9 Neutronium - {Neutronium.SalePrice()} {Neutronium.Price:0}";
            return bp;
        }
        public int Helium3Avail()
        {
            Random itemchance = new Random();
            int Helium3avail = Helium3.Availability(itemchance.Next(4, 10));
            return Helium3avail;
        }
        public string Helium3price()
        {
            int avail = Helium3Avail();
            string bp = "Failed Method";
            if (avail == 1) { bp = $"Item # 10 Helium3 - {Helium3.SalePrice()} {Helium3.Price:0}    {Helium3.SaleQty()} {this.Helium3.Qty}/ {Helium3.BaseQty}    {Helium3.SaleWeight()} {Helium3.Weight}"; return bp; }
            else if (avail == 0) { Helium3.Price = 0; Helium3.Qty = 0; bp = $"Item # 10 Helium3 - {Helium3.SalePrice()} {Helium3.Price:0}    {Helium3.SaleQty()} {Helium3.Qty = 0}/{Helium3.BaseQty}    {Helium3.SaleWeight()} {Helium3.Weight}"; return bp; }
            return bp;
        }
        public string Helium3Sellprice()
        {

            string bp = $"Item # 10 Helium3 - {Helium3.SalePrice()} {Helium3.Price:0}";
            return bp;
        }
        public int DarkMatterAvail()
        {
            Random itemchance = new Random();
            int DarkMatteravail = DarkMatter.Availability(itemchance.Next(0, 10));
            return DarkMatteravail;
        }
        public string DarkMatterprice()
        {
            int avail = DarkMatterAvail();
            string bp = "Failed Method";
            if (avail == 1) { bp = $"Item # 11 DarkMatter - {DarkMatter.SalePrice()} {DarkMatter.Price:0}    {DarkMatter.SaleQty()} {this.DarkMatter.Qty}/ {DarkMatter.BaseQty}    {DarkMatter.SaleWeight()} {DarkMatter.Weight} \n\n (Illegal in some systems)"; return bp; }
            else if (avail == 0) { DarkMatter.Price = 0; DarkMatter.Qty = 0; bp = $"Item # 11 DarkMatter - {DarkMatter.SalePrice()} {DarkMatter.Price:0}    {DarkMatter.SaleQty()} {DarkMatter.Qty = 0}/{DarkMatter.BaseQty}    {DarkMatter.SaleWeight()} {DarkMatter.Weight}"; return bp; }
            return bp;
        }
        public string DarkMatterSellprice()
        {

            string bp = $"Item # 11 DarkMatter - {DarkMatter.SalePrice()} {DarkMatter.Price:0}";
            return bp;
        }
        public string StationSellprice()
        {

            string bp = $"Item # 11 Xaenides Station - 100,000";
            return bp;
        }
        #endregion
        public override double ItemTranslation(double input)
        {
            if (input == 1)
            { return Dilithium.Price; }
            if (input == 2)
            { return Beryllium.Price; }
            if (input == 3)
            { return Carbon.Price; }
            if (input == 4)
            { return Thorium.Price; }
            if (input == 5)
            { return WaterIce.Price; }
            if (input == 6)
            { return Lead.Price; }
            if (input == 7)
            { return Aether.Price; }
            if (input == 8)
            { return Food.Price; }
            if (input == 9)
            { return Neutronium.Price; }
            if (input == 10)
            { return Helium3.Price; }
            if (input == 11)
            { return DarkMatter.Price; }
            if (input == 12)
            { return 5000; }
            if (input == 13)
            { return 100000; }
            return input;
        }
        public override double WeightTranslation(double input)
        {
            if (input == 1)
            { input = Dilithium.Weight; }
            if (input == 2)
            { input = Beryllium.Weight; }
            if (input == 3)
            { return Carbon.Weight; }
            if (input == 4)
            { return Thorium.Weight; }
            if (input == 5)
            { return WaterIce.Weight; }
            if (input == 6)
            { return Lead.Weight; }
            if (input == 7)
            { return Aether.Weight; }
            if (input == 8)
            { return Food.Weight; }
            if (input == 9)
            { return Neutronium.Weight; }
            if (input == 10)
            { return Helium3.Weight; }
            if (input == 11)
            { return DarkMatter.Weight; }
            if (input == 12)
            { return 0; }
            return input;
        }
        public override double QtyTranslation(double input2)
        {
            if (input2 == 1)
            { return Dilithium.Qty; }
            if (input2 == 2)
            { return Beryllium.Qty; }
            if (input2 == 3)
            { return Carbon.Qty; }
            if (input2 == 4)
            { return Thorium.Qty; }
            if (input2 == 5)
            { return WaterIce.Qty; }
            if (input2 == 6)
            { return Lead.Qty; }
            if (input2 == 7)
            { return Aether.Qty; }
            if (input2 == 8)
            { return Food.Qty; }
            if (input2 == 9)
            { return Neutronium.Qty; }
            if (input2 == 10)
            { return Helium3.Qty; }
            if (input2 == 11)
            { return DarkMatter.Qty; }
            return input2;

        }

        public string XaenidesStationSelectionDisplay()
        {

            string bp = $"1 - Natotis (30)\n" +
                        $"2 - Otov (10)\n" +
                        $"3 - Gelara (15)\n" +
                        $"4 - Larvis (15)\n" +
                        $"5 - Aoclite (25)\n\n\n" +
                        $"Make Selection and Press Enter\n\n\n";
            return bp;
        }

        public string NotEnoughCredits()
        {
            string notEnough = "You do not have enough credits to enter the station";
            return notEnough;
        }





    }
    }