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
                answer2 = "Mission ['Need a coworker escorted to the ACL system'] PASSED\n\nThank you for getting my friend home safely. You know those pesky political activist always get in the way.";
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
                answer2 = "Mission ['Need 100 Food for homeless Vurik on Otov'] PASSED\n\n.";
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
    }
}
