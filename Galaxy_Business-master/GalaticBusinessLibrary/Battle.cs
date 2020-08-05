using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using GalaticBusinessLibrary;

namespace SpaceMerchantLibrary
{
    public class Battle
    {
        
        public int shipChoice { get; set; } //assigned in ShipEmerges method

        public int Battlechance(int chance)
        {
            
            if (chance >= 85)
            {
                chance = 4;
                return chance;
            }
            if (chance >= 75 && chance <= 84)
            {
                chance = 3;
                return chance;
            }
            if (chance >= 51 && chance <= 74)
            {
                chance = 2;
                return chance;
            }
            if (chance >= 20 && chance <= 50)
            {
                chance = 1;
                return chance;
            }
            else
            {
                chance = 0;
                return chance;
            }
        }

        public string ShipEmerges(int ship)
        {
            string ShipEmerge = "\n\n\nSlip space can be super boring. Youre glad to be back in real space.";
            if (ship == 4)//Fereration Flagship
            {
                ShipEmerge =
                    "\n\n\nAs you exit your slip space jump you notice that the normal glow from the star you jumped to is not\n" +
                    "illuminating your cockpit. you slow down and turn to see a full Federation star ship. You quickly try \n" +
                    "and remember if you are carrying anything illegal...";
                this.shipChoice = 4;
                return ShipEmerge;
            }
            if (ship == 3)//Federation cruiser
            {
                ShipEmerge =
                    "\n\n\nA pretty mean looking Federal Cruiser is waiting for you as soon as you exit your jump...";
                this.shipChoice = 3;
                return ShipEmerge;
            }
            if (ship == 2)//Pirate
            {
                ShipEmerge =
                    "\n\n\nBefore you exit slip space your radar starts to go wild.. This can mean only one thing. Interdiction.\n" +
                    "You make a very rough exit to see several small ships with a pirate logo on the side...";
                this.shipChoice = 2;
                return ShipEmerge;
            }
            if (ship == 1)//Smuggler
            {
                ShipEmerge =
                    "\n\n\nYou exit a pretty uneventful jump and notice a hail coming in on your comms. You answer to find a small \n" +
                    "cargo ship is hailing you and asks if you would like to trade..";
                this.shipChoice = 1;
                return ShipEmerge;
            }
            else
            {
                Random random = new Random();
                int dialog = random.Next(1, 10);
                if (dialog>=7)
                { ShipEmerge = "\n\n\nYou emerge from a safe slip space jump";
                    return ShipEmerge;
                }
                if (dialog >= 4 && dialog >= 6)
                {
                    ShipEmerge = "\n\n\nYou had a rough ride through the tunnel. You had to battle a hoard of strut rats that tried to \n" +
                                 "chew through your food supply.. you need some rest and a good beer at the next planet";
                    return ShipEmerge;
                }
                if (dialog < 4 )
                {
                    ShipEmerge = "\n\n\nYou slept through your alarm and wake up to the jerk of returning to normal space..";
                    return ShipEmerge;
                    this.shipChoice = 0;
                }
                return ShipEmerge;
            }
        }

