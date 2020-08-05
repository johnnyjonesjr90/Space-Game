using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceMerchantLibrary
{
    public class Stocks
    {
        //Natotis Companies
        public string StockChoice()
        {
            string stock = "What would you like to buy?";
            return stock;
        }

        public double PriceGen(double stock)
        {
            double newprice = 50;
            Random stockprice = new Random();
            #region //Normal Stocks
            int ss = stockprice.Next(0, 100);
            if (ss > 95)
            {
                newprice=stockraiseHighHigh(stock);
            }
            if (ss <= 91 && ss >= 95)
            {
                newprice = stockraiseMid(stock);
            }
            if (ss <= 81 && ss >= 90)
            {
                newprice = stockraiseHigh(stock);
            }
            if (ss <= 71 && ss >= 80)
            {
                newprice = stockraiseMidMid(stock);
            }
            if (ss <= 61 && ss >= 70)
            {
                newprice = stockraiseMid(stock);
            }
            if (ss <= 51 && ss >= 60)
            {
                newprice = stockraiseLow(stock);
            }
            if (ss >= 45&&ss >=50 )
            {
                newprice = stockFallHighHigh(stock); 
            }
            if (ss <=44&& ss >= 40)
            {
                newprice = stockFallHighMid(stock);
            }
            if (ss <= 39 && ss >= 30)
            {
                newprice = stockFallHigh(stock);
            }
            if (ss <= 29 && ss >= 20)
            {
                newprice = stockFallMidMid(stock);
            }
            if (ss <= 19 && ss >= 10)
            {
                newprice = stockFallMid(stock);
            }
            if (ss <= 9 && ss >= 0)
            {
                newprice = stockFallLow(stock);
            }
#endregion
            return newprice;
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
