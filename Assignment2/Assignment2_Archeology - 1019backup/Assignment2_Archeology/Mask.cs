using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Assignment2_Archeology
{
    internal class Mask : Treasure
    {
        public string value_ = "mask";
        public Mask()
        {
            CardName_ = this.value_;
            CardNum_ = 4;
            TradeValue_ = 4;
            SellingValue_ = 4; 
        }
        public override string getResourceId()
        {
            return this.value_.ToLower();
        }

        public override string ToString()
        {
            return "* [" + CardName_ + "] " + CardNum_.ToString() + ", " + TradeValue_.ToString() + ", " + SellingValue_.ToString();
        }
    }
}