        public string ShipEngages(int Ship)
        {
            string ShipEngages="test";
            if (Ship == 4)//Federation Flagship
            {
                
                Random random = new Random();
                int dialog = random.Next(1, 10);
                if (dialog >= 7)
                {
                    ShipEngages = "\nEnemy Ship\n\n<<<Stop and submit to a security scan...if you do not have anything to hide this will be over quickly>>> ";
                    return ShipEngages;
                }
                if (dialog >= 4 && dialog <= 6)
                {
                    ShipEngages = "\nEnemy Ship\n\n<<<Dock and submit to a contraband search>>>";
                    return ShipEngages;
                }
                if (dialog < 4)
                {
                    ShipEngages = "\nEnemy Ship\n\n<<<We have been looking for you>>>";
                    return ShipEngages;
                }
            }
            if (Ship == 3)//Federation Cruiser
            {
                
                Random random = new Random();
                int dialog = random.Next(1, 10);
                if (dialog >= 7)
                {
                    ShipEngages = "\nEnemy Ship\n\n<<<We are patrolling this area... do not cause any trouble and we will not bother you>>> ";
                    return ShipEngages;
                }
                if (dialog >= 4 && dialog <= 6)
                {
                    ShipEngages = "\nEnemy Ship\n\n<<<Dock and submit to a contraband search>>>";
                    return ShipEngages;
                }
                if (dialog < 4)
                {
                    ShipEngages = "\nEnemy Ship\n\n<<<Do you have any illegal cargo?>>>";
                    return ShipEngages;
                }
            }
            if (Ship == 2)//Pirate
            {
                
                Random random = new Random();
                int dialog = random.Next(1, 10);
                if (dialog >= 7)
                {
                    ShipEngages = "\nEnemy Ship\n\n<<<Youve crossed the wrong path... how about a 1500 credits and we dont take you for all youve got?>>> ";
                    return ShipEngages;
                }
                if (dialog >= 4 && dialog <= 6)
                {
                    ShipEngages = "\nEnemy Ship\n\n<<<Theres a toll here.. 500 credits...>>>";
                    return ShipEngages;
                }
                if (dialog < 4)
                {
                    ShipEngages = "\nEnemy Ship\n\n<<<We have bigger guns... hows about you convince us to let you go? {1500 credits}>>>";
                    return ShipEngages;
                }
            }
            if (Ship == 1) //smuggler
            {

                Random random = new Random();
                int dialog = random.Next(1, 10);
                if (dialog >= 7)
                {
                    ShipEngages = "\nEnemy Ship\n\n<<<I have some good wares you cant buy anywhere else...... interested?>>> ";
                    return ShipEngages;
                }

                if (dialog >= 4 && dialog <= 6)
                {
                    ShipEngages = "\nEnemy Ship\n\n<<<I have some cargo you might be interested in...>>>";
                    return ShipEngages;
                }

                if (dialog < 4)
                {
                    ShipEngages = "\nEnemy Ship\n\n<<<Have you ever seem Morite Crystal before? willing to trade?>>>";
                    return ShipEngages;
                }
                else return ShipEngages;
            }
            if (Ship == 0)
            {
                Random random = new Random();
                int dialog = random.Next(1, 10);
                if (dialog >= 7)
                {
                    ShipEngages = "\n\n\nYou pull into the shipyard and wait in line to be docked.. you would assume this \n" +
                                  "docking system would be more streamlined by now....";
                    return ShipEngages;
                }

                if (dialog >= 4 && dialog <= 6)
                {
                    ShipEngages = "\n\n\nAs you make your way into the system you have to work hard to avoid kids flying reckless\n" +
                                  "around the docking station... patrol is never around when you need them..";
                    return ShipEngages;
                }

                if (dialog < 4)
                {
                    ShipEngages = "\n\n\nYou slowly make your way to the planets docking station...";
                    return ShipEngages;
                }
                else return ShipEngages;
            }
            else return ShipEngages;
        }

        public string PlayerConfronts(int Ship)
        {
            string ShipEngages = "";
            if (Ship == 4)//Federation Flagship
            {
                     ShipEngages = "\nPlayer\n\n1 - >>> I know my rights I dont want to be scanned for no good cause! <<< \n\n" +
                                         "2 - >>> Hey Hey lets not be crays here...BRIBE {1000 credits} <<< \n\n" +
                                         "3 - >>> I dont want any trouble with the Federation..... <<< \n\n\n" +
                                         $"Make Selection and Press Enter\n\n\n";
                    return ShipEngages;
            }
            if (Ship == 3)//Federation Cruiser
            {


                
                     ShipEngages = "\nPlayer\n\n1 - >>> I know my rights I dont want to be scanned for no good cause! <<< \n\n" +
                                         "2 - >>> Hey Hey lets not be crays here...BRIBE {1000 credits} <<< \n\n" +
                                         "3 - >>> I dont want any trouble hurry up please..... <<< \n\n\n" +
                                         $"Make Selection and Press Enter\n\n\n";
                return ShipEngages;
               
            }
            if (Ship == 2)//Pirate
            {


                
                    ShipEngages = "\nPlayer\n\n1 - >>> Pirate dogs Im not paying you scratch {Try to escape} <<< \n\n" +
                                         "2 - >>> Pirate dogs Im not paying you scratch {Try and attack} <<< \n\n" +
                                         "3 - >>> I dont want any trouble..... {Pay bribe} <<< \n\n\n" +
                                         $"Make Selection and Press Enter\n\n\n";
                return ShipEngages;
               
            }
            if (Ship == 1) //smuggler
            {


                
                    ShipEngages = "\nPlayer\n\n1 - >>> Hey man, Im not trying to get into any black market stuff..<<< \n\n" +
                                         "2 - >>> Smuggler trash go scam someone else...<<< \n\n" +
                                         "3 - >>> What you have in stock?<<< \n\n\n" +
                                         $"Make Selection and Press Enter\n\n\n";
                return ShipEngages;
                
                
            }
            if (Ship == 0) //Normal
            {



                ShipEngages = "\n\n\n1 - Dock and get some rest\n\n" +
                              "2 - Investigate a signal you see on the radar \n\n" +
                              "3 - Have your ship serviced\n\n\n" +
                              $"Make Selection and Press Enter\n\n\n";
                return ShipEngages;


            }
            return ShipEngages;

        }

