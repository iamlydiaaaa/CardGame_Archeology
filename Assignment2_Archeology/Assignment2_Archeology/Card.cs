using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Assignment2_Archeology
{
    //List<string> TreasureCardValue = new List<>(shard, scrap, coin, talisman, cup, map, mask);
    public enum TreasureCardValue { shard, scrap, coin, talisman, cup, mask };


    public class Card
    {


        private const int CARD_GAP = 10;

        private TreasureCardValue value_;

        private Image image_;
        private Image backImage_;

        private bool flip = false;

        public Card() { }

        public Card(TreasureCardValue value)
        {
            value_ = value;


            ResourceManager re_manager = Properties.Resources.ResourceManager;
            string resource_id = getResourceId();

            image_ = (Image)re_manager.GetObject(resource_id);
            backImage_ = (Image)re_manager.GetObject("cardback");
        }

        public Card(Card card)
        {
            value_ = card.value_;
            image_ = card.image_;
        }

        /// <summary>
        /// A getter to get the faceValue of the card
        /// </summary>
        public TreasureCardValue FaceValue { get { return value_; } }


        /// <summary>
        /// Get the id of resource, to get each image to draw.
        /// </summary>
        /// <returns></returns>
        private string getResourceId()
        {
            Console.WriteLine("이 카드는 " + value_);
            return value_.ToString().ToLower();
        }

        public void DrawCard(Graphics g, PictureBox p, int cardPos)
        {
            Draw(g, p, cardPos, image_);
            //if (!flip) Draw(g, p, cardPos, image_);
            //else Draw(g, p, cardPos, backImage_);
        }

        private void Draw(Graphics graphics, PictureBox pictureBox, int cardPos, Image image)
        {
            int display_x_dim = pictureBox.Width; //그림의 가로세로값
            int display_y_dim = pictureBox.Height;

            int y = 10;

            graphics.DrawImage(image, cardPos, y, 75, 125);
            Console.WriteLine("그림 그렸음");
        }
        
        /// <summary>
        /// flip the card
        /// </summary>
        public void Flip() { flip = true; }
        public void UnFlip() { flip = false; }

        public override string ToString()
        {
            return value_.ToString();
        }

    }
}
