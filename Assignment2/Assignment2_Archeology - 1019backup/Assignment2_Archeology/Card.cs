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

        protected String CardName_;
        protected int CardNum_;
        protected int TradeValue_;
        protected int SellingValue_;

        protected int XPos_;
        protected int YPos_;

        // left is the left-hand edge of the main part of the gate.
        // So the input pins are further left than left.
        protected int _left;

        // top is the top of the whole gate
        protected int _top;

        public Card(int left, int top)
        {
            _left = left;
            _top = top;
        }
        public virtual int Left
        {
            get { return _left; }
        }

        /// <summary>
        /// Gets the top edge of the gate.
        /// </summary>
        public virtual int Top
        {
            get { return _top; }
        }

        public virtual bool IsMouseOn(int x, int y)
        {
            if (x >= (XPos_ - 75) && x <= XPos_ 
                && y >= YPos_ && y <= (YPos_ + 125))
                return true;
            else
                return false;
        }

        public Card(string CardName_, int cardNum, int sellingVal, int tradeVal)
        {
            CardNum_ = cardNum;
            TradeValue_ = tradeVal;
            SellingValue_ = sellingVal;

            
        }

        public Card()
        {
            
        }

        public int XPos
        {
            get { return XPos_; }
            set { XPos_ = value; }
        }
        public int YPos
        {
            get { return YPos_; }
            set { YPos_ = value; }
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
        public string CardName
        {
            get { return CardName_; }
            set { CardName_ = value; }
        }
        public int CardNum { 
            get { return CardNum_; } 
            set { CardNum_ = value; }
        }
        public int TradeValue { 
            get { return TradeValue_; } 
            set { TradeValue_ = value; }
        }
        protected int SellingValue { 
            get { return SellingValue_; } 
            set { SellingValue_ = value; }
        }

        public abstract void DrawCard(Graphics g, PictureBox p, int cardPos, Image image);
        //public abstract void Draw(Graphics g, PictureBox p, int cardPos, Image image);

        /// <summary>
        /// Get the id of resource, to get each image to draw.
        /// </summary>
        /// <returns></returns>
        public abstract string getResourceId();
    }
}
