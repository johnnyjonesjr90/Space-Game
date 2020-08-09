
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Xml.Serialization;
using System.IO;
using System.Threading.Channels;


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
                               "after years of travel he decides to close up his business.. He gives you his ship and moves to the \n\n" +
                               "Xaenides System. You have some money saved from your years of work and you start your business. After\n" +
                               "paying for your merchants license you have some money left. You can sell your ship and put some money\n" +
                               "towards a new one or you can start out with your ship.... \n\nPress Enter...";
            return selection;
        }

        public string ShipSelection()
        {
            string Shipselect =
                "\n\nIf you sell your ship you will have 20000 credits and can buy a few different models.\n\n" +
                "1 - Xaenides Cruiser $18000   Cargo- 50    Fuel - 300   Hull - 200   Speed - 500  Attack - 400\n\n" +
                "2 - Natotis Hauler   $15000   Cargo- 350   Fuel - 50    Hull - 300   Speed - 100  Attack - 200 \n\n" +
                "3 - Your Ship        $0       Cargo- 100   Fuel - 100   Hull - 200   Speed - 300  Attack - 300\n\n\n\n" +
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
        public string XaenidesArt()
        {
            string hub = @"                                        
                                                                                                                                                                                                   
                                                                                                      ---                                                                                               
                                                                                                      -c:-                                                                                              
                                                                                                     -::-                                            -       -`,-                                       
                                                                                                   `:c,        --                                              -`,,-                                    
                                                                                   `:::clll,      `oxc-                                                           -,:,-                                 
                                                                                 ,xXNNXKx:--     -cdo`                                                              -,:,-                               
                                                                               -oKNKOl:`-        ,oc`-                                                                 `::-                             
                                                                              :OX0x:-           -co,                                                                     `:,-                           
                                                                            -dKOxc-            -:dd`                                                                       ,:`                          
                                                                           :O0xl,-              `oo-                                                                        -::-                        
                                                                          :OOdc-               -:dc-                                                                          -:,                       
                                                                        -lOxo:-                `lxl                                                                            -::-                     
                                                                       -oOdl:-                 -cxc                                                                              ,:-                    
                                                                      -okoc:-                  `lxo-                                                                              `c-                   
                                                                     -o0d:,-                  -:okk:                                                                               -:`                  
                                                                    -lxdl,-                   -cdkOxo,                                                                              -:-                 
                                                                   -lklc:-                    -codkxkxc-                                                                             -:-                
                                                                   :xl,:`                     -ldxkdodkd:-                                                                            :c                
                                                                  ,do,``-                     -lxxkdolodkxc,````-``,,``----``:c,-`---:,-----------                                    -o:               
                                                                 `okc`--                     --:odxdooooxkkO00xc:coxl:::`----odcc:::cxl``,---:`-``---`:::,-----                        :d-              
                                                                -lkd:--  ---,::clol:-----````,:lxkxxxxxoddk0ko:---:dkd,---- --------lx,-------`--`-   -::,,:,``--------                -dc              
                                                               -,odc,`:ldxO00K0Od:,::`-``,-----:cloddddo::oxl::::``l0Kxccc::::````-,O0:-                  --`------`,,`````--           cd-             
                                                               -:oc:-,xKK0Oxoc,--   `:`-----`:::ldxO0OOkxllxdccoxc`ckxccoo:------``:coxddoc:`-                -  ---`--``-,clc::,-      `x:             
                                                        -:ld:--`cl:,-`ldc,-          -c,-:cok00KXNX0Okl,``:,-`lodo::odooxKOxdl:,-------`:coO0kdc-                     --`-  -`,,:,-      oo             
                                                    -:lx0KXk`--,c:,--                 ,doxOXNNNK00Oxdl`---   ----,,,:x00kKNXXNNKkl:`cdc:,--:k0KK0l-                          -``-        cx-            
                                                  -:xKXXXKk, --`cl,-                 -,:`-,llc,`,:cc:`          --`,ccoxkKXNNNNOO0xxk0xl:``cxk0KK0occ:::,,,,,`````----------`,,,-        ,kl-           
                                               -lxddk00d:`-  `-`cc`                    ------   ,clc:--------------,c::dxk0KXNk:c:--`::::ok0KKXXX0odOOOOOOOOOOkkkkkxo:clcc:::`--         -kNOl`         
                                             -:OXK0xdx:    -----cl`                    -`::colc:okxdl::cclo:-`,,,::c::::cdOOOx,-``,:lok0XXXNNNWKo`-,,::cc:clloxdlcc:-                    -xKkdc-        
                                            `dOk0Oc`--     -   -co:-                   -    -,clloddddddk0xc::cccccllc::dOOdl:--lkkOOO00KXXX0xc-     -`----- ---  ---  --                -xXOo,-        
                                           -o00Oc:,        -   -:d:-                         --   ---`,:::::cllccccl::,,:`--    --,::colcc:`-                      -----  ------  -     -`kNK0Ol-       
                                           -:cdo`--       --    :dl`             -`:,-      --    -   -----``-`,,,,`-------- --   ----                                      ----``--   -:dXNXXNN0c-     
                                     -     --:xOd-       --     `dd:-       --:ldxkkdl::::ldd,  -         -------,`--:cc,:-                                                      -  --`ckXWWWMMWNd-     
                                            `lk0O:            - -lkd, --`,:cloxxxdollldxOKOl`-     --:`      --`:,`,lxk0xdc-                                                   -,::``cxKNNNNWWWN0:      
                                             -,ldc-    --  -  -  ,xOdc:cllccloolodlclkKXKl-       -:cdc        -::clodOKKXXc                                                  -oOOxxolxKXXKKXNN0:       
                                      --       -`:,-   ---       -:kOdc::`---`,,::,lOX0o`         -oxOd-         --`,:lxkxc-                                                --:okO0KOl--:oOXWXd`        
                                        --         ---------   -  -:k0x:-       ---:c:-            ckkk:           --- --                                              --,:cdk0XNX0O00o-  -`:,          
                                                 -:l`  ----    -- -,ckKx:      ----                `ldOo-          ---                                          ---`,:codxxOKXXK0KKKKXNk`               
                                                  `,-          --`::`:xKKo-,:`::-                   -:Ok:             -                        ---``---  --`,:::llcldddxO0KKKXXK0KXKkxo:-               
                                                               ,l:::`-`cO0xxkdxc-                    -d0d-                                 - -,oolllccccllllc::lddl:okkOKK0KKK0kxdc,--                  
                                                              -:l,-     ---`,::::,,:::::,,``wwww`,::::cxkcw         wwwwwwwwwwww`,,::::::::::::clc`w  w`codoc:,,:odxkOOOOkdoc,`w                        
                                                                                  wwwwww`,,,:,::,,:::::::c:::,,,,,,,,,,,,,,:,,,,`,::,,`ww::``w `ld:     w,coddllooooll::`w                              
                                                                              ww,:w:,www,w,w,wwww,,,,,ww:,w,,,,,,:w,ww,:, wwwwww   w,```w`cc:,`w:ldlw      w:cl::,www                                    
                                                                               w   :wwww w w w w ww www ww w w w w www:wwwwww,www  www`,,`,::::::::c:w     wwwww                                          
                                                                                    wwwwww        w          wwwwwwwwww,,,``wwww`,,,:::::::,,,`wwww                                                     
                                                                                                  ww  wwwwwwwwww``wwwwwwwwwwwwwwwww                                                            - 
                                                                                                               -                                                             
                                                                           
   

";
            return hub;
        }
        public string OtovArt()
        {
            string otov = @"             
                                                               ----`````,`:xXXkc:dkO00Oxdlc::,``--       
                                                           ------``,,,,,:lxKNKxclxdloooooollolllc:,`--- -
                                                        --------`,:::::::o0NXOxk00xoodddddddddddooolllc
                                                     ------`::::,,,,,:::cldO0Okkxdddxxddddxxxkkkkxxddddolc:,`      
                                                   --------`cddc,`-`:looooxxdxodxxxkxxxxxxkkOOOOOOkkkkkxxdolc:`-  
                                                 -``----```:dO0kxdocoxxxxddxOkxxkkkOOOOkkkOOOOOOOOOkOOOkxxxddxd:,          
                                               -,,``--`--:okKXK0kxoloxxxxxdxkkdxkkOO0OOOOOOOO0OOOOOOOOOOOkkkxdOOd:`      
                                             --,::`---`-`d0OxxOxolclcoddkOxdodxxkkkOOOOO0000000OO0000000000OkkOKKOl,              -,:~}`:-
                                            --,,`,`--``--,::-,coddkdoxxdkOkxdkkkkOkO0000000OO000000000000OOOOkkk0NKo:,           ::&&#{}8:- 
                                           --`:,`---------`-`::ldkN0odOkOOkkkOkxk0OO000OOOOO000000000KK00OOkxxxk0K0ko            {0:~&&*%::
                                         ----,,`,,:,--- -:ol:c::lkXXkxOkkkkkkkkkOOOO00OOkkkOOO0000000KKOOOOkkxxkkkO0Oo            ~:XpPP)}`
                                        ----`::::::,-----,oc:ll:cxKXkccddxkkkOkkOOOO0OOkkkkOOO00000000OOOkkkkkxxkkk0Kkd:``          ~--`~
                                        ----`::,`-``------:ccodc:dOxllccdxxxkOOxxO0OO00OkkO00000000000OkkkkkkxxxxkxkOOOx
                                       -- ---:,----`------::lddl:oxxdxOOOkxOOkxxdxO0OKXK0OOOO000000000OkkkkkxkOOOKKkk0K0x
                                      --  -------  -------`,:clcooldOO0XNXKXNXKKK0O0K00K0kOOOOOO000000OOOkkOO0XNNWWXO0XK0o
                                      --  - -- ---   -- ----`:c:cddx0K0k0NNWWWWWWWXK00kxxk00OOOOO0OOO00OO0OOXWWWWWWWXXNWNOc
                                     --   -    -------------,ll:cxOXNK0kdx0NXK0KXXNNNXOkk0XK0OO0OOOOkkO0KXKkKWNK00NWWWWWWKo
                                     --      ---------------`cc:lxkOXKOxdooxkdooodOXWN0kkKXOOOkkOkkO0OO0KXX0KKK0kxONWWWNNXd::,
                                    ---   ---`,--------------:c:::lk00OxlllcloooddxO0kxxxkxxkkkxkOOkkOK0OKXWXKOddkKNWWWXXNkc
                                    ---    ---,,-------------`,``-:dlllc::ccloooodxxkkxxxkxxkkkkkkkkOOOOKKK0Oxdx0XNNWWNNNNOl                             
                                    -`-    ----`-- ---------------`,:c::::::clodxddddxxdxxxkkkxxxxxkxxOX0xdxOXKKWWWWWWNNNX0oc         
                                    -`-       ---- ------------------`,::cc::clodddoooodxkkkxkkxdxdddxkkdddkKXWWWWWWWWNNXX0d:,,
                                     --       ----  ------------------`,,,:,,,:::clooddxxxxxdddkkxdddddoxdxO0XNWWWWNWNKKKKx
                                     --       ---   -------------------```,`,,`,::ldodxdoloooooddooddddolloOK0OOkkOOkddOKOc`-`
                                     ---       ---     -  ---------------------,ldodddxxddlllolodolloodlc::colc:::::::d0Kx #
                                      --        ---      ----------------``,`- -cdodoolooolc::::llc::lo:::::::::,,::clxOkc`   ,,
                                      ---        ----   ---------------------- -,ldxdoolc:,``,`,::,,`:c:::::::,``,:::clol`   (&%:
                                       --          ---    ---------------``-----,:cloddo:- -----`--``:c:::::::,`:cc::::c #    ~`
                                       ---                ----------------,,----`,,::cod:-------`----,,,,,,,``-,::`-`:c #
                                        ---                -------  ----------------,,,cc:,-------------------`,,`--:l:` 
                                        ----                     --  ---------------:,``,cc`- ---------------------`::`# 
                                         ------                          -- --------:ll:-``--  ---------``--------``::`` 
                                           ----                          ------------`:,-   -----------`,`----:ll::```` 
                                              -----       ,-~~--,         ------------ -,--------  -----`::--`,:c::,` 
                                               -----   ,,:codxdlc:,-      -,,`,---,:`- ---    --   ----`-----,,`,,,`` 
                                                ------,::clolcccc::,-     ----- ---             -`,---------`,,,,`` 
                                                  ---::::ccc::::::::-    ----                -`::`----  --,::`` 
                                                     ::,,!#:c:Nn,::::`     -                ------- -  --,:::, 
                                                     :::,,::ccWw-,:`:                          ------ --,`` 
                           
";
            return otov;
        }

        public string GelaraArt()
        {
            string aoclite = @"                  
                                                                                                                 ########*****(((##                              
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
                                                                                                                      ************##   
                                                                                                                                                  

";
            return aoclite;
        }

        public string LarvisArt()
        {
            string larvis = @"                                                                                                                             
                                                                                                         #@@@#&@@@@@@@@%@@@@@@%%@@@@                          
                                                                                                   .&(%@&&@%@@@@#@@@@@@%@@@@@@@%#@@@@@@@@*                    
                                                                                               .%%&&%@&#@@@@@@@#@@%/&@%%@@@@@@@@@@@%@@@@@@@@@.                
                                                                                             (%/&%@&@@@(@@@&#@@@@@@&%(#(@@@@@@@@@@@@@@#@@@@@@@@@/             
                                                                                          (##%&%&&@@@@@&@@&@@@@@@@@%@@@(*@@&(#@@@@@@&#%(&@@@@%((@@@           
                                                                                        //%(&%&@&@@@@@@##@@##@@@#@@@@@@@@/@@#%@&&@@@@@@@@@%@@@%(@@@&@.        
                                                                                        **(#%%%&@@@@@@@%@@@@@@@@@&@@@@@@@@@/&&@@@@#@@@@@@@@@@@/*/#%@@@@&@       
                                                                                     ,((#%#&&@@@@@@@@#@@@@@@@@#@@@@###((/*,&@@@@@@%@@@@@@@@@@@@((*&@@@@@@&     
                                                                                    //(%&%&%@@@@@@@(@#@@@@@@&%@@@@@@@@@@@@@/#@@@@@%&@@@@@@@@&(*@*@/&&@@@@&@    
                                                                                   **%(%#%&@@@@@@#@@@@%@#&@@@@@@@@@@@@@@@@//(@@@@@@(#/&@@@@@@@@@@*%,*/%#/%@@   
                                                                                  **((#%(%@&@@@%@@@@@@@&@@@@@@@@@@@@@@@@@@@/**(##@@&/@@@@@@@@@@@@(/#.%.(@@@@@  
                                                                                 ,/((%#%&&&&&@(@@@@&&@@@&@@@@@@@@@@@@@@@@@@#((@@@@@@@*@@@@@@@@*&@@@@@#@(@@@@@# 
                                                                                 */###%%&&@@@%@@@@@@@@@@@@@@@@@@@@@@@@@@&(@@*&@*#/&@##,(@@@@@((@@@@@@@/@@@@@@& 
                                                                                .*(*(#%&%@&@&#@@@@@@@@@&@@@@@@&@@@@(&@@@@@@@%./@@@@@@@@@@//,&@@&@@@@@@@#@@@@@%*
                                                                                ,/*(#%#&&&&@@@@@@@@@@@@&@@#/%%@@@@@@@@@@@@@@@@#,@@@@@@&@@,@@@@@@@@@@@@@(@@@@@#&
                                                                                ,*/(###%&&&&@@@@@@@#(%&%@@@@@@@@@@*@@@@@@@@@@@@&.%@@@@&/@&.*@@@@@@@@@@@&(@@@(%%
                                                                                */*/##%%&&&@&@@@/#@@@@@&#@@@@@@@@&@@(@@@@@@@@@@@@,*@@&*@@@@@#*&@@@@@@@@&,/%@(#&
                                                                                 ,*/###&%&&&@@%@@@&@@@@@@@@@&@@@@@@@@@@&@@@@@@@@@@(*.&@@@@@@@@@/&@@@@@*@@@@@(#,
                                                                                 ,*///###&%&&(@&@@@@(@@@@@@/@@@@@%@@@@@@#@@@@@@@@@%*&@@@@@@@@@@@@/&*&@&(@@@@%% 
                                                                                  **/((###%%&&@@@@@@@%#@@@@@@@##(&@@@@@@#@(&@@@@@/@@@@@&@@@@@@@%/@/@@@@@@/@#@, 
                                                                                  ,,/*#####%&&@@@@@@@@@&(%@@@@@@@@(@@@@@@@@@@@@@&.@@@@@@@@@@@&/@@@#@@@@@@@#@(  
                                                                                   .,,/#(#%%%@&&@@@@@@#@@&@@@@@@@@@@(@@@@@@@@@@@/*@@@@@@@&*(#@@@@@%%@@@@@@(%   
                                                                                    .(*/(((%&%#@&@&@&%@@@@@#@@@@@@@@@@(@@@@@@@@&.@,*/#@@@@@#@@@@@@&%@@@(/&/    
                                                                                       ,///###%%%%#@&@@@@@@@@@@#@@@@@@@@@@(@@&(/%@@@@@@@@@%/@@@@@@@@&,%@@&      
                                                                                       ./,,(#%#&%%&@&@@@@@@@@@@@@&@@@@@@@*@@@&&/@@@@@@@@@*@@&**%@@@@(#&(       
                                                                                         ,,**(%##%%(&@@@&@@@@@@@@@%(@@@(@@@@@@@@@@@@&/@@(@@@@@@@@@%&%#         
                                                                                             ///&(%#%%%&&&@&/@@@@@@@&@@@&@@@@@@@@@@@@@@@@(@@@@@@@%&/*           
                                                                                               ,(/#(%#%%&%@&&&@@(@@@@@@@@@@#@@@@@@@@@@@%*@@@@@%(@%              
                                                                                                   ((#/##%&%&&@&@@&#&@@@@%#@@@#@@&@@@@@&@*&@&&,                 
                                                                                                       //*((#(%#%#&&&@%&&%&&@@#@@@@%/@&@@@                      
                                                                                                            /**/%#%&&&#%(/%@@%(#%@#                            
                                                                                                                                                             
";
            return larvis;
        }

        public string NatotisArt()
        {
            string natotis = @"                      
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
                                                    `+=+++;
";
            return natotis;
        }

        
    }
}
