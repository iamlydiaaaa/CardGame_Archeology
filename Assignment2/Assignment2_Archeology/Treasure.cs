﻿using System;
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
        }



        public override void DrawCard(Graphics g, PictureBox p, int xpos, Image image)
        {
            int cardWidth = image.Width / 4;
            int cardHeight = image.Height / 4;
            //XPos = xpos;
            YPos = 10;

            g.DrawImage(image, xpos, YPos_, cardWidth, cardHeight);
            //XPos = XPos + cardWidth + 10;
            getResourceId();
        }


        public override string getResourceId()
        {
            return CardName_.ToString().ToLower();
        }
    }
}
