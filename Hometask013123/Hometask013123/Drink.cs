using System;
using System.Collections.Generic;
using System.Text;

namespace Hometask013123
{
    public class Drink:Product
    {
        private double _alcoholpercent;
        public double AlcoholPercent
        {
            set {
                if (value>=0 && value<=100)
                {
                    _alcoholpercent = value;
                }
            }
            get {
                return _alcoholpercent;
                }
        }
    }
}
