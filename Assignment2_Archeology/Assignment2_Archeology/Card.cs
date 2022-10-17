using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Assignment2_Archeology
{
    //List<string> TreasureCardValue = new List<>(shard, scrap, coin, talisman, cup, map, mask);
   

    public abstract class Card
    {
        protected const int CARD_GAP = 10;
        protected Image image_;
        protected Image backImage_;
        protected ResourceManager re_manager = Properties.Resources.ResourceManager;
        protected bool flip = false;
        protected List<Deck> decks = new List<Deck>();

        protected int CardNum_;
        protected int TradeValue_;
        protected int SellingValue_;


        public Card(int cardNum, int sellingVal, int tradeVal, Image image)
        {
            CardNum_ = cardNum;
            TradeValue_ = tradeVal;
            SellingValue_ = sellingVal;

            
        }

        public Card()
        {
            
        }


        public Image Image
        {
            get { return image_; }
            set { image_ = (Image)re_manager.GetObject(getResourceId()); }
        }
        public Image BackImage
        {
            get { return backImage_; }
        }
        public virtual List<Deck> Decks
        {
            get { return decks;}
        }
        public int CardNum { get { return CardNum_; } }
        public int TradeValue { get { return TradeValue_; } }
        protected int SellingValue { get { return SellingValue_; } }

        public abstract void DrawCard(Graphics g, PictureBox p, int cardPos, Image image);
        public abstract void Draw(Graphics g, PictureBox p, int cardPos, Image image);

        /// <summary>
        /// Get the id of resource, to get each image to draw.
        /// </summary>
        /// <returns></returns>
        public abstract string getResourceId();
    }
}
