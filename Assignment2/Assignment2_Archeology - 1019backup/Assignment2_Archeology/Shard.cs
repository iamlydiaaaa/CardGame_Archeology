using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Assignment2_Archeology
{
    internal class Shard : Treasure
    {
        public string value_ = "shard";
        public Shard()
        {
            CardName_ = this.value_;
            CardNum_ = 18;
            TradeValue_ = 1;
            SellingValue_ = 1;
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