using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceMerchantLibrary
{
    public class NatotisMissions
    {

        public string MissionBoard()
        {
            string board = "Welcome to the Federation Mission board, please help your fellow civilian in their time \n" +
                           "of need. But do note any assassination attempt or smuggling are illegal and will not be \n" +
                           "tolerated.";
            return board;
        }
        //3 is not opened,2 is in progress  1 is mission success, 0 is mission failed, 4 Declined
        public int Mission001success = 3;
        
        #region //ESCORT MISSION 001
        public string Escort001advertisement()
        {
            string advert = "4000 Credits--[ 'Need a coworker escorted to the ACL system' ]--- Expires 31/3/2457";
            return advert;
        }
        public string Escort001InProgress()
        {
            string advert = "4000 Credits--[ 'Coworker escort ] In progress...Expires 31/3/2457";
            return advert;
        }
        public string Escort001()
        {
            string escort = "\n\nHello merchant, I know you travel a lot. Would you be willing to escort a coworker of mine to Aoclite?\n" +
                            "I can pay you 4000 credits for your efforts\n\n" +
                            "1 - Accept\n\n" +
                            "2 - Deny";
            return escort;
        }

        public string Escort001A(double response)
        {
            string answer = "";
            if (response == 1)//Yes
            {
                answer = "\n\nThank you very much. I hope you travel will be safe!!....... By the way he is a wanted man but that should be a problem....\n\n" +
                         "A very nervous man gets meets you and you exchange an awkward conversation about the trip and he was very concerned if you \n" +
                         "were a Xenocrat or not. You ignore the conversation and tell him where your ship is. HE said he will stay there until your \n" +
                         "business is complete on this planet.";
                Mission001success = 2;
                return answer;
            }
            if (response == 2)//NO
            {
                answer = "\n\nWell I understand not all of us like easy money. But tell me... do you not care about the fate of the ACL galaxy's fruit farms?.";
                return answer;
            }

            return answer;
        }

        public string Escort001Ends(int result)
        {
            string answer2="";
            if (result == 1)//Pass
            {
                answer2 = "Mission ['Need a coworker escorted to the ACL system'] PASSED\n\nThank you for getting my friend home safely. You know those pesky political activist always get in the way.\n\n" +
                          "Reputation -2\n" +
                          "Federation Favor +1\n" +
                          "Vurik Favor -1";
                return answer2;
            }

            if (result == 2)//Fail
            {
                answer2 = "Mission ['Need a coworker escorted to the ACL system'] FAILED\n\nThank you for nothing, I guess dont hire a merchant to do a pirates job...";
                return answer2;
            }

            return answer2;
        }

        public string Excort001DropOff()
        {
            string dropoff =
                "You get off the ship and head to the Assist lounge to find several large groups of people sitting on the floor with signs. They are all chanting 'Freedom, rights, liberty'\n" +
                "as soon as they see you and your guest they run over and dump a tub of green liquid on his head. One of the protestors scream ' You Skruk! you voted against the Vurik rights\n" +
                "bill, now where are my children supposed to go to school?'";
            return dropoff;
        }
        #endregion

        #region //DELIVERY MISSION 002

        public double Mission002food = 0;
            public int Mission002success = 3;
        public string Delivery002advertisement()
        {
            string advert = "8000 Credits--[ 'Need 100 Food for homeless Vurik on Otov' ]--- Expires 1/5/2457";
            return advert;
        }
        public string Delivery002InProgress()
        {
            string advert = "8000 Credits--[ 'Need 100 Food' ] In progress...Expires 1/5/2457";
            return advert;
        }
        public string Delivery002()
        {
            string escort = "\n\nHello, theres a lot of Vuriks on Otov that could use your help. Would you be willing to deliver 100 food to the shelter on that planet?\n\n" +
                            "1 - Accept\n\n" +
                            "2 - Deny";
            return escort;
        }

        public string Delivery002A(double response)
        {
            string answer = "";
            if (response == 1)//Yes
            {
                answer = "\n\nThank you very much! There are so many of them in need because of the Federation and their willingness to let an entire race suffer.";
                Mission001success = 2;
                return answer;
            }
            if (response == 2)//NO
            {
                answer = "\n\nOkay......Well if you wont, hopefully we can figure out a way to help the Vurik.";
                return answer;
            }
             
            return answer;
        }
        public string Delivery002Ends(int result)
        {
            string answer2 = "";
            if (result == 1)//Pass
            {
                answer2 = "Mission ['Need 100 Food for homeless Vurik on Otov'] PASSED\n\n" +
                          "Reputation +2\n" +
                          "Federation Favor -2\n" +
                          "Vurik Favor +3";
                return answer2;
            }

            if (result == 2)//Fail
            {
                answer2 = "Mission ['Need 100 Food for homeless Vurik on Otov'] FAILED\n\n";
                return answer2;
            }

            return answer2;
        }
        
        public string Delivery002DropOff()
        {
            
            string dropoff =
                $"Thank you. Thank you so much. You are a blessing. This food will allow us to feed many women and children.'  \n\n" +
                $"{Mission002food} / 100 food";
            return dropoff;
        }

        #endregion

        public string CantinaEntry()
        {
            string board = "You sit for a drink and look around the bar, you know from your travels that you can find good money at the \n" +
                           "Cantinas if your willing to go outside the law a little.\n\n" +
                           "1 - Speak to the man you heard deals with the Vurik resistance\n\n" +
                           "2 - Speak to a known smuggler\n\n" +
                           "3 - See if anyone is in the 'backroom'\n\n" +
                           "99 - Exit";
            return board;
        }
        #region //CantinaSupply001
        public double Supply001Choice = 0;
        public int Supply001Success = 3;
        public string Supply001Mission()
        {
            string advert = "\n\nYou walk up and spark a conversation with this guy. He is big and looks like he might be half Vurik. His pale skin and \n" +
                            "pale green eyes point to that at least. but after a few drinks you are both laughing and you find your opportunity to \n" +
                            "let him know that you feel for the Vurik cause and you hesitate to see how he is going to respond. Luckily he grabs you by\n" +
                            "the shoulders and says 'the Vurik are great people that were wronged by the Ferderation and the expansionists. He leans in\n" +
                            "close and asks if you were willing to help the cause. You nod and he explains that there is a resistance in Xigow that could\n" +
                            "use some supplies. If you would be so kind to deliver these supplies, since youre a merchant and nobody would assume your\n" +
                            "cargo would be helping the Vurik. You agree and he says he will let them know to pay you 4,000 Credits for your help. They\n" +
                            " are in the Epsolon Motor warehouses, they will know youre coming to help!" +
                            "";
            Supply001Success = 2;
            return advert;
        }
        public string Supply001InProgress()
        {
            string advert = "4000 Credits--[ 'Supply Vurik rebels on Xigow' ] In progress...";
            return advert;
        }
        public string Supply001AA()
        {
            string escort = "\n\n As you walk out of the Cantina you are grabbed by two figures in dark blue outfits, they cover your head and drag you for \n" +
                            "what feels like an hour. They remove the cover and you are sitting in a very nice room with several guards and a older man sitting\n" +
                            "across from you. 'Son, I need you to listen, I know that you just struck a deal with that very large half-alien in the bar. Let me \n" +
                            "help you with this situation, you will not deliver that package to the rebels, because as a ,currently, law abiding Federation citizen\n" +
                            "you have loyalties with us. Instead you will deliver this package to them instead. Some of us remember the great war, they killed millions\n" +
                            "of us, never forget that. Is some change worth it? if so, we will give you some for your loyalty'";
            return escort;
        }
        public string Supply001BB()
        {
            string escort = "\n\n Before you can speak a young woman walk in a whispers in the mans ear. The guards escort him out and the young woman stays behind.\n" +
                            "'I will take you to the city's hangar.' as you get up she grabs you and says sharply 'THINK about what youre going to do.'\n" +
                            "At the end of the hallway she turns around again and says sorry. Your head is covered from behind and some time later you are at \n" +
                            "your ship. YOu see a man sitting with a package on your ships stairs. As you walk up he says 'The Vurik thank you friend...'";
            return escort;
        }
        public string Supply001CC()
        {
            string escort = "\n\n As you approach the warehouse are in awe to see how large it is, you notice that they have anti-ship warp cannons hidden in the roof,\n " +
                            "if there was any sort of attack there would be no way anyone would be able to avoid those cannons. You receive a message on your NAVVI stating\n" +
                            " for you to land in the back lot of the warehouse. As you land you see several men with rifles waiting to meet you. You land and step out of the\n" +
                            " ship and to your surprise you are greeted by three elderly Vurik women. ' We are so glad to see you merchant! Come we have prepared a meal.' ";
            return escort;
        }
        public string SupplyQuestions()
        {
            string escort = "\n\n As you are eating you have a conversation with the elders..\n\n" +
                            "1 - Where are the Vurik men? I dont really see any here at this warehouse?\n\n" +
                            "2 - Why did the Vurik and the Humans go to war? We seem to be alike..\n\n" +
                            "3 - What is the point of the resistance?\n\n" +
                            "4 - I have to go please let me deliver your package";
            return escort;
        }

        public string SupplyAnswer1()
        {
            string answer =
                "You see the Vurik men work throughout the factory as this is the only Vurik owned company and they do not have to worry about being mistreated. After the war\n" +
                "it was very hard for us to find work but after years of protest and hard work this planet is beginning to accept Vurik but as long as the Federation is on the\n" +
                "world we will never fully be safe or free.";
            return answer;
        }
        public string SupplyAnswer2()
        {
            string answer =
                "Years ago Humans came to our worlds preaching of lost worlds and needing to find a new place to settle. Us Vurik being a docile people allowed the Humans to \n" +
                "live on our planets... but after decades of peace, the humans began to outnumber us and wanted to expand into Vurik territories. The Humans moved to all the \n" +
                "worlds in the system but that was not enough, and soon there was the great war. Us Vurik not having so many weapons of war lost many fighters but on the cunning\n" +
                "of a few of our Generals we were able to still bring the war to a stalemate.";
            return answer;
        }
        public string SupplyAnswer3()
        {
            string answer =
                "Freedom merchant, that is the point of all resistances. Freedom from oppression and from the tyranny of the Federation.";
            return answer;
        }
        public string Supply001DD()
        {
            string escort = "\n\nYou stand up and you and the group walk to your ship. As you get to your ship you see both packages sre sitting in the storage bay.\n\n" +
                            "1 - Give them the Vurik package\n\n" +
                            "2 - Give them ther Federation Package";
            return escort;
        }
        public string Supply001A(double response)
        {
            string answer = "";
            if (response == 1)//Vurik Package
            {
                answer = "\n\nThank you very much! The Vurik elder says as you hand them the package. You watch as they open the package to find an arsenal of rifles and pistols \n" +
                         "You watch as they pull out sensor mines and even a small auto-cannon. All this was hidden under the food and clothing on top. As you get into your ship \n" +
                         "and fly off you wonder what kind of destruction will come from the weapons you delivered. Your thoughts are interrupted by your NAVVI showing a message from\n" +
                         "the half-Vurik 'Thank you for helping us brother, Please call me Naroot, stay in contact, there is always help needed for the cause.'";
                Supply001Success = 1;
                return answer;
            }
            if (response == 2)//Federation Package
            {
                answer = "\n\nYou walk past the original box and give them the Federation supplied crate. As you give it to them you tell them that you have to go. As you turn and\n" +
                         "lift up above building height you see the Vurik pulling clothing out of the crate. You pull out into the traffic lane and put the ship into auto pilot. You \n" +
                         "head to the bathroom and start some coffee. You hear your Navvi get a message and then your ship's power fades and you begin to fall out of the air... Your \n" +
                         "ship regains power and then is thrust forward as a large shockwave hits it followed by the deafening sound of an explosion. You run to your controls and look\n" +
                         "out at the rear camera to see a large plume of smoke and fire where the warehouse once was. You look at the NAVVI to see the half-Vurik has messaged you a thanks\n" +
                         "and next to it is a news clipping with his face and the headline 'Vurik Criminal killed after altercation with Federation police in Zhul city Senate building..' ";
                Supply001Success = 0;
                return answer;
            }

            return answer;
        }
        public string Supply001Ends(int result)
        {
            string answer2 = "";
            if (result == 1)//Pass
            {
                answer2 = "Mission ['Supply Vurik rebels on Xigow'] PASSED\n\n" +
                          "Federation Favor -10\n" +
                          "Vurik Favor +10\n" +
                          "Credits +4000";
                return answer2;
            }

            if (result == 0)//Fail
            {
                answer2 = "Mission ['Supply Vurik rebels on Xigow'] PASSED\n\n" +
                          "Federation Favor +20\n" +
                          "Vurik Favor -30\n" +
                          "Credits +10000";
                return answer2;
            }

            return answer2;
        }

        public string Supply0012DropOff(double response)
        {
            
            if (response == 1)
            {
                string dropoff =
                    $"\n\n A NAVVI message comes through from an unknown sender 'Your decisions will not be forgotten merchant...'";
                return dropoff;
            }
            else 
            {
                string dropoff =
                    $"\n\nA NAVVI message comes through from an unknown sender 'Not just the rebel cause has been hurt today merchant... you \n" +
                    $"and the Federation will pay...'";
                return dropoff;
            }
            
        }


        #endregion
    }
}
