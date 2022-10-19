﻿using System;
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

        protected string CardName_;
        protected int CardNum_;
        protected int TradeValue_;
        protected int SellingValue_;


        public Card(int cardNum, int sellingVal, int tradeVal, string cardName)
        {
            CardNum_ = cardNum;
            TradeValue_ = tradeVal;
            SellingValue_ = sellingVal;
            CardName_ = cardName;
        }

        public Card()
        {
            
        }

        public String CardName
        {
            get { return CardName_; }
            set { CardName_ = value; }
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
        public int CardNum
        {
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

        public virtual void DrawCard(Graphics g, PictureBox p, int cardPos, Image image)
        {
            //image_ = image;
            int cardWidth = image.Width / 4;
            int cardHeight = image.Height / 4;
            int gap = 10;

            int display_x_dim = p.Width; //그림의 가로세로값
            int display_y_dim = p.Height;
            int y = 10;

            g.DrawImage(image, cardPos, y, cardWidth, cardHeight);
            //Console.WriteLine(image.ToString()+" 그림 그렸음");
            getResourceId();
        }
        public abstract void Draw(Graphics g, PictureBox p, int cardPos, Image image);

        /// <summary>
        /// Get the id of resource, to get each image to draw.
        /// </summary>
        /// <returns></returns>
        public abstract string getResourceId();
    }
}