        public string ShipResponds(int Ship, int input, double speed, double hull, double attack, double contraband, double credits)
        {
            string ShipEngages="test";
            if (Ship == 4)//Federation Flagship
            {

                
                if (input==1)
                {
                    ShipEngages = "\nEnemy Ship\n\n<<<We are searching be-CAUSE we feel like it. And now we need to resupply merchant.. as a donation \n to our cause...>>>";
                    return ShipEngages;
                }
                if (input == 2)
                {
                    if(credits > 50000)
                    ShipEngages = "\nEnemy Ship\n\n<<<I see you arent just a run of the mill criminal... be on your way>>>";
                    if (credits < 50000)
                        ShipEngages = "\nEnemy Ship\n\n<<<Trying to bribe a Federation officer is a felony... enjoy prison... >>>";
                    return ShipEngages;
                }
                if (input == 3)
                {
                    if (contraband == 0)
                    {
                        ShipEngages =
                            "\nEnemy Ship\n\n<<<You check out, stay out of trouble>>> ";
                        return ShipEngages;
                    }

                    if (contraband > 0)
                    {
                        ShipEngages =
                            "\nEnemy Ship\n\n<<<You have illegal cargo, you need to pay a fine or you will be detained...>>> ";
                        return ShipEngages;
                    }
                }
            }
            if (Ship == 3)//Federation Cruiser
            {



                if (input == 1)
                {
                    ShipEngages = "\nEnemy Ship\n\n<<<We are searching be-CAUSE we feel like it. And now we need to resupply merchant.. as a donation \n to our cause...>>>";
                    return ShipEngages;
                }
                if (input == 2)
                {
                    if (credits > 50000)
                        ShipEngages = "\nEnemy Ship\n\n<<<I see you arent just a run of the mill criminal... be on your way>>>";
                    if (credits < 50000)
                        ShipEngages = "\nEnemy Ship\n\n<<<Trying to bribe a Federation officer is a felony... enjoy prison... >>>";
                    return ShipEngages;
                }
                if (input == 3)
                {
                    if (contraband < 0)
                    {
                        ShipEngages =
                            "\nEnemy Ship\n\n<<<You check out, stay out of trouble>>> ";
                        return ShipEngages;
                    }

                    if (contraband > 0)
                    {
                        ShipEngages =
                            "\nEnemy Ship\n\n<<<You have illegal cargo, you need to pay a fine or you will be detained...>>> ";
                        return ShipEngages;
                    }
                }
            }
            if (Ship == 2)//Pirate
            {
                
                
                Random random = new Random();
                Enemy smuggler = new Enemy { Speed = random.Next(200, 600), Hull = random.Next(100, 300)};

                if (input == 1)
                {
                    
                    if (speed>smuggler.Speed)
                    {ShipEngages = "\n\n\nYou Push the throttle and speed off leaving the pirates behind"; }
                    else if (speed< smuggler.Speed)
                    {ShipEngages = "\n\n\nYou try and run but the pirates surround you..<<<Nice try>>>"; }
                    return ShipEngages;
                }
                if (input == 2)
                {
                    if (attack  > smuggler.Hull)
                    {ShipEngages = "\n\n\nYou maneuver and take well aimed shots at the pirate ships, one explodes and the others scatter."; }
                    
                    if (attack < smuggler.Hull)
                    {ShipEngages = "\n\n\nYou maneuver and take well aimed shots at the pirate ships, but your shots dont seem to have done \n" +
                                   "enough damage to destroy a ship <<<You really tried to attack us??? Get ready to die..>>>.";}
                    return ShipEngages;
                }
                if (input == 3)
                {
                    ShipEngages = "\n\n\n<<<Thank you very much kind merchant, for your donation we will escort you to your destination!>>>";
                    return ShipEngages;
                }
            }
            if (Ship == 1) //smuggler
            {
                ;

                if (input == 1)
                {
                    ShipEngages = "\nEnemy Ship\n\n<<< Suit yourself..>>> ";
                    return ShipEngages;
                }

                if (input == 2)
                {
                    ShipEngages = "\nEnemy Ship\n\n<<< Merchant scum..>>>";
                    return ShipEngages;
                }

                if (input == 3)
                {
                    ShipEngages = "\n\n\n<<<Item # 1 - Weapons   Price: 500   Weight: 0>>>\n\n Choose Item and Press Enter";
                    return ShipEngages;
                }
                
            }
            if (Ship == 0) //Normal
            {
                ;

                if (input == 1)
                {
                    ShipEngages = "\n\n\nYou get some much needed rest.";
                    return ShipEngages;
                }

                if (input == 2)
                {
                    ShipEngages = "\n\n\nYou find a small transport vehicle. its stripped of all useful parts.. it must have been\n" +
                                  "hit by pirates or something..";
                    return ShipEngages;
                }

                if (input == 3)
                {
                    ShipEngages = "\n\n\nYou sit back and relax as the mechanic patches all the damage that occurs when traveling\n" +
                                  "in space. luckily you have insurance.";
                    return ShipEngages;
                }
                
            }
            return ShipEngages;
        }

