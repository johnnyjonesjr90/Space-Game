
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Xml.Serialization;
using System.IO;


namespace GalaticBusinessLibrary
{
    public class Menu
    {
        public double planetChoice { get; set; }



        public string StoryStart()
        {
            
            string selection = "" +
                               "\n\nYou worked for a small merchant for years, being his co-pilot and accompanying him on his trips\n" +
                               "throughout the galaxy. He treated you well and encouraged you to seek out your own adventure. But\n" +
                               "after years of travel he decides to close up his business.. He gives you his ship and moves to the \n" +
                               "Xaenides System. You have some money saved from your years of work and you start your business. After\n" +
                               "paying for your merchants license you have some money left. You can sell your ship and put some money\n" +
                               "towards a new one or you can start out with your ship....\n\n\n\n Press Enter...";
            return selection;
        }

        public string ShipSelection()
        {
            string Shipselect =
                "\n\nIf you sell your ship you will have 20000 credits and can buy a few different models.\n\n" +
                "1 - Xaenides Cruiser $18000   Cargo- 50    Fuel - 300   Hull - 200   Speed - 500\n\n" +
                "2 - Natotis Hauler   $15000   Cargo- 350   Fuel - 50    Hull - 300   Speed - 100\n\n" +
                "3 - Your Ship        $0       Cargo- 100   Fuel - 100   Hull - 200   Speed - 300\n\n\n\n" +
                "Enter Selection and Press Enter:";
            return Shipselect;
        }

       

       
        public string PlanetTranslation(double choice1)
        {
            string planet1 = "Home Base";
            if (choice1 == 1) planet1 = $"{Planet.PlanetName.Natotis} ";
            if (choice1 == 3) planet1 = $"{Planet.PlanetName.Gelara} ";
            if (choice1 == 2) planet1 = $"{Planet.PlanetName.Otov} ";
            if (choice1 == 4) planet1 = $"{Planet.PlanetName.Larvis} ";
            if (choice1 == 5) planet1 = $"{Planet.PlanetName.Aoclite} ";
            if (choice1 == 6) planet1 = $"{Planet.PlanetName.XaenidesStation}";
            return planet1;
        }
        public double ChekForFuel(double shipFuel)
        {
            double travel = 1;
            if (planetChoice == 1 && shipFuel < 30) { travel = 0; return travel; }
            if (planetChoice == 2 && shipFuel < 15) { travel = 0; return travel; }
            if (planetChoice == 3 && shipFuel < 10) { travel = 0; return travel; }
            if (planetChoice == 4 && shipFuel < 15) { travel = 0; return travel; }
            if (planetChoice == 5 && shipFuel < 25) { travel = 0; return travel; }
            if (planetChoice == 6 && shipFuel < 5) { travel = 0; return travel; }
            return travel;

        }
        public string PlanetDialog()
        {
            string dialog = "1 - MarketPlace \n2 - Travel to the Capital City  \n3 - Mission Board \n4 - Return to Ship \n5 - Inventory \n6 - Stock Market";
            return dialog;
        }
        public string ShopDialog()
        {
            string dialog = "1 - Buy \n2 - Sell \n99 - Exit";
            return dialog;
        }
        public double PurchasePrice(double cost, double qty)
        {
            double purchaseAmt = cost * qty;
            return purchaseAmt;
        }
        public string NotEnoughCredits()
        {
            string notEnough;
            notEnough = "You do not have enough credits for this purchase.";
            return notEnough;
        }
        public string NotEnoughItems()
        {
            string notEnough;
            notEnough = "You do not have enough Items for this purchase.";
            return notEnough;
        }
        public string NotEnoughCargo()
        {
            string notEnough;
            notEnough = "You do not have room in cargo for this purchase.";
            return notEnough;
        }

        public double TotalCargo(double weight, double qty)
        {
            double cargoAmt = weight * qty;
            return cargoAmt;
        }
        public  string OutofStock()
        {
            string outof = "There are no more in stock";
            return outof;

        }

        public string NoSale()
        {
            string nosale = "We dont buy that type of Item here..";
            return nosale;
        }
        public string NotEnoughFuel()
        {
            string outof = "Not enough fuel to go here.";
            return outof;

        }
        public string SeperationLine()
        {
            string outof = "-----------------------------------------------------------------------------------------";
            return outof;

        }
        public string IncorrectSelection()
        {
            string outof = "Incorrect Selection";
            return outof;

        }

        public string NewShip()
        {
            string newship = "Item # 12 - Ship Upgrade (Total Cargo increase by 100) $5000";
            return newship;
        }

        public string GameOver()
        {
            string gameover = "" +
                "\n\n\n With no money, not fuel and no cargo, you sold your ship and without proper resources you have no choice but to look up to the sky\n" +
                "and remember when you used to own the stars...";
            return gameover;
        }
        public string PlayerQuit()
        {
            string gameover = "" +
                              "You determine that the life of a smuggler/merchant isnt for you. You sell your ship\n" +
                              "and take up a simple farmers life on your home world. At times you think about the fun \n" +
                              "You had on your journey...";
            return gameover;
        }
        public string Win()
        {
            string win = "After purchasing the larges station in the region you sit back while it makes you richer...";
            return win;
        }
        public string ThrustersCharging()
        {
            string win = "Thrusters Charging Please wait...";
            return win;
        }
        public string ThrustersCharged()
        {
            string win = "Thrusters Charged, Please Press Enter for Slip Space Jump...";
            return win;
        }

        public string Occupation(int membership)
        {
            if (membership == 1)
            {
                string occ = "Federation Member";
                return occ;
            }
            if (membership ==2)
            {
                string occ = "AT WAR";
                return occ;
            }
            if (membership == 3)
            {
                string occ = "Vurik Colony";
                return occ;
            }
            else
            {
                string occ = "Independant Colony";
                return occ;
            }

        }








    }
}
