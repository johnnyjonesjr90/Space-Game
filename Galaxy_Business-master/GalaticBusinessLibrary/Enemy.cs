using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceMerchantLibrary
{
   public enum typeEnemy
    {
        Smuggler,
        Pirate,
        FederationCruiser,
        FederationFlagship

    }
    public class Enemy
    {
        

        
        public double Chance { get; set; }
        
        public double Speed { get; set; }
        public double Attack { get; set; }

        public  double Hull { get; set; }
        


    }
}
