using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Assignment2_Archeology
{
    internal class Coin : Treasure
    {
        public string value_ = "coin";
        public Coin()
        {
            CardName_ = this.value_;
            CardNum_ = 14;
            TradeValue_ = 2;
            SellingValue_ = 2;
        }
        public override string getResourceId()
        {
            return this.value_.ToLower();
        }

    }
}