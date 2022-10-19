using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Assignment2_Archeology
{
    public class Thief : Card
    {
        public Thief()
        {
            CardName_ = "thief";
            CardNum_ = 8;
            string resource_id = getResourceId();
            image_ = (Image)re_manager.GetObject(resource_id);
        }
        public override string getResourceId()
        {
            Console.WriteLine("--" + CardName_ + ".cs_line32: 이 카드는 " + CardName_);
            return CardName_.ToString().ToLower();
        }
        public override void DrawCard(Graphics g, PictureBox p, int xpos, Image image)
        {
            int cardWidth = image.Width / 4;
            int cardHeight = image.Height / 4;
            int gap = 10;
            XPos = xpos;
            YPos = 10;

            int display_x_dim = p.Width; //그림의 가로세로값
            int display_y_dim = p.Height;

            g.DrawImage(image, XPos, YPos_, cardWidth, cardHeight);
            XPos = XPos + cardWidth + 10;
            getResourceId();
        }

        public override string ToString()
        {
            return CardName_;
        }
    }
    
}
