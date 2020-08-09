using GalaticBusinessLibrary;
using Microsoft.VisualBasic;
using System;
using System.Reflection.Metadata;
using System.Threading.Channels;
using System.Xml.Serialization;
using SpaceMerchantLibrary;
using System.Threading;



namespace GalaxyBusiness

{
    class Program
    {
        

        
        static void Main(string[] args)
        {
            #region //Instatiated Objects
            Random battlechance = new Random();
            Menu menu = new Menu();
            Ship Zell = new Ship { Beryllium = 0, Aether =0, Carbon= 0, DarkMatter =0, Food = 0, Helium3 = 0, Lead = 0, Neutronium = 0, Thorium = 0, WaterIce = 0, Weapons = 0};
            Natotis natotis = new Natotis();
            Gelara gelara = new Gelara();
            Aoclite aoclite = new Aoclite();
            Larvis larvis = new Larvis();
            XaenidesStation xaenidesStation = new XaenidesStation();
            Otov otov = new Otov(); 
            Enemy smuggler = new Enemy { Attack = 100, Speed = 300, Hull = 500 }; 
            Enemy pirate = new Enemy { Attack = 200, Speed = 3, Hull = 800 }; 
            Enemy Federationscout = new Enemy { Attack = 400, Speed = 4, Hull = 400 };
            Battle battle = new Battle();
            InGameTime ingametime = new InGameTime {day= 12, month = 3, year = 2457};
            NatotisMissions natotisMissions = new NatotisMissions();
            OtovMissions otovMissions = new OtovMissions();
            //Companyies
            Stocks stock = new Stocks();
            Companies Zhul = new Companies { companyName = "Zhul Shuttle Co.", stockPrice = 75, symbol = "ZZZL", percentChange = 0};
            Companies Epsolon = new Companies { companyName = "Epsolon Motor Co.", stockPrice = 175, symbol = "EMC", percentChange = 0};
            Companies CrudeHelium = new Companies { companyName = "Crude Helium", stockPrice = 3000, symbol = "CLL", percentChange = 0};
            Companies TabletRetailers = new Companies { companyName = "Tablet Retailers", stockPrice = 16, symbol = "TRKL", percentChange = 0};
            Companies Valkyrie = new Companies { companyName = "Valkyrie Intelligence", stockPrice = 201, symbol = "VLG", percentChange = 0};

            #endregion
            int exit = 0;
            menu.planetChoice = 6;
            double tryparse;
            int natotisstatus = 1;
            int gelarastatus = 1;
            int acolitestatus = 1;
            int otovstatus = 3;
            int larvisstatus = 3;
            int xaendisstatus = 4;


            #region //Game Start
            Console.WriteLine(@"
                                                                ███████ ██████   █████   ██████ ███████     ███    ███ ███████ ██████   ██████ ██   ██  █████  ███    ██ ████████ 
                                                                ██      ██   ██ ██   ██ ██      ██          ████  ████ ██      ██   ██ ██      ██   ██ ██   ██ ████   ██    ██    
                                                                ███████ ██████  ███████ ██      █████       ██ ████ ██ █████   ██████  ██      ███████ ███████ ██ ██  ██    ██    
                                                                     ██ ██      ██   ██ ██      ██          ██  ██  ██ ██      ██   ██ ██      ██   ██ ██   ██ ██  ██ ██    ██    
                                                                ███████ ██      ██   ██  ██████ ███████     ██      ██ ███████ ██   ██  ██████ ██   ██ ██   ██ ██   ████    ██                                                                                                              
                                                                                                                                          
");
            Console.WriteLine("Press Enter..."); Console.ReadKey();
            //var audioPlayer = new BasicAudio.AudioPlayer();
            //audioPlayer.Filename = @"C:\Users\Johnny\Documents\GitHub\Space-Game\Galaxy_Business-master\GalaxyBusiness\outer-space-warning.wav";
            //audioPlayer.Play();

            Console.Clear();
            menu.StoryStart();
            foreach (var character in menu.StoryStart())
            {

                Console.Write(character);
                Thread.Sleep(10);
            }
            Console.ReadKey();
            int exit01 = 0;
            while (exit01 == 0)
            {
                Console.Clear();
                Console.WriteLine(menu.ShipSelection());
                string tempship = Console.ReadLine();
                double.TryParse(tempship, out tryparse);
                double shipselect = tryparse;
                if (shipselect == 1)
                {
                    Zell.TotalCargo = 50;
                    Zell.Fuel = 300;
                    Zell.Hull = 200;
                    Zell.Attack = 400;
                    Zell.Speed = 500;
                    Zell.Credits = 2000;
                    Console.Clear();
                    Console.WriteLine(
                        $"You purchased the Xaenides Cruiser : \n\n\nFuel: {Zell.Fuel} \n\nCargo:{Zell.TotalCargo} \n\nHull: {Zell.Hull} \n\nSpeed: {Zell.Speed} \n\nCredits: {Zell.Credits}" +
                        $"\n\n\n\n Press Enter...");
                    Console.ReadKey();
                    exit01 = 1;
                }

                if (shipselect == 2)
                {
                    Zell.TotalCargo = 350;
                    Zell.Fuel = 50;
                    Zell.Hull = 300;
                    Zell.Attack = 200;
                    Zell.Speed = 100;
                    Zell.Credits = 5000;
                    Console.Clear();
                    Console.WriteLine(
                        $"You purchased the Natotis Hauler : \n\n\nFuel: {Zell.Fuel} \n\nCargo:{Zell.TotalCargo} \n\nHull: {Zell.Hull} \n\nSpeed: {Zell.Speed} \n\nCredits: {Zell.Credits}" +
                        $"\n\n\n\n Press Enter...");
                    Console.ReadKey();
                    exit01 = 1;
                }

                if (shipselect == 3)
                {
                    Zell.TotalCargo = 100;
                    Zell.Fuel = 100;
                    Zell.Hull = 200;
                    Zell.Attack = 300;
                    Zell.Speed = 300;
                    Zell.Credits = 8000;
                    Console.Clear();
                    Console.WriteLine(
                        $"You decided to keep your ship: \n\n\nFuel: {Zell.Fuel} \n\nCargo:{Zell.TotalCargo} \n\nHull: {Zell.Hull} \n\nSpeed: {Zell.Speed} \n\nCredits: {Zell.Credits}" +
                        $"\n\n\n\n Press Enter...");
                    Console.ReadKey();
                    exit01 = 1;
                }
            }

            #endregion

            double fuelchecker = 0;
            double exitt = 0;
            while (exit <= 0)

            {
                
                if (Zell.Credits == 0 && Zell.Fuel == 0 || Zell.Credits == 0 && Zell.Cargo == 0)
                {
                    Console.WriteLine(menu.GameOver());
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                Console.Clear();
                while (exitt == 0)
                {
                    
                    #region MyRegion
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@" =================================================================================");
                    Console.WriteLine(@" ||                                    NAVVI SYSTEM                             ||");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@" ||=============================================================================||");
                    Console.WriteLine(@$" ||  Current System: Xaenides 2c                                                ||");
                    Console.WriteLine(@" ||                                                                             ||");
                    Console.WriteLine(@" ||                                                                             ||");
                    Console.WriteLine(@$" || {ingametime.day}/{ingametime.month}/{ingametime.year}                                                                   ||");
                    Console.WriteLine(@" ||                                                                             ||");
                    Console.WriteLine(@" ||=============================================================================||");
                    Console.WriteLine(@" ||=============================================================================||");
                    Console.WriteLine(@$" || Current Fuel: {Zell.Fuel}                                                           ||");
                    Console.WriteLine(@$" || Credit Ledger: {Zell.Credits}                                                         ||");
                    Console.WriteLine(@" ||                                                                             ||");
                    Console.WriteLine(@" ||                                                                             ||");
                    Console.WriteLine(@" ||                                                                             ||");
                    Console.WriteLine($@" || 1 - Natotis  (30 Feul)                                                      ||");
                    Console.WriteLine(@" || 2 - Otov     (15 Feul)                                                      ||");
                    Console.WriteLine(@" || 3 - Gelara   (15 Feul)                                                      ||");
                    Console.WriteLine(@" || 4 - Larvis   (15 Feul)                                                      ||");
                    Console.WriteLine(@" || 5 - Aoclite  (25 Feul)                                                      ||");
                    Console.WriteLine(@" ||                                                                             ||");
                    Console.WriteLine(@" ||                                                                             ||");
                    Console.WriteLine(@" ||                                                                             ||");
                    Console.WriteLine(@" ||                                                                             ||");
                    Console.WriteLine(@" ||                                                                             ||");
                    Console.WriteLine(@" ||                                                                             ||");
                    Console.WriteLine(@" ||                                                                             ||");
                    Console.WriteLine(@" ||=============================================================================||");
                    Console.WriteLine(@" || Galaxy News Network [Vurik presence growing in surrounding galaxies some wo.||");
                    Console.WriteLine(@" ||=============================================================================||");


                    #endregion

                    Console.WriteLine();
                    Console.Write("> ");
                    string tempvaluek = Console.ReadLine();
                    double.TryParse(tempvaluek, out tryparse);
                    if (tryparse==1){ menu.planetChoice = tryparse; exitt = 1; }
                    if (tryparse == 2) { menu.planetChoice = tryparse; exitt = 1; }
                    if (tryparse == 3) { menu.planetChoice = tryparse; exitt = 1; }
                    if (tryparse == 4) { menu.planetChoice = tryparse; exitt = 1; }
                    if (tryparse == 5) { menu.planetChoice = tryparse; exitt = 1; }
                    if (tryparse == 0) { menu.planetChoice = 6; exitt = 1; }

                    if (tryparse == 1 || tryparse == 2 || tryparse == 3 || tryparse == 4 || tryparse == 5)
                    {
                        Console.WriteLine(menu.ThrustersCharging());
                        ShowSimplePercentage();
                        int milliseconds = 600;
                        Thread.Sleep(milliseconds);
                        Console.WriteLine();
                        Console.WriteLine(menu.ThrustersCharged());
                        Console.ReadKey();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Clear();
                }
               Console.ForegroundColor = ConsoleColor.White;
                switch (menu.planetChoice)
                {
                    case 1://Natotis 
                        ingametime.time(menu.planetChoice);
                        Zell.Fuel -= 30;
                        int exit1 = 0;
                        natotis.ItemCalculation();
                        StockGen();
                        #region //Ship interaction
                        Console.WriteLine(battle.ShipEmerges(battle.Battlechance(battlechance.Next(0, 100))));
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine($"\n  {battle.ShipEngages(battle.shipChoice)}");
                        Console.WriteLine(battle.PlayerConfronts(battle.shipChoice));
                         int confront = Int32.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine(battle.ShipResponds(battle.shipChoice,confront,Zell.Speed,Zell.Hull,Zell.Attack,Zell.Weapons,Zell.Credits));
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine(battle.ConflictResult(battle.shipChoice, confront, Zell.Weapons, Zell.Credits, Zell.Speed, Zell.Hull, Zell.Attack));
                        Console.ReadLine();
                        #region Conflict results
                        if (battle.shipChoice == 4)//Federation Flagship
                        {


                            if (confront == 1)
                            {
                                if (Zell.DarkMatter <= 0)
                                {
                                    
                                    Zell.Fuel -= 20;
                                }

                                if (Zell.DarkMatter > 0)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    ingametime.month += 3;
                                    break;
                                }
                            }
                            if (confront == 2)
                            {
                                if (Zell.Credits > 50000)
                                {
                                    Zell.Credits = Zell.Credits - (Zell.Credits * .10);
                                }

                                if (Zell.Credits < 50000)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    ingametime.month += 3;
                                    break;
                                }
                            }
                            if (confront == 3)
                            {
                                

                                if (Zell.DarkMatter > 0 && Zell.Credits < 20000)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }

                                if (Zell.DarkMatter > 0 && Zell.Credits > 20000)
                                {
                                    Zell.Credits = Zell.Credits - (Zell.Credits * .05);

                                }
                            }
                        }
                        if (battle.shipChoice == 3)//Federation Cruiser
                        {


                            if (confront == 1)
                            {
                                if (Zell.DarkMatter <= 0)
                                {

                                    Zell.Fuel -= 20;
                                }

                                if (Zell.DarkMatter > 0)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    ingametime.month += 3;
                                    break;
                                }
                            }
                            if (confront == 2)
                            {
                                if (Zell.Credits > 20000)
                                {
                                    Zell.Credits = Zell.Credits - (Zell.Credits * .05);
                                }

                                if (Zell.Credits < 20000)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    ingametime.month += 3;
                                    break;
                                }
                            }
                            if (confront == 3)
                            {


                                if (Zell.DarkMatter > 0 && Zell.Credits < 15000)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }

