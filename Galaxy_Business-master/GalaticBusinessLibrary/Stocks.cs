using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceMerchantLibrary
{
    public class Stocks
    {
        Companies Zhul = new Companies { companyName = "Zhul Shuttle Co.", stockPrice = 75, symbol = "ZZZL", percentChange = 0 };
        Companies Epsolon = new Companies { companyName = "Epsolon Motor Co.", stockPrice = 175, symbol = "EMC", percentChange = 0 };
        Companies CrudeHelium = new Companies { companyName = "Crude Helium", stockPrice = 3000, symbol = "CLL", percentChange = 0 };
        Companies TabletRetailers = new Companies { companyName = "Tablet Retailers", stockPrice = 16, symbol = "TRKL", percentChange = 0 };
        Companies Valkyrie = new Companies { companyName = "Valkyrie Intelligence", stockPrice = 201, symbol = "VLG", percentChange = 0 };
        public double AmountInvested { get; set; }

        public double TotalReturn(double zhul, double epsolon, double crude, double tablet, double valkyrie)
        {
            double total = zhul + epsolon + crude + tablet + valkyrie;
            return total;
        }
        public double ZhulReturn(double Zhulprice, double ZhulAmount)
        {
            double total =ZhulAmount* Zhulprice;
            return total;
        }
        public double EpsolonReturn(double price, double Amount)
        {
            double total = Amount * price;
            return total;
        }
        public double CrudeReturn(double price, double Amount)
        {
            double total = Amount * price;
            return total;
        }
        public double TabletReturn(double price, double Amount)
        {
            double total = Amount * price;
            return total;
        }
        public double ValkyrieReturn(double price, double Amount)
        {
            double total = Amount * price;
            return total;
        }
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
            price -= (price * .10);
            return price;
        }
        public double stockFallHigh(double price)
        {
            price -= (price * .15);
            return price;
        }
        public double stockFallHighMid(double price)
        {
            price -= (price * .21);
            return price;
        }
        public double stockFallHighHigh(double price)
        {
            price -= (price * .35);
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
            price += (price * .10);
            return price;
        }
        public double stockraiseHigh(double price)
        {
            price += (price * .15);
            return price;
        }
        public double stockraiseHighMid(double price)
        {
            price += (price * .21);
            return price;
        }
        public double stockraiseHighHigh(double price)
        {
            price += (price * .30);
            return price;
        }












    }
}
