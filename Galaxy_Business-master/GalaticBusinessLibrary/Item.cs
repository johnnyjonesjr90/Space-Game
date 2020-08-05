using System;

namespace GalaticBusinessLibrary
{
    public class Item
    {
        public Item()
        {
            Random quantity = new Random();
            this.Qty = quantity.Next(0, 150);
            this.BaseQty = 100;
            this.BasePrice = 100;
        }
        public Item(int from, int to)
        {
            Random quantity = new Random();
            this.Qty = quantity.Next(from, to);
            this.BaseQty = 100;
            this.BasePrice = 100;
        }
        public double Qty { get; set;}
        public double Weight { get; set; }
        public double BaseQty { get; set; }
        public double Price { get; set; }
        public double SellPrice { get; set; }
        public double BasePrice { get; set; }
        public int ItemAvailability;
        public int Availability (int chanceofOccurance)
        {
            if (chanceofOccurance>= 5)
            {
                this.ItemAvailability = 1;
                
            }
            if(chanceofOccurance<= 4)
            {
                this.ItemAvailability = 0;
                                 
            }
            return this.ItemAvailability;
        }

        public virtual void BuyCalculation()
        {
          
            if (this.Qty >= (this.BaseQty * 0) && this.Qty <= (this.BaseQty * .24))
            {
                this.Price = this.BasePrice * 1.50;

            }
            else if (this.Qty >= (this.BaseQty * .25) && this.Qty <= (this.BaseQty * .49))
            {
                this.Price = this.BasePrice * 1.20;
            }
            else if (this.Qty >= (this.BaseQty * .50) && this.Qty <= (this.BaseQty * .74))
            {
                this.Price = this.BasePrice * 1.15;
            }
            else if (this.Qty >= (this.BaseQty * .75) && this.Qty <= (this.BaseQty * .99))
            {
                this.Price = this.BasePrice * 1.00;
            }
            else if (this.Qty >= (this.BaseQty * 1) && this.Qty <= (this.BaseQty * 1.24))
            {
                this.Price = this.BasePrice * .95;
            }
            else if (this.Qty >= (this.BaseQty * 1.25) && this.Qty <= (this.BaseQty * 1.49))
            {
                this.Price = this.BasePrice * .85;
            }
            else if (this.Qty >= (this.BaseQty * 1.50))
            {
                this.Price = this.BasePrice * .75;
            }

            //might work if the below is placed in sell.
            //Console.WriteLine($"Dilithium-- Price: ({Program.Dilithium._Price}) Quantity: ({this.Qty}) Weight: ({Program.Dilithium._Weight})");
        }
        public virtual void SellCalculation()
        {
           
            if (this.Qty >= (this.BaseQty * 0) && this.Qty <= (this.BaseQty * .24))
            {
                this.SellPrice = (this.BasePrice  * 1.30);

            }
            else if (this.Qty >= (this.BaseQty * .25) && this.Qty <= (this.BaseQty * .49))
            {
                this.SellPrice = (this.BasePrice * .90) * 1.35;
            }
            else if (this.Qty >= (this.BaseQty * .50) && this.Qty <= (this.BaseQty * .74))
            {
                this.SellPrice = (this.BasePrice * .80) * 1.30;
            }
            else if (this.Qty >= (this.BaseQty * .75) && this.Qty <= (this.BaseQty * .99))
            {
                this.SellPrice = (this.BasePrice * .80) * 1.25;
            }
            else if (this.Qty >= (this.BaseQty * 1) && this.Qty <= (this.BaseQty * 1.24))
            {
                this.SellPrice = (this.BasePrice * .80) * 1.00;
            }
            else if (this.Qty >= (this.BaseQty * 1.25) && this.Qty <= (this.BaseQty * 1.49))
            {
                this.SellPrice = (this.BasePrice * .75) * 0.90;
            }
            else if (this.Qty >= (this.BaseQty * 1.50))
            {
                this.SellPrice = (this.BasePrice * .70) * .80;
            }

            //might work if the below is placed in sell.
            //Console.WriteLine($"Dilithium-- Price: ({Program.Dilithium._Price}) Quantity: ({this.Qty}) Weight: ({Program.Dilithium._Weight})");
        }


        public string SalePrice()
        {
            string saleprice = "Price: ";
            return saleprice;
        }
        public string SaleQty()
        {
            string saleqty = "Quantity: ";
            return saleqty;
        }
        public string SaleWeight()
        {
            string saleweight = "Weight: ";
            return saleweight;
        }

    }
}
