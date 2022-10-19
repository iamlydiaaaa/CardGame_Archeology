using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Assignment2_Archeology
{
    public enum TreasureCardValue { shard, scrap, coin, talisman, cup, mask };

    public class Treasure : Card
    {
        private TreasureCardValue value_;

        public Treasure() {
            string resource_id = getResourceId();
            image_ = (Image)re_manager.GetObject(resource_id);
            backImage_ = (Image)re_manager.GetObject("cardback");
        }


        public Treasure(TreasureCardValue value)
        {
            value_ = value;

            string resource_id = getResourceId();
            image_ = (Image)re_manager.GetObject(resource_id);

        }


        public override void DrawCard(Graphics g, PictureBox p, int xpos, Image image)
        {
            int cardWidth = image.Width / 4;
            int cardHeight = image.Height / 4;
            XPos = xpos;
            YPos = 10;

            g.DrawImage(image, XPos, YPos_, cardWidth, cardHeight);
            XPos = XPos + cardWidth + 10;
            getResourceId();
        }

       // public override void Draw(Graphics g, PictureBox p, int cardPos, Image image)
        //{}


        public override string getResourceId()
        {
            Console.WriteLine("--Treasure.cs_line53: 이 카드는 " + value_);
            return value_.ToString().ToLower();
        }
        public override string ToString()
        {
            return value_.ToString();
        }
    }
}
