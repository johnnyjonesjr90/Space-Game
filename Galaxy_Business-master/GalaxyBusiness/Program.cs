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
            Ship Zell = new Ship { Beryllium = 0, Aether =0, Carbon= 0, DarkMatter =0, Food = 0, Helium3 = 0, Lead = 0, Neutronium = 0, Thorium = 0, WaterIce = 0 };
            Natotis natotis = new Natotis();
            Gelara gelara = new Gelara();
            Aoclite aoclite = new Aoclite();
            Larvis larvis = new Larvis();
            XaenidesStation xaenidesStation = new XaenidesStation();
            Otov otov = new Otov(); 
            Enemy smuggler = new Enemy { Attack = 100, Speed = 2, Hull = 500 }; 
            Enemy pirate = new Enemy { Attack = 200, Speed = 3, Hull = 800 }; 
            Enemy Federationscout = new Enemy { Attack = 400, Speed = 4, Hull = 400 };
            Battle battle = new Battle();
            InGameTime ingametime = new InGameTime {day= 12, month = 3, year = 2457};
            NatotisMissions natotisMissions = new NatotisMissions();
        #endregion
        int exit = 0;
            menu.planetChoice = 6;
            double tryparse;

//            #region //Game Start


//            Console.WriteLine(@"
//                    ███████ ██████   █████   ██████ ███████     ███    ███ ███████ ██████   ██████ ██   ██  █████  ███    ██ ████████ 
//                    ██      ██   ██ ██   ██ ██      ██          ████  ████ ██      ██   ██ ██      ██   ██ ██   ██ ████   ██    ██    
//                    ███████ ██████  ███████ ██      █████       ██ ████ ██ █████   ██████  ██      ███████ ███████ ██ ██  ██    ██    
//                         ██ ██      ██   ██ ██      ██          ██  ██  ██ ██      ██   ██ ██      ██   ██ ██   ██ ██  ██ ██    ██    
//                    ███████ ██      ██   ██  ██████ ███████     ██      ██ ███████ ██   ██  ██████ ██   ██ ██   ██ ██   ████    ██                                                                                                              
                                                                                                                  
//");
//            Console.WriteLine("\n\n\n\n\n\n\n Press Enter...");
//            var audioPlayer = new BasicAudio.AudioPlayer();
//            audioPlayer.Filename = @"C:\Users\Johnny\Documents\GitHub\Space-Game\Galaxy_Business-master\GalaxyBusiness\outer-space-warning.wav";
//            audioPlayer.Play();
//            Console.ReadKey();
//            Console.Clear();
//            menu.StoryStart();
//            foreach (var character in menu.StoryStart())
//            {
//                Console.Write(character);
//                Thread.Sleep(10);
//            }
//            Console.ReadKey();
//            int exit01 = 0;
//            while (exit01 == 0)
//            {
//                Console.Clear();
//                Console.WriteLine(menu.ShipSelection());
//                string tempship = Console.ReadLine();
//                double.TryParse(tempship, out tryparse);
//                double shipselect = tryparse;
//                if (shipselect == 1)
//                {
//                    Zell.TotalCargo = 50;
//                    Zell.Fuel = 300;
//                    Zell.Hull = 200;
//                    Zell.Speed = 500;
//                    Zell.Credits = 2000;
//                    Console.Clear();
//                    Console.WriteLine(
//                        $"You purchased the Xaenides Cruiser : \n\n\nFuel: {Zell.Fuel} \n\nCargo:{Zell.TotalCargo} \n\nHull: {Zell.Hull} \n\nSpeed: {Zell.Speed} \n\nCredits: {Zell.Credits}" +
//                        $"\n\n\n\n Press Enter...");
//                    Console.ReadKey();
//                    exit01 = 1;
//                }

//                if (shipselect == 2)
//                {
//                    Zell.TotalCargo = 350;
//                    Zell.Fuel = 50;
//                    Zell.Hull = 300;
//                    Zell.Speed = 100;
//                    Zell.Credits = 5000;
//                    Console.Clear();
//                    Console.WriteLine(
//                        $"You purchased the Natotis Hauler : \n\n\nFuel: {Zell.Fuel} \n\nCargo:{Zell.TotalCargo} \n\nHull: {Zell.Hull} \n\nSpeed: {Zell.Speed} \n\nCredits: {Zell.Credits}" +
//                        $"\n\n\n\n Press Enter...");
//                    Console.ReadKey();
//                    exit01 = 1;
//                }

//                if (shipselect == 3)
//                {
//                    Zell.TotalCargo = 100;
//                    Zell.Fuel = 100;
//                    Zell.Hull = 200;
//                    Zell.Speed = 300;
//                    Zell.Credits = 8000;
//                    Console.Clear();
//                    Console.WriteLine(
//                        $"You decided to keep your ship: \n\n\nFuel: {Zell.Fuel} \n\nCargo:{Zell.TotalCargo} \n\nHull: {Zell.Hull} \n\nSpeed: {Zell.Speed} \n\nCredits: {Zell.Credits}" +
//                        $"\n\n\n\n Press Enter...");
//                    Console.ReadKey();
//                    exit01 = 1;
//                }
//            }

