using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace SpaceMerchantLibrary
{
    public class InGameTime
    {
        public int day { get; set; }
        public int year { get; set; }
        public int month { get; set; }
        
        public void time(double planetchoice)
        {
            
            if (planetchoice == 1)
            {
                day += 3;
            }
            if (planetchoice == 2)
            {
                day += 1;
            }
            if (planetchoice == 3)
            {
                day += 0;
            }
            if (planetchoice == 4)
            {
                day += 2;
            }
            if (planetchoice == 5)
            {
                day += 3;
            }
            if (planetchoice == 6)
            {
                day += 1;
            }

            if (day == 32)
            {
                {
                    day = 1;
                    month++;

                }
            }

            if (month == 12 && day == 32)
            {
                year++;
                month = 1;
                day = 1;
            }

        }
    }
}
