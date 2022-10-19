using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Assignment2_Archeology
{
    internal class Cup : Treasure
    {
        public string value_ = "cup";
        public Cup()
        {
            CardName_ = this.value_;
            CardNum_ = 6;
            TradeValue_ = 2;
            SellingValue_ = 2;
        }
        public override string getResourceId()
        {
            return this.value_.ToLower();
        }

    }
}