//            #endregion

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
                    Console.WriteLine(@$" ||  Current System: Xaenides Station                                           ||");
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
                    Console.WriteLine($@" || 1 - Natotis (30)                                                            ||");
                    Console.WriteLine(@" || 2 - Otov     (10)                                                           ||");
                    Console.WriteLine(@" || 3 - Gelara   (15)                                                           ||");
                    Console.WriteLine(@" || 4 - Larvis   (15)                                                           ||");
                    Console.WriteLine(@" || 5 - Aoclite  (25)                                                           ||");
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
                    
                    string tempvaluek = Console.ReadLine();
                    double.TryParse(tempvaluek, out tryparse);
                    if (tryparse==1){ menu.planetChoice = tryparse; exitt = 1; }
                    if (tryparse == 2) { menu.planetChoice = tryparse; exitt = 1; }
                    if (tryparse == 3) { menu.planetChoice = tryparse; exitt = 1; }
                    if (tryparse == 4) { menu.planetChoice = tryparse; exitt = 1; }
                    if (tryparse == 5) { menu.planetChoice = tryparse; exitt = 1; }
                    
                    Console.Clear();
                }
                ingametime.time(menu.planetChoice);
                switch (menu.planetChoice)
                {
                       
                    case 1://Natotis 

                        Zell.Fuel -= 30;
                        int exit1 = 0;
                        
                        natotis.ItemCalculation();
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
                                    Zell.Credits = Zell.Credits - (Zell.Credits * 20);
                                }
                                
                            }
                            if (confront == 3)
                            {
                                Zell.Credits -= 500;
                            }
                        }
                        if (battle.shipChoice == 1) //smuggler
                        {
                            if (confront == 4)
                            {
                                Zell.Weapons += 1;
                                Zell.Cargo += 15;
                            }
                            
                        }



                        #endregion
                        #endregion
                        while (exit1 == 0)// Exits once user chooses to go back to ship
                        {
                            #region  //Planet welcome dialog
                                                                               
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine(@" ███    ██  █████  ████████  ██████  ████████ ██ ███████ 
████   ██ ██   ██    ██    ██    ██    ██    ██ ██      
██ ██  ██ ███████    ██    ██    ██    ██    ██ ███████ 
██  ██ ██ ██   ██    ██    ██    ██    ██    ██      ██ 
██   ████ ██   ██    ██     ██████     ██    ██ ███████");
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine(@"                                                                                            
                                                                                                                    .:=iiiiii=+=
                                                                                                                 .=i))=;::+)i=+,
                                                                                                              ,=i);)I)))I):=i=;
                                                                                                           .=i==))))ii)))I:i++
                                                                                                         +)+))iiiiiiii))I=i+:'
                                                                                    .,:;;++++++;:,.       )iii+:::;iii))+i='
                                                                                 .:;++=iiiiiiiiii=++;.    =::,,,:::=i));=+'
                                                                               ,;+==ii)))))))))))ii==+;,      ,,,:=i))+=:
                                                                             ,;+=ii))))))IIIIII))))ii===;.    ,,:=i)=i+
                                                                            ;+=ii)))IIIIITIIIIII))))iiii=+,   ,:=));=,
                                                                          ,+=i))IIIIIITTTTTITIIIIII)))I)i=+,,:+i)=i+
                                                                         ,+i))IIIIIITTTTTTTTTTTTI))IIII))i=::i))i='
                                                                        ,=i))IIIIITLLTTTTTTTTTTIITTTTIII)+;+i)+i`
                                                                        =i))IIITTLTLTTTTTTTTTIITTLLTTTII+:i)ii:'
                                                                       +i))IITTTLLLTTTTTTTTTTTTLLLTTTT+:i)))=,
                                                                       =))ITTTTTTTTTTTLTTTTTTLLLLLLTi:=)IIiii;
                                                                      .i)IIITTTTTTTTLTTTITLLLLLLLT);=)I)))))i;
                                                                      :))IIITTTTTLTTTTTTLLHLLLLL);=)II)IIIIi=:
                                                                      :i)IIITTTTTTTTTLLLHLLHLL)+=)II)ITTTI)i=
                                                                      .i)IIITTTTITTLLLHHLLLL);=)II)ITTTTII)i+
                                                                      =i)IIIIIITTLLLLLLHLL=:i)II)TTTTTTIII)i'
                                                                    +i)i)))IITTLLLLLLLLT=:i)II)TTTTLTTIII)i;
                                                                  +ii)i:)IITTLLTLLLLT=;+i)I)ITTTTLTTTII))i;
                                                                 =;)i=:,=)ITTTTLTTI=:i))I)TTTLLLTTTTTII)i;
                                                               +i)ii::,  +)IIITI+:+i)I))TTTTLLTTTTTII))=,
                                                             :=;)i=:,,    ,i++::i))I)ITTTTTTTTTTIIII)=+'
                                                           .+ii)i=::,,   ,,::=i)))iIITTTTTTTTIIIII)=+
                                                          ,==)ii=;:,,,,:::=ii)i)iIIIITIIITIIII))i+:'
                                                         +=:))i==;:::;=iii)+)=  `:i)))IIIII)ii+'
                                                       .+=:))iiiiiiii)))+ii;
                                                      .+=;))iiiiii)));ii+
                                                     .+=i:)))))))=+ii+
                                                    .;==i+::::=)i=;
                                                    ,+==iiiiii+,
                                                    `+=+++;`");
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine($"{natotis.Description()}\n\n\n");
                            Console.ReadKey();
                            Console.WriteLine(menu.ShopDialog());
                            #endregion

                            
                            string tempvalue = Console.ReadLine();
                            double.TryParse(tempvalue, out tryparse);
                            double choice = tryparse;
                            Console.Clear();
                            switch (choice)
                            {
                                case 1://Buy
                                    #region//BUY
                                    Console.WriteLine(natotis.BuyWelcome());
                                    Console.ReadLine();
                                    #region Item sale list
                                    Console.WriteLine($"Credits: {Zell.Credits}\n\n");
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

                                    Console.Write("\n\nWhat would you like to purchase?:"); string tempvalue1 = Console.ReadLine();
                                    double.TryParse(tempvalue1, out tryparse);
                                    double item = tryparse;
                                    if (natotis.QtyTranslation(item) == 0) { Console.WriteLine(menu.OutofStock()); Console.ReadKey(); break; }
                                    Console.Write("\n\nHow many?:"); string tempvalue2 = Console.ReadLine();
                                    double.TryParse(tempvalue2, out tryparse);
                                    double amount = tryparse;
                                    if (menu.TotalCargo(natotis.WeightTranslation(item), amount) + Zell.Cargo > Zell.TotalCargo) // sees if you have room to buy more items
                                    {Console.WriteLine(menu.NotEnoughCargo()); Console.ReadKey(); break; }
                                    if (menu.PurchasePrice(natotis.ItemTranslation(item), amount) > Zell.Credits) //sees if you have money to buy more items
                                    { Console.WriteLine(menu.NotEnoughCredits()); Console.ReadLine(); break; }
                                    Console.Clear();
                                    Console.WriteLine($"\n\nSale total is : ${menu.PurchasePrice(natotis.ItemTranslation(item), amount):0}  Weight:{menu.TotalCargo(natotis.WeightTranslation(item), amount):0}");
                                    #region  //Math to reduce Qty and raise cargo
                                    switch (item) 
                                    {
                                        case 1:
                                            Zell.Fuel += amount; natotis.Dilithium.Qty -= amount;
                                            break;
                                        case 2:
                                            Zell.Beryllium += amount; natotis.Beryllium.Qty -= amount;
                                            Zell.Cargo += menu.TotalCargo(natotis.WeightTranslation(item), amount);
                                            break;
                                        case 3:
                                            Zell.Carbon += amount; natotis.Carbon.Qty -= amount;
                                            Zell.Cargo += menu.TotalCargo(natotis.WeightTranslation(item), amount);
                                            break;
                                        case 4:
                                            Zell.Thorium += amount; natotis.Thorium.Qty -= amount;
                                            Zell.Cargo += menu.TotalCargo(natotis.WeightTranslation(item), amount);
                                            break;
                                        case 5:
                                            Zell.WaterIce += amount; natotis.WaterIce.Qty -= amount;
                                            Zell.Cargo += menu.TotalCargo(natotis.WeightTranslation(item), amount);
                                            break;
                                        case 6:
                                            Zell.Lead += amount; natotis.Lead.Qty -= amount;
                                            Zell.Cargo += menu.TotalCargo(natotis.WeightTranslation(item), amount);
                                            break;
                                        case 7:
                                            Zell.Aether += amount; natotis.Aether.Qty -= amount;
                                            Zell.Cargo += menu.TotalCargo(natotis.WeightTranslation(item), amount);
                                            break;
                                        case 8:
                                            Zell.Food += amount; natotis.Food.Qty -= amount;
                                            Zell.Cargo += menu.TotalCargo(natotis.WeightTranslation(item), amount);
                                            break;
                                        case 9:
                                            Zell.Neutronium += amount; natotis.Neutronium.Qty -= amount;
                                            Zell.Cargo += menu.TotalCargo(natotis.WeightTranslation(item), amount);
                                            break;
                                        case 10:
                                            Zell.Helium3 += amount; natotis.Helium3.Qty -= amount;
                                            Zell.Cargo += menu.TotalCargo(natotis.WeightTranslation(item), amount);
                                            break;
                                        case 11:
                                            Zell.DarkMatter += amount; natotis.DarkMatter.Qty -= amount;
                                            Zell.Cargo += menu.TotalCargo(natotis.WeightTranslation(item), amount);
                                            break;
                                        case 12:
                                            Zell.TotalCargo += 100;
                                            break;
                                    }         
                                    Zell.Credits -= menu.PurchasePrice(natotis.ItemTranslation(item), amount);
                                    #endregion
                                        Console.WriteLine($"\n\nCredits remaining: ${Zell.Credits}\n\nTotal Cargo: {Zell.Cargo} / {Zell.TotalCargo}\n\nFuel Level: {Zell.Fuel}");
                                        Console.WriteLine($"\n\n{Zell.InventoryDisplay()}");
                                        Console.ReadLine();
                                        Console.Clear();
                                    #endregion
                                    break;
                                case 2://Sell
                                    #region//SELL
                                    Console.WriteLine($"{natotis.BuyWelcome()}\n\n");
                                    Console.ReadLine();
                                    Console.WriteLine($"Current Prices:\n\n{natotis.DithSellprice()} \n {natotis.Beryllprice()} \n {natotis.CarbonSellprice()} \n {natotis.ThoriumSellprice()} \n " +
                                                      $"{natotis.WaterIceSellprice()} \n {natotis.LeadSellprice()} \n {natotis.AetherSellprice()} \n {natotis.FoodSellprice()} \n {natotis.NeutroniumSellprice()} \n {natotis.Helium3Sellprice()} \n " +
                                                      $"{natotis.DarkMatterSellprice()}");
                                    Console.WriteLine($"\n\nYour Inventory:\n\n {Zell.InventoryDisplay()}");
                                    Console.Write("\n\nWhat would you like to sell?:"); string tempvalue3 = Console.ReadLine();
                                    double.TryParse(tempvalue3, out tryparse);
                                    double item2 = tryparse;
                                    if (natotis.QtyTranslation(item2) == 0) { Console.WriteLine(menu.OutofStock()); Console.ReadKey(); break; }
                                    else if (natotis.QtyTranslation(item2) == 99) { break; }
                                    Console.Write("\n\nHow many?:"); string tempvalue4 = Console.ReadLine();
                                    double.TryParse(tempvalue4, out tryparse);
                                    double amount2 = tryparse;
                                    Console.Clear();
                                    if (Zell.ItemTranslation(item2) - amount2 < 0) { Console.WriteLine(menu.NotEnoughItems()); Console.ReadKey(); break; }
                                    Console.WriteLine($"\n\nSale total is : ${menu.PurchasePrice(natotis.ItemTranslation(item2), amount2):0}  Weight:{menu.TotalCargo(natotis.WeightTranslation(item2), amount2):0}");
                                    switch (item2)
                                    {
                                        
                                        case 2:
                                            Zell.Beryllium += amount2; natotis.Beryllium.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(natotis.WeightTranslation(item2), amount2);
                                            break;
                                        case 3:
                                            Zell.Carbon += amount2; natotis.Carbon.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(natotis.WeightTranslation(item2), amount2);
                                            break;
                                        case 4:
                                            Zell.Thorium += amount2; natotis.Thorium.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(natotis.WeightTranslation(item2), amount2);
                                            break;
                                        case 5:
                                            Zell.WaterIce += amount2; natotis.WaterIce.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(natotis.WeightTranslation(item2), amount2);
                                            break;
                                        case 6:
                                            Zell.Lead += amount2; natotis.Lead.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(natotis.WeightTranslation(item2), amount2);
                                            break;
                                        case 7:
                                            Zell.Aether += amount2; natotis.Aether.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(natotis.WeightTranslation(item2), amount2);
                                            break;
                                        case 8:
                                            Zell.Food += amount2; natotis.Food.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(natotis.WeightTranslation(item2), amount2);
                                            break;
                                        case 9:
                                            Zell.Neutronium += amount2; natotis.Neutronium.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(natotis.WeightTranslation(item2), amount2);
                                            break;
                                        case 10:
                                            Zell.Helium3 += amount2; natotis.Helium3.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(natotis.WeightTranslation(item2), amount2);
                                            break;
                                        case 11:
                                            Zell.DarkMatter += amount2; natotis.DarkMatter.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(natotis.WeightTranslation(item2), amount2);
                                            break;
                                    }
                                    Zell.Credits += menu.PurchasePrice(natotis.ItemTranslation(item2), amount2);
                                    Console.WriteLine($"\nCredits remaining: ${Zell.Credits}\n\nTotal Cargo: {Zell.Cargo} / {Zell.TotalCargo}\n\nFuel Level: {Zell.Fuel}");
                                    Console.WriteLine(Zell.InventoryDisplay());
                                    Console.ReadKey();
                                    #endregion
                                    break;
                                case 3://Mission Board
                                    int exitmission = 1;
                                    while (exitmission == 1)
                                    {
                                        #region //Mission Endings
                                        if (natotisMissions.Mission001success == 1 || natotisMissions.Mission001success == 0)
                                        {
                                            Console.WriteLine(natotisMissions.Escort001Ends(natotisMissions.Mission001success));
                                        }

                                        #endregion
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
                                            Console.WriteLine($"   #1 -  {natotisMissions.Escort001InProgress()}");
                                        }

                                        Console.WriteLine(
                                            @$" ||                                                                                     ||");
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
                                        string tempvalu = Console.ReadLine();
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
                                                    natotisMissions.Mission001success = 0;
                                                }
                                            }
                                        }
                                       
                                        Console.Clear();

                                        #endregion
                                    }

                                    break;
                                case 4://Back to Ship
                                    #region //BACK TO SHIP
                                    #region Navvi
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
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||  2 - Otov (30)                                                              ||");
                                    Console.WriteLine(@" ||  3 - Gelara (15)                                                            ||");
                                    Console.WriteLine(@" ||  6 - XaenidesStation (5)                                                    ||");
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
                                    Console.WriteLine(@" || Galaxy News Network [Smugglers are being noted in very high quantities in t.||");
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
                                    exit1 = 1;
                                    #endregion
                                    break;
                                case 5:
                                    Console.WriteLine(Zell.InventoryDisplay());
                                    Console.ReadKey();
                                    break;
                            }



                        }
                        break;
                    case 2://Otov
                        Zell.Fuel -= 15;
                        int exit2 = 0;
                        otov.ItemCalculation();
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
                                    Zell.Credits = Zell.Credits - (Zell.Credits * 20);
                                }

                            }
                            if (confront1 == 3)
                            {
                                Zell.Credits -= 500;
                            }
                        }
                        if (battle.shipChoice == 1) //smuggler
                        {
                            if (confront1 == 4)
                            {
                                Zell.Weapons += 1;
                                Zell.Cargo += 15;
                            }

                        }



                        #endregion
                        #endregion
                        Console.ReadKey();
                        while (exit2 == 0)// Exits once user chooses to go back to ship
                        {
                            #region  //Planet welcome dialog


                            Console.Clear();                            
                            Console.WriteLine($"\n\n{otov.OtovDesc()}\n\n"); 
                            Console.WriteLine(@"                .                                            .
                                                     *   .                  .              .        .   *          .
                                                  .         .                     .       .           .      .        .
                                                        o                             .                   .
                                                         .              .                  .           .
                                                          0     .
                                                                 .          .                 ,                ,    ,
                                                 .          \          .                         .
                                                      .      \   ,
                                                   .          o     .                 .                   .            .
                                                     .         \                 ,             .                .
                                                               #\##\#      .                              .        .
                                                             #  #O##\###                .                        .
                                                   .        #*#  #\##\###                       .                     ,
                                                        .   ##*#  #\##\##               .                     .
                                                      .      ##*#  #o##\#         .                             ,       .
                                                          .     *#  #\#     .                    .             .          ,
                                                                      \          .                         .
                                                ____^/\___^--____/\____O______________/\/\---/\___________---______________
                                                   /\^   ^  ^    ^                  ^^ ^  '\ ^          ^       ---
                                                         --           -            --  -      -         ---  __       ^
                                                   --  __                      ___--  ^  ^                         --  __");
                            Console.ReadKey();
                            Console.WriteLine($"\n{menu.ShopDialog()}");
                            #endregion 
                            string tempvalue = Console.ReadLine();
                            double.TryParse(tempvalue, out tryparse);
                            double choice = tryparse;
                            switch (choice)
                            {
                                case 1://Buy
                                    Console.Clear();
                                    Console.WriteLine($"{otov.BuyWelcome()}\n\n");
                                    Console.ReadLine();

                                    #region Items for sale list
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
                                    Console.Write("\n\nWhat would you like to purchase?:"); string tempvalue1 = Console.ReadLine();
                                    double.TryParse(tempvalue1, out tryparse);
                                    double item = tryparse;
                                    Console.WriteLine();
                                    if (otov.QtyTranslation(item) == 0) { Console.WriteLine(menu.OutofStock()); Console.ReadKey();}
                                    else if (otov.QtyTranslation(item) == 99) { break; }                                    
                                        Console.Write("\n\nHow many?:"); string tempvalue2 = Console.ReadLine();
                                    double.TryParse(tempvalue2, out tryparse);
                                    double amount = tryparse;
                                    if (menu.PurchasePrice(otov.ItemTranslation(item), amount) > Zell.Credits) 
                                    { Console.WriteLine(menu.NotEnoughCredits()); Console.ReadLine(); break; }
                                    Console.Clear();                                        
                                        Console.WriteLine($"\n\nSale total is : ${menu.PurchasePrice(otov.ItemTranslation(item), amount):0}  Weight:{menu.TotalCargo(otov.WeightTranslation(item), amount):0}");
                                        #region  //Math to reduce Qty and raise cargo
                                        switch (item)
                                        {
                                        case 1:
                                            Zell.Fuel += amount; otov.Dilithium.Qty -= amount;
                                            break;
                                        case 2:
                                            Zell.Beryllium += amount; otov.Beryllium.Qty -= amount;
                                            Zell.Cargo += menu.TotalCargo(otov.WeightTranslation(item), amount);
                                            break;
                                        case 3:
                                            Zell.Carbon += amount; otov.Carbon.Qty -= amount;
                                            Zell.Cargo += menu.TotalCargo(otov.WeightTranslation(item), amount);
                                            break;
                                        case 4:
                                            Zell.Thorium += amount; otov.Thorium.Qty -= amount;
                                            Zell.Cargo += menu.TotalCargo(otov.WeightTranslation(item), amount);
                                            break;
                                        case 5:
                                            Zell.WaterIce += amount; otov.WaterIce.Qty -= amount;
                                            Zell.Cargo += menu.TotalCargo(otov.WeightTranslation(item), amount);
                                            break;
                                        case 6:
                                            Zell.Lead += amount; otov.Lead.Qty -= amount;
                                            Zell.Cargo += menu.TotalCargo(otov.WeightTranslation(item), amount);
                                            break;
                                        case 7:
                                            Zell.Aether += amount; otov.Aether.Qty -= amount;
                                            Zell.Cargo += menu.TotalCargo(otov.WeightTranslation(item), amount);
                                            break;
                                        case 8:
                                            Zell.Food += amount; otov.Food.Qty -= amount;
                                            Zell.Cargo += menu.TotalCargo(otov.WeightTranslation(item), amount);
                                            break;
                                        case 9:
                                            Console.WriteLine(menu.NoSale());
                                            //Zell.Neutronium += amount; otov.Neutronium.Qty -= amount;
                                            //Zell.Cargo += menu.TotalCargo(otov.WeightTranslation(item), amount);
                                            break;
                                        case 10:
                                            Console.WriteLine(menu.NoSale());
                                            //Zell.Helium3 += amount; otov.Helium3.Qty -= amount;
                                            //Zell.Cargo += menu.TotalCargo(otov.WeightTranslation(item), amount);
                                            break;
                                        case 11:
                                            Console.WriteLine(menu.NoSale());
                                            //Zell.DarkMatter += amount; otov.DarkMatter.Qty -= amount;
                                            //Zell.Cargo += menu.TotalCargo(otov.WeightTranslation(item), amount);
                                            break;
                                    }
                                        Zell.Credits -= menu.PurchasePrice(otov.ItemTranslation(item), amount);
                                        #endregion
                                        Console.WriteLine($"\nCredits remaining: ${Zell.Credits}\n\nTotal Cargo: {Zell.Cargo} / {Zell.TotalCargo}\n\nFuel Level: {Zell.Fuel}");
                                        Console.WriteLine(Zell.InventoryDisplay());
                                        Console.ReadLine();
                                        Console.Clear();
                                    
                                    break;
                                case 2://Sell
                                    Console.WriteLine($"{otov.BuyWelcome()}\n\n");
                                    Console.ReadLine();
                                    Console.WriteLine($"Current Prices:\n\n{otov.DithSellprice()} \n {otov.Beryllprice()} \n {otov.CarbonSellprice()} \n {otov.ThoriumSellprice()} \n " +
                                                      $"{otov.WaterIceSellprice()} \n {otov.LeadSellprice()} \n {otov.AetherSellprice()} \n {otov.FoodSellprice()}");
                                    Console.WriteLine($"\n\nYour Inventory:\n\n {Zell.InventoryDisplay()}");
                                    Console.Write("\n\nWhat would you like to sell?:"); string tempvalue4 = Console.ReadLine();
                                    double.TryParse(tempvalue4, out tryparse);
                                    double item2 = tryparse;
                                    if (otov.QtyTranslation(item2) == 0) { Console.WriteLine(menu.OutofStock()); Console.ReadKey(); break; }
                                    else if (otov.QtyTranslation(item2) == 99) { break; }
                                    Console.Write("\n\nHow many?:"); string tempvalue5 = Console.ReadLine();
                                    double.TryParse(tempvalue5, out tryparse);
                                    double amount2 = tryparse;
                                    Console.Clear();
                                    if (Zell.ItemTranslation(item2)-amount2 <0) { Console.WriteLine(menu.NotEnoughItems()); Console.ReadKey(); break; }
                                    Console.WriteLine($"\n\nSale total is : ${menu.PurchasePrice(otov.ItemTranslation(item2), amount2):0}  Weight:{menu.TotalCargo(otov.WeightTranslation(item2), amount2):0}");
                                    switch (item2)
                                    {
                                        case 2:
                                            Zell.Beryllium += amount2; otov.Beryllium.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(otov.WeightTranslation(item2), amount2);
                                            break;
                                        case 3:
                                            Zell.Carbon += amount2; otov.Carbon.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(otov.WeightTranslation(item2), amount2);
                                            break;
                                        case 4:
                                            Zell.Thorium += amount2; otov.Thorium.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(otov.WeightTranslation(item2), amount2);
                                            break;
                                        case 5:
                                            Zell.WaterIce += amount2; otov.WaterIce.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(otov.WeightTranslation(item2), amount2);
                                            break;
                                        case 6:
                                            Zell.Lead += amount2; otov.Lead.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(otov.WeightTranslation(item2), amount2);
                                            break;
                                        case 7:
                                            Zell.Aether += amount2; otov.Aether.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(otov.WeightTranslation(item2), amount2);
                                            break;
                                        case 8:
                                            Zell.Food += amount2; otov.Food.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(otov.WeightTranslation(item2), amount2);
                                            break;
                                        case 9:
                                            Zell.Neutronium += amount2; otov.Neutronium.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(otov.WeightTranslation(item2), amount2);
                                            break;
                                        case 10:
                                            Zell.Helium3 += amount2; otov.Helium3.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(otov.WeightTranslation(item2), amount2);
                                            break;
                                        case 11:
                                            Zell.DarkMatter += amount2; otov.DarkMatter.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(otov.WeightTranslation(item2), amount2);
                                            break;
                                        case 12:
                                            Zell.TotalCargo += 100;
                                            break;
                                    }
                                    Zell.Credits += menu.PurchasePrice(otov.ItemTranslation(item2), amount2);
                                    Console.WriteLine($"\nCredits remaining: ${Zell.Credits}\n\nTotal Cargo: {Zell.Cargo} / {Zell.TotalCargo}\n\nFuel Level: {Zell.Fuel}");
                                    Console.WriteLine(Zell.InventoryDisplay());
                                    Console.ReadKey();
                                    

                                    break;
                                case 3://Mission Board
                                    break;
                                case 4://Back to Ship
                                    #region MyRegion
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
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||  1 - Natotis        (30)                                                    ||");
                                    Console.WriteLine(@" ||  5 - Aoclite        (25)                                                    ||");
                                    Console.WriteLine(@" ||  6 - XaenidesStation (5)                                                    ||");
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
                                    Console.WriteLine(@" || Galaxy News Network [Vurik presence growing in surrounding galaxies some wo.||");
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
                                    exit2 = 1;
                                    break;
                                case 5:
                                    Console.WriteLine(Zell.InventoryDisplay());
                                    Console.ReadKey();
                                    break;
                            }




                        }
                        break;
                    case 3://Gelara
                        Zell.Fuel -= 10;
                        int exit3 = 0;
                        gelara.ItemCalculation();
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
                                    Zell.Credits = Zell.Credits - (Zell.Credits * 20);
                                }

                            }
                            if (confront2 == 3)
                            {
                                Zell.Credits -= 500;
                            }
                        }
                        if (battle.shipChoice == 1) //smuggler
                        {
                            if (confront2 == 4)
                            {
                                Zell.Weapons += 1;
                                Zell.Cargo += 15;
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
                            Console.WriteLine($"\n\n{gelara.Description()}\n\n");
                            Console.WriteLine(@"                             ;::;
                                                                         ::: =,;
                                                                     ;;=;;=== M
                                                        ,=YVRMBBMMR=,   :i=
                                                      :iVRRMMMMMMBMMM :=;  ==;======
                                                     =tYMMMMMMBBMMM;=Y ,::;==iMMMMMMMMMM
                                                    ;tYVBBMMVMMMM =; .,,,::;;=YVBBMMMMMMMMM
                                                    ;tYVVYRMMM;=ti ...,,,;::==iMVMMMMMMMMMMMM
                                                    ,=tYRBM;;tVB, ....,  ,::;====YVBMMMMMMMMMM
                                                ..   ,=t =tYVRB, .....,,,,=:;:;;i=VYMMRMMMMMMMM
                                               ;;..  ,===iYVVRY .....,,,;,,,,,:;;==t=RBMMMMMMMMM
                                             :;;:;=;,...       .......,,,,,,,,,:;;==Y=tYMMMMMMMM
                                            ;.,:,.....         ....,,,,,,,,,,,,,:;;;==YYMRMMMMMM;
                                            .......             .,,,,,,,,,,,,,,,,::;;;=YtVBMMMMM
                                          ;t ...                .,,,,,,,,,,,,,,,,,::;;i=RiRMMMMM
                                          ,=..                    .,,,,,,,,,,,,,,,:::;;=iYBBMM
                                                                   .,,,,,,,,,,,,,,,,::;;;;tVB
                                                  :VMM               .,,,,,,,,,,,,:,,,::;;=
                                                 ,;VBM                 .,,,,,,,,,,,,,:,::
                                                 ,,==                      `,,,,,,,   ");
                            Console.ReadKey();
                            Console.WriteLine($"\n{menu.ShopDialog()}");
                            #endregion 
                            int choice = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch (choice)
                            {
                                case 1://Buy

                                    Console.WriteLine($"{gelara.BuyWelcome()}\n\n");
                                    Console.ReadLine();
                                    Console.Clear();
                                    #region Item sale Methods
                                    Console.WriteLine($"Credits: {Zell.Credits}\n\n");
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
                                    Console.Write("\n\nWhat would you like to purchase?:"); double item = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                    if (gelara.QtyTranslation(item) == 0) { Console.WriteLine(menu.OutofStock()); Console.ReadKey(); }
                                    else if (gelara.QtyTranslation(item) == 99) { break; }
                                    Console.Write("\n\nHow many?:"); int amount = Convert.ToInt32(Console.ReadLine());
                                    if (menu.PurchasePrice(gelara.ItemTranslation(item), amount) > Zell.Credits)
                                    { Console.WriteLine(menu.NotEnoughCredits()); Console.ReadLine(); break; }
                                    Console.Clear();
                                    Console.WriteLine($"\n\nSale total is : ${menu.PurchasePrice(gelara.ItemTranslation(item), amount):0}  Weight:{menu.TotalCargo(gelara.WeightTranslation(item), amount):0}");
                                    #region  //Math to reduce Qty and raise cargo
                                    switch (item)
                                    {
                                        case 1:
                                            Zell.Fuel += amount; gelara.Dilithium.Qty -= amount;
                                            break;
                                        case 2:
                                            Zell.Beryllium += amount; gelara.Beryllium.Qty -= amount;
                                            Zell.Cargo += menu.TotalCargo(gelara.WeightTranslation(item), amount);
                                            break;
                                        case 3:
                                            Zell.Carbon += amount; gelara.Carbon.Qty -= amount;
                                            Zell.Cargo += menu.TotalCargo(gelara.WeightTranslation(item), amount);
                                            break;
                                        case 4:
                                            Zell.Thorium += amount; gelara.Thorium.Qty -= amount;
                                            Zell.Cargo += menu.TotalCargo(gelara.WeightTranslation(item), amount);
                                            break;
                                        case 5:
                                            Zell.WaterIce += amount; gelara.WaterIce.Qty -= amount;
                                            Zell.Cargo += menu.TotalCargo(gelara.WeightTranslation(item), amount);
                                            break;
                                        case 6:
                                            Zell.Lead += amount; gelara.Lead.Qty -= amount;
                                            Zell.Cargo += menu.TotalCargo(gelara.WeightTranslation(item), amount);
                                            break;
                                        case 7:
                                            Zell.Aether += amount; gelara.Aether.Qty -= amount;
                                            Zell.Cargo += menu.TotalCargo(gelara.WeightTranslation(item), amount);
                                            break;
                                        case 8:
                                            Zell.Food += amount; gelara.Food.Qty -= amount;
                                            Zell.Cargo += menu.TotalCargo(gelara.WeightTranslation(item), amount);
                                            break;
                                        case 12:
                                            Zell.TotalCargo += 100;
                                            break;
                                    }
                                    Zell.Credits -= menu.PurchasePrice(gelara.ItemTranslation(item), amount);
                                    #endregion
                                    Console.WriteLine($"\nCredits remaining: ${Zell.Credits}\n\nTotal Cargo: {Zell.Cargo} / {Zell.TotalCargo}\n\nFuel Level: {Zell.Fuel}");
                                    Console.WriteLine(Zell.InventoryDisplay());
                                    Console.ReadLine();
                                    Console.Clear();

                                    break;
                                case 2://Sell
                                    Console.WriteLine($"{gelara.BuyWelcome()}\n\n");
                                    Console.ReadLine();
                                    Console.WriteLine($"Current Prices:\n\n{gelara.DithSellprice()} \n {gelara.Beryllprice()} \n {gelara.CarbonSellprice()} \n {gelara.ThoriumSellprice()} \n " +
                                                      $"{gelara.WaterIceSellprice()} \n {gelara.LeadSellprice()} \n {gelara.AetherSellprice()} \n {gelara.FoodSellprice()}");
                                    Console.WriteLine($"\n\nYour Inventory:\n\n {Zell.InventoryDisplay()}");
                                    Console.Write("\n\nWhat would you like to sell?:"); double item2 = Convert.ToInt32(Console.ReadLine());
                                    if (gelara.QtyTranslation(item2) == 0) { Console.WriteLine(menu.OutofStock()); Console.ReadKey(); break; }
                                    else if (gelara.QtyTranslation(item2) == 99) { break; }
                                    Console.Write("\n\nHow many?:"); int amount2 = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    if (Zell.ItemTranslation(item2) - amount2 < 0) { Console.WriteLine(menu.NotEnoughItems()); Console.ReadKey(); break; }
                                    Console.WriteLine($"\n\nSale total is : ${menu.PurchasePrice(gelara.ItemTranslation(item2), amount2):0}  Weight:{menu.TotalCargo(gelara.WeightTranslation(item2), amount2):0}");
                                    switch (item2)
                                    {
                                        case 2:
                                            Zell.Beryllium += amount2; gelara.Beryllium.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(gelara.WeightTranslation(item2), amount2);
                                            break;
                                        case 3:
                                            Zell.Carbon += amount2; gelara.Carbon.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(gelara.WeightTranslation(item2), amount2);
                                            break;
                                        case 4:
                                            Zell.Thorium += amount2; gelara.Thorium.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(gelara.WeightTranslation(item2), amount2);
                                            break;
                                        case 5:
                                            Zell.WaterIce += amount2; gelara.WaterIce.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(gelara.WeightTranslation(item2), amount2);
                                            break;
                                        case 6:
                                            Zell.Lead += amount2; gelara.Lead.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(gelara.WeightTranslation(item2), amount2);
                                            break;
                                        case 7:
                                            Zell.Aether += amount2; gelara.Aether.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(gelara.WeightTranslation(item2), amount2);
                                            break;
                                        case 8:
                                            Zell.Food += amount2; gelara.Food.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(gelara.WeightTranslation(item2), amount2);
                                            break;
                                        case 9:
                                            Console.WriteLine(menu.NoSale());
                                            //Zell.Neutronium += amount; otov.Neutronium.Qty -= amount;
                                            //Zell.Cargo += menu.TotalCargo(otov.WeightTranslation(item), amount);
                                            break;
                                        case 10:
                                            Console.WriteLine(menu.NoSale());
                                            //Zell.Helium3 += amount; otov.Helium3.Qty -= amount;
                                            //Zell.Cargo += menu.TotalCargo(otov.WeightTranslation(item), amount);
                                            break;
                                        case 11:
                                            Console.WriteLine(menu.NoSale());
                                            //Zell.DarkMatter += amount; otov.DarkMatter.Qty -= amount;
                                            //Zell.Cargo += menu.TotalCargo(otov.WeightTranslation(item), amount);
                                            break;
                                    }
                                    Zell.Credits += menu.PurchasePrice(gelara.ItemTranslation(item2), amount2);
                                    Console.WriteLine($"\nCredits remaining: ${Zell.Credits}\n\nTotal Cargo: {Zell.Cargo} / {Zell.TotalCargo}\n\nFuel Level: {Zell.Fuel}");
                                    Console.WriteLine(Zell.InventoryDisplay());
                                    Console.ReadKey();
                                    break;
                                case 3://Mission Board
                                    break;
                                case 4://Back to Ship
                                    #region Navvi
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
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||  2 - Natotis (30)                                                              ||");
                                    Console.WriteLine(@" ||  3 - Larvis (15)                                                            ||");
                                    Console.WriteLine(@" ||  6 - XaenidesStation (5)                                                    ||");
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
                                    Console.WriteLine(@" || Galaxy News Network [Federation scouts have located the Laserous Gang Leade.||");
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
                                    exit3 = 1;
                                    break;
                                case 5:
                                    Console.WriteLine(Zell.InventoryDisplay());
                                    Console.ReadKey();
                                    break;
                            }




                        }
                        break;
                    case 4://Larvis
                        Zell.Fuel -= 15;
                        int exit4 = 0;
                        larvis.ItemCalculation();
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
                                    Zell.Credits = Zell.Credits - (Zell.Credits * 20);
                                }

                            }
                            if (confront3 == 3)
                            {
                                Zell.Credits -= 500;
                            }
                        }
                        if (battle.shipChoice == 1) //smuggler
                        {
                            if (confront3 == 4)
                            {
                                Zell.Weapons += 1;
                                Zell.Cargo += 15;
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
                            Console.WriteLine($"\n\n{larvis.Description()}\n\n");
                            Console.WriteLine(@"     x  .--------------.
                                                    .---'  o        .    `---.
                                                 .-'    .    O  .         .   `-.
                                              .-'     @@@@@@       .             `-.
                                            .'@@   @@@@@@@@@@@       @@@@@@@   .    `.
                                          .'@@@  @@@@@@@@@@@@@@     @@@@@@@@@         `.
                                         /@@@  o @@@@@@@@@@@@@@     @@@@@@@@@     O     \
                                        /        @@@@@@@@@@@@@@  @   @@@@@@@@@ @@     .  \
                                       /@  o      @@@@@@@@@@@   .  @@  @@@@@@@@@@@     @@ \
                                      /@@@      .   @@@@@@ o       @  @@@@@@@@@@@@@ o @@@@ \
                                     /@@@@@                  @ .      @@@@@@@@@@@@@@  @@@@@ \
                                     |@@@@@    O    `.-./  .        .  @@@@@@@@@@@@@   @@@  |
                                    / @@@@@        --`-'       o        @@@@@@@@@@@ @@@    . \
                                    |@ @@@@ .  @  @    `    @            @@      . @@@@@@    |
                                    |   @@                         o    @@   .     @@@@@@    |
                                    |  .     @   @ @       o              @@   o   @@@@@@.   |
                                    \     @    @       @       .-.       @@@@       @@@      /
                                     |  @    @  @              `-'     . @@@@     .    .    |
                                     \ .  o       @  @@@@  .              @@  .           . /
                                      \      @@@    @@@@@@       .                   o     /
                                       \    @@@@@   @@\@@    /        O          .        /
                                        \ o  @@@       \ \  /  __        .   .     .--.  /
                                         \      .     . \.-.---                   `--'  /
                                          `.             `-'      .                   .'
                                            `.    o     / | `           O     .     .'
                                              `-.      /  |        o             .-'
                                                 `-.          .         .     .-'
                                                    `---.        .       .---'
                                                         `--------------'");
                            Console.ReadKey();
                            Console.WriteLine($"\n{menu.ShopDialog()}");
                            #endregion 
                            int choice = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch (choice)
                            {
                                case 1://Buy

                                    Console.WriteLine($"{larvis.BuyWelcome()}\n\n");
                                    Console.ReadLine();
                                    #region Item sale list
                                    Console.WriteLine($"Credits: {Zell.Credits}\n\n");
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
                                    Console.Write("\n\nWhat would you like to purchase?:"); double item = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                    if (larvis.QtyTranslation(item) == 0) { Console.WriteLine(menu.OutofStock()); Console.ReadKey(); }
                                    else if (larvis.QtyTranslation(item) == 99) { break; }
                                    Console.Write("\n\nHow many?:"); int amount = Convert.ToInt32(Console.ReadLine());
                                    if (menu.PurchasePrice(larvis.ItemTranslation(item), amount) > Zell.Credits)
                                    { Console.WriteLine(menu.NotEnoughCredits()); Console.ReadLine(); break; }
                                    Console.Clear();
                                    Console.WriteLine($"\n\nSale total is : ${menu.PurchasePrice(larvis.ItemTranslation(item), amount):0}  Weight:{menu.TotalCargo(larvis.WeightTranslation(item), amount):0}");
                                    #region  //Math to reduce Qty and raise cargo
                                    switch (item)
                                    {
                                        case 1:
                                            Zell.Fuel += amount; larvis.Dilithium.Qty -= amount;
                                            break;
                                        case 2:
                                            Zell.Beryllium += amount; larvis.Beryllium.Qty -= amount;
                                            Zell.Cargo += menu.TotalCargo(larvis.WeightTranslation(item), amount);
                                            break;
                                        case 3:
                                            Zell.Carbon += amount; larvis.Carbon.Qty -= amount;
                                            Zell.Cargo += menu.TotalCargo(larvis.WeightTranslation(item), amount);
                                            break;
                                        case 4:
                                            Zell.Thorium += amount; larvis.Thorium.Qty -= amount;
                                            Zell.Cargo += menu.TotalCargo(larvis.WeightTranslation(item), amount);
                                            break;
                                        case 5:
                                            Zell.WaterIce += amount; larvis.WaterIce.Qty -= amount;
                                            Zell.Cargo += menu.TotalCargo(larvis.WeightTranslation(item), amount);
                                            break;
                                        case 6:
                                            Zell.Lead += amount; larvis.Lead.Qty -= amount;
                                            Zell.Cargo += menu.TotalCargo(larvis.WeightTranslation(item), amount);
                                            break;
                                        case 7:
                                            Zell.Aether += amount; larvis.Aether.Qty -= amount;
                                            Zell.Cargo += menu.TotalCargo(larvis.WeightTranslation(item), amount);
                                            break;
                                        case 8:
                                            Zell.Food += amount; larvis.Food.Qty -= amount;
                                            Zell.Cargo += menu.TotalCargo(larvis.WeightTranslation(item), amount);
                                            break;
                                        case 12:
                                            Zell.TotalCargo += 100;
                                            break;
                                    }
                                    Zell.Credits -= menu.PurchasePrice(larvis.ItemTranslation(item), amount);
                                    #endregion
                                    Console.WriteLine($"\nCredits remaining: ${Zell.Credits}\n\nTotal Cargo: {Zell.Cargo} / {Zell.TotalCargo}\n\nFuel Level: {Zell.Fuel}");
                                    Console.WriteLine(Zell.InventoryDisplay());
                                    Console.ReadLine();
                                    Console.Clear();

                                    break;
                                case 2://Sell
                                    Console.WriteLine($"{larvis.BuyWelcome()}\n\n");
                                    Console.ReadLine();
                                    Console.WriteLine($"Current Prices:\n\n{larvis.DithSellprice()} \n {larvis.Beryllprice()} \n {larvis.CarbonSellprice()} \n {larvis.ThoriumSellprice()} \n " +
                                                      $"{larvis.WaterIceSellprice()} \n {larvis.LeadSellprice()} \n {larvis.AetherSellprice()} \n {larvis.FoodSellprice()}");
                                    Console.WriteLine($"\n\nYour Inventory:\n\n {Zell.InventoryDisplay()}");
                                    Console.Write("\n\nWhat would you like to sell?:"); double item2 = Convert.ToInt32(Console.ReadLine());
                                    if (larvis.QtyTranslation(item2) == 0) { Console.WriteLine(menu.OutofStock()); Console.ReadKey(); break; }
                                    else if (larvis.QtyTranslation(item2) == 99) { break; }
                                    Console.Write("\n\nHow many?:"); int amount2 = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    if (Zell.ItemTranslation(item2) - amount2 < 0) { Console.WriteLine(menu.NotEnoughItems()); Console.ReadKey(); break; }
                                    Console.WriteLine($"\n\nSale total is : ${menu.PurchasePrice(larvis.ItemTranslation(item2), amount2):0}  Weight:{menu.TotalCargo(larvis.WeightTranslation(item2), amount2):0}");
                                    switch (item2)
                                    {
                                        case 2:
                                            Zell.Beryllium += amount2; larvis.Beryllium.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(larvis.WeightTranslation(item2), amount2);
                                            break;
                                        case 3:
                                            Zell.Carbon += amount2; larvis.Carbon.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(larvis.WeightTranslation(item2), amount2);
                                            break;
                                        case 4:
                                            Zell.Thorium += amount2; larvis.Thorium.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(larvis.WeightTranslation(item2), amount2);
                                            break;
                                        case 5:
                                            Zell.WaterIce += amount2; larvis.WaterIce.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(larvis.WeightTranslation(item2), amount2);
                                            break;
                                        case 6:
                                            Zell.Lead += amount2; larvis.Lead.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(larvis.WeightTranslation(item2), amount2);
                                            break;
                                        case 7:
                                            Zell.Aether += amount2; larvis.Aether.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(larvis.WeightTranslation(item2), amount2);
                                            break;
                                        case 8:
                                            Zell.Food += amount2; larvis.Food.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(larvis.WeightTranslation(item2), amount2);
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
                                    Zell.Credits += menu.PurchasePrice(larvis.ItemTranslation(item2), amount2);
                                    Console.WriteLine($"\nCredits remaining: ${Zell.Credits}\n\nTotal Cargo: {Zell.Cargo} / {Zell.TotalCargo}\n\nFuel Level: {Zell.Fuel}");
                                    Console.WriteLine(Zell.InventoryDisplay());
                                    Console.ReadKey();


                                    break;
                                case 3://Mission Board
                                    break;
                                case 4://Back to Ship
                                    #region Navvi
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
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||  2 - Otov (15)                                                              ||");
                                    Console.WriteLine(@" ||  3 - Aoclite (25)                                                           ||");
                                    Console.WriteLine(@" ||  6 - XaenidesStation (5)                                                    ||");
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
                                    Console.WriteLine(@" || Galaxy News Network [Local elections have erupted into planet wide riots as.||");
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
                                        if (menu.planetChoice == 2 || menu.planetChoice == 3 || menu.planetChoice == 6 ||
                                            menu.planetChoice == 99)
                                        {
                                            exitt = 1;
                                        }
                                        else if (menu.planetChoice != 2 || menu.planetChoice != 3 || menu.planetChoice != 6 ||
                                                 menu.planetChoice != 99)
                                        {
                                            menu.planetChoice = 4;
                                            Console.WriteLine(menu.IncorrectSelection());
                                            exitt = 0;
                                        }
                                    }
                                    exit4 = 1;
                                    break;
                                case 5:
                                    Console.WriteLine(Zell.InventoryDisplay());
                                    Console.ReadKey();
                                    break;
                            }




                        }
                        break;
                    case 5://Aoclite
                        Zell.Fuel -= 25;
                        int exit5 = 0;
                        aoclite.ItemCalculation();
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
                                    Zell.Credits = Zell.Credits - (Zell.Credits * 20);
                                }

                            }
                            if (confront4 == 3)
                            {
                                Zell.Credits -= 500;
                            }
                        }
                        if (battle.shipChoice == 1) //smuggler
                        {
                            if (confront4 == 4)
                            {
                                Zell.Weapons += 1;
                                Zell.Cargo += 15;
                            }

                        }



                        #endregion
                        #endregion
                        Console.ReadKey();
                        Console.Clear();
                        while (exit5 == 0)// Exits once user chooses to go back to ship
                        {
                            #region  //Planet welcome dialog


                            Console.Clear();
                            Console.WriteLine($"\n\n{aoclite.Description()}\n\n");
                            Console.WriteLine(@"");
                            Console.ReadKey();
                            Console.WriteLine($"\n{menu.ShopDialog()}");
                            #endregion 
                            int choice = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch (choice)
                            {
                                case 1://Buy

                                    Console.WriteLine($"{aoclite.BuyWelcome()}\n\n");
                                    Console.ReadLine();

                                    #region Item sale list
                                    Console.WriteLine($"Credits: {Zell.Credits}\n\n");
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
                                    Console.WriteLine();
                                    if (aoclite.QtyTranslation(item) == 0) { Console.WriteLine(menu.OutofStock()); Console.ReadKey(); }
                                    else if (aoclite.QtyTranslation(item) == 99) { break; }
                                    Console.Write("\n\nHow many?:"); int amount = Convert.ToInt32(Console.ReadLine());
                                    if (menu.PurchasePrice(aoclite.ItemTranslation(item), amount) > Zell.Credits)
                                    { Console.WriteLine(menu.NotEnoughCredits()); Console.ReadLine(); break; }
                                    Console.Clear();
                                    Console.WriteLine($"\n\nSale total is : ${menu.PurchasePrice(aoclite.ItemTranslation(item), amount):0}  Weight:{menu.TotalCargo(aoclite.WeightTranslation(item), amount):0}");
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

                                    break;
                                case 2://Sell
                                    Console.WriteLine($"{aoclite.BuyWelcome()}\n\n");
                                    Console.ReadLine();
                                    Console.WriteLine($"Current Prices:\n\n{aoclite.DithSellprice()} \n {aoclite.Beryllprice()} \n {aoclite.CarbonSellprice()} \n {aoclite.ThoriumSellprice()} \n " +
                                                      $"{aoclite.WaterIceSellprice()} \n {aoclite.LeadSellprice()} \n {aoclite.AetherSellprice()} \n {aoclite.FoodSellprice()} \n {aoclite.NeutroniumSellprice()} \n {aoclite.Helium3Sellprice()} \n " +
                                                      $"{aoclite.DarkMatterSellprice()}");
                                    Console.WriteLine($"\n\nYour Inventory:\n\n {Zell.InventoryDisplay()}");
                                    Console.Write("\n\nWhat would you like to sell?:"); double item2 = Convert.ToInt32(Console.ReadLine());
                                    if (aoclite.QtyTranslation(item2) == 0) { Console.WriteLine(menu.OutofStock()); Console.ReadKey(); break; }
                                    else if (aoclite.QtyTranslation(item2) == 99) { break; }
                                    Console.Write("\n\nHow many?:"); int amount2 = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    if (Zell.ItemTranslation(item2) - amount2 < 0) { Console.WriteLine(menu.NotEnoughItems()); Console.ReadKey(); break; }
                                    Console.WriteLine($"\n\nSale total is : ${menu.PurchasePrice(aoclite.ItemTranslation(item2), amount2):0}  Weight:{menu.TotalCargo(aoclite.WeightTranslation(item2), amount2):0}");
                                    switch (item2)
                                    {
                                        case 2:
                                            Zell.Beryllium += amount2; aoclite.Beryllium.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(aoclite.WeightTranslation(item2), amount2);
                                            break;
                                        case 3:
                                            Zell.Carbon += amount2; aoclite.Carbon.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(aoclite.WeightTranslation(item2), amount2);
                                            break;
                                        case 4:
                                            Zell.Thorium += amount2; aoclite.Thorium.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(aoclite.WeightTranslation(item2), amount2);
                                            break;
                                        case 5:
                                            Zell.WaterIce += amount2; aoclite.WaterIce.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(aoclite.WeightTranslation(item2), amount2);
                                            break;
                                        case 6:
                                            Zell.Lead += amount2; aoclite.Lead.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(aoclite.WeightTranslation(item2), amount2);
                                            break;
                                        case 7:
                                            Zell.Aether += amount2; aoclite.Aether.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(aoclite.WeightTranslation(item2), amount2);
                                            break;
                                        case 8:
                                            Zell.Food += amount2; aoclite.Food.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(aoclite.WeightTranslation(item2), amount2);
                                            break;
                                        case 9:
                                            Zell.Neutronium += amount2; aoclite.Neutronium.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(aoclite.WeightTranslation(item2), amount2);
                                            break;
                                        case 10:
                                            Zell.Helium3 += amount2; aoclite.Helium3.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(aoclite.WeightTranslation(item2), amount2);
                                            break;
                                        case 11:
                                            Zell.DarkMatter += amount2; aoclite.DarkMatter.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(aoclite.WeightTranslation(item2), amount2);
                                            break;
                                    }
                                    Zell.Credits += menu.PurchasePrice(aoclite.ItemTranslation(item2), amount2);
                                    Console.WriteLine($"\nCredits remaining: ${Zell.Credits}\n\nTotal Cargo: {Zell.Cargo} / {Zell.TotalCargo}\n\nFuel Level: {Zell.Fuel}");
                                    Console.WriteLine(Zell.InventoryDisplay());
                                    Console.ReadKey();


                                    break;
                                case 3://Mission Board
                                    break;
                                case 4://Back to Ship
                                    #region Navvi
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
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||  2 - Otov (30)                                                              ||");
                                    Console.WriteLine(@" ||  4 - Larvis (15)                                                            ||");
                                    Console.WriteLine(@" ||  6 - XaenidesStation (5)                                                    ||");
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
                                    Console.WriteLine(@" || Galaxy News Network [New merchant tax coming in 2458.. is your business rea.||");
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
                                    exit5 = 1;
                                    break;
                                case 5:
                                    Console.WriteLine(Zell.InventoryDisplay());
                                    Console.ReadKey();
                                    break;
                            }




                        }
                        break;
                    case 6://XaenidesStation
                        Zell.Fuel -= 05;
                        if (Zell.Credits <300){Console.WriteLine(xaenidesStation.NotEnoughCredits());
                            Console.ReadKey();
                            break;
                        }
                        Zell.Credits -= 300;
                        int exit6 = 0;
                        xaenidesStation.ItemCalculation();
                        #region //Ship interaction
                        Console.WriteLine(battle.ShipEmerges(battle.Battlechance(battlechance.Next(0, 100))));
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine($"\n" + battle.ShipEngages(battle.shipChoice));
                        Console.WriteLine(battle.PlayerConfronts(battle.shipChoice));
                        int confront5 = Int32.Parse(Console.ReadLine());
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
                                    Zell.Credits = Zell.Credits - (Zell.Credits * 20);
                                }

                            }
                            if (confront5 == 3)
                            {
                                Zell.Credits -= 500;
                            }
                        }
                        if (battle.shipChoice == 1) //smuggler
                        {
                            if (confront5 == 4)
                            {
                                Zell.Weapons += 1;
                                Zell.Cargo += 15;
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
                            Console.WriteLine($"\n\n{xaenidesStation.Description()}\n\n {xaenidesStation.Tax()}");
                            Console.WriteLine(@" ");
                            Console.ReadKey();
                            Console.WriteLine($"\n{menu.ShopDialog()}");
                            #endregion 
                            int choice = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch (choice)
                            {
                                case 1://Buy

                                    Console.WriteLine($"{xaenidesStation.BuyWelcome()}\n\n");
                                    Console.ReadLine();

                                    #region Item for sale list
                                    Console.WriteLine($"Credits: {Zell.Credits}\n\n");
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
                                    Console.WriteLine();
                                    if (xaenidesStation.QtyTranslation(item) == 0) { Console.WriteLine(menu.OutofStock()); Console.ReadKey(); }
                                    else if (xaenidesStation.QtyTranslation(item) == 99) { break; }
                                    Console.Write("\n\nHow many?:"); int amount = Convert.ToInt32(Console.ReadLine());
                                    if (menu.PurchasePrice(xaenidesStation.ItemTranslation(item), amount) > Zell.Credits)
                                    { Console.WriteLine(menu.NotEnoughCredits()); Console.ReadLine(); break; }
                                    Console.Clear();
                                    Console.WriteLine($"\n\nSale total is : ${menu.PurchasePrice(xaenidesStation.ItemTranslation(item), amount):0}  Weight:{menu.TotalCargo(xaenidesStation.WeightTranslation(item), amount):0}");
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

                                    break;
                                case 2://Sell
                                    Console.WriteLine($"{xaenidesStation.BuyWelcome()}\n\n");
                                    Console.ReadLine();
                                    Console.WriteLine($"Current Prices:\n\n{xaenidesStation.DithSellprice()} \n {xaenidesStation.Beryllprice()} \n {xaenidesStation.CarbonSellprice()} \n {xaenidesStation.ThoriumSellprice()} \n " +
                                                      $"{xaenidesStation.WaterIceSellprice()} \n {xaenidesStation.LeadSellprice()} \n {xaenidesStation.AetherSellprice()} \n {xaenidesStation.FoodSellprice()} \n {xaenidesStation.NeutroniumSellprice()} \n {xaenidesStation.Helium3Sellprice()} \n " +
                                                      $"{xaenidesStation.DarkMatterSellprice()}");
                                    Console.WriteLine($"\n\nYour Inventory:\n\n {Zell.InventoryDisplay()}");
                                    Console.Write("\n\nWhat would you like to sell?:"); double item2 = Convert.ToInt32(Console.ReadLine());
                                    if (xaenidesStation.QtyTranslation(item2) == 0) { Console.WriteLine(menu.OutofStock()); Console.ReadKey(); break; }
                                    else if (xaenidesStation.QtyTranslation(item2) == 99) { break; }
                                    Console.Write("\n\nHow many?:"); int amount2 = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    if (Zell.ItemTranslation(item2) - amount2 < 0) { Console.WriteLine(menu.NotEnoughItems()); Console.ReadKey(); break; }
                                    Console.WriteLine($"\n\nSale total is : ${menu.PurchasePrice(xaenidesStation.ItemTranslation(item2), amount2):0}  Weight:{menu.TotalCargo(xaenidesStation.WeightTranslation(item2), amount2):0}");
                                    switch (item2)
                                    {
                                        case 2:
                                            Zell.Beryllium += amount2; xaenidesStation.Beryllium.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(xaenidesStation.WeightTranslation(item2), amount2);
                                            break;
                                        case 3:
                                            Zell.Carbon += amount2; xaenidesStation.Carbon.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(xaenidesStation.WeightTranslation(item2), amount2);
                                            break;
                                        case 4:
                                            Zell.Thorium += amount2; xaenidesStation.Thorium.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(xaenidesStation.WeightTranslation(item2), amount2);
                                            break;
                                        case 5:
                                            Zell.WaterIce += amount2; xaenidesStation.WaterIce.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(xaenidesStation.WeightTranslation(item2), amount2);
                                            break;
                                        case 6:
                                            Zell.Lead += amount2; xaenidesStation.Lead.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(xaenidesStation.WeightTranslation(item2), amount2);
                                            break;
                                        case 7:
                                            Zell.Aether += amount2; xaenidesStation.Aether.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(xaenidesStation.WeightTranslation(item2), amount2);
                                            break;
                                        case 8:
                                            Zell.Food += amount2; xaenidesStation.Food.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(xaenidesStation.WeightTranslation(item2), amount2);
                                            break;
                                        case 9:
                                            Zell.Neutronium += amount2; xaenidesStation.Neutronium.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(xaenidesStation.WeightTranslation(item2), amount2);
                                            break;
                                        case 10:
                                            Zell.Helium3 += amount2; xaenidesStation.Helium3.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(xaenidesStation.WeightTranslation(item2), amount2);
                                            break;
                                        case 11:
                                            Zell.DarkMatter += amount2; xaenidesStation.DarkMatter.Qty -= amount2;
                                            Zell.Cargo -= menu.TotalCargo(xaenidesStation.WeightTranslation(item2), amount2);
                                            break;
                                    }
                                    Zell.Credits += menu.PurchasePrice(xaenidesStation.ItemTranslation(item2), amount2);
                                    Console.WriteLine($"\nCredits remaining: ${Zell.Credits}\n\nTotal Cargo: {Zell.Cargo} / {Zell.TotalCargo}\n\nFuel Level: {Zell.Fuel}");
                                    Console.WriteLine(Zell.InventoryDisplay());
                                    Console.ReadKey();
                                    break;
                                case 3://Mission Board
                                    break;
                                case 4://Back to Ship
                                    #region MyRegion
                                    #region Navvi
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
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||  1 - Natotis (25)                                                           ||");
                                    Console.WriteLine(@" ||  2 - Otov (30)                                                              ||");
                                    Console.WriteLine(@" ||  3 - Gelara (15)                                                            ||");
                                    Console.WriteLine(@" ||  4 - Larvis (15)                                                            ||");
                                    Console.WriteLine(@" ||  5 - Aoclite (25)                                                           ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||                                                                             ||");
                                    Console.WriteLine(@" ||=============================================================================||");
                                    Console.WriteLine(@" || Galaxy News Network [Volcanoes in space?? Experts think this can be possibl.||");
                                    Console.WriteLine(@" ||=============================================================================||");
                                    #endregion


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
                                        exitt = 1;
                                    }
                                    exit6 = 1;
                                    break;
                                case 5:
                                    Console.WriteLine(Zell.InventoryDisplay());
                                    Console.ReadKey();
                                    break;
                            }




                        }
                        break;
                    case 7:
                        Console.WriteLine(Zell.InventoryDisplay());

                        #region 
                        if (ingametime.month == 3 && ingametime.day <= 31 && ingametime.year == 2457 &&
                            natotisMissions.Mission001success == 2)
                        {
                            Console.WriteLine($"\n\n   #1 -  {natotisMissions.Escort001InProgress()}");
                        }
                        #endregion
                        Console.ReadKey();
                        break;
                    case 99:
                        Console.WriteLine(menu.PlayerQuit());
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;


                }

                




            }




            


            

        }

        

    }
}
