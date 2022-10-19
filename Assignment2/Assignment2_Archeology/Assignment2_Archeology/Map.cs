using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Assignment2_Archeology
{
    public class Map : Treasure
    {
        public string value_ = "map";
        public Map()
        {
            CardName_ = this.value_;
            CardNum_ = 6;
            TradeValue_ = 3;
            SellingValue_ = 3;
        }

        public override string getResourceId()
        {
            return this.value_.ToLower();
        }

    }
}
