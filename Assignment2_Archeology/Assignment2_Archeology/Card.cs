using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Assignment2_Archeology
{
    //List<string> CardFaceValue = new List<>(shard, scrap, coin, talisman, cup, map, mask);
    public enum CardFaceValue { shard, scrap, coin, talisman, cup, map, mask };
    public enum CardNum { one,two,three,four,five };

    public class Card
    {
        public static int NUM_CARDS = 10;
        private const int CARD_GAP = 10;

        private CardFaceValue value_;
        private CardNum cardNum_;

        private Image image_;
        private Image backImage_;

        private bool flip = false;

        public Card() { }

        public Card(CardFaceValue value)
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
            cardNum_ = card.cardNum_;
            image_ = card.image_;
        }

        /// <summary>
        /// A getter to get the faceValue of the card
        /// </summary>
        public CardFaceValue FaceValue { get { return value_; } }


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

            int x = CARD_GAP + image.Width ;
            int y = display_y_dim + 10;

            graphics.DrawImage(image, x, y, 75, 125);
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
