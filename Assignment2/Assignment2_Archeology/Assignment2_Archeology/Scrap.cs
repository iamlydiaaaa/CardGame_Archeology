using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Assignment2_Archeology
{
    internal class Scrap : Treasure
    {
        public string value_ = "scrap";
        public Scrap()
        {
            CardName_ = this.value_;
            CardNum_ = 16;
            TradeValue_ = 1;
            SellingValue_ = 1;
        }
        public override string getResourceId()
        {
            return this.value_.ToLower();
        }

    }
}