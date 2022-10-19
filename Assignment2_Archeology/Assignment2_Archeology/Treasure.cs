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
        
        }
        public Treasure(int cardNum, int sellingVal, int tradeVal, string cardName) : base(cardNum, sellingVal, tradeVal, cardName)
        {
            
        }

            public Treasure(TreasureCardValue value)
        {
            value_ = value;
            string resource_id = getResourceId();
            image_ = (Image)re_manager.GetObject(resource_id);
            backImage_ = (Image)re_manager.GetObject("cardback");
        }

/*        public Treasure(Treasure treasure)
        {
            value_ = treasure.value_;
            image_ = treasure.image_;
        }*/

/*        public override void DrawCard(Graphics g, PictureBox p, int cardPos, Image image)
        {
            //image_ = image;
            int cardWidth = image.Width/4;
            int cardHeight = image.Height/4;
            int gap = 10;

            int display_x_dim = p.Width; //그림의 가로세로값
            int display_y_dim = p.Height;
            int y = 10;

            g.DrawImage(image, cardPos, y, cardWidth, cardHeight);
            //Console.WriteLine(image.ToString()+" 그림 그렸음");
            getResourceId();
        }*/

        public override void Draw(Graphics g, PictureBox p, int cardPos, Image image)
        {
            
        }


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
