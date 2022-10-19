using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Assignment2_Archeology
{

    public class Treasure : Card
    {
        public Treasure() {
            string resource_id = getResourceId();
            image_ = (Image)re_manager.GetObject(resource_id);
            backImage_ = (Image)re_manager.GetObject("cardback");
        }



        public override void DrawCard(Graphics g, PictureBox p, int xpos, Image image)
        {
            int cardWidth = image.Width / 4;
            int cardHeight = image.Height / 4;
            XPos = xpos;
            YPos = 10;

            g.DrawImage(image, XPos, YPos_, cardWidth, cardHeight);
            //XPos = XPos + cardWidth + 10;
            getResourceId();
        }


        public override string getResourceId()
        {
            //Console.WriteLine("--Treasure.cs_line53: 이 카드는 " + value_);
            return CardName_.ToString().ToLower();
        }
        public override string ToString()
        {
            return "* [" + CardName_ + "] " + CardNum_.ToString() + ", " + TradeValue_.ToString() + ", " + SellingValue_.ToString();
        }
    }
}