                                if (Zell.DarkMatter > 0 && Zell.Credits > 15000)
                                {
                                    Zell.Credits = Zell.Credits - (Zell.Credits * .02);

                                }
                            }
                        }
                        if (battle.shipChoice == 2)//Pirate
                        {

                            if (confront == 1)
                            {

                                
                                if (Zell.Speed < smuggler.Speed)
                                { Zell.Credits -= 500; }
                                
                            }
                            if (confront == 2)
                            {
                                
                                if (Zell.Attack < smuggler.Hull)
                                {
                                    Zell.Credits -= 500;
                                }
                                
                            }
                            if (confront == 3)
                            {
                                Zell.Credits -= 500;
                            }
                        }
                        if (battle.shipChoice == 1) //smuggler
                        {
                            if (confront == 3)
                            {
                                Zell.Weapons += 1;
                                Zell.Credits -= 500;
                            }

                        }
                        if (battle.shipChoice == 0) //Normal
                        {
                            if (confront == 2)
                            {
                                if (battle.brokenShip() == 9)
                                {
                                    Console.WriteLine("You found some containers with 3- Beryllium"); Console.ReadKey();
                                    Zell.Beryllium += 1;
                                }
                                if (battle.brokenShip() == 5)
                                {
                                    Console.WriteLine("You found some containers with 3- Water/Ice"); Console.ReadKey();
                                    Zell.WaterIce += 1;
                                }
                                if (battle.brokenShip() == 2)
                                {
                                    Console.WriteLine("You found some containers with 1 - Lead"); Console.ReadKey();
                                    Zell.Lead += 1;
                                }
                                if (battle.brokenShip() == 15)
                                {
                                    Console.WriteLine("You found some containers with 1 - Neutronium");
                                    Console.ReadKey();
                                    Zell.Neutronium += 1;
                                }
                                else
                                {
                                    Console.WriteLine("You found nothing.... ");
                                }

                            }

                        }


                        #endregion
                        #endregion
                        while (exit1 == 0)// Exits once user chooses to go back to ship
                        {
                            #region  //Planet welcome dialog
                                                                               
                            Console.Clear();
                            Console.WriteLine();
                            Console.Write(@" ███    ██  █████  ████████  ██████  ████████ ██ ███████ 
████   ██ ██   ██    ██    ██    ██    ██    ██ ██      
██ ██  ██ ███████    ██    ██    ██    ██    ██ ███████ 
██  ██ ██ ██   ██    ██    ██    ██    ██    ██      ██ 
██   ████ ██   ██    ██     ██████     ██    ██ ███████"); Console.Write($"\t{menu.Occupation(1)}");
                            Console.WriteLine();
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine(menu.NatotisArt());
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine($"{natotis.Description()}\n\n\n");
                            Console.WriteLine(menu.PlanetDialog());
                            #endregion

                            
                            string tempvalue = Console.ReadLine();
                            double.TryParse(tempvalue, out tryparse);
                            double choice = tryparse;
                            Console.Clear();
                            switch (choice)
                            {
                                case 1://Marketplace
                                    int marketexit = 0;
                                    while (marketexit == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine();
                                        Console.WriteLine(
                                            @"███    ███  █████  ██████  ██   ██ ███████ ████████ ██████  ██       █████   ██████ ███████ 
████  ████ ██   ██ ██   ██ ██  ██  ██         ██    ██   ██ ██      ██   ██ ██      ██      
██ ████ ██ ███████ ██████  █████   █████      ██    ██████  ██      ███████ ██      █████   
██  ██  ██ ██   ██ ██   ██ ██  ██  ██         ██    ██      ██      ██   ██ ██      ██      
██      ██ ██   ██ ██   ██ ██   ██ ███████    ██    ██      ███████ ██   ██  ██████ ███████");
                                        Console.WriteLine(
                                            "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine(
                                            "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine($"\n\n{menu.ShopDialog()}");
                                        Console.Write("> ");
                                        string tempvalue0 = Console.ReadLine();
                                        double.TryParse(tempvalue0, out tryparse);
                                        Console.Clear();
                                        double commerceChoice = tryparse;
                                        switch (commerceChoice)
                                        {
                                            case 1: //Buy

                                                #region //BUY
                                                Console.WriteLine();
                                                Console.WriteLine(
                                                    @"███    ███  █████  ██████  ██   ██ ███████ ████████ ██████  ██       █████   ██████ ███████ 
████  ████ ██   ██ ██   ██ ██  ██  ██         ██    ██   ██ ██      ██   ██ ██      ██      
██ ████ ██ ███████ ██████  █████   █████      ██    ██████  ██      ███████ ██      █████   
██  ██  ██ ██   ██ ██   ██ ██  ██  ██         ██    ██      ██      ██   ██ ██      ██      
██      ██ ██   ██ ██   ██ ██   ██ ███████    ██    ██      ███████ ██   ██  ██████ ███████");

                                                Console.WriteLine(natotis.BuyWelcome());
                                                Console.ReadLine();

                                                #region Item sale list

                                                Console.WriteLine($"Credits: {Zell.Credits}\n\n Cargo:{Zell.Cargo} / {Zell.TotalCargo}\n\n");
                                                Console.WriteLine($"\n{natotis.Dithprice()}");
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine($"{natotis.Beryllprice()}\n");
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(natotis.Carbonprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(natotis.Thoriumprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(natotis.WaterIceprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(natotis.Leadprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(natotis.Aetherprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(natotis.Foodprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(natotis.Helium3price());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(natotis.Neutroniumprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(natotis.DarkMatterprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(menu.NewShip());

                                                #endregion

                                                Console.Write("\n\nWhat would you like to purchase?:");
                                                string tempvalue1 = Console.ReadLine();
                                                double.TryParse(tempvalue1, out tryparse);
                                                double item = tryparse;
                                                if (item == 99)
                                                {
                                                    break;}
                                                if (natotis.QtyTranslation(item) == 0)
                                                {
                                                    Console.WriteLine(menu.OutofStock());
                                                    Console.ReadKey();
                                                    break;
                                                }

                                                Console.Write("\n\nHow many?:");
                                                string tempvalue2 = Console.ReadLine();
                                                double.TryParse(tempvalue2, out tryparse);
                                                double amount = tryparse;
                                                if (menu.TotalCargo(natotis.WeightTranslation(item), amount) +
                                                    Zell.Cargo >
                                                    Zell.TotalCargo) // sees if you have room to buy more items
                                                {
                                                    Console.WriteLine(menu.NotEnoughCargo());
                                                    Console.ReadKey();
                                                    break;
                                                }

                                                if (menu.PurchasePrice(natotis.ItemTranslation(item), amount) >
                                                    Zell.Credits) //sees if you have money to buy more items
                                                {
                                                    Console.WriteLine(menu.NotEnoughCredits());
                                                    Console.ReadLine();
                                                    break;
                                                }
                                                if (natotis.ItemTranslation(item) - amount < 0)
                                                {
                                                    Console.WriteLine(menu.OutofStock()); Console.ReadKey();
                                                    break;  // sees if your purchase will put the store into negative stock
                                                }

                                                Console.Clear();
                                                Console.WriteLine(
                                                    $"\n\nSale total is : ${menu.PurchasePrice(natotis.ItemTranslation(item), amount):C}  Weight:{menu.TotalCargo(natotis.WeightTranslation(item), amount):C}");

                                                #region //Math to reduce Qty and raise cargo

                                                switch (item)
                                                {
                                                    case 1:
                                                        Zell.Fuel += amount;
                                                        natotis.Dilithium.Qty -= amount;
                                                        break;
                                                    case 2:
                                                        Zell.Beryllium += amount;
                                                        natotis.Beryllium.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(natotis.WeightTranslation(item),
                                                            amount);
                                                        break;
                                                    case 3:
                                                        Zell.Carbon += amount;
                                                        natotis.Carbon.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(natotis.WeightTranslation(item),
                                                            amount);
                                                        break;
                                                    case 4:
                                                        Zell.Thorium += amount;
                                                        natotis.Thorium.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(natotis.WeightTranslation(item),
                                                            amount);
                                                        break;
                                                    case 5:
                                                        Zell.WaterIce += amount;
                                                        natotis.WaterIce.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(natotis.WeightTranslation(item),
                                                            amount);
                                                        break;
                                                    case 6:
                                                        Zell.Lead += amount;
                                                        natotis.Lead.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(natotis.WeightTranslation(item),
                                                            amount);
                                                        break;
                                                    case 7:
                                                        Zell.Aether += amount;
                                                        natotis.Aether.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(natotis.WeightTranslation(item),
                                                            amount);
                                                        break;
                                                    case 8:
                                                        Zell.Food += amount;
                                                        natotis.Food.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(natotis.WeightTranslation(item),
                                                            amount);
                                                        break;
                                                    case 9:
                                                        Zell.Neutronium += amount;
                                                        natotis.Neutronium.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(natotis.WeightTranslation(item),
                                                            amount);
                                                        break;
                                                    case 10:
                                                        Zell.Helium3 += amount;
                                                        natotis.Helium3.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(natotis.WeightTranslation(item),
                                                            amount);
                                                        break;
                                                    case 11:
                                                        Zell.DarkMatter += amount;
                                                        natotis.DarkMatter.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(natotis.WeightTranslation(item),
                                                            amount);
                                                        break;
                                                    case 12:
                                                        Zell.TotalCargo += 100;
                                                        break;
                                                }

                                                Zell.Credits -= menu.PurchasePrice(natotis.ItemTranslation(item),
                                                    amount);

                                                #endregion

                                                Console.WriteLine(
                                                    $"\n\nCredits remaining: ${Zell.Credits}\n\nTotal Cargo: {Zell.Cargo} / {Zell.TotalCargo}\n\nFuel Level: {Zell.Fuel}");
                                                Console.WriteLine($"\n\n{Zell.InventoryDisplay()}");
                                                Console.ReadLine();
                                                Console.Clear();

                                                #endregion

                                                break;
                                            case 2: //Sell

                                                #region //SELL
                                                Console.Clear();
                                                Console.WriteLine(
                                                    @"███    ███  █████  ██████  ██   ██ ███████ ████████ ██████  ██       █████   ██████ ███████ 
████  ████ ██   ██ ██   ██ ██  ██  ██         ██    ██   ██ ██      ██   ██ ██      ██      
██ ████ ██ ███████ ██████  █████   █████      ██    ██████  ██      ███████ ██      █████   
██  ██  ██ ██   ██ ██   ██ ██  ██  ██         ██    ██      ██      ██   ██ ██      ██      
██      ██ ██   ██ ██   ██ ██   ██ ███████    ██    ██      ███████ ██   ██  ██████ ███████");

                                                Console.WriteLine($"{natotis.SellWelcome()}\n\n");
                                                Console.ReadLine();
                                                Console.WriteLine(
                                                    $"Current Prices:\n\n{natotis.DithSellprice()} \n {natotis.BeryllSellprice()} \n {natotis.CarbonSellprice()} \n {natotis.ThoriumSellprice()} \n " +
                                                    $"{natotis.WaterIceSellprice()} \n {natotis.LeadSellprice()} \n {natotis.AetherSellprice()} \n {natotis.FoodSellprice()} \n {natotis.NeutroniumSellprice()} \n {natotis.Helium3Sellprice()} \n " +
                                                    $"{natotis.DarkMatterSellprice()}");
                                                Console.WriteLine($"\n\nYour Inventory:\n\n {Zell.InventoryDisplay()}");
                                                Console.Write("\n\nWhat would you like to sell?:");
                                                string tempvalue3 = Console.ReadLine();
                                                double.TryParse(tempvalue3, out tryparse);
                                                double item2 = tryparse;
                                                if (item2 == 99)
                                                {
                                                    break;
                                                }
                                                if (natotis.QtyTranslation(item2) == 0)
                                                {
                                                    Console.WriteLine(menu.OutofStock());
                                                    Console.ReadKey();
                                                    break;
                                                }
                                                

                                                Console.Write("\n\nHow many?:");
                                                string tempvalue4 = Console.ReadLine();
                                                double.TryParse(tempvalue4, out tryparse);
                                                double amount2 = tryparse;
                                                Console.Clear();
                                                if (Zell.ItemTranslation(item2) - amount2 < 0)
                                                {
                                                    Console.WriteLine(menu.NotEnoughItems());
                                                    Console.ReadKey();
                                                    break;
                                                }

                                                Console.WriteLine(
                                                    $"\n\nSale total is : ${menu.PurchasePrice(natotis.ItemTranslation(item2), amount2):C}  Weight:{menu.TotalCargo(natotis.WeightTranslation(item2), amount2):C}");
                                                switch (item2)
                                                {

                                                    case 2:
                                                        Zell.Beryllium -= amount2;
                                                        natotis.Beryllium.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(natotis.WeightTranslation(item2),
                                                            amount2);
                                                        break;
                                                    case 3:
                                                        Zell.Carbon -= amount2;
                                                        natotis.Carbon.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(natotis.WeightTranslation(item2),
                                                            amount2);
                                                        break;
                                                    case 4:
                                                        Zell.Thorium -= amount2;
                                                        natotis.Thorium.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(natotis.WeightTranslation(item2),
                                                            amount2);
                                                        break;
                                                    case 5:
                                                        Zell.WaterIce -= amount2;
                                                        natotis.WaterIce.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(natotis.WeightTranslation(item2),
                                                            amount2);
                                                        break;
                                                    case 6:
                                                        Zell.Lead -= amount2;
                                                        natotis.Lead.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(natotis.WeightTranslation(item2),
                                                            amount2);
                                                        break;
                                                    case 7:
                                                        Zell.Aether -= amount2;
                                                        natotis.Aether.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(natotis.WeightTranslation(item2),
                                                            amount2);
                                                        break;
                                                    case 8:
                                                        Zell.Food -= amount2;
                                                        natotis.Food.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(natotis.WeightTranslation(item2),
                                                            amount2);
                                                        break;
                                                    case 9:
                                                        Zell.Neutronium -= amount2;
                                                        natotis.Neutronium.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(natotis.WeightTranslation(item2),
                                                            amount2);
                                                        break;
                                                    case 10:
                                                        Zell.Helium3 -= amount2;
                                                        natotis.Helium3.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(natotis.WeightTranslation(item2),
                                                            amount2);
                                                        break;
                                                    case 11:
                                                        Zell.DarkMatter -= amount2;
                                                        natotis.DarkMatter.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(natotis.WeightTranslation(item2),
                                                            amount2);
                                                        break;
                                                }

                                                Zell.Credits += menu.PurchasePrice(natotis.ItemTranslation(item2),
                                                    amount2);
                                                Console.WriteLine(
                                                    $"\nCredits remaining: ${Zell.Credits}\n\nTotal Cargo: {Zell.Cargo} / {Zell.TotalCargo}\n\nFuel Level: {Zell.Fuel}");
                                                Console.WriteLine(Zell.InventoryDisplay());
                                                Console.ReadKey();

                                                #endregion

                                                break;
                                            case 99:
                                                marketexit = 1;
                                                break;
                                        }
                                    }

                                    break;
                                case 2://Capital City
                                    int zhulexit = 0;
                                    while (zhulexit == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine();
                                        Console.WriteLine(
                                            @"███████ ██   ██ ██    ██ ██           ██████ ██ ████████ ██    ██ 
   ███  ██   ██ ██    ██ ██          ██      ██    ██     ██  ██  
  ███   ███████ ██    ██ ██          ██      ██    ██      ████   
 ███    ██   ██ ██    ██ ██          ██      ██    ██       ██    
███████ ██   ██  ██████  ███████      ██████ ██    ██       ██ ");
                                        Console.WriteLine(
                                            "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine(
                                            "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine($"\n\n{natotis.ZhulOptions()}");
                                        string tempvalue01 = Console.ReadLine();
                                        double.TryParse(tempvalue01, out tryparse);
                                        double zhulChoice = tryparse;
                                        switch (zhulChoice)
                                        {
                                            case 1: //Warehouse
                                                #region //Warehouse
                                                Console.WriteLine(
                                                    "Warehouse district is large and contains with many factories");
                                                Console.ReadKey();
                                                Console.WriteLine(
                                                    "This area will have corporate espionage missions and sabatoge missions");
                                                Console.ReadKey();
                                                #endregion
                                                break;
                                            case 2: //Technology District
                                                #region //Tech
                                                Console.WriteLine(
                                                    "The technology District is where much of the research and business takes place on Natotis..");
                                                Console.ReadKey();
                                                Console.WriteLine(
                                                    "The technology District will have missions where you can invest money and collect later on.like a stock market ");
                                                Console.ReadKey();
                                                #endregion
                                                break;
                                            case 3: //Cantina
                                                #region //Cantina
                                                Console.Clear();
                                                Console.WriteLine();
                                                Console.WriteLine(@"███    ███  █████  ██   ██ ██ ██     ██ ██      ██████  █████  ███    ██ ████████ ██ ███    ██  █████  
████  ████ ██   ██ ██  ██  ██ ██     ██ ██     ██      ██   ██ ████   ██    ██    ██ ████   ██ ██   ██ 
██ ████ ██ ███████ █████   ██ ██  █  ██ ██     ██      ███████ ██ ██  ██    ██    ██ ██ ██  ██ ███████ 
██  ██  ██ ██   ██ ██  ██  ██ ██ ███ ██ ██     ██      ██   ██ ██  ██ ██    ██    ██ ██  ██ ██ ██   ██ 
██      ██ ██   ██ ██   ██ ██  ███ ███  ██      ██████ ██   ██ ██   ████    ██    ██ ██   ████ ██   ██");
                                                Console.WriteLine(
                                                    "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                                Console.WriteLine(
                                                    "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                                                Console.WriteLine(
                                                    "The Makiwi Cantina is a small bar the plays host to many world travelers");
                                                Console.ReadKey();
                                                Console.Clear();
                                                if (Zell.Weapons > 0)
                                                {
                                                    
                                                    Console.WriteLine("You walk in and have a few drinks, after a while you hear rumbles that there is an arms dealer \n" +
                                                                      "sitting at the table across the bar. You think about the stock of weapons you have on your ship.\n" +
                                                                      "You walk over and make conversation and let it 'slip' that you have Federation weapons. He seems\n" +
                                                                      "interested and you head back to your ship. After inspecting the contents, he offers to pay 600 for\n" +
                                                                      "each.");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    Zell.Credits = Zell.Weapons * 600;
                                                    Zell.Weapons = 0;

                                                }//Sell weapons
                                                Console.WriteLine(natotisMissions.CantinaEntry());
                                                string tempchoice = Console.ReadLine();
                                                double.TryParse(tempchoice, out tryparse);
                                                double cantinaChoice = tryparse;
                                                switch (cantinaChoice)
                                                {
                                                    case 1:
                                                        if (natotisMissions.Supply001Success == 3)
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine(natotisMissions.Supply001Mission());
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                            Console.WriteLine(natotisMissions.Supply001AA());
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                            Console.WriteLine(natotisMissions.Supply001BB());
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                        }
                                                        else if (natotisMissions.Supply001Success == 1)
                                                        {
                                                            Console.WriteLine("You look for him but are told he is in the back room");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                        }
                                                        else if (natotisMissions.Supply001Success == 0)
                                                        {
                                                            Console.WriteLine("You see the half-Vurik, he is drunk in the corner, he sees you and yells 'hurry my people need you!' \n" +
                                                                              "afterwards he shuffles to the bar and orders another beer. ");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                        }
                                                        else if (natotisMissions.Supply001Success == 0)
                                                        {
                                                            Console.WriteLine("After the killing of the resistance member, there arent any resistance fighters around this cantina anymore...");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                        }
                                                        break;
                                                    case 2:
                                                        Console.WriteLine("You look for him but are told he is in the back room");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case 3:
                                                        Console.WriteLine("There are guards at the door to the back room, apparently there is a meeting going on...");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case 99:
                                                        break;
                                                }
                                                #endregion
                                                break;
                                            case 4: //Senate Building
                                                #region //Senate
                                                Console.WriteLine(
                                                    "Natotis is the Federatrions political stronghold in the area. This makes the Natotis Senate\n" +
                                                    "one of the most inportant locations in this system cluster.");
                                                Console.ReadKey();
                                                Console.WriteLine(
                                                    "This will have some of the 'story missions' and possibly where you can become and envoy.");
                                                Console.ReadKey();
                                                #endregion
                                                break;
                                            case 99:
                                                zhulexit = 1;
                                                break;
                                        }
                                    }
                                    break;
                                case 3://Mission Board
                                    int exitmission = 1;
                                    while (exitmission == 1)
                                    {
                                        #region //Mission Endings
                                        if (natotisMissions.Mission001success == 1 || natotisMissions.Mission001success == 0)
                                        {
                                            Console.WriteLine(natotisMissions.Escort001Ends(natotisMissions.Mission001success));
                                            Console.ReadKey();
                                            Console.Clear();
                                            if (natotisMissions.Mission001success == 1)
                                            {
                                                Zell.Credits += 4000;
                                                Zell.Reputation -= 2;
                                                Zell.FederationFavor += 1;
                                                Zell.VurikFavor -= 2;
                                            }
                                        }
                                        if (natotisMissions.Mission002success == 1 || natotisMissions.Mission002success == 0)
                                        {
                                            Console.WriteLine(natotisMissions.Delivery002Ends(natotisMissions.Mission002success));
                                            Console.ReadKey();
                                            Console.Clear();
                                            if (natotisMissions.Mission002success == 1)
                                            {
                                                Zell.Credits += 8000;
                                                Zell.Reputation += 2;
                                                Zell.FederationFavor -= 2;
                                                Zell.VurikFavor += 3;
                                            }
                                        }

                                        #endregion
                                        Console.WriteLine();
                                        Console.WriteLine(@"███    ███ ██ ███████ ███████ ██  ██████  ███    ██     ██████   ██████   █████  ██████  ██████  
████  ████ ██ ██      ██      ██ ██    ██ ████   ██     ██   ██ ██    ██ ██   ██ ██   ██ ██   ██ 
██ ████ ██ ██ ███████ ███████ ██ ██    ██ ██ ██  ██     ██████  ██    ██ ███████ ██████  ██   ██ 
██  ██  ██ ██      ██      ██ ██ ██    ██ ██  ██ ██     ██   ██ ██    ██ ██   ██ ██   ██ ██   ██ 
██      ██ ██ ███████ ███████ ██  ██████  ██   ████     ██████   ██████  ██   ██ ██   ██ ██████ ");
                                        Console.WriteLine();
                                        Console.WriteLine(
                                            "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                                        Console.WriteLine(natotisMissions.MissionBoard());
                                        Console.ReadKey();

                                        #region Mission graphic

                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine(
                                            @" =========================================================================================");
                                        Console.WriteLine(
                                            @" ||                       Natotis Federation Assist Board                               ||");

                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine(
                                            @" ||=====================================================================================||");
                                        Console.WriteLine(
                                            @$" ||  Current System: Natotis                                                            ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @$" || {ingametime.month}/{ingametime.day}/{ingametime.year}                                ");
                                        Console.WriteLine(
                                            @" ||=====================================================================================||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||=====================================================================================||");
                                        Console.WriteLine(
                                            @$" ||                                                                                     || ");
                                        if (ingametime.month == 3 && ingametime.day <= 31 && ingametime.year == 2457 &&
                                            natotisMissions.Mission001success == 3)
                                        {
                                            Console.WriteLine($"#1 -  {natotisMissions.Escort001advertisement()}");
                                        }
                                        if (ingametime.month == 3 && ingametime.day <= 31 && ingametime.year == 2457 &&
                                            natotisMissions.Mission001success ==2)
                                        {
                                            Console.WriteLine($"#1 -  {natotisMissions.Escort001InProgress()}");
                                        }

                                        Console.WriteLine(
                                            @$" ||                                                                                     ||");
                                        if (ingametime.month <= 5 &&  ingametime.year == 2457 &&
                                            natotisMissions.Mission002success == 3)
                                        {
                                            Console.WriteLine($"#2 -  {natotisMissions.Delivery002advertisement()}");
                                        }
                                        if (ingametime.month <= 5 && ingametime.year == 2457 &&
                                            natotisMissions.Mission002success == 2)
                                        {
                                            Console.WriteLine($"#2 -  {natotisMissions.Delivery002InProgress()}");
                                        }
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            $@" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||=====================================================================================||");
                                        Console.WriteLine("\n\n\n Please choose a mission and press Enter or press 99 to exit..");
                                        Console.Write(">"); string tempvalu = Console.ReadLine();
                                        double.TryParse(tempvalu, out tryparse);
                                        double mission = tryparse;
                                        if (mission == 99)
                                        {
                                            exitmission = 0;}
                                        if (natotisMissions.Mission001success == 3)
                                        {
                                            if (mission == 1)
                                            {
                                                Console.Clear();
                                                Console.WriteLine(natotisMissions.Escort001());
                                                string tempvalu1 = Console.ReadLine();
                                                Console.Clear();
                                                double.TryParse(tempvalu1, out tryparse);
                                                double mission2 = tryparse;
                                                Console.WriteLine(natotisMissions.Escort001A(mission2));
                                                Console.ReadKey();
                                                if (mission2 == 2)
                                                {
                                                    natotisMissions.Mission001success = 4;
                                                }
                                            }
                                        }
                                        if (natotisMissions.Mission002success == 3)
                                        {
                                            if (mission == 2)
                                            {
                                                Console.Clear();
                                                Console.WriteLine(natotisMissions.Delivery002());
                                                string tempvalu1 = Console.ReadLine();
                                                Console.Clear();
                                                double.TryParse(tempvalu1, out tryparse);
                                                double mission2 = tryparse;
                                                Console.WriteLine(natotisMissions.Delivery002A(mission2));
                                                Console.ReadKey();
                                                if (mission2 == 2)
                                                {
                                                    natotisMissions.Mission002success = 4;
                                                }
                                            }
                                        }

                                        Console.Clear();

                                        #endregion
                                    }
                                    Console.ForegroundColor = ConsoleColor.White;
                                    break;
                                case 4://Back to Ship
                                    #region //BACK TO SHIP
                                    #region Navvi
                                    Console.WriteLine(@"███    ██  █████  ██    ██ ██    ██ ██     ███████ ██    ██ ███████ ████████ ███████ ███    ███ 
████   ██ ██   ██ ██    ██ ██    ██ ██     ██       ██  ██  ██         ██    ██      ████  ████ 
██ ██  ██ ███████ ██    ██ ██    ██ ██     ███████   ████   ███████    ██    █████   ██ ████ ██ 
██  ██ ██ ██   ██  ██  ██   ██  ██  ██          ██    ██         ██    ██    ██      ██  ██  ██ 
██   ████ ██   ██   ████     ████   ██     ███████    ██    ███████    ██    ███████ ██      ██ ");
                                    Console.WriteLine("\n\n");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(@" =================================================================================");
                                    Console.WriteLine(@" ||                                    NAVVI SYSTEM                             ||");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(@" ||=============================================================================||");
                                    Console.WriteLine(@$" ||  Current System: Natotis                                                   ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@$" || {ingametime.month}/{ingametime.day}/{ingametime.year}                                                                   ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||=============================================================================||");
                                    Console.WriteLine(@" ||=============================================================================||");
                                    Console.WriteLine(@$" || Current Fuel: {Zell.Fuel}                                                         ");
                                    Console.WriteLine(@$" || Credit Ledger: {Zell.Credits}                                                    ");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||  0 - Stay on Planet                                                         ||");
                                    Console.WriteLine(@" ||  2 - Otov (15 Feul)                                                         ||");
                                    Console.WriteLine(@" ||  3 - Gelara (15 Feul)                                                       ||");
                                    Console.WriteLine(@" ||  6 - XaenidesStation (5 Feul)                                               ||");
                                    Console.WriteLine(@" ||  99 = Exit Game                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||=============================================================================||");
                                    Console.WriteLine($@" ||                                                                            ||");
                                    Console.WriteLine(@" ||=============================================================================||");
                                    #endregion
                                    
                                    string Natotisexit = Console.ReadLine();
                                    if (double.TryParse(Natotisexit, out tryparse))
                                    {
                                        menu.planetChoice = tryparse;
                                    }
                                    fuelchecker = (menu.ChekForFuel(Zell.Fuel));
                                    if (fuelchecker == 0)
                                    {
                                        menu.planetChoice = 1;
                                        Console.WriteLine(menu.NotEnoughFuel());
                                        Console.ReadKey();
                                    }
                                    Console.Clear();
                                    if (fuelchecker == 1)
                                    {
                                        if (menu.planetChoice == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.White;
                                            break;
                                        }
                                        if (menu.planetChoice == 2 || menu.planetChoice == 3 || menu.planetChoice == 6 ||
                                            menu.planetChoice == 99)
                                        {
                                            exitt = 1;
                                        }
                                        else if (menu.planetChoice != 2 || menu.planetChoice != 3 || menu.planetChoice != 6 ||
                                                 menu.planetChoice != 99)
                                        {
                                            menu.planetChoice = 1;
                                            Console.WriteLine(menu.IncorrectSelection());
                                            exitt = 0;
                                        }
                                    }
                                    Console.WriteLine(menu.ThrustersCharging());
                                    ShowSimplePercentage();
                                    int milliseconds = 600;
                                    Thread.Sleep(milliseconds);
                                    Console.WriteLine();
                                    Console.WriteLine(menu.ThrustersCharged());
                                    Console.ReadKey();
                                    Console.Clear();
                                    exit1 = 1;
                                    Console.ForegroundColor = ConsoleColor.White;
                                    #endregion
                                    break;
                                case 5://Inventory
                                    Console.WriteLine(Zell.InventoryDisplay());
                                    if (Zell.Weapons > 0)
                                    {
                                        Console.WriteLine($"Weapons: {Zell.Weapons}");}
                                    #region //Mission log for inventory
                                    if (ingametime.month == 3 && ingametime.day <= 31 && ingametime.year == 2457 &&
                                        natotisMissions.Mission001success == 2)
                                    {
                                        Console.WriteLine($"\n\nNatotis #1 -  {natotisMissions.Escort001InProgress()}");
                                    }
                                    if (ingametime.month <= 5 && ingametime.year == 2457 &&
                                        natotisMissions.Mission002success == 2)
                                    {
                                        Console.WriteLine($"\nNatotis #2 -  {natotisMissions.Delivery002InProgress()}");
                                    }
                                    if (natotisMissions.Supply001Success == 2)
                                    {
                                        Console.WriteLine($"\nNatotis -  {natotisMissions.Supply001InProgress()}");
                                    }


                                    #endregion
                                    Console.ReadKey();
                                    break;
                                case 6:
                                    StockMarket();
                                    break;
                                case 7:
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine(@" =================================================================================");
                                    Console.WriteLine(@" ||                          Galactic News Network                              ||");
                                    Console.WriteLine(@" ||=============================================================================||");
                                    Console.WriteLine(@$" ||  Current System: Natotis                                                   ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@$" || {ingametime.month}/{ingametime.day}/{ingametime.year}                                                                   ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||=============================================================================||");
                                    Console.WriteLine(@" ||=============================================================================||");
                                    Console.WriteLine(@$" ||                                                                              ");
                                    Console.WriteLine(@$" ||                                                                              ");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine($@" ||    {News()}                                                                         ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||=============================================================================||");
                                    Console.WriteLine($@" ||                                                                            ||");
                                    Console.WriteLine(@" ||=============================================================================||");
                                    break;

                            }



                        }
                        break;
                    case 2://Otov
                        ingametime.time(menu.planetChoice);
                        Zell.Fuel -= 15;
                        int exit2 = 0;
                        otov.ItemCalculation();
                        StockGen();
                        #region //Ship interaction
                        Console.WriteLine(battle.ShipEmerges(battle.Battlechance(battlechance.Next(0, 100))));
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine($"\n" + battle.ShipEngages(battle.shipChoice));
                        Console.WriteLine(battle.PlayerConfronts(battle.shipChoice));
                        int confront1 = Int32.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine(battle.ShipResponds(battle.shipChoice, confront1, Zell.Speed, Zell.Hull, Zell.Attack, Zell.Weapons, Zell.Credits));
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine(battle.ConflictResult(battle.shipChoice, confront1, Zell.Weapons, Zell.Credits, Zell.Speed, Zell.Hull, Zell.Attack));
                        #region Conflict results
                        if (battle.shipChoice == 4)//Federation Flagship
                        {


                            if (confront1 == 1)
                            {
                                if (Zell.DarkMatter < 0)
                                {

                                    Zell.Fuel -= 20;
                                }

                                if (Zell.DarkMatter > 0)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }
                            }
                            if (confront1 == 2)
                            {
                                if (Zell.Credits > 50000)
                                {
                                    Zell.Credits = Zell.Credits - (Zell.Credits * .10);
                                }

                                if (Zell.Credits < 50000)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }
                            }
                            if (confront1 == 3)
                            {


                                if (Zell.DarkMatter > 0 && Zell.Credits < 20000)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }

                                if (Zell.DarkMatter > 0 && Zell.Credits > 20000)
                                {
                                    Zell.Credits = Zell.Credits - (Zell.Credits * .05);

                                }
                            }
                        }
                        if (battle.shipChoice == 3)//Federation Cruiser
                        {


                            if (confront1 == 1)
                            {
                                if (Zell.DarkMatter < 0)
                                {

                                    Zell.Fuel -= 20;
                                }

                                if (Zell.DarkMatter > 0)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }
                            }
                            if (confront1 == 2)
                            {
                                if (Zell.Credits > 20000)
                                {
                                    Zell.Credits = Zell.Credits - (Zell.Credits * .05);
                                }

                                if (Zell.Credits < 20000)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }
                            }
                            if (confront1 == 3)
                            {


                                if (Zell.DarkMatter > 0 && Zell.Credits < 15000)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }

                                if (Zell.DarkMatter > 0 && Zell.Credits > 15000)
                                {
                                    Zell.Credits = Zell.Credits - (Zell.Credits * .02);

                                }
                            }
                        }
                        if (battle.shipChoice == 2)//Pirate
                        {

                            if (confront1 == 1)
                            {


                                if (Zell.Speed < smuggler.Speed)
                                { Zell.Credits -= 500; }

                            }
                            if (confront1 == 2)
                            {

                                if (Zell.Attack < smuggler.Hull)
                                {
                                    Zell.Credits = Zell.Credits - (Zell.Credits * .20);
                                }

                            }
                            if (confront1 == 3)
                            {
                                Zell.Credits -= 500;
                            }
                        }
                        if (battle.shipChoice == 1) //smuggler
                        {
                            if (confront1 == 3)
                            {
                                Zell.Weapons += 1;
                                Zell.Credits -= 500;
                            }

                        }
                        if (battle.shipChoice == 0) //Normal
                        {
                            if (confront1 == 2)
                            {
                                if (battle.brokenShip() == 9)
                                {
                                    Console.WriteLine("You found some containers with 3- Beryllium"); Console.ReadKey();
                                    Zell.Beryllium += 1;
                                }
                                if (battle.brokenShip() == 5)
                                {
                                    Console.WriteLine("You found some containers with 3- Water/Ice"); Console.ReadKey();
                                    Zell.WaterIce += 1;
                                }
                                if (battle.brokenShip() == 2)
                                {
                                    Console.WriteLine("You found some containers with 1 - Lead"); Console.ReadKey();
                                    Zell.Lead += 1;
                                }
                                if (battle.brokenShip() == 15)
                                {
                                    Console.WriteLine("You found some containers with 1 - Neutronium");
                                    Console.ReadKey();
                                    Zell.Neutronium += 1;
                                }
                                else
                                {
                                    Console.WriteLine("You found nothing.... ");
                                }

                            }

                        }


                        #endregion
                        #endregion
                        Console.ReadKey();
                        while (exit2 == 0)// Exits once user chooses to go back to ship
                        {
                            #region  //Planet welcome dialog


                            Console.Clear();                            
                            
                            Console.Write(@" ██████  ████████  ██████  ██    ██ 
██    ██    ██    ██    ██ ██    ██ 
██    ██    ██    ██    ██ ██    ██ 
██    ██    ██    ██    ██  ██  ██  
 ██████     ██     ██████    ████  "); Console.Write($"\t{menu.Occupation(3)}");
                            Console.WriteLine();
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine(menu.OtovArt());
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine($"\n{otov.OtovDesc()}\n\n");
                            Console.WriteLine($"\n{menu.PlanetDialog()}");
                            #endregion 
                            string tempvalue = Console.ReadLine();
                            double.TryParse(tempvalue, out tryparse);
                            double choice = tryparse;
                            Console.Clear();
                            switch (choice)
                            {

                                case 1://Marketplace
                                    int marketexit1=0;
                                    while (marketexit1==0)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine(
                                            @"███    ███  █████  ██████  ██   ██ ███████ ████████ ██████  ██       █████   ██████ ███████ 
████  ████ ██   ██ ██   ██ ██  ██  ██         ██    ██   ██ ██      ██   ██ ██      ██      
██ ████ ██ ███████ ██████  █████   █████      ██    ██████  ██      ███████ ██      █████   
██  ██  ██ ██   ██ ██   ██ ██  ██  ██         ██    ██      ██      ██   ██ ██      ██      
██      ██ ██   ██ ██   ██ ██   ██ ███████    ██    ██      ███████ ██   ██  ██████ ███████");
                                        Console.WriteLine(
                                            "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine(
                                            "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine($"\n\n{menu.ShopDialog()}");
                                        Console.Write("> ");
                                        string tempvalueo = Console.ReadLine();
                                        double.TryParse(tempvalueo, out tryparse);
                                        double Marketotov = tryparse;
                                        Console.Clear();
                                        switch (Marketotov)
                                        {
                                            case 1:

                                                #region Buy

                                                Console.Clear();
                                                Console.WriteLine();
                                                Console.WriteLine(
                                                    @"███    ███  █████  ██████  ██   ██ ███████ ████████ ██████  ██       █████   ██████ ███████ 
████  ████ ██   ██ ██   ██ ██  ██  ██         ██    ██   ██ ██      ██   ██ ██      ██      
██ ████ ██ ███████ ██████  █████   █████      ██    ██████  ██      ███████ ██      █████   
██  ██  ██ ██   ██ ██   ██ ██  ██  ██         ██    ██      ██      ██   ██ ██      ██      
██      ██ ██   ██ ██   ██ ██   ██ ███████    ██    ██      ███████ ██   ██  ██████ ███████");

                                                Console.WriteLine($"{otov.BuyWelcome()}\n\n");
                                                Console.ReadLine();

                                                #region Items for sale list

                                                Console.WriteLine($"Credits: {Zell.Credits}\n\n Cargo:{Zell.Cargo} / {Zell.TotalCargo}\n\n");
                                                Console.WriteLine(otov.Dithprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(otov.Beryllprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(otov.Carbonprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(otov.Thoriumprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(otov.WaterIceprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(otov.Leadprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(otov.Aetherprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(otov.Foodprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(menu.NewShip());

                                                #endregion

                                                Console.Write("\n\nWhat would you like to purchase?:");
                                                string tempvalue1 = Console.ReadLine();
                                                double.TryParse(tempvalue1, out tryparse);
                                                double item = tryparse;
                                                Console.WriteLine();
                                                if (item == 99)
                                                {
                                                    break;
                                                }
                                                if (otov.QtyTranslation(item) == 0)
                                                {
                                                    Console.WriteLine(menu.OutofStock());
                                                    Console.ReadKey();
                                                }
                                                

                                                Console.Write("\n\nHow many?:");
                                                string tempvalue2 = Console.ReadLine();
                                                double.TryParse(tempvalue2, out tryparse);
                                                double amount = tryparse;
                                                if (menu.PurchasePrice(otov.ItemTranslation(item), amount) >
                                                    Zell.Credits)
                                                {
                                                    Console.WriteLine(menu.NotEnoughCredits());
                                                    Console.ReadLine();
                                                    break;
                                                }
                                                if (otov.ItemTranslation(item) - amount < 0)
                                                {
                                                    Console.WriteLine(menu.OutofStock()); Console.ReadKey();
                                                    break;
                                                }
                                                Console.Clear();
                                                Console.WriteLine(
                                                    $"\n\nSale total is : ${menu.PurchasePrice(otov.ItemTranslation(item), amount):C}  Weight:{menu.TotalCargo(otov.WeightTranslation(item), amount):C}");

                                                #region //Math to reduce Qty and raise cargo

                                                switch (item)
                                                {
                                                    case 1:
                                                        Zell.Fuel += amount;
                                                        otov.Dilithium.Qty -= amount;
                                                        break;
                                                    case 2:
                                                        Zell.Beryllium += amount;
                                                        otov.Beryllium.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(otov.WeightTranslation(item),
                                                            amount);
                                                        break;
                                                    case 3:
                                                        Zell.Carbon += amount;
                                                        otov.Carbon.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(otov.WeightTranslation(item),
                                                            amount);
                                                        break;
                                                    case 4:
                                                        Zell.Thorium += amount;
                                                        otov.Thorium.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(otov.WeightTranslation(item),
                                                            amount);
                                                        break;
                                                    case 5:
                                                        Zell.WaterIce += amount;
                                                        otov.WaterIce.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(otov.WeightTranslation(item),
                                                            amount);
                                                        break;
                                                    case 6:
                                                        Zell.Lead += amount;
                                                        otov.Lead.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(otov.WeightTranslation(item),
                                                            amount);
                                                        break;
                                                    case 7:
                                                        Zell.Aether += amount;
                                                        otov.Aether.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(otov.WeightTranslation(item),
                                                            amount);
                                                        break;
                                                    case 8:
                                                        Zell.Food += amount;
                                                        otov.Food.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(otov.WeightTranslation(item),
                                                            amount);
                                                        break;
                                                    case 9:
                                                        Console.WriteLine(menu.NoSale());

                                                        break;
                                                    case 10:
                                                        Console.WriteLine(menu.NoSale());

                                                        break;
                                                    case 11:
                                                        Console.WriteLine(menu.NoSale());

                                                        break;
                                                    case 12:
                                                        Zell.TotalCargo += 100;
                                                        break;
                                                }

                                                Zell.Credits -= menu.PurchasePrice(otov.ItemTranslation(item), amount);

                                                #endregion

                                                Console.WriteLine(
                                                    $"\nCredits remaining: ${Zell.Credits}\n\nTotal Cargo: {Zell.Cargo} / {Zell.TotalCargo}\n\nFuel Level: {Zell.Fuel}");
                                                Console.WriteLine(Zell.InventoryDisplay());
                                                Console.ReadLine();
                                                Console.Clear();

                                                #endregion

                                                break;
                                            case 2:

                                                #region Sell
                                                Console.WriteLine(
                                                    @"███    ███  █████  ██████  ██   ██ ███████ ████████ ██████  ██       █████   ██████ ███████ 
████  ████ ██   ██ ██   ██ ██  ██  ██         ██    ██   ██ ██      ██   ██ ██      ██      
██ ████ ██ ███████ ██████  █████   █████      ██    ██████  ██      ███████ ██      █████   
██  ██  ██ ██   ██ ██   ██ ██  ██  ██         ██    ██      ██      ██   ██ ██      ██      
██      ██ ██   ██ ██   ██ ██   ██ ███████    ██    ██      ███████ ██   ██  ██████ ███████");

                                                Console.WriteLine($"{otov.BuyWelcome()}\n\n");
                                                Console.ReadLine();
                                                Console.WriteLine(
                                                    $"Current Prices:\n\n{otov.DithSellprice()} \n {otov.Beryllprice()} \n {otov.CarbonSellprice()} \n {otov.ThoriumSellprice()} \n " +
                                                    $"{otov.WaterIceSellprice()} \n {otov.LeadSellprice()} \n {otov.AetherSellprice()} \n {otov.FoodSellprice()}");
                                                Console.WriteLine($"\n\nYour Inventory:\n\n {Zell.InventoryDisplay()}");
                                                Console.Write("\n\nWhat would you like to sell?:");
                                                string tempvalue4 = Console.ReadLine();
                                                double.TryParse(tempvalue4, out tryparse);
                                                double item2 = tryparse;
                                                if (item2 == 99)
                                                {
                                                    break;
                                                }
                                                if (otov.QtyTranslation(item2) == 0)
                                                {
                                                    Console.WriteLine(menu.OutofStock());
                                                    Console.ReadKey();
                                                    break;
                                                }
                                                

                                                Console.Write("\n\nHow many?:");
                                                string tempvalue5 = Console.ReadLine();
                                                double.TryParse(tempvalue5, out tryparse);
                                                double amount2 = tryparse;
                                                Console.Clear();
                                                if (Zell.ItemTranslation(item2) - amount2 < 0)
                                                {
                                                    Console.WriteLine(menu.NotEnoughItems());
                                                    Console.ReadKey();
                                                    break;
                                                }

                                                Console.WriteLine(
                                                    $"\n\nSale total is : ${menu.PurchasePrice(otov.ItemTranslation(item2), amount2):C}  Weight:{menu.TotalCargo(otov.WeightTranslation(item2), amount2):C}");
                                                switch (item2)
                                                {
                                                    case 2:
                                                        Zell.Beryllium -= amount2;
                                                        otov.Beryllium.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(otov.WeightTranslation(item2),
                                                            amount2);
                                                        break;
                                                    case 3:
                                                        Zell.Carbon -= amount2;
                                                        otov.Carbon.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(otov.WeightTranslation(item2),
                                                            amount2);
                                                        break;
                                                    case 4:
                                                        Zell.Thorium -= amount2;
                                                        otov.Thorium.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(otov.WeightTranslation(item2),
                                                            amount2);
                                                        break;
                                                    case 5:
                                                        Zell.WaterIce -= amount2;
                                                        otov.WaterIce.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(otov.WeightTranslation(item2),
                                                            amount2);
                                                        break;
                                                    case 6:
                                                        Zell.Lead -= amount2;
                                                        otov.Lead.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(otov.WeightTranslation(item2),
                                                            amount2);
                                                        break;
                                                    case 7:
                                                        Zell.Aether -= amount2;
                                                        otov.Aether.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(otov.WeightTranslation(item2),
                                                            amount2);
                                                        break;
                                                    case 8:
                                                        Zell.Food -= amount2;
                                                        otov.Food.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(otov.WeightTranslation(item2),
                                                            amount2);
                                                        break;
                                                    case 9:
                                                        Zell.Neutronium -= amount2;
                                                        otov.Neutronium.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(otov.WeightTranslation(item2),
                                                            amount2);
                                                        break;
                                                    case 10:
                                                        Zell.Helium3 -= amount2;
                                                        otov.Helium3.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(otov.WeightTranslation(item2),
                                                            amount2);
                                                        break;
                                                    case 11:
                                                        Zell.DarkMatter -= amount2;
                                                        otov.DarkMatter.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(otov.WeightTranslation(item2),
                                                            amount2);
                                                        break;
                                                   
                                                }

                                                Zell.Credits += menu.PurchasePrice(otov.ItemTranslation(item2),
                                                    amount2);
                                                Console.WriteLine(
                                                    $"\nCredits remaining: ${Zell.Credits}\n\nTotal Cargo: {Zell.Cargo} / {Zell.TotalCargo}\n\nFuel Level: {Zell.Fuel}");
                                                Console.WriteLine(Zell.InventoryDisplay());
                                                Console.ReadKey();

                                                #endregion

                                                break;
                                            case 99:
                                                marketexit1 = 1;
                                                break;
                                        }
                                    }

                                    break;
                                case 2://Capital City
                                    int xigowexit = 0;
                                    while (xigowexit == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine();
                                        Console.WriteLine(
                                            @"██   ██ ██  ██████   ██████  ██     ██ 
 ██ ██  ██ ██       ██    ██ ██     ██ 
  ███   ██ ██   ███ ██    ██ ██  █  ██ 
 ██ ██  ██ ██    ██ ██    ██ ██ ███ ██ 
██   ██ ██  ██████   ██████   ███ ███");
                                        Console.WriteLine(
                                            "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine(
                                            "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine($"\n\n{otov.XigowOptions()}");
                                        string tempvalue01 = Console.ReadLine();
                                        double.TryParse(tempvalue01, out tryparse);
                                        double XChoice = tryparse;
                                        switch (XChoice)
                                        {
                                            case 1: //Warehouse

                                                #region Warehouse
                                                Console.Clear();
                                                Console.WriteLine();
                                                Console.WriteLine(@"██   ██ ██  ██████   ██████  ██     ██     ██     ██  █████  ██████  ███████ ██   ██  ██████  ██    ██ ███████ ███████     ██████  ██ ███████ ████████ ██████  ██  ██████ ████████ 
 ██ ██  ██ ██       ██    ██ ██     ██     ██     ██ ██   ██ ██   ██ ██      ██   ██ ██    ██ ██    ██ ██      ██          ██   ██ ██ ██         ██    ██   ██ ██ ██         ██    
  ███   ██ ██   ███ ██    ██ ██  █  ██     ██  █  ██ ███████ ██████  █████   ███████ ██    ██ ██    ██ ███████ █████       ██   ██ ██ ███████    ██    ██████  ██ ██         ██    
 ██ ██  ██ ██    ██ ██    ██ ██ ███ ██     ██ ███ ██ ██   ██ ██   ██ ██      ██   ██ ██    ██ ██    ██      ██ ██          ██   ██ ██      ██    ██    ██   ██ ██ ██         ██    
██   ██ ██  ██████   ██████   ███ ███       ███ ███  ██   ██ ██   ██ ███████ ██   ██  ██████   ██████  ███████ ███████     ██████  ██ ███████    ██    ██   ██ ██  ██████    ██ ");
                                                Console.WriteLine(
                                                    "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                                Console.WriteLine(
                                                    "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                                                Console.WriteLine(
                                                    "Warehouse district is large and contains with many factories, it is famed for being thge Epsolon Motor Company's HQ ");
                                                Console.ReadKey();
                                                if (natotisMissions.Supply001Success == 2)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine(natotisMissions.Supply001CC());
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    int exquestions = 0;
                                                    while (exquestions == 0)
                                                    {
                                                        Console.WriteLine(natotisMissions.SupplyQuestions());
                                                        string tempvalue01a = Console.ReadLine();
                                                        double.TryParse(tempvalue01a, out tryparse);
                                                        double answers = tryparse;
                                                        Console.WriteLine();
                                                        if (answers ==1)
                                                        {
                                                            Console.WriteLine(natotisMissions.SupplyAnswer1());
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                        }
                                                        if (answers == 2) {
                                                            Console.WriteLine(natotisMissions.SupplyAnswer2());
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                        }
                                                        if (answers == 3) {
                                                            Console.WriteLine(natotisMissions.SupplyAnswer3());
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                        }
                                                        if (answers == 4)
                                                        {
                                                            exquestions = 1;
                                                        }
                                                    }
                                                    
                                                    
                                                    int exot = 1;
                                                    while (exot == 1)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine(natotisMissions.Supply001DD());
                                                        string tempvalue011 = Console.ReadLine();
                                                        double.TryParse(tempvalue011, out tryparse);
                                                        double supplyChoice = tryparse;
                                                        if (supplyChoice ==1)
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine(natotisMissions.Supply001A(1));
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                            Console.WriteLine(natotisMissions.Supply0012DropOff(1));
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                            Console.WriteLine(natotisMissions.Supply001Ends(1));
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                            Zell.Credits += 4000;
                                                            Zell.FederationFavor -= 10;
                                                            Zell.VurikFavor += 10;
                                                            exot = 0;
                                                        }
                                                        if (supplyChoice== 2){ Console.WriteLine(natotisMissions.Supply001A(2));
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                            Console.WriteLine(natotisMissions.Supply0012DropOff(2));
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                            Console.WriteLine(natotisMissions.Supply001Ends(2));
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                            Zell.Credits += 10000;
                                                            Zell.FederationFavor += 20;
                                                            Zell.VurikFavor -= 30;
                                                            exot = 0;
                                                        }
                                                    }
                                                    
                                                }
                                                #endregion
                                                break;
                                            case 2: //Technology District
                                                Console.Clear();
                                                Console.WriteLine(
                                                    "The technology District is where much of the research and business takes place on Natotis..");
                                                Console.ReadKey();
                                                Console.WriteLine(
                                                    "The technology District will have missions where you can invest money and collect later on.like a stock market ");
                                                Console.ReadKey();
                                                break;
                                            case 3: //Cantina
                                                Console.Clear();
                                                Console.WriteLine(
                                                    "The Makiwi Cantina is a small bar the plays host to many world travellers");
                                                Console.ReadKey();
                                                if (Zell.Weapons > 0)
                                                {
                                                    Console.WriteLine("You walk in and have a few drinks, after a while you hear rumbles that there is an arms dealer \n" +
                                                                      "sitting at the table across the bar. You think about the stock of weapons you have on your ship.\n" +
                                                                      "You walk over and make conversation and let it 'slip' that you have Federation weapons. He seems\n" +
                                                                      "interested and you head back to your ship. After inspecting the contents, he offers to pay 600 for\n" +
                                                                      "each.");
                                                    Console.ReadKey();
                                                    Zell.Credits = Zell.Weapons * 600;
                                                    Zell.Weapons = 0;

                                                }//Sell weapons
                                                Console.WriteLine(
                                                    "The Cantina will host more illegal missions unlike the normal mission board.");
                                                Console.ReadKey();
                                                break;
                                            case 4: //Senate Building
                                                Console.Clear();
                                                Console.WriteLine(
                                                    "Natotis is the Federatrions political stronghold in the area. This makes the Natotis Senate\n" +
                                                    "one of the most inportant locations in this system cluster.");
                                                Console.ReadKey();
                                                if (natotisMissions.Mission002success == 2)
                                                {
                                                    natotisMissions.Mission002food += Zell.Food;
                                                    Zell.Food = 0;
                                                    natotisMissions.Delivery002DropOff();
                                                    Console.ReadKey();
                                                }
                                               
                                                Console.WriteLine(
                                                    "This will have some of the 'story missions' and possibly where you can become and envoy.");
                                                Console.ReadKey();
                                                break;
                                            case 99:
                                                xigowexit = 1;
                                                break;
                                        }
                                    }
                                    break;
                                case 3://Mission Board
                                    int exitmission = 1;
                                    while (exitmission == 1)
                                    {
                                        #region //Mission Endings
                                        //if (natotisMissions.Mission001success == 1 || natotisMissions.Mission001success == 0)
                                        //{
                                        //    Console.WriteLine(natotisMissions.Escort001Ends(natotisMissions.Mission001success));
                                        //    Console.ReadKey();
                                        //    Console.Clear();

                                        //}

                                        #endregion
                                        Console.WriteLine();
                                        Console.WriteLine(@"███    ███ ██ ███████ ███████ ██  ██████  ███    ██     ██████   ██████   █████  ██████  ██████  
████  ████ ██ ██      ██      ██ ██    ██ ████   ██     ██   ██ ██    ██ ██   ██ ██   ██ ██   ██ 
██ ████ ██ ██ ███████ ███████ ██ ██    ██ ██ ██  ██     ██████  ██    ██ ███████ ██████  ██   ██ 
██  ██  ██ ██      ██      ██ ██ ██    ██ ██  ██ ██     ██   ██ ██    ██ ██   ██ ██   ██ ██   ██ 
██      ██ ██ ███████ ███████ ██  ██████  ██   ████     ██████   ██████  ██   ██ ██   ██ ██████ ");
                                        Console.WriteLine();
                                        Console.WriteLine(
                                            "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                                        Console.WriteLine(otovMissions.MissionBoard());  
                                        Console.ReadKey();

                                        #region Mission graphic

                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine(
                                            @" =========================================================================================");
                                        Console.WriteLine(
                                            @" ||                           Otov Mission Board                                         ||");

                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine(
                                            @" ||=====================================================================================||");
                                        Console.WriteLine(
                                            @$" ||  Current System: Natotis                                                            ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @$" || {ingametime.month}/{ingametime.day}/{ingametime.year}                                ");
                                        Console.WriteLine(
                                            @" ||=====================================================================================||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||=====================================================================================||");
                                        Console.WriteLine(
                                            @$" ||                                                                                     || ");
                                        //if (ingametime.month == 3 && ingametime.day <= 31 && ingametime.year == 2457 &&
                                        //    natotisMissions.Mission001success == 3)
                                        //{
                                        //    Console.WriteLine($"#1 -  {natotisMissions.Escort001advertisement()}");
                                        //}
                                        //if (ingametime.month == 3 && ingametime.day <= 31 && ingametime.year == 2457 &&
                                        //    natotisMissions.Mission001success == 2)
                                        //{
                                        //    Console.WriteLine($"   #1 -  {natotisMissions.Escort001InProgress()}");
                                        //}

                                        Console.WriteLine(
                                            @$" ||                                                                                     ||");
                                        //if (ingametime.month == 3 && ingametime.day <= 31 && ingametime.year == 2457 &&
                                        //    natotisMissions.Mission002success == 3)
                                        //{
                                        //    Console.WriteLine($"#2 -  {natotisMissions.Delivery002advertisement()}");
                                        //}
                                        //if (ingametime.month == 5 && ingametime.day <= 1 && ingametime.year == 2457 &&
                                        //    natotisMissions.Mission002success == 2)
                                        //{
                                        //    Console.WriteLine($"   #2 -  {natotisMissions.Delivery002InProgress()}");
                                        //}
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            $@" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||=====================================================================================||");
                                        Console.WriteLine("\n\n\n No missions available... press Enter or press 99 to exit..");
                                        Console.Write(">"); string tempvalu = Console.ReadLine();
                                        double.TryParse(tempvalu, out tryparse);
                                        double mission = tryparse;
                                        if (mission == 99)
                                        {
                                            exitmission = 0;
                                        }
                                        //if (natotisMissions.Mission001success == 3)
                                        //{
                                        //    if (mission == 1)
                                        //    {
                                        //        Console.Clear();
                                        //        Console.WriteLine(natotisMissions.Escort001());
                                        //        string tempvalu1 = Console.ReadLine();
                                        //        Console.Clear();
                                        //        double.TryParse(tempvalu1, out tryparse);
                                        //        double mission2 = tryparse;
                                        //        Console.WriteLine(natotisMissions.Escort001A(mission2));
                                        //        Console.ReadKey();
                                        //        if (mission2 == 2)
                                        //        {
                                        //            natotisMissions.Mission001success = 4;
                                        //        }
                                        //    }
                                        //}
                                        //if (natotisMissions.Mission002success == 3)
                                        //{
                                        //    if (mission == 1)
                                        //    {
                                        //        Console.Clear();
                                        //        Console.WriteLine(natotisMissions.Escort001());
                                        //        string tempvalu1 = Console.ReadLine();
                                        //        Console.Clear();
                                        //        double.TryParse(tempvalu1, out tryparse);
                                        //        double mission2 = tryparse;
                                        //        Console.WriteLine(natotisMissions.Escort001A(mission2));
                                        //        Console.ReadKey();
                                        //        if (mission2 == 2)
                                        //        {
                                        //            natotisMissions.Mission002success = 4;
                                        //        }
                                        //    }
                                        //}

                                        Console.Clear();

                                        #endregion
                                    }
                                    Console.ForegroundColor = ConsoleColor.White;
                                    break;
                                case 4://Back to Ship
                                    #region MyRegion
                                    Console.Clear();
                                    Console.WriteLine(@"███    ██  █████  ██    ██ ██    ██ ██     ███████ ██    ██ ███████ ████████ ███████ ███    ███ 
████   ██ ██   ██ ██    ██ ██    ██ ██     ██       ██  ██  ██         ██    ██      ████  ████ 
██ ██  ██ ███████ ██    ██ ██    ██ ██     ███████   ████   ███████    ██    █████   ██ ████ ██ 
██  ██ ██ ██   ██  ██  ██   ██  ██  ██          ██    ██         ██    ██    ██      ██  ██  ██ 
██   ████ ██   ██   ████     ████   ██     ███████    ██    ███████    ██    ███████ ██      ██ ");
                                    Console.WriteLine("\n\n");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(@" =================================================================================");
                                    Console.WriteLine(@" ||                                    NAVVI SYSTEM                             ||");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(@" ||=============================================================================||");
                                    Console.WriteLine(@$" ||  Current System: Ovov                                                      ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@$" || {ingametime.month}/{ingametime.day}/{ingametime.year}                                                                   ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||=============================================================================||");
                                    Console.WriteLine(@" ||=============================================================================||");
                                    Console.WriteLine(@$" || Current Fuel: {Zell.Fuel}                                                         ");
                                    Console.WriteLine(@$" || Credit Ledger: {Zell.Credits}                                                    ");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||  0 - Return to Otov                                                         ||");
                                    Console.WriteLine(@" ||  1 - Natotis        (30 Feul)                                               ||");
                                    Console.WriteLine(@" ||  5 - Aoclite        (25 Feul)                                               ||");
                                    Console.WriteLine(@" ||  6 - XaenidesStation (5 Feul)                                               ||");
                                    Console.WriteLine(@" ||  99 = Exit Game                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||=============================================================================||");
                                    Console.WriteLine($@" ||                                                                            ||");
                                    Console.WriteLine(@" ||=============================================================================||");
                                    #endregion
                                    string tempvaluea = Console.ReadLine();
                                    if (double.TryParse(tempvaluea, out tryparse))
                                    {
                                        menu.planetChoice = tryparse;
                                    }
                                    fuelchecker = (menu.ChekForFuel(Zell.Fuel));
                                    if (fuelchecker == 0)
                                    {
                                        menu.planetChoice = 2;
                                        Console.WriteLine(menu.NotEnoughFuel());
                                        Console.ReadKey();
                                    }
                                    Console.Clear();
                                    if (fuelchecker == 1)
                                    {
                                        if (menu.planetChoice == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.White;
                                            break;
                                        }
                                        if (menu.planetChoice == 1 || menu.planetChoice == 3 || menu.planetChoice == 6 ||
                                            menu.planetChoice == 99)
                                        {
                                            exitt = 1;
                                        }
                                        else if (menu.planetChoice != 1 || menu.planetChoice != 3 || menu.planetChoice != 6 ||
                                                 menu.planetChoice != 99)
                                        {
                                            menu.planetChoice = 2;
                                            Console.WriteLine(menu.IncorrectSelection());
                                            exitt = 0;
                                        }
                                    }
                                    Console.WriteLine(menu.ThrustersCharging());
                                    ShowSimplePercentage();
                                    int milliseconds = 600;
                                    Thread.Sleep(milliseconds);
                                    Console.WriteLine();
                                    Console.WriteLine(menu.ThrustersCharged());
                                    Console.ReadKey();
                                    Console.Clear();
                                    exit2 = 1;
                                    break;
                                case 5:
                                    Console.WriteLine(Zell.InventoryDisplay());
                                    if (Zell.Weapons > 0)
                                    {
                                        Console.WriteLine($"Weapons: {Zell.Weapons}");
                                    }
                                    #region //Mission log for inventory
                                    if (ingametime.month == 3 && ingametime.day <= 31 && ingametime.year == 2457 &&
                                        natotisMissions.Mission001success == 2)
                                    {
                                        Console.WriteLine($"\n\nNatotis #1 -  {natotisMissions.Escort001InProgress()}");
                                    }
                                    if (ingametime.month <= 5 && ingametime.year == 2457 &&
                                        natotisMissions.Mission002success == 2)
                                    {
                                        Console.WriteLine($"\nNatotis #2 -  {natotisMissions.Delivery002InProgress()}");
                                    }
                                    if (natotisMissions.Supply001Success == 2)
                                    {
                                        Console.WriteLine($"\nNatotis -  {natotisMissions.Supply001InProgress()}");
                                    }


                                    #endregion
                                    Console.ReadKey();
                                    break;
                                case 6:
                                    StockMarket();
                                    break;
                            }




                        }
                        break;
                    case 3://Gelara
                        ingametime.time(menu.planetChoice);
                        Zell.Fuel -= 10;
                        int exit3 = 0;
                        gelara.ItemCalculation();
                        StockGen();
                        #region //Ship interaction
                        Console.WriteLine(battle.ShipEmerges(battle.Battlechance(battlechance.Next(0, 100))));
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine($"\n" + battle.ShipEngages(battle.shipChoice));
                        Console.WriteLine(battle.PlayerConfronts(battle.shipChoice));
                        int confront2 = Int32.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine(battle.ShipResponds(battle.shipChoice, confront2, Zell.Speed, Zell.Hull, Zell.Attack, Zell.Weapons, Zell.Credits));
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine(battle.ConflictResult(battle.shipChoice, confront2, Zell.Weapons, Zell.Credits, Zell.Speed, Zell.Hull, Zell.Attack));
                        #region Conflict results
                        if (battle.shipChoice == 4)//Federation Flagship
                        {


                            if (confront2 == 1)
                            {
                                if (Zell.DarkMatter < 0)
                                {

                                    Zell.Fuel -= 20;
                                }

                                if (Zell.DarkMatter > 0)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }
                            }
                            if (confront2 == 2)
                            {
                                if (Zell.Credits > 50000)
                                {
                                    Zell.Credits = Zell.Credits - (Zell.Credits * .10);
                                }

                                if (Zell.Credits < 50000)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }
                            }
                            if (confront2 == 3)
                            {


                                if (Zell.DarkMatter > 0 && Zell.Credits < 20000)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }

                                if (Zell.DarkMatter > 0 && Zell.Credits > 20000)
                                {
                                    Zell.Credits = Zell.Credits - (Zell.Credits * .05);

                                }
                            }
                        }
                        if (battle.shipChoice == 3)//Federation Cruiser
                        {


                            if (confront2 == 1)
                            {
                                if (Zell.DarkMatter < 0)
                                {

                                    Zell.Fuel -= 20;
                                }

                                if (Zell.DarkMatter > 0)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }
                            }
                            if (confront2 == 2)
                            {
                                if (Zell.Credits > 20000)
                                {
                                    Zell.Credits = Zell.Credits - (Zell.Credits * .05);
                                }

                                if (Zell.Credits < 20000)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }
                            }
                            if (confront2 == 3)
                            {


                                if (Zell.DarkMatter > 0 && Zell.Credits < 15000)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }

                                if (Zell.DarkMatter > 0 && Zell.Credits > 15000)
                                {
                                    Zell.Credits = Zell.Credits - (Zell.Credits * .02);

                                }
                            }
                        }
                        if (battle.shipChoice == 2)//Pirate
                        {

                            if (confront2 == 1)
                            {


                                if (Zell.Speed < smuggler.Speed)
                                { Zell.Credits -= 500; }

                            }
                            if (confront2 == 2)
                            {

                                if (Zell.Attack < smuggler.Hull)
                                {
                                    Zell.Credits = Zell.Credits - (Zell.Credits * .20);
                                }

                            }
                            if (confront2 == 3)
                            {
                                Zell.Credits -= 500;
                            }
                        }
                        if (battle.shipChoice == 1) //smuggler
                        {
                            if (confront2 == 3)
                            {
                                Zell.Weapons += 1;
                                Zell.Credits -= 500;
                            }

                        }
                        if (battle.shipChoice == 0) //Normal
                        {
                            if (confront2 == 2)
                            {
                                if (battle.brokenShip() == 9)
                                {
                                    Console.WriteLine("You found some containers with 3- Beryllium"); Console.ReadKey();
                                    Zell.Beryllium += 1;
                                }
                                if (battle.brokenShip() == 5)
                                {
                                    Console.WriteLine("You found some containers with 3- Water/Ice"); Console.ReadKey();
                                    Zell.WaterIce += 1;
                                }
                                if (battle.brokenShip() == 2)
                                {
                                    Console.WriteLine("You found some containers with 1 - Lead"); Console.ReadKey();
                                    Zell.Lead += 1;
                                }
                                if (battle.brokenShip() == 15)
                                {
                                    Console.WriteLine("You found some containers with 1 - Neutronium");
                                    Console.ReadKey();
                                    Zell.Neutronium += 1;
                                }
                                else
                                {
                                    Console.WriteLine("You found nothing.... ");
                                }

                            }

                        }


                        #endregion
                        #endregion
                        Console.ReadKey();
                        Console.Clear();
                        while (exit3 == 0)// Exits once user chooses to go back to ship
                        {
                            #region  //Planet welcome dialog
                            Console.Clear();
                            Console.Write(@" ██████  ███████ ██       █████  ██████   █████  
██       ██      ██      ██   ██ ██   ██ ██   ██ 
██   ███ █████   ██      ███████ ██████  ███████ 
██    ██ ██      ██      ██   ██ ██   ██ ██   ██ 
 ██████  ███████ ███████ ██   ██ ██   ██ ██   ██ "); Console.Write($"\t{menu.Occupation(1)}");
                            Console.WriteLine();
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine(menu.GelaraArt());
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                            Console.WriteLine($"\n\n{gelara.Description()}\n\n");
                            Console.WriteLine($"\n{menu.PlanetDialog()}");
                            #endregion 
                            int choice = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch (choice)
                            {
                                case 1://Marketplace
                                    int marketexit1 = 0;
                                    while (marketexit1 == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine();
                                        Console.WriteLine(
                                            @"███    ███  █████  ██████  ██   ██ ███████ ████████ ██████  ██       █████   ██████ ███████ 
████  ████ ██   ██ ██   ██ ██  ██  ██         ██    ██   ██ ██      ██   ██ ██      ██      
██ ████ ██ ███████ ██████  █████   █████      ██    ██████  ██      ███████ ██      █████   
██  ██  ██ ██   ██ ██   ██ ██  ██  ██         ██    ██      ██      ██   ██ ██      ██      
██      ██ ██   ██ ██   ██ ██   ██ ███████    ██    ██      ███████ ██   ██  ██████ ███████");
                                        Console.WriteLine(
                                            "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine(
                                            "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine($"\n\n{menu.ShopDialog()}");
                                        Console.Write("> ");
                                        string tempvalueo = Console.ReadLine();
                                        double.TryParse(tempvalueo, out tryparse);
                                        double Marketgelara = tryparse;
                                        switch (Marketgelara)
                                        {
                                            case 1: //buy

                                                #region Buy
                                                Console.Clear();
                                                Console.WriteLine();
                                                Console.WriteLine(
                                                    @"███    ███  █████  ██████  ██   ██ ███████ ████████ ██████  ██       █████   ██████ ███████ 
████  ████ ██   ██ ██   ██ ██  ██  ██         ██    ██   ██ ██      ██   ██ ██      ██      
██ ████ ██ ███████ ██████  █████   █████      ██    ██████  ██      ███████ ██      █████   
██  ██  ██ ██   ██ ██   ██ ██  ██  ██         ██    ██      ██      ██   ██ ██      ██      
██      ██ ██   ██ ██   ██ ██   ██ ███████    ██    ██      ███████ ██   ██  ██████ ███████");
                                                Console.WriteLine(
                                                    "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                                Console.WriteLine(
                                                    "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                                                Console.WriteLine($"{gelara.BuyWelcome()}\n\n");
                                                Console.ReadLine();
                                                Console.Clear();

                                                #region Item sale Methods

                                                Console.WriteLine($"Credits: {Zell.Credits}\n\n Cargo:{Zell.Cargo} / {Zell.TotalCargo}\n\n");
                                                Console.WriteLine(gelara.Dithprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(gelara.Beryllprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(gelara.Carbonprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(gelara.Thoriumprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(gelara.WaterIceprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(gelara.Leadprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(gelara.Aetherprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(gelara.Foodprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(menu.NewShip());

                                                #endregion

                                                Console.Write("\n\nWhat would you like to purchase?:");
                                                double item = Convert.ToInt32(Console.ReadLine());
                                                if (item == 99)
                                                {
                                                    break;
                                                }
                                                Console.WriteLine();
                                                if (gelara.QtyTranslation(item) == 0)
                                                {
                                                    Console.WriteLine(menu.OutofStock());
                                                    Console.ReadKey();
                                                }
                                                

                                                Console.Write("\n\nHow many?:");
                                                int amount = Convert.ToInt32(Console.ReadLine());
                                                if (menu.PurchasePrice(gelara.ItemTranslation(item), amount) >
                                                    Zell.Credits)
                                                {
                                                    Console.WriteLine(menu.NotEnoughCredits());
                                                    Console.ReadLine();
                                                    break;
                                                }
                                                if (gelara.ItemTranslation(item) - amount < 0)
                                                {
                                                    Console.WriteLine(menu.OutofStock()); Console.ReadKey();
                                                    break;
                                                }
                                                Console.Clear();
                                                Console.WriteLine(
                                                    $"\n\nSale total is : ${menu.PurchasePrice(gelara.ItemTranslation(item), amount):C}  Weight:{menu.TotalCargo(gelara.WeightTranslation(item), amount):C}");

                                                #region //Math to reduce Qty and raise cargo

                                                switch (item)
                                                {
                                                    case 1:
                                                        Zell.Fuel += amount;
                                                        gelara.Dilithium.Qty -= amount;
                                                        break;
                                                    case 2:
                                                        Zell.Beryllium += amount;
                                                        gelara.Beryllium.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(gelara.WeightTranslation(item),
                                                            amount);
                                                        break;
                                                    case 3:
                                                        Zell.Carbon += amount;
                                                        gelara.Carbon.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(gelara.WeightTranslation(item),
                                                            amount);
                                                        break;
                                                    case 4:
                                                        Zell.Thorium += amount;
                                                        gelara.Thorium.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(gelara.WeightTranslation(item),
                                                            amount);
                                                        break;
                                                    case 5:
                                                        Zell.WaterIce += amount;
                                                        gelara.WaterIce.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(gelara.WeightTranslation(item),
                                                            amount);
                                                        break;
                                                    case 6:
                                                        Zell.Lead += amount;
                                                        gelara.Lead.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(gelara.WeightTranslation(item),
                                                            amount);
                                                        break;
                                                    case 7:
                                                        Zell.Aether += amount;
                                                        gelara.Aether.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(gelara.WeightTranslation(item),
                                                            amount);
                                                        break;
                                                    case 8:
                                                        Zell.Food += amount;
                                                        gelara.Food.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(gelara.WeightTranslation(item),
                                                            amount);
                                                        break;
                                                    case 12:
                                                        Zell.TotalCargo += 100;
                                                        break;
                                                }

                                                Zell.Credits -= menu.PurchasePrice(gelara.ItemTranslation(item),
                                                    amount);

                                                #endregion

                                                Console.WriteLine(
                                                    $"\nCredits remaining: ${Zell.Credits}\n\nTotal Cargo: {Zell.Cargo} / {Zell.TotalCargo}\n\nFuel Level: {Zell.Fuel}");
                                                Console.WriteLine(Zell.InventoryDisplay());
                                                Console.ReadLine();
                                                Console.Clear();

                                                #endregion

                                                break;
                                            case 2:
                                                #region Sell
                                                Console.Clear();
                                                Console.WriteLine();
                                                Console.WriteLine(
                                                    @"███    ███  █████  ██████  ██   ██ ███████ ████████ ██████  ██       █████   ██████ ███████ 
████  ████ ██   ██ ██   ██ ██  ██  ██         ██    ██   ██ ██      ██   ██ ██      ██      
██ ████ ██ ███████ ██████  █████   █████      ██    ██████  ██      ███████ ██      █████   
██  ██  ██ ██   ██ ██   ██ ██  ██  ██         ██    ██      ██      ██   ██ ██      ██      
██      ██ ██   ██ ██   ██ ██   ██ ███████    ██    ██      ███████ ██   ██  ██████ ███████");
                                                Console.WriteLine(
                                                    "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                                Console.WriteLine(
                                                    "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                                Console.WriteLine($"{gelara.BuyWelcome()}\n\n");
                                                Console.ReadLine();
                                                Console.WriteLine($"Current Prices:\n\n{gelara.DithSellprice()} \n {gelara.Beryllprice()} \n {gelara.CarbonSellprice()} \n {gelara.ThoriumSellprice()} \n " +
                                                                  $"{gelara.WaterIceSellprice()} \n {gelara.LeadSellprice()} \n {gelara.AetherSellprice()} \n {gelara.FoodSellprice()}");
                                                Console.WriteLine($"\n\nYour Inventory:\n\n {Zell.InventoryDisplay()}");
                                                Console.Write("\n\nWhat would you like to sell?:"); double item2 = Convert.ToInt32(Console.ReadLine());
                                                if (item2 == 99)
                                                {
                                                    break;
                                                }
                                                if (gelara.QtyTranslation(item2) == 0) { Console.WriteLine(menu.OutofStock()); Console.ReadKey(); break; }
                                               
                                                Console.Write("\n\nHow many?:"); int amount2 = Convert.ToInt32(Console.ReadLine());
                                                Console.Clear();
                                                if (Zell.ItemTranslation(item2) - amount2 < 0) { Console.WriteLine(menu.NotEnoughItems()); Console.ReadKey(); break; }
                                                Console.WriteLine($"\n\nSale total is : ${menu.PurchasePrice(gelara.ItemTranslation(item2), amount2):C}  Weight:{menu.TotalCargo(gelara.WeightTranslation(item2), amount2):C}");
                                                switch (item2)
                                                {
                                                    case 2:
                                                        Zell.Beryllium -= amount2; gelara.Beryllium.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(gelara.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 3:
                                                        Zell.Carbon -= amount2; gelara.Carbon.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(gelara.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 4:
                                                        Zell.Thorium -= amount2; gelara.Thorium.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(gelara.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 5:
                                                        Zell.WaterIce -= amount2; gelara.WaterIce.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(gelara.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 6:
                                                        Zell.Lead -= amount2; gelara.Lead.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(gelara.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 7:
                                                        Zell.Aether -= amount2; gelara.Aether.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(gelara.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 8:
                                                        Zell.Food -= amount2; gelara.Food.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(gelara.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 9:
                                                        Console.WriteLine(menu.NoSale());
                                                        break;
                                                    case 10:
                                                        Console.WriteLine(menu.NoSale());
                                                        break;
                                                    case 11:
                                                        Console.WriteLine(menu.NoSale());
                                                        break;
                                                }
                                                Zell.Credits += menu.PurchasePrice(gelara.ItemTranslation(item2), amount2);
                                                Console.WriteLine($"\nCredits remaining: ${Zell.Credits}\n\nTotal Cargo: {Zell.Cargo} / {Zell.TotalCargo}\n\nFuel Level: {Zell.Fuel}");
                                                Console.WriteLine(Zell.InventoryDisplay());
                                                Console.ReadKey();
                                                #endregion
                                                break;
                                            case 99:
                                                marketexit1 = 1;
                                                break;
                                        }
                                    }

                                    break;
                                    
                                case 2://Capital City
                                    int xigowexit = 0;
                                    while (xigowexit == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine();
                                        Console.WriteLine(
                                            @" █████  ██████  ██████  ██ ██████  ██ ████████ ██   ██ 
██   ██ ██   ██ ██   ██ ██ ██   ██ ██    ██    ██   ██ 
███████ ██████  ██████  ██ ██████  ██    ██    ███████ 
██   ██ ██   ██ ██   ██ ██ ██   ██ ██    ██    ██   ██ 
██   ██ ██████  ██   ██ ██ ██   ██ ██    ██    ██   ██ ");
                                        Console.WriteLine(
                                            "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine(
                                            "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine($"\n\n{gelara.AbririthOptions()}");
                                        string tempvalue01 = Console.ReadLine();
                                        double.TryParse(tempvalue01, out tryparse);
                                        double XChoice = tryparse;
                                        switch (XChoice)
                                        {
                                            case 1: //Warehouse
                                                Console.WriteLine(
                                                    "Warehouse district is large and contains with many factories");
                                                Console.ReadKey();
                                                Console.WriteLine(
                                                    "This area will have corporate espionage missions and sabatoge missions");
                                                Console.ReadKey();
                                                break;
                                            case 2: //Technology District
                                                Console.WriteLine(
                                                    "The technology District is where much of the research and business takes place on Natotis..");
                                                Console.ReadKey();
                                                Console.WriteLine(
                                                    "The technology District will have missions where you can invest money and collect later on.like a stock market ");
                                                Console.ReadKey();
                                                break;
                                            case 3: //Cantina
                                                Console.WriteLine(
                                                    "The Carlaine Cantina is a small bar the plays host to many world travellers");
                                                Console.ReadKey();
                                                if (Zell.Weapons > 0)
                                                {
                                                    Console.WriteLine("You walk in and have a few drinks, after a while you hear rumbles that there is an arms dealer \n" +
                                                                      "sitting at the table across the bar. You think about the stock of weapons you have on your ship.\n" +
                                                                      "You walk over and make conversation and let it 'slip' that you have Federation weapons. He seems\n" +
                                                                      "interested and you head back to your ship. After inspecting the contents, he offers to pay 600 for\n" +
                                                                      "each.");
                                                    Console.ReadKey();
                                                    Zell.Credits = Zell.Weapons * 600;
                                                    Zell.Weapons = 0;

                                                }//Sell weapons
                                                Console.WriteLine(
                                                    "The Cantina will host more illegal missions unlike the normal mission board.");
                                                Console.ReadKey();
                                                break;
                                            case 4: //Senate Building
                                                Console.WriteLine(
                                                    "Natotis is the Federatrions political stronghold in the area. This makes the Natotis Senate\n" +
                                                    "one of the most inportant locations in this system cluster.");
                                                Console.ReadKey();
                                                Console.WriteLine(
                                                    "This will have some of the 'story missions' and possibly where you can become and envoy.");
                                                Console.ReadKey();
                                                break;
                                            case 99:
                                                xigowexit = 1;
                                                break;
                                        }
                                    }
                                    break;
                                case 3://Mission Board
                                    int exitmission = 1;
                                    while (exitmission == 1)
                                    {
                                        #region //Mission Endings
                                        //if (natotisMissions.Mission001success == 1 || natotisMissions.Mission001success == 0)
                                        //{
                                        //    Console.WriteLine(natotisMissions.Escort001Ends(natotisMissions.Mission001success));
                                        //    Console.ReadKey();
                                        //    Console.Clear();

                                        //}

                                        #endregion
                                        Console.WriteLine();
                                        Console.WriteLine(@"███    ███ ██ ███████ ███████ ██  ██████  ███    ██     ██████   ██████   █████  ██████  ██████  
████  ████ ██ ██      ██      ██ ██    ██ ████   ██     ██   ██ ██    ██ ██   ██ ██   ██ ██   ██ 
██ ████ ██ ██ ███████ ███████ ██ ██    ██ ██ ██  ██     ██████  ██    ██ ███████ ██████  ██   ██ 
██  ██  ██ ██      ██      ██ ██ ██    ██ ██  ██ ██     ██   ██ ██    ██ ██   ██ ██   ██ ██   ██ 
██      ██ ██ ███████ ███████ ██  ██████  ██   ████     ██████   ██████  ██   ██ ██   ██ ██████ ");
                                        Console.WriteLine();
                                        Console.WriteLine(
                                            "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                                        //Console.WriteLine(natotisMissions.MissionBoard());  //Add board desc
                                        Console.ReadKey();

                                        #region Mission graphic

                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine(
                                            @" =========================================================================================");
                                        Console.WriteLine(
                                            @" ||                           Gelara Federal Assist Board                                ||");

                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine(
                                            @" ||=====================================================================================||");
                                        Console.WriteLine(
                                            @$" ||  Current System: Natotis                                                            ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @$" || {ingametime.month}/{ingametime.day}/{ingametime.year}                                ");
                                        Console.WriteLine(
                                            @" ||=====================================================================================||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||=====================================================================================||");
                                        Console.WriteLine(
                                            @$" ||                                                                                     || ");
                                        //if (ingametime.month == 3 && ingametime.day <= 31 && ingametime.year == 2457 &&
                                        //    natotisMissions.Mission001success == 3)
                                        //{
                                        //    Console.WriteLine($"#1 -  {natotisMissions.Escort001advertisement()}");
                                        //}
                                        //if (ingametime.month == 3 && ingametime.day <= 31 && ingametime.year == 2457 &&
                                        //    natotisMissions.Mission001success == 2)
                                        //{
                                        //    Console.WriteLine($"   #1 -  {natotisMissions.Escort001InProgress()}");
                                        //}

                                        Console.WriteLine(
                                            @$" ||                                                                                     ||");
                                        //if (ingametime.month == 3 && ingametime.day <= 31 && ingametime.year == 2457 &&
                                        //    natotisMissions.Mission002success == 3)
                                        //{
                                        //    Console.WriteLine($"#2 -  {natotisMissions.Delivery002advertisement()}");
                                        //}
                                        //if (ingametime.month == 5 && ingametime.day <= 1 && ingametime.year == 2457 &&
                                        //    natotisMissions.Mission002success == 2)
                                        //{
                                        //    Console.WriteLine($"   #2 -  {natotisMissions.Delivery002InProgress()}");
                                        //}
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            $@" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||=====================================================================================||");
                                        Console.WriteLine("\n\n\n No missions available... press Enter or press 99 to exit..");
                                        Console.Write(">"); string tempvalu = Console.ReadLine();
                                        double.TryParse(tempvalu, out tryparse);
                                        double mission = tryparse;
                                        if (mission == 99)
                                        {
                                            exitmission = 0;
                                        }
                                        //if (natotisMissions.Mission001success == 3)
                                        //{
                                        //    if (mission == 1)
                                        //    {
                                        //        Console.Clear();
                                        //        Console.WriteLine(natotisMissions.Escort001());
                                        //        string tempvalu1 = Console.ReadLine();
                                        //        Console.Clear();
                                        //        double.TryParse(tempvalu1, out tryparse);
                                        //        double mission2 = tryparse;
                                        //        Console.WriteLine(natotisMissions.Escort001A(mission2));
                                        //        Console.ReadKey();
                                        //        if (mission2 == 2)
                                        //        {
                                        //            natotisMissions.Mission001success = 4;
                                        //        }
                                        //    }
                                        //}
                                        //if (natotisMissions.Mission002success == 3)
                                        //{
                                        //    if (mission == 1)
                                        //    {
                                        //        Console.Clear();
                                        //        Console.WriteLine(natotisMissions.Escort001());
                                        //        string tempvalu1 = Console.ReadLine();
                                        //        Console.Clear();
                                        //        double.TryParse(tempvalu1, out tryparse);
                                        //        double mission2 = tryparse;
                                        //        Console.WriteLine(natotisMissions.Escort001A(mission2));
                                        //        Console.ReadKey();
                                        //        if (mission2 == 2)
                                        //        {
                                        //            natotisMissions.Mission002success = 4;
                                        //        }
                                        //    }
                                        //}

                                        Console.Clear();

                                        #endregion
                                    }
                                    Console.ForegroundColor = ConsoleColor.White;
                                    break;
                                case 4://Back to Ship
                                    #region Navvi
                                    Console.WriteLine(@"███    ██  █████  ██    ██ ██    ██ ██     ███████ ██    ██ ███████ ████████ ███████ ███    ███ 
████   ██ ██   ██ ██    ██ ██    ██ ██     ██       ██  ██  ██         ██    ██      ████  ████ 
██ ██  ██ ███████ ██    ██ ██    ██ ██     ███████   ████   ███████    ██    █████   ██ ████ ██ 
██  ██ ██ ██   ██  ██  ██   ██  ██  ██          ██    ██         ██    ██    ██      ██  ██  ██ 
██   ████ ██   ██   ████     ████   ██     ███████    ██    ███████    ██    ███████ ██      ██ ");
                                    Console.WriteLine("\n\n");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(@" =================================================================================");
                                    Console.WriteLine(@" ||                                    NAVVI SYSTEM                             ||");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(@" ||=============================================================================||");
                                    Console.WriteLine(@$" ||  Current System: Gelara                                                    ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@$" || {ingametime.month}/{ingametime.day}/{ingametime.year}                                                                   ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||=============================================================================||");
                                    Console.WriteLine(@" ||=============================================================================||");
                                    Console.WriteLine(@$" || Current Fuel: {Zell.Fuel}                                                         ");
                                    Console.WriteLine(@$" || Credit Ledger: {Zell.Credits}                                                    ");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||  0 - Return to Gelara                                                       ||");
                                    Console.WriteLine(@" ||  2 - Natotis (30 Feul)                                                      ||");
                                    Console.WriteLine(@" ||  4 - Larvis (15 Feul)                                                       ||");
                                    Console.WriteLine(@" ||  6 - XaenidesStation (5 Feul)                                               ||");
                                    Console.WriteLine(@" ||  99 = Exit Game                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||=============================================================================||");
                                    Console.WriteLine($@" ||                                                                            ||");
                                    Console.WriteLine(@" ||=============================================================================||");
                                    #endregion
                                    string tempvalueb = Console.ReadLine();
                                    if (double.TryParse(tempvalueb, out tryparse))
                                    {
                                        menu.planetChoice = tryparse;
                                    }
                                    fuelchecker = (menu.ChekForFuel(Zell.Fuel));
                                    if (fuelchecker == 0)
                                    {
                                        menu.planetChoice = 3;
                                        Console.WriteLine(menu.NotEnoughFuel());
                                        Console.ReadKey();
                                    }
                                    Console.Clear();
                                    if (fuelchecker == 1)
                                    {
                                        if (menu.planetChoice == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.White;
                                            break;
                                        }
                                        if (menu.planetChoice == 2 || menu.planetChoice == 4 || menu.planetChoice == 6 ||
                                            menu.planetChoice == 99)
                                        {
                                            exitt = 1;
                                        }
                                        else if (menu.planetChoice != 2 || menu.planetChoice != 4 || menu.planetChoice != 6 ||
                                                 menu.planetChoice != 99)
                                        {
                                            menu.planetChoice = 1;
                                            Console.WriteLine(menu.IncorrectSelection());
                                            exitt = 0;
                                        }
                                    }
                                    Console.WriteLine(menu.ThrustersCharging());
                                    ShowSimplePercentage();
                                    int milliseconds = 600;
                                    Thread.Sleep(milliseconds);
                                    Console.WriteLine();
                                    Console.WriteLine(menu.ThrustersCharged());
                                    Console.ReadKey();
                                    Console.Clear();
                                    exit3 = 1;
                                    break;
                                case 5:
                                    Console.WriteLine(Zell.InventoryDisplay());
                                    if (Zell.Weapons > 0)
                                    {
                                        Console.WriteLine($"Weapons: {Zell.Weapons}");
                                    }
                                    #region //Mission log for inventory
                                    if (ingametime.month == 3 && ingametime.day <= 31 && ingametime.year == 2457 &&
                                        natotisMissions.Mission001success == 2)
                                    {
                                        Console.WriteLine($"\n\nNatotis #1 -  {natotisMissions.Escort001InProgress()}");
                                    }
                                    if (ingametime.month <= 5 && ingametime.year == 2457 &&
                                        natotisMissions.Mission002success == 2)
                                    {
                                        Console.WriteLine($"\nNatotis #2 -  {natotisMissions.Delivery002InProgress()}");
                                    }
                                    if (natotisMissions.Supply001Success == 2)
                                    {
                                        Console.WriteLine($"\nNatotis -  {natotisMissions.Supply001InProgress()}");
                                    }


                                    #endregion
                                    Console.ReadKey();
                                    break;
                                case 6:
                                    StockMarket();
                                    break;
                            }




                        }
                        break;
                    case 4://Larvis
                        ingametime.time(menu.planetChoice);
                        Zell.Fuel -= 15;
                        int exit4 = 0;
                        larvis.ItemCalculation();
                        StockGen();
                        #region //Ship interaction
                        Console.WriteLine(battle.ShipEmerges(battle.Battlechance(battlechance.Next(0, 100))));
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine($"\n" + battle.ShipEngages(battle.shipChoice));
                        Console.WriteLine(battle.PlayerConfronts(battle.shipChoice));
                        int confront3 = Int32.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine(battle.ShipResponds(battle.shipChoice, confront3, Zell.Speed, Zell.Hull, Zell.Attack, Zell.Weapons, Zell.Credits));
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine(battle.ConflictResult(battle.shipChoice, confront3, Zell.Weapons, Zell.Credits, Zell.Speed, Zell.Hull, Zell.Attack));
                        #region Conflict results
                        if (battle.shipChoice == 4)//Federation Flagship
                        {


                            if (confront3 == 1)
                            {
                                if (Zell.DarkMatter < 0)
                                {

                                    Zell.Fuel -= 20;
                                }

                                if (Zell.DarkMatter > 0)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }
                            }
                            if (confront3 == 2)
                            {
                                if (Zell.Credits > 50000)
                                {
                                    Zell.Credits = Zell.Credits - (Zell.Credits * .10);
                                }

                                if (Zell.Credits < 50000)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }
                            }
                            if (confront3 == 3)
                            {


                                if (Zell.DarkMatter > 0 && Zell.Credits < 20000)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }

                                if (Zell.DarkMatter > 0 && Zell.Credits > 20000)
                                {
                                    Zell.Credits = Zell.Credits - (Zell.Credits * .05);

                                }
                            }
                        }
                        if (battle.shipChoice == 3)//Federation Cruiser
                        {


                            if (confront3 == 1)
                            {
                                if (Zell.DarkMatter < 0)
                                {

                                    Zell.Fuel -= 20;
                                }

                                if (Zell.DarkMatter > 0)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }
                            }
                            if (confront3 == 2)
                            {
                                if (Zell.Credits > 20000)
                                {
                                    Zell.Credits = Zell.Credits - (Zell.Credits * .05);
                                }

                                if (Zell.Credits < 20000)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }
                            }
                            if (confront3 == 3)
                            {


                                if (Zell.DarkMatter > 0 && Zell.Credits < 15000)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }

                                if (Zell.DarkMatter > 0 && Zell.Credits > 15000)
                                {
                                    Zell.Credits = Zell.Credits - (Zell.Credits * .02);

                                }
                            }
                        }
                        if (battle.shipChoice == 2)//Pirate
                        {

                            if (confront3 == 1)
                            {


                                if (Zell.Speed < smuggler.Speed)
                                { Zell.Credits -= 500; }

                            }
                            if (confront3 == 2)
                            {

                                if (Zell.Attack < smuggler.Hull)
                                {
                                    Zell.Credits = Zell.Credits - (Zell.Credits * .20);
                                }

                            }
                            if (confront3 == 3)
                            {
                                Zell.Credits -= 500;
                            }
                        }
                        if (battle.shipChoice == 1) //smuggler
                        {
                            if (confront3 == 3)
                            {
                                Zell.Weapons += 1;
                                Zell.Credits -= 500;
                            }

                        }
                        if (battle.shipChoice == 0) //Normal
                        {
                            if (confront3 == 2)
                            {
                                if (battle.brokenShip() == 9)
                                {
                                    Console.WriteLine("You found some containers with 3- Beryllium"); Console.ReadKey();
                                    Zell.Beryllium += 1;
                                }
                                if (battle.brokenShip() == 5)
                                {
                                    Console.WriteLine("You found some containers with 3- Water/Ice"); Console.ReadKey();
                                    Zell.WaterIce += 1;
                                }
                                if (battle.brokenShip() == 2)
                                {
                                    Console.WriteLine("You found some containers with 1 - Lead"); Console.ReadKey();
                                    Zell.Lead += 1;
                                }
                                if (battle.brokenShip() == 15)
                                {
                                    Console.WriteLine("You found some containers with 1 - Neutronium");
                                    Console.ReadKey();
                                    Zell.Neutronium += 1;
                                }
                                else
                                {
                                    Console.WriteLine("You found nothing.... ");
                                }

                            }

                        }


                        #endregion
                        #endregion
                        Console.ReadKey();
                        Console.Clear();
                        while (exit4 == 0)// Exits once user chooses to go back to ship
                        {
                            #region  //Planet welcome dialog
                            Console.Clear();
                            Console.Write(@"██       █████  ██████  ██    ██ ██ ███████ 
██      ██   ██ ██   ██ ██    ██ ██ ██      
██      ███████ ██████  ██    ██ ██ ███████ 
██      ██   ██ ██   ██  ██  ██  ██      ██ 
███████ ██   ██ ██   ██   ████   ██ ███████ "); Console.Write($"\t{menu.Occupation(3)}");
                            Console.WriteLine();
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine(menu.LarvisArt());
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine($"\n\n{larvis.Description()}\n\n");
                            Console.WriteLine($"\n{menu.PlanetDialog()}");
                            #endregion 
                            int choice = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch (choice)
                            {
                                case 1://Marketplace
                                    int marketexit = 0;
                                    while (marketexit == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine();
                                        Console.WriteLine(
                                            @"███    ███  █████  ██████  ██   ██ ███████ ████████ ██████  ██       █████   ██████ ███████ 
████  ████ ██   ██ ██   ██ ██  ██  ██         ██    ██   ██ ██      ██   ██ ██      ██      
██ ████ ██ ███████ ██████  █████   █████      ██    ██████  ██      ███████ ██      █████   
██  ██  ██ ██   ██ ██   ██ ██  ██  ██         ██    ██      ██      ██   ██ ██      ██      
██      ██ ██   ██ ██   ██ ██   ██ ███████    ██    ██      ███████ ██   ██  ██████ ███████");
                                        Console.WriteLine(
                                            "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine(
                                            "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine($"\n\n{menu.ShopDialog()}");
                                        Console.Write("> ");
                                        string tempvalue0 = Console.ReadLine();
                                        double.TryParse(tempvalue0, out tryparse);
                                        Console.Clear();
                                        double commerceChoice = tryparse;
                                        switch (commerceChoice)
                                        {
                                            case 1:
                                                #region //Buy
                                                Console.WriteLine();
                                                Console.WriteLine(
                                                    @"███    ███  █████  ██████  ██   ██ ███████ ████████ ██████  ██       █████   ██████ ███████ 
████  ████ ██   ██ ██   ██ ██  ██  ██         ██    ██   ██ ██      ██   ██ ██      ██      
██ ████ ██ ███████ ██████  █████   █████      ██    ██████  ██      ███████ ██      █████   
██  ██  ██ ██   ██ ██   ██ ██  ██  ██         ██    ██      ██      ██   ██ ██      ██      
██      ██ ██   ██ ██   ██ ██   ██ ███████    ██    ██      ███████ ██   ██  ██████ ███████");
                                                Console.WriteLine(
                                                    "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                                Console.WriteLine(
                                                    "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                                                Console.WriteLine($"{larvis.BuyWelcome()}\n\n");
                                                Console.ReadLine();

                                                #region Item sale list

                                                Console.WriteLine(
                                                    $"Credits: {Zell.Credits}\n\n Cargo:{Zell.Cargo} / {Zell.TotalCargo}\n\n");
                                                Console.WriteLine(larvis.Dithprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(larvis.Beryllprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(larvis.Carbonprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(larvis.Thoriumprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(larvis.WaterIceprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(larvis.Leadprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(larvis.Aetherprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(larvis.Foodprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(menu.NewShip());

                                                #endregion

                                                Console.Write("\n\nWhat would you like to purchase?:");
                                                double item = Convert.ToInt32(Console.ReadLine());
                                                if (item == 99)
                                                {
                                                    break;
                                                }
                                                Console.WriteLine();
                                                if (larvis.QtyTranslation(item) == 0)
                                                {
                                                    Console.WriteLine(menu.OutofStock());
                                                    Console.ReadKey();
                                                }
                                               

                                                Console.Write("\n\nHow many?:");
                                                int amount = Convert.ToInt32(Console.ReadLine());
                                                if (menu.PurchasePrice(larvis.ItemTranslation(item), amount) >
                                                    Zell.Credits)
                                                {
                                                    Console.WriteLine(menu.NotEnoughCredits());
                                                    Console.ReadLine();
                                                    break;
                                                }

                                                if (larvis.ItemTranslation(item) - amount < 0)
                                                {
                                                    Console.WriteLine(menu.OutofStock());
                                                    Console.ReadKey();
                                                    break;
                                                }

                                                Console.Clear();
                                                Console.WriteLine(
                                                    $"\n\nSale total is : ${menu.PurchasePrice(larvis.ItemTranslation(item), amount):C}  Weight:{menu.TotalCargo(larvis.WeightTranslation(item), amount):C}");

                                                #region //Math to reduce Qty and raise cargo

                                                switch (item)
                                                {
                                                    case 1:
                                                        Zell.Fuel += amount;
                                                        larvis.Dilithium.Qty -= amount;
                                                        break;
                                                    case 2:
                                                        Zell.Beryllium += amount;
                                                        larvis.Beryllium.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(larvis.WeightTranslation(item),
                                                            amount);
                                                        break;
                                                    case 3:
                                                        Zell.Carbon += amount;
                                                        larvis.Carbon.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(larvis.WeightTranslation(item),
                                                            amount);
                                                        break;
                                                    case 4:
                                                        Zell.Thorium += amount;
                                                        larvis.Thorium.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(larvis.WeightTranslation(item),
                                                            amount);
                                                        break;
                                                    case 5:
                                                        Zell.WaterIce += amount;
                                                        larvis.WaterIce.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(larvis.WeightTranslation(item),
                                                            amount);
                                                        break;
                                                    case 6:
                                                        Zell.Lead += amount;
                                                        larvis.Lead.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(larvis.WeightTranslation(item),
                                                            amount);
                                                        break;
                                                    case 7:
                                                        Zell.Aether += amount;
                                                        larvis.Aether.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(larvis.WeightTranslation(item),
                                                            amount);
                                                        break;
                                                    case 8:
                                                        Zell.Food += amount;
                                                        larvis.Food.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(larvis.WeightTranslation(item),
                                                            amount);
                                                        break;
                                                    case 12:
                                                        Zell.TotalCargo += 100;
                                                        break;
                                                }

                                                Zell.Credits -= menu.PurchasePrice(larvis.ItemTranslation(item),
                                                    amount);

                                                #endregion

                                                Console.WriteLine(
                                                    $"\nCredits remaining: ${Zell.Credits}\n\nTotal Cargo: {Zell.Cargo} / {Zell.TotalCargo}\n\nFuel Level: {Zell.Fuel}");
                                                Console.WriteLine(Zell.InventoryDisplay());
                                                Console.ReadLine();
                                                Console.Clear();

                                                #endregion
                                                break;
                                            case 2:
                                                #region //Sell
                                                Console.WriteLine(
                                                    @"███    ███  █████  ██████  ██   ██ ███████ ████████ ██████  ██       █████   ██████ ███████ 
████  ████ ██   ██ ██   ██ ██  ██  ██         ██    ██   ██ ██      ██   ██ ██      ██      
██ ████ ██ ███████ ██████  █████   █████      ██    ██████  ██      ███████ ██      █████   
██  ██  ██ ██   ██ ██   ██ ██  ██  ██         ██    ██      ██      ██   ██ ██      ██      
██      ██ ██   ██ ██   ██ ██   ██ ███████    ██    ██      ███████ ██   ██  ██████ ███████");
                                                Console.WriteLine(
                                                    "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                                Console.WriteLine(
                                                    "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                                                Console.WriteLine($"{larvis.BuyWelcome()}\n\n");
                                                Console.ReadLine();
                                                Console.WriteLine(
                                                    $"Current Prices:\n\n{larvis.DithSellprice()} \n {larvis.Beryllprice()} \n {larvis.CarbonSellprice()} \n {larvis.ThoriumSellprice()} \n " +
                                                    $"{larvis.WaterIceSellprice()} \n {larvis.LeadSellprice()} \n {larvis.AetherSellprice()} \n {larvis.FoodSellprice()}");
                                                Console.WriteLine($"\n\nYour Inventory:\n\n {Zell.InventoryDisplay()}");
                                                Console.Write("\n\nWhat would you like to sell?:");
                                                double item2 = Convert.ToInt32(Console.ReadLine());
                                                if (larvis.QtyTranslation(item2) == 0)
                                                {
                                                    Console.WriteLine(menu.OutofStock());
                                                    Console.ReadKey();
                                                    break;
                                                }
                                                if (item2 == 99)
                                                {
                                                    break;
                                                }

                                                Console.Write("\n\nHow many?:");
                                                int amount2 = Convert.ToInt32(Console.ReadLine());
                                                Console.Clear();
                                                if (Zell.ItemTranslation(item2) - amount2 < 0)
                                                {
                                                    Console.WriteLine(menu.NotEnoughItems());
                                                    Console.ReadKey();
                                                    break;
                                                }

                                                Console.WriteLine(
                                                    $"\n\nSale total is : ${menu.PurchasePrice(larvis.ItemTranslation(item2), amount2):C}  Weight:{menu.TotalCargo(larvis.WeightTranslation(item2), amount2):C}");
                                                switch (item2)
                                                {
                                                    case 2:
                                                        Zell.Beryllium -= amount2; larvis.Beryllium.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(larvis.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 3:
                                                        Zell.Carbon -= amount2; larvis.Carbon.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(larvis.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 4:
                                                        Zell.Thorium -= amount2; larvis.Thorium.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(larvis.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 5:
                                                        Zell.WaterIce -= amount2; larvis.WaterIce.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(larvis.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 6:
                                                        Zell.Lead -= amount2; larvis.Lead.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(larvis.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 7:
                                                        Zell.Aether -= amount2; larvis.Aether.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(larvis.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 8:
                                                        Zell.Food -= amount2; larvis.Food.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(larvis.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 9:
                                                        Zell.Neutronium -= amount2; larvis.Neutronium.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(larvis.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 10:
                                                        Zell.Helium3 -= amount2; larvis.Helium3.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(larvis.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 11:
                                                        Zell.DarkMatter -= amount2; larvis.DarkMatter.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(larvis.WeightTranslation(item2), amount2);
                                                        break;
                                                }

                                                Zell.Credits += menu.PurchasePrice(larvis.ItemTranslation(item2),
                                                    amount2);
                                                Console.WriteLine(
                                                    $"\nCredits remaining: ${Zell.Credits}\n\nTotal Cargo: {Zell.Cargo} / {Zell.TotalCargo}\n\nFuel Level: {Zell.Fuel}");
                                                Console.WriteLine(Zell.InventoryDisplay());
                                                Console.ReadKey();

                                                #endregion
                                                break;
                                            case 99:
                                                marketexit = 1;
                                                break;
                                        }
                                    }

                                    break;
                                case 2://Capital City
                                    int zhulexit = 0;
                                    while (zhulexit == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine();
                                        Console.WriteLine(
                                            @" ██████  ███    ██ ████████ ██████   ██████  ██████  ████████ 
██    ██ ████   ██    ██    ██   ██ ██    ██ ██   ██    ██    
██    ██ ██ ██  ██    ██    ██████  ██    ██ ██████     ██    
██    ██ ██  ██ ██    ██    ██      ██    ██ ██   ██    ██    
 ██████  ██   ████    ██    ██       ██████  ██   ██    ██   ");
                                        Console.WriteLine(
                                            "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine(
                                            "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine($"\n\n{larvis.OntportOptions()}");
                                        string tempvalue01 = Console.ReadLine();
                                        double.TryParse(tempvalue01, out tryparse);
                                        double zhulChoice = tryparse;
                                        switch (zhulChoice)
                                        {
                                            case 1: //Warehouse
                                                Console.WriteLine(
                                                    "Warehouse district is large and contains with many factories");
                                                Console.ReadKey();
                                                Console.WriteLine(
                                                    "This area will have corporate espionage missions and sabatoge missions");
                                                Console.ReadKey();
                                                break;
                                            case 2: //Technology District
                                                Console.WriteLine(
                                                    "The technology District is where much of the research and business takes place on Larvis..");
                                                Console.ReadKey();
                                                Console.WriteLine(
                                                    "The technology District will have missions where you can invest money and collect later on.like a stock market ");
                                                Console.ReadKey();
                                                break;
                                            case 3: //Cantina
                                                Console.WriteLine(
                                                    "The Makiwi Cantina is a small bar the plays host to many world travellers");
                                                Console.ReadKey();
                                                if (Zell.Weapons > 0)
                                                {
                                                    Console.WriteLine("You walk in and have a few drinks, after a while you hear rumbles that there is an arms dealer \n" +
                                                                      "sitting at the table across the bar. You think about the stock of weapons you have on your ship.\n" +
                                                                      "You walk over and make conversation and let it 'slip' that you have Federation weapons. He seems\n" +
                                                                      "interested and you head back to your ship. After inspecting the contents, he offers to pay 600 for\n" +
                                                                      "each.");
                                                    Console.ReadKey();
                                                    Zell.Credits = Zell.Weapons * 600;
                                                    Zell.Weapons = 0;

                                                }//Sell weapons
                                                Console.WriteLine(
                                                    "The Cantina will host more illegal missions unlike the normal mission board.");
                                                Console.ReadKey();
                                                break;
                                            case 4: //Senate Building
                                                Console.WriteLine(
                                                    "Larvis senate building will house the planets political structure.");
                                                Console.ReadKey();
                                                Console.WriteLine(
                                                    "This will have some of the 'story missions' and possibly where you can become and envoy.");
                                                Console.ReadKey();
                                                break;
                                            case 99:
                                                zhulexit = 1;
                                                break;
                                        }
                                    }
                                    break;
                                case 3://Mission Board
                                    int exitmission = 1;
                                    while (exitmission == 1)
                                    {
                                        #region //Mission Endings
                                        //if (natotisMissions.Mission001success == 1 || natotisMissions.Mission001success == 0)
                                        //{
                                        //    Console.WriteLine(natotisMissions.Escort001Ends(natotisMissions.Mission001success));
                                        //    Console.ReadKey();
                                        //    Console.Clear();

                                        //}

                                        #endregion
                                        Console.WriteLine();
                                        Console.WriteLine(@"███    ███ ██ ███████ ███████ ██  ██████  ███    ██     ██████   ██████   █████  ██████  ██████  
████  ████ ██ ██      ██      ██ ██    ██ ████   ██     ██   ██ ██    ██ ██   ██ ██   ██ ██   ██ 
██ ████ ██ ██ ███████ ███████ ██ ██    ██ ██ ██  ██     ██████  ██    ██ ███████ ██████  ██   ██ 
██  ██  ██ ██      ██      ██ ██ ██    ██ ██  ██ ██     ██   ██ ██    ██ ██   ██ ██   ██ ██   ██ 
██      ██ ██ ███████ ███████ ██  ██████  ██   ████     ██████   ██████  ██   ██ ██   ██ ██████ ");
                                        Console.WriteLine();
                                        Console.WriteLine(
                                            "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                                        //Console.WriteLine(natotisMissions.MissionBoard());  //Add board desc
                                        Console.ReadKey();

                                        #region Mission graphic

                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine(
                                            @" =========================================================================================");
                                        Console.WriteLine(
                                            @" ||                           Larvis Mission Board                                       ||");

                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine(
                                            @" ||=====================================================================================||");
                                        Console.WriteLine(
                                            @$" ||  Current System: Natotis                                                            ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @$" || {ingametime.month}/{ingametime.day}/{ingametime.year}                                ");
                                        Console.WriteLine(
                                            @" ||=====================================================================================||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||=====================================================================================||");
                                        Console.WriteLine(
                                            @$" ||                                                                                     || ");
                                        //if (ingametime.month == 3 && ingametime.day <= 31 && ingametime.year == 2457 &&
                                        //    natotisMissions.Mission001success == 3)
                                        //{
                                        //    Console.WriteLine($"#1 -  {natotisMissions.Escort001advertisement()}");
                                        //}
                                        //if (ingametime.month == 3 && ingametime.day <= 31 && ingametime.year == 2457 &&
                                        //    natotisMissions.Mission001success == 2)
                                        //{
                                        //    Console.WriteLine($"   #1 -  {natotisMissions.Escort001InProgress()}");
                                        //}

                                        Console.WriteLine(
                                            @$" ||                                                                                     ||");
                                        //if (ingametime.month == 3 && ingametime.day <= 31 && ingametime.year == 2457 &&
                                        //    natotisMissions.Mission002success == 3)
                                        //{
                                        //    Console.WriteLine($"#2 -  {natotisMissions.Delivery002advertisement()}");
                                        //}
                                        //if (ingametime.month == 5 && ingametime.day <= 1 && ingametime.year == 2457 &&
                                        //    natotisMissions.Mission002success == 2)
                                        //{
                                        //    Console.WriteLine($"   #2 -  {natotisMissions.Delivery002InProgress()}");
                                        //}
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            $@" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||=====================================================================================||");
                                        Console.WriteLine("\n\n\n No missions available... press Enter or press 99 to exit..");
                                        Console.Write(">"); string tempvalu = Console.ReadLine();
                                        double.TryParse(tempvalu, out tryparse);
                                        double mission = tryparse;
                                        if (mission == 99)
                                        {
                                            exitmission = 0;
                                        }
                                        //if (natotisMissions.Mission001success == 3)
                                        //{
                                        //    if (mission == 1)
                                        //    {
                                        //        Console.Clear();
                                        //        Console.WriteLine(natotisMissions.Escort001());
                                        //        string tempvalu1 = Console.ReadLine();
                                        //        Console.Clear();
                                        //        double.TryParse(tempvalu1, out tryparse);
                                        //        double mission2 = tryparse;
                                        //        Console.WriteLine(natotisMissions.Escort001A(mission2));
                                        //        Console.ReadKey();
                                        //        if (mission2 == 2)
                                        //        {
                                        //            natotisMissions.Mission001success = 4;
                                        //        }
                                        //    }
                                        //}
                                        //if (natotisMissions.Mission002success == 3)
                                        //{
                                        //    if (mission == 1)
                                        //    {
                                        //        Console.Clear();
                                        //        Console.WriteLine(natotisMissions.Escort001());
                                        //        string tempvalu1 = Console.ReadLine();
                                        //        Console.Clear();
                                        //        double.TryParse(tempvalu1, out tryparse);
                                        //        double mission2 = tryparse;
                                        //        Console.WriteLine(natotisMissions.Escort001A(mission2));
                                        //        Console.ReadKey();
                                        //        if (mission2 == 2)
                                        //        {
                                        //            natotisMissions.Mission002success = 4;
                                        //        }
                                        //    }
                                        //}

                                        Console.Clear();

                                        #endregion
                                    }
                                    Console.ForegroundColor = ConsoleColor.White;
                                    break;
                                case 4://Back to Ship
                                    #region Navvi
                                    Console.WriteLine(@"███    ██  █████  ██    ██ ██    ██ ██     ███████ ██    ██ ███████ ████████ ███████ ███    ███ 
████   ██ ██   ██ ██    ██ ██    ██ ██     ██       ██  ██  ██         ██    ██      ████  ████ 
██ ██  ██ ███████ ██    ██ ██    ██ ██     ███████   ████   ███████    ██    █████   ██ ████ ██ 
██  ██ ██ ██   ██  ██  ██   ██  ██  ██          ██    ██         ██    ██    ██      ██  ██  ██ 
██   ████ ██   ██   ████     ████   ██     ███████    ██    ███████    ██    ███████ ██      ██ ");
                                    Console.WriteLine("\n\n");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(@" =================================================================================");
                                    Console.WriteLine(@" ||                                    NAVVI SYSTEM                             ||");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(@" ||=============================================================================||");
                                    Console.WriteLine(@$" ||  Current System: Larvis                                                    ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@$" || {ingametime.month}/{ingametime.day}/{ingametime.year}                                                                   ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||=============================================================================||");
                                    Console.WriteLine(@" ||=============================================================================||");
                                    Console.WriteLine(@$" || Current Fuel: {Zell.Fuel}                                                         ");
                                    Console.WriteLine(@$" || Credit Ledger: {Zell.Credits}                                                    ");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||  0 - Return to Larvis                                                       ||");
                                    Console.WriteLine(@" ||  2 - Otov (15 Feul)                                                              ||");
                                    Console.WriteLine(@" ||  5 - Aoclite (25 Feul)                                                           ||");
                                    Console.WriteLine(@" ||  6 - XaenidesStation (5 Feul)                                                    ||");
                                    Console.WriteLine(@" ||  99 = Exit Game                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||=============================================================================||");
                                    Console.WriteLine($@" ||                                                                            ||");
                                    Console.WriteLine(@" ||=============================================================================||");
                                    #endregion
                                    string tempvaluec = Console.ReadLine();
                                    if (double.TryParse(tempvaluec, out tryparse))
                                    {
                                        menu.planetChoice = tryparse;
                                    }
                                    fuelchecker = (menu.ChekForFuel(Zell.Fuel));
                                    if (fuelchecker == 0)
                                    {
                                        menu.planetChoice = 4;
                                        Console.WriteLine(menu.NotEnoughFuel());
                                        Console.ReadKey();
                                    }
                                    Console.Clear();
                                    if (fuelchecker == 1)
                                    {
                                        if (menu.planetChoice == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.White;
                                            break;
                                        }
                                        if (menu.planetChoice == 2 || menu.planetChoice == 5 || menu.planetChoice == 6 ||
                                            menu.planetChoice == 99)
                                        {
                                            exitt = 1;
                                        }
                                        else if (menu.planetChoice != 2 || menu.planetChoice != 5 || menu.planetChoice != 6 ||
                                                 menu.planetChoice != 99)
                                        {
                                            menu.planetChoice = 4;
                                            Console.WriteLine(menu.IncorrectSelection());
                                            exitt = 0;
                                        }
                                    }
                                    Console.WriteLine(menu.ThrustersCharging());
                                    ShowSimplePercentage();
                                    int milliseconds = 600;
                                    Thread.Sleep(milliseconds);
                                    Console.WriteLine();
                                    Console.WriteLine(menu.ThrustersCharged());
                                    Console.ReadKey();
                                    Console.Clear();
                                    exit4 = 1;
                                    break;
                                case 5:
                                    Console.WriteLine(Zell.InventoryDisplay());
                                    if (Zell.Weapons > 0)
                                    {
                                        Console.WriteLine($"Weapons: {Zell.Weapons}");
                                    }
                                    #region //Mission log for inventory
                                    if (ingametime.month == 3 && ingametime.day <= 31 && ingametime.year == 2457 &&
                                        natotisMissions.Mission001success == 2)
                                    {
                                        Console.WriteLine($"\n\nNatotis #1 -  {natotisMissions.Escort001InProgress()}");
                                    }
                                    if (ingametime.month <= 5 && ingametime.year == 2457 &&
                                        natotisMissions.Mission002success == 2)
                                    {
                                        Console.WriteLine($"\nNatotis #2 -  {natotisMissions.Delivery002InProgress()}");
                                    }
                                    if (natotisMissions.Supply001Success == 2)
                                    {
                                        Console.WriteLine($"\nNatotis -  {natotisMissions.Supply001InProgress()}");
                                    }


                                    #endregion
                                    Console.ReadKey();
                                    break;
                                case 6:
                                    StockMarket();
                                    break;
                            }




                        }
                        break;
                    case 5://Aoclite
                        ingametime.time(menu.planetChoice);
                        Zell.Fuel -= 25;
                        int exit5 = 0;
                        aoclite.ItemCalculation();
                        StockGen();
                        #region //Ship interaction
                        Console.WriteLine(battle.ShipEmerges(battle.Battlechance(battlechance.Next(0, 100))));
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine($"\n" + battle.ShipEngages(battle.shipChoice));
                        Console.WriteLine(battle.PlayerConfronts(battle.shipChoice));
                        int confront4 = Int32.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine(battle.ShipResponds(battle.shipChoice, confront4, Zell.Speed, Zell.Hull, Zell.Attack, Zell.Weapons, Zell.Credits));
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine(battle.ConflictResult(battle.shipChoice, confront4, Zell.Weapons, Zell.Credits, Zell.Speed, Zell.Hull, Zell.Attack));
                        #region Conflict results
                        if (battle.shipChoice == 4)//Federation Flagship
                        {


                            if (confront4 == 1)
                            {
                                if (Zell.DarkMatter < 0)
                                {

                                    Zell.Fuel -= 20;
                                }

                                if (Zell.DarkMatter > 0)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }
                            }
                            if (confront4 == 2)
                            {
                                if (Zell.Credits > 50000)
                                {
                                    Zell.Credits = Zell.Credits - (Zell.Credits * .10);
                                }

                                if (Zell.Credits < 50000)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }
                            }
                            if (confront4 == 3)
                            {


                                if (Zell.DarkMatter > 0 && Zell.Credits < 20000)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }

                                if (Zell.DarkMatter > 0 && Zell.Credits > 20000)
                                {
                                    Zell.Credits = Zell.Credits - (Zell.Credits * .05);

                                }
                            }
                        }
                        if (battle.shipChoice == 3)//Federation Cruiser
                        {


                            if (confront4 == 1)
                            {
                                if (Zell.DarkMatter < 0)
                                {

                                    Zell.Fuel -= 20;
                                }

                                if (Zell.DarkMatter > 0)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }
                            }
                            if (confront4 == 2)
                            {
                                if (Zell.Credits > 20000)
                                {
                                    Zell.Credits = Zell.Credits - (Zell.Credits * .05);
                                }

                                if (Zell.Credits < 20000)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }
                            }
                            if (confront4 == 3)
                            {


                                if (Zell.DarkMatter > 0 && Zell.Credits < 15000)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }

                                if (Zell.DarkMatter > 0 && Zell.Credits > 15000)
                                {
                                    Zell.Credits = Zell.Credits - (Zell.Credits * .02);

                                }
                            }
                        }
                        if (battle.shipChoice == 2)//Pirate
                        {

                            if (confront4 == 1)
                            {


                                if (Zell.Speed < smuggler.Speed)
                                { Zell.Credits -= 500; }

                            }
                            if (confront4 == 2)
                            {

                                if (Zell.Attack < smuggler.Hull)
                                {
                                    Zell.Credits = Zell.Credits - (Zell.Credits * .20);
                                }

                            }
                            if (confront4 == 3)
                            {
                                Zell.Credits -= 500;
                            }
                        }
                        if (battle.shipChoice == 1) //smuggler
                        {
                            if (confront4 == 3)
                            {
                                Zell.Weapons += 1;
                                Zell.Credits -= 500;
                            }

                        }
                        if (battle.shipChoice == 0) //Normal
                        {
                            if (confront4 == 2)
                            {
                                if (battle.brokenShip() == 9)
                                {
                                    Console.WriteLine("You found some containers with 3- Beryllium"); Console.ReadKey();
                                    Zell.Beryllium += 1;
                                }
                                if (battle.brokenShip() == 5)
                                {
                                    Console.WriteLine("You found some containers with 3- Water/Ice"); Console.ReadKey();
                                    Zell.WaterIce += 1;
                                }
                                if (battle.brokenShip() == 2)
                                {
                                    Console.WriteLine("You found some containers with 1 - Lead"); Console.ReadKey();
                                    Zell.Lead += 1;
                                }
                                if (battle.brokenShip() == 15)
                                {
                                    Console.WriteLine("You found some containers with 1 - Neutronium");
                                    Console.ReadKey();
                                    Zell.Neutronium += 1;
                                }
                                else
                                {
                                    Console.WriteLine("You found nothing.... ");
                                }

                            }

                        }


                        #endregion
                        #endregion
                        Console.ReadKey();
                        Console.Clear();
                        while (exit5 == 0)// Exits once user chooses to go back to ship
                        {
                            #region  //Planet welcome dialog

                            if (natotisMissions.Mission001success == 2)
                            {
                                Console.WriteLine(natotisMissions.Excort001DropOff());
                                Console.ReadKey();
                            }
                            Console.Clear();
                            Console.Write(@" █████   ██████   ██████ ██      ██ ████████ ███████ 
██   ██ ██    ██ ██      ██      ██    ██    ██      
███████ ██    ██ ██      ██      ██    ██    █████   
██   ██ ██    ██ ██      ██      ██    ██    ██      
██   ██  ██████   ██████ ███████ ██    ██    ███████ "); Console.Write($"\t{menu.Occupation(1)}");
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine(@"          ########*****(((##                              
                                                                                                         #####################*((((((((%#                       
                                                                                                    *(#############################((((((((%%                   
                                                                                                ,***********(#########################((((((((%%/               
                                                                                              ##########(**********#######################(((((((%%             
                                                                                          *####################*********###################(((((((%%#          
                                                                                        ,***********(###############*********(################(((((#%%(        
                                                                                       ********************/#############********###############(((((%%%       
                                                                                      .***************************############******((#############((((%%%#     
                                                                                      *****%%%%%%%%%%%%***************############***((((###########((((%%%#    
                                                                                     *****%%%%%%%%%%%%%%%%%***************############((((((##########(((%%%#   
                                                                                     *******%%%%%%%%%%%%%%%%%%****************(###########((((((#########((%%%   
                                                                                    **********%%%%%%%%%%%%%%%%********************###########(((((#########%%%#  
                                                                                    ##************(##%%#*****************************##########(((((#######%%%%  
                                                                                    ########******************************************((##########((((######%%%  
                                                                                    (##################********************************(((((#########((((####%%%/ 
                                                                                     #############################/********************(((((((#########(((##%%%%  
                                                                                     #####################################*************((((((((((########(((%%%%  
                                                                                     ,*************############################********(((((((((((((######((%%%#  
                                                                                       *******************##########################***/(((((((((((((((#####%%%%   
                                                                                       ***********************#########################(((((((((((((((((###%%%    
                                                                                        **************************#########################(((((((((((((((%%%     
                                                                                         *****************************########################(((((((((((%%#      
                                                                                          .*******************************#######################((((((%%%(       
                                                                                            *********************************######################(((%%#         
                                                                                               **********************************/###################%%(           
                                                                                                  **********************************(#############%%%              
                                                                                                    ******************************((((#########%%                 
                                                                                                          ************************(((((((((##%%                     
                                                                                                               .*****************(((((((##                          
                                                                                                                      ************## ");
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine($"\n\n{aoclite.Description()}\n\n");
                            Console.WriteLine($"\n{menu.PlanetDialog()}");
                            #endregion 
                            int choice = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch (choice)
                            {
                                case 1://Marketplace
                                    int marketexit = 0;
                                    while (marketexit == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine();
                                        Console.WriteLine(
                                            @"███    ███  █████  ██████  ██   ██ ███████ ████████ ██████  ██       █████   ██████ ███████ 
████  ████ ██   ██ ██   ██ ██  ██  ██         ██    ██   ██ ██      ██   ██ ██      ██      
██ ████ ██ ███████ ██████  █████   █████      ██    ██████  ██      ███████ ██      █████   
██  ██  ██ ██   ██ ██   ██ ██  ██  ██         ██    ██      ██      ██   ██ ██      ██      
██      ██ ██   ██ ██   ██ ██   ██ ███████    ██    ██      ███████ ██   ██  ██████ ███████"); Console.Write($"\t{menu.Occupation(3)}");
                                        Console.WriteLine();
                                        Console.WriteLine(
                                            "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine(
                                            "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine($"\n\n{menu.ShopDialog()}");
                                        Console.Write("> ");
                                        string tempvalue0 = Console.ReadLine();
                                        double.TryParse(tempvalue0, out tryparse);
                                        Console.Clear();
                                        double commerceChoice = tryparse;
                                        switch (commerceChoice)
                                        {
                                            case 1:
                                                #region BUY
                                                Console.Clear();
                                                Console.WriteLine();
                                                Console.WriteLine(
                                                    @"███    ███  █████  ██████  ██   ██ ███████ ████████ ██████  ██       █████   ██████ ███████ 
████  ████ ██   ██ ██   ██ ██  ██  ██         ██    ██   ██ ██      ██   ██ ██      ██      
██ ████ ██ ███████ ██████  █████   █████      ██    ██████  ██      ███████ ██      █████   
██  ██  ██ ██   ██ ██   ██ ██  ██  ██         ██    ██      ██      ██   ██ ██      ██      
██      ██ ██   ██ ██   ██ ██   ██ ███████    ██    ██      ███████ ██   ██  ██████ ███████");
                                                Console.WriteLine(
                                                    "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                                Console.WriteLine(
                                                    "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                                Console.WriteLine($"{aoclite.BuyWelcome()}\n\n");
                                                Console.ReadLine();

                                                #region Item sale list
                                                Console.WriteLine($"Credits: {Zell.Credits}\n\n Cargo:{Zell.Cargo} / {Zell.TotalCargo}\n\n");
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(aoclite.Dithprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(aoclite.Beryllprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(aoclite.Carbonprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(aoclite.Thoriumprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(aoclite.WaterIceprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(aoclite.Leadprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(aoclite.Aetherprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(aoclite.Foodprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(aoclite.Helium3price());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(aoclite.Neutroniumprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(aoclite.DarkMatterprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(menu.NewShip());
                                                #endregion
                                                Console.Write("\n\nWhat would you like to purchase?:"); double item = Convert.ToInt32(Console.ReadLine());
                                                if (item == 99)
                                                {
                                                    break;
                                                }
                                                Console.WriteLine();
                                                if (aoclite.QtyTranslation(item) == 0) { Console.WriteLine(menu.OutofStock()); Console.ReadKey(); }
                                               
                                                Console.Write("\n\nHow many?:"); int amount = Convert.ToInt32(Console.ReadLine());
                                                if (menu.PurchasePrice(aoclite.ItemTranslation(item), amount) > Zell.Credits)
                                                { Console.WriteLine(menu.NotEnoughCredits()); Console.ReadLine(); break; }
                                                if (aoclite.ItemTranslation(item) - amount < 0)
                                                {
                                                    Console.WriteLine(menu.OutofStock()); Console.ReadKey();
                                                    break;
                                                }
                                                Console.Clear();
                                                Console.WriteLine($"\n\nSale total is : ${menu.PurchasePrice(aoclite.ItemTranslation(item), amount):C}  Weight:{menu.TotalCargo(aoclite.WeightTranslation(item), amount):C}");
                                                #region  //Math to reduce Qty and raise cargo
                                                switch (item)
                                                {
                                                    case 1:
                                                        Zell.Fuel += amount; aoclite.Dilithium.Qty -= amount;
                                                        break;
                                                    case 2:
                                                        Zell.Beryllium += amount; aoclite.Beryllium.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(aoclite.WeightTranslation(item), amount);
                                                        break;
                                                    case 3:
                                                        Zell.Carbon += amount; aoclite.Carbon.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(aoclite.WeightTranslation(item), amount);
                                                        break;
                                                    case 4:
                                                        Zell.Thorium += amount; aoclite.Thorium.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(aoclite.WeightTranslation(item), amount);
                                                        break;
                                                    case 5:
                                                        Zell.WaterIce += amount; aoclite.WaterIce.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(aoclite.WeightTranslation(item), amount);
                                                        break;
                                                    case 6:
                                                        Zell.Lead += amount; aoclite.Lead.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(aoclite.WeightTranslation(item), amount);
                                                        break;
                                                    case 7:
                                                        Zell.Aether += amount; aoclite.Aether.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(aoclite.WeightTranslation(item), amount);
                                                        break;
                                                    case 8:
                                                        Zell.Food += amount; aoclite.Food.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(aoclite.WeightTranslation(item), amount);
                                                        break;
                                                    case 9:
                                                        Zell.Neutronium += amount; aoclite.Neutronium.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(aoclite.WeightTranslation(item), amount);
                                                        break;
                                                    case 10:
                                                        Zell.Helium3 += amount; aoclite.Helium3.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(aoclite.WeightTranslation(item), amount);
                                                        break;
                                                    case 11:
                                                        Zell.DarkMatter += amount; aoclite.DarkMatter.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(aoclite.WeightTranslation(item), amount);
                                                        break;
                                                    case 12:
                                                        Zell.TotalCargo += 100;
                                                        break;
                                                }
                                                Zell.Credits -= menu.PurchasePrice(aoclite.ItemTranslation(item), amount);
                                                #endregion
                                                Console.WriteLine($"\nCredits remaining: ${Zell.Credits}\n\nTotal Cargo: {Zell.Cargo} / {Zell.TotalCargo}\n\nFuel Level: {Zell.Fuel}");
                                                Console.WriteLine(Zell.InventoryDisplay());
                                                Console.ReadLine();
                                                Console.Clear();
                                                #endregion
                                                break;
                                            case 2:
                                                #region //SELL




                                                Console.WriteLine($"{aoclite.BuyWelcome()}\n\n");
                                                Console.ReadLine();
                                                Console.WriteLine($"Current Prices:\n\n{aoclite.DithSellprice()} \n {aoclite.Beryllprice()} \n {aoclite.CarbonSellprice()} \n {aoclite.ThoriumSellprice()} \n " +
                                                                  $"{aoclite.WaterIceSellprice()} \n {aoclite.LeadSellprice()} \n {aoclite.AetherSellprice()} \n {aoclite.FoodSellprice()} \n {aoclite.NeutroniumSellprice()} \n {aoclite.Helium3Sellprice()} \n " +
                                                                  $"{aoclite.DarkMatterSellprice()}");
                                                Console.WriteLine($"\n\nYour Inventory:\n\n {Zell.InventoryDisplay()}");
                                                Console.Write("\n\nWhat would you like to sell?:"); double item2 = Convert.ToInt32(Console.ReadLine());
                                                if (item2 == 99)
                                                {
                                                    break;
                                                }
                                                if (aoclite.QtyTranslation(item2) == 0) { Console.WriteLine(menu.OutofStock()); Console.ReadKey(); break; }
                                               
                                                Console.Write("\n\nHow many?:"); int amount2 = Convert.ToInt32(Console.ReadLine());
                                                Console.Clear();
                                                if (Zell.ItemTranslation(item2) - amount2 < 0) { Console.WriteLine(menu.NotEnoughItems()); Console.ReadKey(); break; }
                                                Console.WriteLine($"\n\nSale total is : ${menu.PurchasePrice(aoclite.ItemTranslation(item2), amount2):C}  Weight:{menu.TotalCargo(aoclite.WeightTranslation(item2), amount2):C}");
                                                switch (item2)
                                                {
                                                    case 2:
                                                        Zell.Beryllium -= amount2; aoclite.Beryllium.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(aoclite.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 3:
                                                        Zell.Carbon -= amount2; aoclite.Carbon.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(aoclite.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 4:
                                                        Zell.Thorium -= amount2; aoclite.Thorium.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(aoclite.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 5:
                                                        Zell.WaterIce -= amount2; aoclite.WaterIce.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(aoclite.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 6:
                                                        Zell.Lead -= amount2; aoclite.Lead.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(aoclite.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 7:
                                                        Zell.Aether -= amount2; aoclite.Aether.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(aoclite.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 8:
                                                        Zell.Food -= amount2; aoclite.Food.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(aoclite.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 9:
                                                        Zell.Neutronium -= amount2; aoclite.Neutronium.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(aoclite.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 10:
                                                        Zell.Helium3 -= amount2; aoclite.Helium3.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(aoclite.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 11:
                                                        Zell.DarkMatter -= amount2; aoclite.DarkMatter.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(aoclite.WeightTranslation(item2), amount2);
                                                        break;
                                                }
                                                Zell.Credits += menu.PurchasePrice(aoclite.ItemTranslation(item2), amount2);
                                                Console.WriteLine($"\nCredits remaining: ${Zell.Credits}\n\nTotal Cargo: {Zell.Cargo} / {Zell.TotalCargo}\n\nFuel Level: {Zell.Fuel}");
                                                Console.WriteLine(Zell.InventoryDisplay());
                                                Console.ReadKey();
                                                #endregion
                                                break;
                                            case 99:
                                                marketexit = 1;
                                                break;
                                        }
                                    }

                                   
                                    break;
                                case 2://Capital City
                                    int zhulexit = 0;
                                    while (zhulexit == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine();
                                        Console.WriteLine(
                                            @"  ██████  ██████   ██████  ███    ██ ██ 
██    ██ ██   ██ ██    ██ ████   ██ ██ 
██    ██ ██████  ██    ██ ██ ██  ██ ██ 
██    ██ ██   ██ ██    ██ ██  ██ ██ ██ 
 ██████  ██   ██  ██████  ██   ████ ██    ");
                                        Console.WriteLine(
                                            "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine(
                                            "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine($"\n\n{aoclite.OroniOptions()}");
                                        string tempvalue01 = Console.ReadLine();
                                        double.TryParse(tempvalue01, out tryparse);
                                        double zhulChoice = tryparse;
                                        switch (zhulChoice)
                                        {
                                            case 1: //Warehouse
                                                Console.WriteLine(
                                                    "Warehouse district is large and contains with many factories");
                                                Console.ReadKey();
                                                Console.WriteLine(
                                                    "This area will have corporate espionage missions and sabatoge missions");
                                                Console.ReadKey();
                                                break;
                                            case 2: //Technology District
                                                Console.WriteLine(
                                                    "The technology District is where much of the research and business takes place on Aoclite..");
                                                Console.ReadKey();
                                                Console.WriteLine(
                                                    "The technology District will have missions where you can invest money and collect later on.like a stock market ");
                                                Console.ReadKey();
                                                break;
                                            case 3: //Cantina
                                                Console.WriteLine(
                                                    "The Aoclite Guest Cantina is a small bar the plays host to many world travellers");
                                                Console.ReadKey();
                                                if (Zell.Weapons > 0)
                                                {
                                                    Console.WriteLine("You walk in and have a few drinks, after a while you hear rumbles that there is an arms dealer \n" +
                                                                      "sitting at the table across the bar. You think about the stock of weapons you have on your ship.\n" +
                                                                      "You walk over and make conversation and let it 'slip' that you have Federation weapons. He seems\n" +
                                                                      "interested and you head back to your ship. After inspecting the contents, he offers to pay 600 for\n" +
                                                                      "each.");
                                                    Console.ReadKey();
                                                    Zell.Credits = Zell.Weapons * 600;
                                                    Zell.Weapons = 0;

                                                }//Sell weapons
                                                Console.WriteLine(
                                                    "The Cantina will host more illegal missions unlike the normal mission board.");
                                                Console.ReadKey();
                                                break;
                                            case 4: //Senate Building
                                                Console.WriteLine(
                                                    "Larvis senate building will house the planets political structure.");
                                                Console.ReadKey();
                                                Console.WriteLine(
                                                    "This will have some of the 'story missions' and possibly where you can become and envoy.");
                                                Console.ReadKey();
                                                break;
                                            case 99:
                                                zhulexit = 1;
                                                break;
                                        }
                                    }
                                    break;
                                case 3://Mission Board
                                    int exitmission = 1;
                                    while (exitmission == 1)
                                    {
                                        #region //Mission Endings
                                        //if (natotisMissions.Mission001success == 1 || natotisMissions.Mission001success == 0)
                                        //{
                                        //    Console.WriteLine(natotisMissions.Escort001Ends(natotisMissions.Mission001success));
                                        //    Console.ReadKey();
                                        //    Console.Clear();

                                        //}

                                        #endregion
                                        Console.WriteLine();
                                        Console.WriteLine(@"███    ███ ██ ███████ ███████ ██  ██████  ███    ██     ██████   ██████   █████  ██████  ██████  
████  ████ ██ ██      ██      ██ ██    ██ ████   ██     ██   ██ ██    ██ ██   ██ ██   ██ ██   ██ 
██ ████ ██ ██ ███████ ███████ ██ ██    ██ ██ ██  ██     ██████  ██    ██ ███████ ██████  ██   ██ 
██  ██  ██ ██      ██      ██ ██ ██    ██ ██  ██ ██     ██   ██ ██    ██ ██   ██ ██   ██ ██   ██ 
██      ██ ██ ███████ ███████ ██  ██████  ██   ████     ██████   ██████  ██   ██ ██   ██ ██████ ");
                                        Console.WriteLine();
                                        Console.WriteLine(
                                            "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                                        //Console.WriteLine(natotisMissions.MissionBoard());  //Add board desc
                                        Console.ReadKey();

                                        #region Mission graphic

                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine(
                                            @" =========================================================================================");
                                        Console.WriteLine(
                                            @" ||                           Aoclite Federal Assist Board                               ||");

                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine(
                                            @" ||=====================================================================================||");
                                        Console.WriteLine(
                                            @$" ||  Current System: Natotis                                                            ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @$" || {ingametime.month}/{ingametime.day}/{ingametime.year}                                ");
                                        Console.WriteLine(
                                            @" ||=====================================================================================||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||=====================================================================================||");
                                        Console.WriteLine(
                                            @$" ||                                                                                     || ");
                                        //if (ingametime.month == 3 && ingametime.day <= 31 && ingametime.year == 2457 &&
                                        //    natotisMissions.Mission001success == 3)
                                        //{
                                        //    Console.WriteLine($"#1 -  {natotisMissions.Escort001advertisement()}");
                                        //}
                                        //if (ingametime.month == 3 && ingametime.day <= 31 && ingametime.year == 2457 &&
                                        //    natotisMissions.Mission001success == 2)
                                        //{
                                        //    Console.WriteLine($"   #1 -  {natotisMissions.Escort001InProgress()}");
                                        //}

                                        Console.WriteLine(
                                            @$" ||                                                                                     ||");
                                        //if (ingametime.month == 3 && ingametime.day <= 31 && ingametime.year == 2457 &&
                                        //    natotisMissions.Mission002success == 3)
                                        //{
                                        //    Console.WriteLine($"#2 -  {natotisMissions.Delivery002advertisement()}");
                                        //}
                                        //if (ingametime.month == 5 && ingametime.day <= 1 && ingametime.year == 2457 &&
                                        //    natotisMissions.Mission002success == 2)
                                        //{
                                        //    Console.WriteLine($"   #2 -  {natotisMissions.Delivery002InProgress()}");
                                        //}
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            $@" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||=====================================================================================||");
                                        Console.WriteLine("\n\n\n No missions available... press Enter or press 99 to exit..");
                                        Console.Write(">"); string tempvalu = Console.ReadLine();
                                        double.TryParse(tempvalu, out tryparse);
                                        double mission = tryparse;
                                        if (mission == 99)
                                        {
                                            exitmission = 0;
                                        }
                                        //if (natotisMissions.Mission001success == 3)
                                        //{
                                        //    if (mission == 1)
                                        //    {
                                        //        Console.Clear();
                                        //        Console.WriteLine(natotisMissions.Escort001());
                                        //        string tempvalu1 = Console.ReadLine();
                                        //        Console.Clear();
                                        //        double.TryParse(tempvalu1, out tryparse);
                                        //        double mission2 = tryparse;
                                        //        Console.WriteLine(natotisMissions.Escort001A(mission2));
                                        //        Console.ReadKey();
                                        //        if (mission2 == 2)
                                        //        {
                                        //            natotisMissions.Mission001success = 4;
                                        //        }
                                        //    }
                                        //}
                                        //if (natotisMissions.Mission002success == 3)
                                        //{
                                        //    if (mission == 1)
                                        //    {
                                        //        Console.Clear();
                                        //        Console.WriteLine(natotisMissions.Escort001());
                                        //        string tempvalu1 = Console.ReadLine();
                                        //        Console.Clear();
                                        //        double.TryParse(tempvalu1, out tryparse);
                                        //        double mission2 = tryparse;
                                        //        Console.WriteLine(natotisMissions.Escort001A(mission2));
                                        //        Console.ReadKey();
                                        //        if (mission2 == 2)
                                        //        {
                                        //            natotisMissions.Mission002success = 4;
                                        //        }
                                        //    }
                                        //}

                                        Console.Clear();

                                        #endregion
                                    }
                                    Console.ForegroundColor = ConsoleColor.White;
                                    break;
                                case 4://Back to Ship
                                    #region Navvi
                                    Console.WriteLine(@"███    ██  █████  ██    ██ ██    ██ ██     ███████ ██    ██ ███████ ████████ ███████ ███    ███ 
████   ██ ██   ██ ██    ██ ██    ██ ██     ██       ██  ██  ██         ██    ██      ████  ████ 
██ ██  ██ ███████ ██    ██ ██    ██ ██     ███████   ████   ███████    ██    █████   ██ ████ ██ 
██  ██ ██ ██   ██  ██  ██   ██  ██  ██          ██    ██         ██    ██    ██      ██  ██  ██ 
██   ████ ██   ██   ████     ████   ██     ███████    ██    ███████    ██    ███████ ██      ██ ");
                                    Console.WriteLine("\n\n");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(@" =================================================================================");
                                    Console.WriteLine(@" ||                                    NAVVI SYSTEM                             ||");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(@" ||=============================================================================||");
                                    Console.WriteLine(@$" ||  Current System: Aoclite                                                   ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@$" || {ingametime.month}/{ingametime.day}/{ingametime.year}                                                                   ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||=============================================================================||");
                                    Console.WriteLine(@" ||=============================================================================||");
                                    Console.WriteLine(@$" || Current Fuel: {Zell.Fuel}                                                         ");
                                    Console.WriteLine(@$" || Credit Ledger: {Zell.Credits}                                                    ");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||  0 - Return to Aoclite                                                      ||");
                                    Console.WriteLine(@" ||  2 - Otov (15 Feul)                                                         ||");
                                    Console.WriteLine(@" ||  4 - Larvis (15 Feul)                                                       ||");
                                    Console.WriteLine(@" ||  6 - XaenidesStation (5 Feul)                                               ||");
                                    Console.WriteLine(@" ||  99 = Exit Game                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||=============================================================================||");
                                    Console.WriteLine($@" ||                                                                            ||");
                                    Console.WriteLine(@" ||=============================================================================||");
                                    #endregion
                                    string tempvalued = Console.ReadLine();
                                    if (double.TryParse(tempvalued, out tryparse))
                                    {
                                        menu.planetChoice = tryparse;
                                    }
                                    fuelchecker = (menu.ChekForFuel(Zell.Fuel));
                                    if (fuelchecker == 0)
                                    {
                                        menu.planetChoice = 5;
                                        Console.WriteLine(menu.NotEnoughFuel());
                                        Console.ReadKey();
                                    }
                                    Console.Clear();
                                    if (fuelchecker == 1)
                                    {
                                        if (menu.planetChoice == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.White;
                                            break;
                                        }
                                        if (menu.planetChoice == 2 || menu.planetChoice == 4 || menu.planetChoice == 6 ||
                                            menu.planetChoice == 99)
                                        {
                                            exitt = 1;
                                        }
                                        else if (menu.planetChoice != 2 || menu.planetChoice != 4 || menu.planetChoice != 6 ||
                                                 menu.planetChoice != 99)
                                        {
                                            menu.planetChoice = 5;
                                            Console.WriteLine(menu.IncorrectSelection());
                                            exitt = 0;
                                        }
                                    }
                                    Console.WriteLine(menu.ThrustersCharging());
                                    ShowSimplePercentage();
                                    int milliseconds = 600;
                                    Thread.Sleep(milliseconds);
                                    Console.WriteLine();
                                    Console.WriteLine(menu.ThrustersCharged());
                                    Console.ReadKey();
                                    Console.Clear();
                                    exit5 = 1;
                                    break;
                                case 5:
                                    Console.WriteLine(Zell.InventoryDisplay());
                                    if (Zell.Weapons > 0)
                                    {
                                        Console.WriteLine($"Weapons: {Zell.Weapons}");
                                    }
                                    #region //Mission log for inventory
                                    if (ingametime.month == 3 && ingametime.day <= 31 && ingametime.year == 2457 &&
                                        natotisMissions.Mission001success == 2)
                                    {
                                        Console.WriteLine($"\n\nNatotis #1 -  {natotisMissions.Escort001InProgress()}");
                                    }
                                    if (ingametime.month <= 5 && ingametime.year == 2457 &&
                                        natotisMissions.Mission002success == 2)
                                    {
                                        Console.WriteLine($"\nNatotis #2 -  {natotisMissions.Delivery002InProgress()}");
                                    }
                                    if (natotisMissions.Supply001Success == 2)
                                    {
                                        Console.WriteLine($"\nNatotis -  {natotisMissions.Supply001InProgress()}");
                                    }


                                    #endregion
                                    Console.ReadKey();
                                    break;
                                case 6:
                                    StockMarket();
                                    break;
                            }




                        }
                        break;
                    case 6://XaenidesStation
                        ingametime.time(menu.planetChoice);
                        Zell.Fuel -= 05;
                        if (Zell.Credits <300){Console.WriteLine(xaenidesStation.NotEnoughCredits());
                            Console.ReadKey();
                            break;
                        }
                        Zell.Credits -= 300;
                        int exit6 = 0;
                        xaenidesStation.ItemCalculation();
                        StockGen();
                        #region //Ship interaction
                        Console.WriteLine(battle.ShipEmerges(battle.Battlechance(battlechance.Next(0, 100))));
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine($"\n" + battle.ShipEngages(battle.shipChoice));
                        Console.WriteLine(battle.PlayerConfronts(battle.shipChoice));
                        int confront5 = Int32.Parse(Console.ReadLine());   //try parse
                        Console.Clear();
                        Console.WriteLine(battle.ShipResponds(battle.shipChoice, confront5, Zell.Speed, Zell.Hull, Zell.Attack, Zell.Weapons, Zell.Credits));
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine(battle.ConflictResult(battle.shipChoice, confront5, Zell.Weapons, Zell.Credits, Zell.Speed, Zell.Hull, Zell.Attack));
                        #region Conflict results
                        if (battle.shipChoice == 4)//Federation Flagship
                        {


                            if (confront5 == 1)
                            {
                                if (Zell.DarkMatter < 0)
                                {

                                    Zell.Fuel -= 20;
                                }

                                if (Zell.DarkMatter > 0)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }
                            }
                            if (confront5 == 2)
                            {
                                if (Zell.Credits > 50000)
                                {
                                    Zell.Credits = Zell.Credits - (Zell.Credits * .10);
                                }

                                if (Zell.Credits < 50000)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }
                            }
                            if (confront5 == 3)
                            {


                                if (Zell.DarkMatter > 0 && Zell.Credits < 20000)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }

                                if (Zell.DarkMatter > 0 && Zell.Credits > 20000)
                                {
                                    Zell.Credits = Zell.Credits - (Zell.Credits * .05);

                                }
                            }
                        }
                        if (battle.shipChoice == 3)//Federation Cruiser
                        {


                            if (confront5 == 1)
                            {
                                if (Zell.DarkMatter < 0)
                                {

                                    Zell.Fuel -= 20;
                                }

                                if (Zell.DarkMatter > 0)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }
                            }
                            if (confront5 == 2)
                            {
                                if (Zell.Credits > 20000)
                                {
                                    Zell.Credits = Zell.Credits - (Zell.Credits * .05);
                                }

                                if (Zell.Credits < 20000)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }
                            }
                            if (confront5 == 3)
                            {


                                if (Zell.DarkMatter > 0 && Zell.Credits < 15000)
                                {
                                    Zell.DarkMatter = 0;
                                    Zell.Aether = 0;
                                    Zell.Beryllium = 0;
                                    Zell.Carbon = 0;
                                    Zell.Food = 0;
                                    Zell.Helium3 = 0;
                                    Zell.Lead = 0;
                                    Zell.Neutronium = 0;
                                    Zell.Thorium = 0;
                                    Zell.WaterIce = 0;
                                    menu.planetChoice = 6;
                                    break;
                                }

                                if (Zell.DarkMatter > 0 && Zell.Credits > 15000)
                                {
                                    Zell.Credits = Zell.Credits - (Zell.Credits * .02);

                                }
                            }
                        }
                        if (battle.shipChoice == 2)//Pirate
                        {

                            if (confront5 == 1)
                            {


                                if (Zell.Speed < smuggler.Speed)
                                { Zell.Credits -= 500; }

                            }
                            if (confront5 == 2)
                            {

                                if (Zell.Attack < smuggler.Hull)
                                {
                                    Zell.Credits = Zell.Credits - (Zell.Credits * .20);
                                }

                            }
                            if (confront5 == 3)
                            {
                                Zell.Credits -= 500;
                            }
                        }
                        if (battle.shipChoice == 1) //smuggler
                        {
                            if (confront5 == 3)
                            {
                                Zell.Weapons += 1;
                                Zell.Credits -= 500;
                            }

                        }
                        if (battle.shipChoice == 0) //Normal
                        {
                            if (confront5 == 2)
                            {
                                if (battle.brokenShip() == 9)
                                {
                                    Console.WriteLine("You found some containers with 3- Beryllium"); Console.ReadKey();
                                    Zell.Beryllium += 1;
                                }
                                if (battle.brokenShip() == 5)
                                {
                                    Console.WriteLine("You found some containers with 3- Water/Ice"); Console.ReadKey();
                                    Zell.WaterIce += 1;
                                }
                                if (battle.brokenShip() == 2)
                                {
                                    Console.WriteLine("You found some containers with 1 - Lead"); Console.ReadKey();
                                    Zell.Lead += 1;
                                }
                                if (battle.brokenShip() == 15)
                                {
                                    Console.WriteLine("You found some containers with 1 - Neutronium");
                                    Console.ReadKey();
                                    Zell.Neutronium += 1;
                                }
                                else
                                {
                                    Console.WriteLine("You found nothing.... ");
                                }

                            }

                        }


                        #endregion
                        #endregion
                        Console.ReadKey();
                        Console.Clear();
                        while (exit6 == 0)// Exits once user chooses to go back to ship
                        {
                            #region  //Planet welcome dialog


                            Console.Clear();
                            Console.Write(@"██   ██  █████  ███████ ███    ██ ██ ██████  ███████ ███████     ███████ ████████  █████  ████████ ██  ██████  ███    ██ 
 ██ ██  ██   ██ ██      ████   ██ ██ ██   ██ ██      ██          ██         ██    ██   ██    ██    ██ ██    ██ ████   ██ 
  ███   ███████ █████   ██ ██  ██ ██ ██   ██ █████   ███████     ███████    ██    ███████    ██    ██ ██    ██ ██ ██  ██ 
 ██ ██  ██   ██ ██      ██  ██ ██ ██ ██   ██ ██           ██          ██    ██    ██   ██    ██    ██ ██    ██ ██  ██ ██ 
██   ██ ██   ██ ███████ ██   ████ ██ ██████  ███████ ███████     ███████    ██    ██   ██    ██    ██  ██████  ██   ████ "); Console.Write($"\t{menu.Occupation(5)}");
                            Console.WriteLine();
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine(menu.XaenidesArt());
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine($"\n\n{xaenidesStation.Description()}\n\n {xaenidesStation.Tax()}");
                            Console.WriteLine($"\n{menu.PlanetDialog()}");
                            #endregion 
                            int choice = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch (choice)
                            {
                                case 1://Market

                                    int marketexit = 0;
                                    while (marketexit == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine();
                                        Console.WriteLine(
                                            @"███    ███  █████  ██████  ██   ██ ███████ ████████ ██████  ██       █████   ██████ ███████ 
████  ████ ██   ██ ██   ██ ██  ██  ██         ██    ██   ██ ██      ██   ██ ██      ██      
██ ████ ██ ███████ ██████  █████   █████      ██    ██████  ██      ███████ ██      █████   
██  ██  ██ ██   ██ ██   ██ ██  ██  ██         ██    ██      ██      ██   ██ ██      ██      
██      ██ ██   ██ ██   ██ ██   ██ ███████    ██    ██      ███████ ██   ██  ██████ ███████");
                                        Console.WriteLine(
                                            "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine(
                                            "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine($"\n\n{menu.ShopDialog()}");
                                        Console.Write("> ");
                                        string tempvalue0 = Console.ReadLine();
                                        double.TryParse(tempvalue0, out tryparse);
                                        Console.Clear();
                                        double commerceChoice = tryparse;
                                        switch (commerceChoice)
                                        {
                                            case 1:
                                                #region //BUY
                                                Console.Clear();
                                                Console.WriteLine();
                                                Console.WriteLine(
                                                    @"███    ███  █████  ██████  ██   ██ ███████ ████████ ██████  ██       █████   ██████ ███████ 
████  ████ ██   ██ ██   ██ ██  ██  ██         ██    ██   ██ ██      ██   ██ ██      ██      
██ ████ ██ ███████ ██████  █████   █████      ██    ██████  ██      ███████ ██      █████   
██  ██  ██ ██   ██ ██   ██ ██  ██  ██         ██    ██      ██      ██   ██ ██      ██      
██      ██ ██   ██ ██   ██ ██   ██ ███████    ██    ██      ███████ ██   ██  ██████ ███████");
                                                Console.WriteLine(
                                                    "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                                Console.WriteLine(
                                                    "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                                                Console.WriteLine($"{xaenidesStation.BuyWelcome()}\n\n");
                                                Console.ReadLine();

                                                #region Item for sale list
                                                Console.WriteLine($"Credits: {Zell.Credits}\n\n Cargo:{Zell.Cargo} / {Zell.TotalCargo}\n\n");
                                                Console.WriteLine(xaenidesStation.Dithprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(xaenidesStation.Beryllprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(xaenidesStation.Carbonprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(xaenidesStation.Thoriumprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(xaenidesStation.WaterIceprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(xaenidesStation.Leadprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(xaenidesStation.Aetherprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(xaenidesStation.Foodprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(xaenidesStation.Helium3price());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(xaenidesStation.Neutroniumprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(xaenidesStation.DarkMatterprice());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(menu.NewShip());
                                                Console.WriteLine(menu.SeperationLine());
                                                Console.WriteLine(xaenidesStation.StationSellprice());
                                                #endregion
                                                Console.Write("\n\nWhat would you like to purchase?:"); double item = Convert.ToInt32(Console.ReadLine());
                                                if (item == 99)
                                                {
                                                    break;
                                                }
                                                Console.WriteLine();
                                                if (xaenidesStation.QtyTranslation(item) == 0) { Console.WriteLine(menu.OutofStock()); Console.ReadKey(); }
                                                
                                                Console.Write("\n\nHow many?:"); int amount = Convert.ToInt32(Console.ReadLine());
                                                if (menu.PurchasePrice(xaenidesStation.ItemTranslation(item), amount) > Zell.Credits)
                                                { Console.WriteLine(menu.NotEnoughCredits()); Console.ReadLine(); break; }
                                                if (xaenidesStation.ItemTranslation(item) - amount < 0)
                                                {
                                                    Console.WriteLine(menu.OutofStock()); Console.ReadKey();
                                                    break;
                                                }
                                                Console.Clear();
                                                Console.WriteLine($"\n\nSale total is : ${menu.PurchasePrice(xaenidesStation.ItemTranslation(item), amount):C}  Weight:{menu.TotalCargo(xaenidesStation.WeightTranslation(item), amount):C}");
                                                #region  //Math to reduce Qty and raise cargo
                                                switch (item)
                                                {
                                                    case 1:
                                                        Zell.Fuel += amount; xaenidesStation.Dilithium.Qty -= amount;
                                                        break;
                                                    case 2:
                                                        Zell.Beryllium += amount; xaenidesStation.Beryllium.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(xaenidesStation.WeightTranslation(item), amount);
                                                        break;
                                                    case 3:
                                                        Zell.Carbon += amount; xaenidesStation.Carbon.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(xaenidesStation.WeightTranslation(item), amount);
                                                        break;
                                                    case 4:
                                                        Zell.Thorium += amount; xaenidesStation.Thorium.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(xaenidesStation.WeightTranslation(item), amount);
                                                        break;
                                                    case 5:
                                                        Zell.WaterIce += amount; xaenidesStation.WaterIce.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(xaenidesStation.WeightTranslation(item), amount);
                                                        break;
                                                    case 6:
                                                        Zell.Lead += amount; xaenidesStation.Lead.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(xaenidesStation.WeightTranslation(item), amount);
                                                        break;
                                                    case 7:
                                                        Zell.Aether += amount; xaenidesStation.Aether.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(xaenidesStation.WeightTranslation(item), amount);
                                                        break;
                                                    case 8:
                                                        Zell.Food += amount; xaenidesStation.Food.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(xaenidesStation.WeightTranslation(item), amount);
                                                        break;
                                                    case 9:
                                                        Zell.Neutronium += amount; xaenidesStation.Neutronium.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(xaenidesStation.WeightTranslation(item), amount);
                                                        break;
                                                    case 10:
                                                        Zell.Helium3 += amount; xaenidesStation.Helium3.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(xaenidesStation.WeightTranslation(item), amount);
                                                        break;
                                                    case 11:
                                                        Zell.DarkMatter += amount; xaenidesStation.DarkMatter.Qty -= amount;
                                                        Zell.Cargo += menu.TotalCargo(xaenidesStation.WeightTranslation(item), amount);
                                                        break;
                                                    case 12:
                                                        Zell.TotalCargo += 100;
                                                        break;
                                                    case 13:
                                                        Console.WriteLine(menu.Win());
                                                        Console.ReadKey();
                                                        Environment.Exit(0);
                                                        break;
                                                }
                                                Zell.Credits -= menu.PurchasePrice(xaenidesStation.ItemTranslation(item), amount);
                                                #endregion
                                                Console.WriteLine($"\nCredits remaining: ${Zell.Credits}\n\nTotal Cargo: {Zell.Cargo} / {Zell.TotalCargo}\n\nFuel Level: {Zell.Fuel}");
                                                Console.WriteLine(Zell.InventoryDisplay());
                                                Console.ReadLine();
                                                Console.Clear();
                                                #endregion
                                                break;
                                            case 2:
                                                #region //SELL
                                                Console.Clear();
                                                Console.WriteLine();
                                                Console.WriteLine(
                                                    @"███    ███  █████  ██████  ██   ██ ███████ ████████ ██████  ██       █████   ██████ ███████ 
████  ████ ██   ██ ██   ██ ██  ██  ██         ██    ██   ██ ██      ██   ██ ██      ██      
██ ████ ██ ███████ ██████  █████   █████      ██    ██████  ██      ███████ ██      █████   
██  ██  ██ ██   ██ ██   ██ ██  ██  ██         ██    ██      ██      ██   ██ ██      ██      
██      ██ ██   ██ ██   ██ ██   ██ ███████    ██    ██      ███████ ██   ██  ██████ ███████");
                                                Console.WriteLine(
                                                    "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                                Console.WriteLine(
                                                    "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                                                Console.WriteLine($"{xaenidesStation.BuyWelcome()}\n\n");
                                                Console.ReadLine();
                                                Console.WriteLine($"Current Prices:\n\n{xaenidesStation.DithSellprice()} \n {xaenidesStation.Beryllprice()} \n {xaenidesStation.CarbonSellprice()} \n {xaenidesStation.ThoriumSellprice()} \n " +
                                                                  $"{xaenidesStation.WaterIceSellprice()} \n {xaenidesStation.LeadSellprice()} \n {xaenidesStation.AetherSellprice()} \n {xaenidesStation.FoodSellprice()} \n {xaenidesStation.NeutroniumSellprice()} \n {xaenidesStation.Helium3Sellprice()} \n " +
                                                                  $"{xaenidesStation.DarkMatterSellprice()}");
                                                Console.WriteLine($"\n\nYour Inventory:\n\n {Zell.InventoryDisplay()}");
                                                Console.Write("\n\nWhat would you like to sell?:"); double item2 = Convert.ToInt32(Console.ReadLine());
                                                if (xaenidesStation.QtyTranslation(item2) == 0) { Console.WriteLine(menu.OutofStock()); Console.ReadKey(); break; }
                                                if (item2 == 99)
                                                {
                                                    break;
                                                }
                                                Console.Write("\n\nHow many?:"); int amount2 = Convert.ToInt32(Console.ReadLine());
                                                Console.Clear();
                                                if (Zell.ItemTranslation(item2) - amount2 < 0) { Console.WriteLine(menu.NotEnoughItems()); Console.ReadKey(); break; }
                                                Console.WriteLine($"\n\nSale total is : ${menu.PurchasePrice(xaenidesStation.ItemTranslation(item2), amount2):C}  Weight:{menu.TotalCargo(xaenidesStation.WeightTranslation(item2), amount2):C}");
                                                switch (item2)
                                                {
                                                    case 2:
                                                        Zell.Beryllium -= amount2; xaenidesStation.Beryllium.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(xaenidesStation.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 3:
                                                        Zell.Carbon -= amount2; xaenidesStation.Carbon.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(xaenidesStation.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 4:
                                                        Zell.Thorium -= amount2; xaenidesStation.Thorium.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(xaenidesStation.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 5:
                                                        Zell.WaterIce -= amount2; xaenidesStation.WaterIce.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(xaenidesStation.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 6:
                                                        Zell.Lead -= amount2; xaenidesStation.Lead.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(xaenidesStation.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 7:
                                                        Zell.Aether -= amount2; xaenidesStation.Aether.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(xaenidesStation.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 8:
                                                        Zell.Food -= amount2; xaenidesStation.Food.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(xaenidesStation.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 9:
                                                        Zell.Neutronium -= amount2; xaenidesStation.Neutronium.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(xaenidesStation.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 10:
                                                        Zell.Helium3 -= amount2; xaenidesStation.Helium3.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(xaenidesStation.WeightTranslation(item2), amount2);
                                                        break;
                                                    case 11:
                                                        Zell.DarkMatter -= amount2; xaenidesStation.DarkMatter.Qty += amount2;
                                                        Zell.Cargo -= menu.TotalCargo(xaenidesStation.WeightTranslation(item2), amount2);
                                                        break;
                                                        //Add station
                                                }
                                                Zell.Credits += menu.PurchasePrice(xaenidesStation.ItemTranslation(item2), amount2);
                                                Console.WriteLine($"\nCredits remaining: ${Zell.Credits}\n\nTotal Cargo: {Zell.Cargo} / {Zell.TotalCargo}\n\nFuel Level: {Zell.Fuel}");
                                                Console.WriteLine(Zell.InventoryDisplay());
                                                Console.ReadKey();
                                                #endregion
                                                break;
                                            case 99:
                                                marketexit = 1;
                                                break;
                                        }
                                    }

                                   
                                    break;
                                case 2://Merchants Lounge
                                    int zhulexit = 0;
                                    while (zhulexit == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine();
                                        Console.WriteLine(
                                            @"  ███    ███ ███████ ██████   ██████ ██   ██  █████  ███    ██ ████████     ██       ██████  ██    ██ ███    ██  ██████  ███████ 
████  ████ ██      ██   ██ ██      ██   ██ ██   ██ ████   ██    ██        ██      ██    ██ ██    ██ ████   ██ ██       ██      
██ ████ ██ █████   ██████  ██      ███████ ███████ ██ ██  ██    ██        ██      ██    ██ ██    ██ ██ ██  ██ ██   ███ █████   
██  ██  ██ ██      ██   ██ ██      ██   ██ ██   ██ ██  ██ ██    ██        ██      ██    ██ ██    ██ ██  ██ ██ ██    ██ ██      
██      ██ ███████ ██   ██  ██████ ██   ██ ██   ██ ██   ████    ██        ███████  ██████   ██████  ██   ████  ██████  ███████     ");
                                        Console.WriteLine(
                                            "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine(
                                            "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine($"\n\n{xaenidesStation.LoungeOptions()}");
                                        string tempvalue01 = Console.ReadLine();
                                        double.TryParse(tempvalue01, out tryparse);
                                        double zhulChoice = tryparse;
                                        switch (zhulChoice)
                                        {
                                            case 1: //
                                                Console.WriteLine(
                                                    "Under Construction");
                                                Console.ReadKey();
                                                break;
                                            case 2: //
                                                Console.WriteLine(
                                                    "Under Construction");
                                                Console.ReadKey();
                                                break;
                                            case 3: //Cantina
                                                Console.WriteLine(
                                                    "Under Construction");
                                                Console.ReadKey();
                                                if (Zell.Weapons > 0)
                                                {
                                                    Console.WriteLine("You walk in and have a few drinks, after a while you hear rumbles that there is an arms dealer \n" +
                                                                      "sitting at the table across the bar. You think about the stock of weapons you have on your ship.\n" +
                                                                      "You walk over and make conversation and let it 'slip' that you have Federation weapons. He seems\n" +
                                                                      "interested and you head back to your ship. After inspecting the contents, he offers to pay 600 for\n" +
                                                                      "each.");
                                                    Console.ReadKey();
                                                    Zell.Credits = Zell.Weapons * 600;
                                                    Zell.Weapons = 0;

                                                }//Sell weapons
                                                break;
                                            case 4: //
                                                Console.WriteLine(
                                                    "Under Construction");
                                                Console.ReadKey();
                                                break;
                                            case 99:
                                                zhulexit = 1;
                                                break;
                                        }
                                    }
                                    break;
                                case 3://Mission Board
                                    int exitmission = 1;
                                    while (exitmission == 1)
                                    {
                                        #region //Mission Endings
                                        //if (natotisMissions.Mission001success == 1 || natotisMissions.Mission001success == 0)
                                        //{
                                        //    Console.WriteLine(natotisMissions.Escort001Ends(natotisMissions.Mission001success));
                                        //    Console.ReadKey();
                                        //    Console.Clear();

                                        //}

                                        #endregion
                                        Console.WriteLine();
                                        Console.WriteLine(@"███    ███ ██ ███████ ███████ ██  ██████  ███    ██     ██████   ██████   █████  ██████  ██████  
████  ████ ██ ██      ██      ██ ██    ██ ████   ██     ██   ██ ██    ██ ██   ██ ██   ██ ██   ██ 
██ ████ ██ ██ ███████ ███████ ██ ██    ██ ██ ██  ██     ██████  ██    ██ ███████ ██████  ██   ██ 
██  ██  ██ ██      ██      ██ ██ ██    ██ ██  ██ ██     ██   ██ ██    ██ ██   ██ ██   ██ ██   ██ 
██      ██ ██ ███████ ███████ ██  ██████  ██   ████     ██████   ██████  ██   ██ ██   ██ ██████ ");
                                        Console.WriteLine();
                                        Console.WriteLine(
                                            "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                                        //Console.WriteLine(natotisMissions.MissionBoard());  //Add board desc
                                        Console.ReadKey();

                                        #region Mission graphic

                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine(
                                            @" =========================================================================================");
                                        Console.WriteLine(
                                            @" ||                   Xaenides Station Board for those who need Help                     ||");

                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine(
                                            @" ||=====================================================================================||");
                                        Console.WriteLine(
                                            @$" ||  Current System: Natotis                                                            ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @$" || {ingametime.month}/{ingametime.day}/{ingametime.year}                                ");
                                        Console.WriteLine(
                                            @" ||=====================================================================================||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||=====================================================================================||");
                                        Console.WriteLine(
                                            @$" ||                                                                                     || ");
                                        //if (ingametime.month == 3 && ingametime.day <= 31 && ingametime.year == 2457 &&
                                        //    natotisMissions.Mission001success == 3)
                                        //{
                                        //    Console.WriteLine($"#1 -  {natotisMissions.Escort001advertisement()}");
                                        //}
                                        //if (ingametime.month == 3 && ingametime.day <= 31 && ingametime.year == 2457 &&
                                        //    natotisMissions.Mission001success == 2)
                                        //{
                                        //    Console.WriteLine($"   #1 -  {natotisMissions.Escort001InProgress()}");
                                        //}

                                        Console.WriteLine(
                                            @$" ||                                                                                     ||");
                                        //if (ingametime.month == 3 && ingametime.day <= 31 && ingametime.year == 2457 &&
                                        //    natotisMissions.Mission002success == 3)
                                        //{
                                        //    Console.WriteLine($"#2 -  {natotisMissions.Delivery002advertisement()}");
                                        //}
                                        //if (ingametime.month == 5 && ingametime.day <= 1 && ingametime.year == 2457 &&
                                        //    natotisMissions.Mission002success == 2)
                                        //{
                                        //    Console.WriteLine($"   #2 -  {natotisMissions.Delivery002InProgress()}");
                                        //}
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            $@" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||                                                                                     ||");
                                        Console.WriteLine(
                                            @" ||=====================================================================================||");
                                        Console.WriteLine("\n\n\n No missions available... press Enter or press 99 to exit..");
                                        Console.Write(">"); string tempvalu = Console.ReadLine();
                                        double.TryParse(tempvalu, out tryparse);
                                        double mission = tryparse;
                                        if (mission == 99)
                                        {
                                            exitmission = 0;
                                        }
                                        //if (natotisMissions.Mission001success == 3)
                                        //{
                                        //    if (mission == 1)
                                        //    {
                                        //        Console.Clear();
                                        //        Console.WriteLine(natotisMissions.Escort001());
                                        //        string tempvalu1 = Console.ReadLine();
                                        //        Console.Clear();
                                        //        double.TryParse(tempvalu1, out tryparse);
                                        //        double mission2 = tryparse;
                                        //        Console.WriteLine(natotisMissions.Escort001A(mission2));
                                        //        Console.ReadKey();
                                        //        if (mission2 == 2)
                                        //        {
                                        //            natotisMissions.Mission001success = 4;
                                        //        }
                                        //    }
                                        //}
                                        //if (natotisMissions.Mission002success == 3)
                                        //{
                                        //    if (mission == 1)
                                        //    {
                                        //        Console.Clear();
                                        //        Console.WriteLine(natotisMissions.Escort001());
                                        //        string tempvalu1 = Console.ReadLine();
                                        //        Console.Clear();
                                        //        double.TryParse(tempvalu1, out tryparse);
                                        //        double mission2 = tryparse;
                                        //        Console.WriteLine(natotisMissions.Escort001A(mission2));
                                        //        Console.ReadKey();
                                        //        if (mission2 == 2)
                                        //        {
                                        //            natotisMissions.Mission002success = 4;
                                        //        }
                                        //    }
                                        //}

                                        Console.Clear();

                                        #endregion
                                    }
                                    Console.ForegroundColor = ConsoleColor.White;
                                    break;
                                case 4://Back to Ship

                                    #region Navvi
                                    Console.WriteLine(@"███    ██  █████  ██    ██ ██    ██ ██     ███████ ██    ██ ███████ ████████ ███████ ███    ███ 
████   ██ ██   ██ ██    ██ ██    ██ ██     ██       ██  ██  ██         ██    ██      ████  ████ 
██ ██  ██ ███████ ██    ██ ██    ██ ██     ███████   ████   ███████    ██    █████   ██ ████ ██ 
██  ██ ██ ██   ██  ██  ██   ██  ██  ██          ██    ██         ██    ██    ██      ██  ██  ██ 
██   ████ ██   ██   ████     ████   ██     ███████    ██    ███████    ██    ███████ ██      ██ ");
                                    Console.WriteLine("\n\n");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(@" =================================================================================");
                                    Console.WriteLine(@" ||                                    NAVVI SYSTEM                             ||");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(@" ||=============================================================================||");
                                    Console.WriteLine(@$" ||  Current System: Xaenides Station                                          ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@$" || {ingametime.month}/{ingametime.day}/{ingametime.year}                                                                   ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||=============================================================================||");
                                    Console.WriteLine(@" ||=============================================================================||");
                                    Console.WriteLine(@$" || Current Fuel: {Zell.Fuel}                                                         ");
                                    Console.WriteLine(@$" || Credit Ledger: {Zell.Credits}                                                    ");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||  0 - Return to Station                                                      ||");
                                    Console.WriteLine(@" ||  1 - Natotis (25 Feul)                                                      ||");
                                    Console.WriteLine(@" ||  2 - Otov (30 Feul)                                                         ||");
                                    Console.WriteLine(@" ||  3 - Gelara (15 Feul)                                                       ||");
                                    Console.WriteLine(@" ||  4 - Larvis (15 Feul)                                                       ||");
                                    Console.WriteLine(@" ||  5 - Aoclite (25 Feul)                                                      ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||=============================================================================||");
                                    Console.WriteLine($@" ||                                                                            ||");
                                    Console.WriteLine(@" ||=============================================================================||");
                                    #endregion


                                    

                                    string tempvaluee = Console.ReadLine();
                                    if (double.TryParse(tempvaluee, out tryparse))
                                    {
                                        menu.planetChoice = tryparse;
                                    }
                                    fuelchecker = (menu.ChekForFuel(Zell.Fuel));
                                    if (fuelchecker == 0)
                                    {
                                        menu.planetChoice = 6;
                                        Console.WriteLine(menu.NotEnoughFuel());
                                        Console.ReadKey();
                                    }
                                    if (fuelchecker == 1)
                                    {
                                        if (menu.planetChoice == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.White;
                                            break;
                                        }
                                        exitt = 1;
                                    }
                                    Console.WriteLine(menu.ThrustersCharging());
                                    ShowSimplePercentage();
                                    int milliseconds = 600;
                                    Thread.Sleep(milliseconds);
                                    Console.WriteLine();
                                    Console.WriteLine(menu.ThrustersCharged());
                                    Console.ReadKey();
                                    Console.Clear();
                                    exit6 = 1;
                                    break;
                                case 5:
                                    Console.WriteLine(Zell.InventoryDisplay());
                                    if (Zell.Weapons > 0)
                                    {
                                        Console.WriteLine($"Weapons: {Zell.Weapons}");
                                    }
                                    #region //Mission log for inventory
                                    if (ingametime.month == 3 && ingametime.day <= 31 && ingametime.year == 2457 &&
                                        natotisMissions.Mission001success == 2)
                                    {
                                        Console.WriteLine($"\n\nNatotis #1 -  {natotisMissions.Escort001InProgress()}");
                                    }
                                    if (ingametime.month <= 5 && ingametime.year == 2457 &&
                                        natotisMissions.Mission002success == 2)
                                    {
                                        Console.WriteLine($"\nNatotis #2 -  {natotisMissions.Delivery002InProgress()}");
                                    }
                                    if (natotisMissions.Supply001Success == 2)
                                    {
                                        Console.WriteLine($"\nNatotis -  {natotisMissions.Supply001InProgress()}");
                                    }


                                    #endregion
                                    Console.ReadKey();
                                    break;
                                case 6:
                                    StockMarket();
                                    break;
                            }




                        }
                        break;
                    case 7:
                        Console.WriteLine(Zell.InventoryDisplay());
                        #region //Mission log for inventory
                        if (ingametime.month == 3 && ingametime.day <= 31 && ingametime.year == 2457 &&
                            natotisMissions.Mission001success == 2)
                        {
                            Console.WriteLine($"\n\nNatotis #1 -  {natotisMissions.Escort001InProgress()}");
                        }
                        if (ingametime.month <= 5 && ingametime.year == 2457 &&
                            natotisMissions.Mission002success == 2)
                        {
                            Console.WriteLine($"\nNatotis #2 -  {natotisMissions.Delivery002InProgress()}");
                        }
                        if (natotisMissions.Supply001Success == 2)
                        {
                            Console.WriteLine($"\nNatotis -  {natotisMissions.Supply001InProgress()}");
                        }


                        #endregion
                        Console.ReadKey();
                        break;
                    case 8:
                        StockMarket();
                        break;
                    case 99:
                        Console.WriteLine(menu.PlayerQuit());
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                }

                




            }



            void StockMarket()
            {
                int exit = 0;
                while (exit == 0)
                {
                    double totalreturn = stock.TotalReturn(stock.ZhulReturn(Zhul.stockPrice, Zhul.qty),
                        stock.EpsolonReturn(Epsolon.stockPrice, Epsolon.qty),
                        stock.CrudeReturn(CrudeHelium.stockPrice, CrudeHelium.qty),
                        stock.TabletReturn(TabletRetailers.stockPrice, TabletRetailers.qty),
                        stock.ValkyrieReturn(Valkyrie.stockPrice, Valkyrie.qty));
                    if (Zhul.qty == 0 && Epsolon.qty == 0 && CrudeHelium.qty == 0 && TabletRetailers.qty == 0 &&
                        Valkyrie.qty == 0)
                    { stock.AmountInvested = 0;}
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(
                        @" ||===============================================================================================================||");
                    Console.WriteLine(
                        @" ||                                               AZGUAN STOCK SYSTEM                                             ||");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(
                        @" ||===============================================================================================================||");
                    Console.WriteLine(
                        $@"     Total Invested:   {stock.AmountInvested:C}                                                                                                 ");
                    Console.WriteLine(
                        $@"     Total Return:  {totalreturn:C}      Gain/Loss: {totalreturn-stock.AmountInvested:C}                                                                                            ");
                    Console.WriteLine(
                        $@"     Credits: {Zell.Credits}                                                                                               ");
                    Console.WriteLine(
                        @$"    Galactic Date: {ingametime.month}/{ingametime.day}/{ingametime.year}                                                                   ");
                    Console.WriteLine(
                        @"                                                                                                                  ");
                    Console.WriteLine(
                        @" ||===============================================================================================================||");
                    Console.WriteLine(
                        @" ||===============================================================================================================||");
                    Console.WriteLine(
                        @" ||  #      Symbol                                      Company                           Price             Qty   ||                ");
                    Console.WriteLine(
                        @$" ||===============================================================================================================||                                                                             ");
                    Console.WriteLine(
                        $@"    1       ZZZL                                   Zhul Shuttle Co.                        {Zhul.stockPrice:C}                                          ");
                    Console.WriteLine(
                        $@"                                                                                                           {Zhul.qty}           ");
                    Console.WriteLine(
                        $@"    2       EMC                                    Epsolon Motor Co.                       {Epsolon.stockPrice:C}                                                ");
                    Console.WriteLine(
                        $@"                                                                                                           {Epsolon.qty}          ");
                    Console.WriteLine(
                        $@"    3       CCL                                     Crude Helium                           {CrudeHelium.stockPrice:C}                                                                               ");
                    Console.WriteLine(
                        $@"                                                                                                           {CrudeHelium.qty}           ");
                    Console.WriteLine(
                        $@"    4       TRKL                                   Tablet Retailers                        {TabletRetailers.stockPrice:C}                                                 ");
                    Console.WriteLine(
                        $@"                                                                                                           {TabletRetailers.qty}            ");
                    Console.WriteLine(
                        $@"    5       VLG                                    Valkyrie Intelligence                   {Valkyrie.stockPrice:C}                                  ");
                    Console.WriteLine(
                        $@"                                                                                                            {Valkyrie.qty} ");
                    Console.WriteLine( 
                        @"                                                                              ");
                    Console.WriteLine(
                        @"                                                                              ");
                    Console.WriteLine(
                        @"                                                                              ");
                    Console.WriteLine(
                        @"                                                                              ");
                    Console.WriteLine(
                        @" ||===============================================================================================================||");
                 ;Console.WriteLine($@" ||{News()}||");   
                    Console.WriteLine(
                        @" ||===============================================================================================================||");
                    
                    Console.WriteLine(
                        "\nWelcome to the AZGUAN STOCK SYSTEM run by the Federation Financial Department (FFD).\n Stock prices are recalculated every Galactic Day. \n" +
                        "Please select one of the following options:\n\n" +
                        "1 - Buy \n\n" +
                        "2 - Sell \n\n" +
                        "99 - Exit");
                    string tempvalue1 = Console.ReadLine();
                    double.TryParse(tempvalue1, out tryparse);
                    double choice = tryparse;
                    switch (choice)
                    {
                        case 1://BUY
                            Console.WriteLine();
                            Console.WriteLine(stock.StockChoice());
                            string temp = Console.ReadLine();
                            double.TryParse(temp, out tryparse);
                            double item = tryparse;
                            if (item == null)
                            {
                                Console.WriteLine("You did not select anything");
                                break;
                            }

                            if (item > 5)
                            {
                                Console.WriteLine("That is not a proper symbol");
                                break;
                            }
                            Console.Write("\n\nHow many?:");
                            string tempvalue2 = Console.ReadLine();
                            double.TryParse(tempvalue2, out tryparse);
                            double amount = tryparse;
                            if (amount == null)
                            {
                                Console.WriteLine("You did not select anything");
                                break;
                            }
                            if (menu.PurchasePrice(ItemTranslation(item), amount) >
                                Zell.Credits) //sees if you have money to buy more items
                            {
                                Console.WriteLine(menu.NotEnoughCredits());
                                Console.ReadLine();

                            }

                            switch (item)
                            {
                                case 1:
                                    Zhul.qty += amount;
                                    
                                    break;
                                case 2:
                                    Epsolon.qty += amount;
                                    break;
                                case 3:
                                    CrudeHelium.qty += amount;
                                    break;
                                case 4:
                                    TabletRetailers.qty += amount;
                                    break;
                                case 5:
                                    Valkyrie.qty += amount;
                                    break;
                                case 99:
                                    exit = 1;
                                    break;
                                

                            }

                            Zell.Credits -= (amount * ItemTranslation(item));
                            Console.WriteLine(
                                $"\n\nSale total is : ${menu.PurchasePrice(ItemTranslation(item), amount):C}");
                            stock.AmountInvested += menu.PurchasePrice(ItemTranslation(item), amount);
                            Console.ReadKey();
                            break;
                        case 2://SELL
                            Console.WriteLine();
                            Console.WriteLine("\n\nWhat would you like to sell?:");
                            string tempvalue3 = Console.ReadLine();
                            double.TryParse(tempvalue3, out tryparse);
                            double item2 = tryparse;
                            if (item2 == null)
                            {
                                Console.WriteLine("You did not select anything");
                                break;
                            }
                            if (item2 > 5)
                            {
                                Console.WriteLine("That is not a proper symbol");
                                break;
                            }
                            if (ItemTranslation(item2) ==0)
                            {
                                Console.WriteLine(menu.NotEnoughItems());
                                Console.ReadKey();
                                break;
                            }
                            Console.Write("\n\nHow many?:");
                            string tempvalue21 = Console.ReadLine();
                            double.TryParse(tempvalue21, out tryparse);
                            double amount1 = tryparse;
                            if (amount1 == null)
                            {
                                Console.WriteLine("You did not select anything");
                                break;
                            }
                            if (QtyTranslation(item2) - amount1 < 0)
                            {
                                Console.WriteLine(menu.NotEnoughItems());
                                Console.ReadKey();
                                break;
                            }
                            switch (item2)
                            {
                                case 1:
                                    Zhul.qty -= amount1;
                                    break;
                                case 2:
                                    Epsolon.qty -= amount1;
                                    break;
                                case 3:
                                    CrudeHelium.qty -= amount1;
                                    break;
                                case 4:
                                    TabletRetailers.qty -= amount1;
                                    break;
                                case 5:
                                    Valkyrie.qty -= amount1;
                                    break;
                                case 99:
                                    exit = 1;
                                    break;

                            }

                            Zell.Credits += (amount1 * ItemTranslation(item2));
                            Console.WriteLine(
                                $"\n\nSale total is : ${menu.PurchasePrice(ItemTranslation(item2), amount1):C}");
                            stock.AmountInvested -= menu.PurchasePrice(ItemTranslation(item2), amount1);
                            
                            Console.ReadKey();
                            break;
                        case 99:
                            exit = 1;
                            break;
                    }
                }
                Console.ForegroundColor = ConsoleColor.White;
            }

            string News()
            {
                string news;
                Random rand = new Random();
                int gg = rand.Next(0, 100);
                if (gg > 90)
                {
                    news = "GNN [What does the Vurik treaty mean for fuel prices in outer colonies? Experts believe Helium prices will fal.";
                    return news;
                }
                if (gg <= 89 && gg>=80 )
                {
                    news = "GNN [Many Vuirk believe that the Federation should allow them to vote, many Fed Citizens are hesitant about thi"; return news;
                }
                if (gg <= 79 && gg >= 70)
                {
                    news = "GNN [Severe storms on Larvis raise concerns about carbon outputs.."; return news;
                }
                if (gg <= 69 && gg >= 60)
                {
                    news = "GNN [Small child falls into black hole, parents say they think he might be in their bookcase."; return news;
                }
                if (gg <= 59 && gg >= 50)
                {
                    news = "GNN [Several children found. The discoverers say they they understand why they were missing. Children destroy h"; return news;
                }
                if (gg <= 49 && gg >= 40)
                {
                    news = "GNN [Are your ships safe to fly? many consumers are curious after several spontanious explosions during takoff.";  return news;
                    
                }
                if (gg <= 39 && gg >= 30)
                {
                    news = "GNN [Epsolon Motor CEO accused of Laundering credits via the baby formula comany black whole fiber. GNN was una"; 
                    ; return news;
                    

                }
                if (gg <= 29 && gg >= 20)
                {
                    news = "GNN [Xaenides Station going to be for sale? Many wealthy investors are waiting for the news to break. Standby f"; return news;
                }
                else 
                {
                    news = "GNN [Federation elections will be done electronic due to COVID-57 breakout on Natotis.";
                     return news;

                }
                
            }
            void StockGen()
            {
                Zhul.stockPrice = stock.PriceGen(Zhul.stockPrice);
                Epsolon.stockPrice = stock.PriceGen(Epsolon.stockPrice);
                CrudeHelium.stockPrice = stock.PriceGen(CrudeHelium.stockPrice);
                TabletRetailers.stockPrice = stock.PriceGen(TabletRetailers.stockPrice);
                Valkyrie.stockPrice = stock.PriceGen(Valkyrie.stockPrice);

            }
        double ItemTranslation(double input)
        {
            if (input == 1)
            { return Zhul.stockPrice; }
            if (input == 2)
            { return Epsolon.stockPrice; }
            if (input == 3)
            { return CrudeHelium.stockPrice; }
            if (input == 4)
            { return TabletRetailers.stockPrice; }
            if (input == 5)
            { return Valkyrie.stockPrice; }
          
            return input;
           
        }

        double QtyTranslation(double input2)
        {
            if (input2 == 1)
            { return Zhul.qty; }
            if (input2 == 2)
            { return Epsolon.qty; }
            if (input2 == 3)
            { return CrudeHelium.qty; }
            if (input2 == 4)
            { return TabletRetailers.qty; }
            if (input2 == 5)
            { return Valkyrie.qty; }
                else return 0;

            //else{  double none= 0;
            //    return none;
            //}
        }



    }
        static void ShowSimplePercentage()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.Write($"\rProgress: {i}%   ");
                Thread.Sleep(25);
            }

            Console.Write("\rDone!          ");
        }

        



    }
}
