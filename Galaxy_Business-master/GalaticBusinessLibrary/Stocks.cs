using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceMerchantLibrary
{
    public class Stocks
    {
        //Natotis Companies


        public double PriceGen(double stock)
        {
            Random stockprice = new Random();
            int ss = stockprice.Next(0, 50);

            if (ss > 45)
            {
                stockFallHighHigh(stock); 
            }
        }

        public double stockFallLow(double price)
        {
            price -= (price * .03);
            return price;
        }

        public double stockFallMid(double price)
        {
            price -= (price * .07);
            return price;
        }

        public double stockFallMidMid(double price)
        {
            price -= (price * .11);
            return price;
        }
        public double stockFallHigh(double price)
        {
            price -= (price * .20);
            return price;
        }
        public double stockFallHighMid(double price)
        {
            price -= (price * .31);
            return price;
        }
        public double stockFallHighHigh(double price)
        {
            price -= (price * .40);
            return price;
        }

        public double stockraiseLow(double price)
        {
            price += (price * .03);
            return price;
        }

        public double stockraiseMid(double price)
        {
            price += (price * .07);
            return price;
        }

        public double stockraiseMidMid(double price)
        {
            price += (price * .11);
            return price;
        }
        public double stockraiseHigh(double price)
        {
            price += (price * .20);
            return price;
        }
        public double stockraiseHighMid(double price)
        {
            price += (price * .31);
            return price;
        }
        public double stockraiseHighHigh(double price)
        {
            price += (price * .40);
            return price;
        }












    }
}
