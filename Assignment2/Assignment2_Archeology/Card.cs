using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Assignment2_Archeology
{
    public abstract class Card
    {
        protected const int CARD_GAP = 10;
        protected Image image_;
        protected ResourceManager re_manager = Properties.Resources.ResourceManager;
        protected bool flip = false;
        protected List<Deck> decks = new List<Deck>();

        protected String CardName_;
        protected int CardNum_;
        protected int TradeValue_;
        protected int SellingValue_;

        protected int XPos_;
        protected int YPos_;

        /// <summary>
        /// It checks if there is any card on the selected position 
        /// </summary>
        /// <param name="x">the mouse x position</param>
        /// <param name="y">the mouse y position</param>
        /// <param name="index">the index of the card in the list</param>
        /// <returns></returns>
        public virtual bool IsMouseOn(int x, int y,int index)
        {
            if (x >= ((85 * (index)) - 75) && x <= (85 * (index)) && y >= 10 && y <= (10 + 125))
                { return true; }
            else
            { return false; }
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

        /// <summary>
        /// Returns the X position of the card
        /// </summary>
        public int XPos
        {
            get { return XPos_; }
            set { XPos_ = value; }
        }

        /// <summary>
        /// Returns the Y position of the card
        /// </summary>
        public int YPos
        {
            get { return YPos_; }
            set { YPos_ = value; }
        }

        /// <summary>
        /// Returns the IMAGE resource of each card
        /// </summary> 
        public Image Image
        {
            get { return image_; }
            set { image_ = (Image)re_manager.GetObject(getResourceId()); }
        }

        public virtual List<Deck> Decks
        {
            get { return decks;}
        }

        /// <summary>
        /// Returns the name of each card
        /// </summary>
        public string CardName
        {
            get { return CardName_; }
            set { CardName_ = value; }
        }

        /// <summary>
        /// Returns the number of each card
        /// </summary>
        public int CardNum { 
            get { return CardNum_; } 
            set { CardNum_ = value; }
        }

        /// <summary>
        /// Returns the trading value of each card
        /// </summary>
        public int TradeValue { 
            get { return TradeValue_; } 
            set { TradeValue_ = value; }
        }

        /// <summary>
        /// Returns the selling value of each card when selling to the museum
        /// </summary>
        public int SellingValue { 
            get { return SellingValue_; } 
            set { SellingValue_ = value; }
        }

        /// <summary>
        /// It is an abstract method which draws each card to picture box
        /// </summary>
        /// <param name="g"></param>
        /// <param name="p">the PictureBox of the card to draw</param>
        /// <param name="cardPos">the x position of the each card to draw</param>
        /// <param name="image">the image source of card</param>
        public abstract void DrawCard(Graphics g, PictureBox p, int cardPos, Image image);

        /// <summary>
        /// Get the id of resource, to get each image to draw.
        /// </summary>
        /// <returns></returns>
        public abstract string getResourceId();

        public override string ToString()
        {
            return "- " + CardName_ + " -" + TradeValue_.ToString().PadLeft(10) + SellingValue_.ToString().PadLeft(10);
        }
    }
}