        public int Weapons = 0;
        public string ConflictResult(int Ship, int input,double contraband, double credits, double speed, double hull, double attack)
        {
            string ShipEngages = "";
            if (Ship == 4)//Federation Flagship
            {


                if (input == 1)
                {
                    if (contraband == 0)
                    {
                        ShipEngages =
                            "\n\n\n<<<Lucky for you, you check out. But we will take some fuel for our time>>> \n\n\n 20 Fuel lost.\n\n\n Press Enter...";
                        return ShipEngages;
                    }

                    if (contraband > 0)
                    {
                        ShipEngages =
                            "\n\n\n<<<HAHAHA You have illegal cargo, unfortunate for you... Enjoy prison..>>> \n\n\n" +
                            " You are taken to a nearby Federation prison planet. You spends several months locked up before you are released.\n\n" +
                            " You get dropped off at Xaenides Station, Luckily your ship was kept in the bay by your previous employer. With a \n\n" +
                            " thank you, you head off to continue your journey. Unfortunately your cargo was sold off to maintain your ship...";
                        
                        return ShipEngages;
                    }
                }
                if (input == 2)
                {
                    if (credits > 50000)
                        ShipEngages = "\n\n\nYou Bribed them 10% of your bankroll...";
                    if (credits < 50000)
                        ShipEngages = " \n\n\nYou are taken to a nearby Federation prison planet. You spends several months locked up before you are released.\n\n" +
                                      " You get dropped off at Xaenides Station, Luckily your ship was kept in the bay by your previous employer. With a \n\n" +
                                      " thank you, you head off to continue your journey. Unfortunately your cargo was sold off to maintain your ship...";
                    return ShipEngages;
                }
                if (input == 3)
                {
                    if (contraband == 0)
                    {
                        ShipEngages =
                            "\n\n\nThe Starship pulls forward, and in a storm of electricity, jumps into hyperspace... ";
                        return ShipEngages;
                    }

                    if (contraband > 0 && credits<20000)
                    {
                        ShipEngages =
                            "\n\n\n<<<You have illegal cargo, unfortunate for you, you dont have enough for the fine... Enjoy prison..>>> \n\n\n" +
                            " You are taken to a nearby Federation prison planet. You spends several months locked up before you are released.\n\n" +
                            " You get dropped off at Xaenides Station, Luckily your ship was kept in the bay by your previous employer. With a \n\n" +
                            " thank you, you head off to continue your journey. Unfortunately your cargo was sold off to maintain your ship...";
                        return ShipEngages;
                    }
                    if (contraband > 0 && credits > 20000)
                        ShipEngages = "\n\n\nYou were fined 5% of your bankroll...";
                }
            }
            if (Ship == 3)//Federation Cruiser
            {


                if (input == 1)
                {
                    if (contraband < 0)
                    {
                        ShipEngages =
                            "\n\n\n<<<Lucky for you, you check out. But we will take some fuel for our time>>> \n\n\n 10 Fuel lost.\n\n\n Press Enter...";
                        return ShipEngages;
                    }

                    if (contraband > 0)
                    {
                        ShipEngages =
                            "\n\n\n<<<HAHAHA You have illegal cargo, unfortunate for you... Enjoy prison..>>> \n\n\n" +
                            " You are taken to a nearby Federation prison planet. You spends several months locked up before you are released.\n\n" +
                            " You get dropped off at Xaenides Station, Luckily your ship was kept in the bay by your previous employer. With a \n\n" +
                            " thank you, you head off to continue your journey. Unfortunately your cargo was sold off to maintain your ship...";

                        return ShipEngages;
                    }
                }
                if (input == 2)
                {
                    if (credits > 50000)
                        ShipEngages = "\n\n\nYou Bribed them 5% of your bankroll...";
                    if (credits < 50000)
                        ShipEngages = " \n\n\nYou are taken to a nearby Federation prison planet. You spends several months locked up before you are released.\n\n" +
                                      " You get dropped off at Xaenides Station, Luckily your ship was kept in the bay by your previous employer. With a \n\n" +
                                      " thank you, you head off to continue your journey. Unfortunately your cargo was sold off to maintain your ship...";
                    return ShipEngages;
                }
                if (input == 3)
                {
                    if (contraband < 0)
                    {
                        ShipEngages =
                            "\n\n\nThe Starship pulls forward, and shortly you see a flash as the ship blows up a small vessel. \n\n" +
                            "Probably some merchant that 'dared' to challange them.....dogs... ";
                        return ShipEngages;
                    }

                    if (contraband > 0 && credits < 15000)
                    {
                        ShipEngages =
                            "\n\n\n<<<You have illegal cargo, unfortunate for you, you dont have enough for the fine... Enjoy prison..>>> \n\n\n" +
                            " You are taken to a nearby Federation prison planet. You spends several months locked up before you are released.\n\n" +
                            " You get dropped off at Xaenides Station, Luckily your ship was kept in the bay by your previous employer. With a \n\n" +
                            " thank you, you head off to continue your journey. Unfortunately your cargo was sold off to maintain your ship...";
                        return ShipEngages;
                    }
                    if (contraband > 0 && credits > 15000)
                        ShipEngages = "\n\n\nYou were fined 5% of your bankroll...";
                }
            }
            if (Ship == 2)//Pirate
            {


                Random random = new Random();
                Enemy smuggler = new Enemy { Speed = random.Next(200, 600), Hull = random.Next(100, 300) };

                if (input == 1)
                {

                    if (speed > smuggler.Speed)
                    { ShipEngages = "\n\n\nYou slow down when you reach your destination >>>Im glad this ship has good thrusters..<<<"; }
                    else if (speed < smuggler.Speed)
                    { ShipEngages = "\n\n\nYou try to negotiate but its either your credits or your life...you give them what you can..."; }
                    return ShipEngages;
                }
                if (input == 2)
                {
                    if (attack > smuggler.Hull)
                    { ShipEngages = "\n\n\nWith the conflict over, you wipe sweat from your brow and continue on..."; }

                    if (attack < smuggler.Hull)
                    {
                        ShipEngages = "\n\n\nYou engage in some scattered battle and take some damage. Unfortunately, you were damaged and \n" +
                                      "were boarded, they take your cargo, but werent able to unlock your credit tablet encryption. \n" +
                                      "You were able to hit the distress beacon and they beat you until you give them what you have \n" +
                                      "on the ship... <<<Lucky the Fed will be here soon or else we'd show you whats what...>>>\n\n\n" +
                                      "You lost 20% of your credits.";
                    }
                    return ShipEngages;
                }
                if (input == 3)
                {
                    ShipEngages = "\n\n\nYou give them 500 credits and that seems to be enough to keep them away. Its enough to get them drunk...";
                    return ShipEngages;
                }
            }
            if (Ship == 1) //smuggler
            {
                ;

                if (input == 1)
                {
                    ShipEngages = "\n\n\nThe smuggler's ship sputters along, coming very close to your ship, likely scanning it... ";
                    return ShipEngages;
                }

                if (input == 2)
                {
                    ShipEngages = "\n\n\nYou move close to the ship, letting them know you arent playing games. They take the message \n" +
                                  "and leave...";
                    return ShipEngages;
                }

                if (input == 3)
                {
                    Weapons = 1;
                    ShipEngages = "\n\n\nYou purchased Black market cargo, dont get caught with it on your ship...";

                    return ShipEngages;
                }
                else return ShipEngages;
            }
            if (Ship == 0) //Normal
            {
                

                if (input == 1)
                {
                    ShipEngages = "\n\n\nYou get up and head planet side to the warehouse district. ";
                    return ShipEngages;
                }

                if (input == 2)
                {
                    ShipEngages = "\n\n\nYou set your navigation planet side and head towards the warehouse district.";
                    return ShipEngages;
                }

                if (input == 3)
                {

                    ShipEngages = "\n\n\nOnce everything is finished, you head planet side towards the warehouse district. ";
                    return ShipEngages;
                }
                else return ShipEngages;
            }
            else return ShipEngages;
        }




    }
}
