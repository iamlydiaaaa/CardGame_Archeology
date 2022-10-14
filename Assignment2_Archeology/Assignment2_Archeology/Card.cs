using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Assignment2_Archeology
{
    //List<string> CardFaceValue = new List<>(shard, scrap, coin, talisman, cup, map, mask);
    public enum CardFaceValue { shard, scrap, coin, talisman, cup, map, mask };

    public class Card
    {
        public static int NUM_CARDS = 5;
        private const int CARD_GAP = 20;

        private CardFaceValue value_;

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
            image_ = card.image_;
        }

        /// <summary>
        /// A getter to get the faceValue of the card
        /// </summary>
        public CardFaceValue FaceValue { get { return value_; } }


        /// <summary>
        /// Hashcodes 해쉬코드
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if(obj is Card)
            {
                Card cardObj = (Card)obj;
                return (value_ == cardObj.value_);
            }
            else
            {
                throw new Exception("Card Equals() test applied to argument of an incompatible type");
            }
        }

        public static bool operator == (Card card1, Card card2) { return card1.Equals(card2); }
        public static bool operator !=(Card card1, Card card2) { return !(card1 == card2); }

        public override int GetHashCode()
        {
            return (int)value_;
        }

        /// <summary>
        /// Get the id of resource, to get each image to draw.
        /// </summary>
        /// <returns></returns>
        private string getResourceId()
        {
            return value_.ToString();
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
            double d_display_x_dim = (double)display_x_dim;
            double d_display_y_dim = (double)display_y_dim;

            double d_card_x_dim = (double)image_.Width; //이미지의 가로세로값
            double d_card_y_dim = (double)image_.Height;

            //카드의 가로길이 = 박스 가로 / ((카드가로+간격)* 4장+2)
            double x_scale = d_display_x_dim / ((d_card_x_dim + CARD_GAP) * (Form1.PLAYER_SIZE + 2));
            double y_scale = d_display_y_dim / (d_card_y_dim);
            
            // scale은 x,y중 더 작은 값으로 설정
            double scale = (x_scale<y_scale) ? x_scale : y_scale;

            int scaled_card_x_dim = (int)Math.Round(d_card_x_dim * scale);
            int scaled_card_y_dim = (int)Math.Round(d_card_y_dim * scale);

            int card_x_org = CARD_GAP + cardPos * (scaled_card_x_dim + CARD_GAP);
            int card_y_org = (display_y_dim - scaled_card_y_dim) / 2;

            graphics.DrawImage(image, card_x_org, card_y_org, scaled_card_x_dim, scaled_card_y_dim);
        }
        
        /// <summary>
        /// flip the card
        /// </summary>
        public void Flip() { flip = true; }
        public void UnFlip() { flip = false; }

/*        public override string ToString()
        {
            
        }*/

    }
}
