using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Assignment2_Archeology
{
    public class Map : Card
    {
        public int MapCount = 6;
        public string name = "map";

        public Map()
        {
            string resource_id = getResourceId();
            image_ = (Image)re_manager.GetObject(name);
        }
        public Map(int cardNum, int sellingVal, int tradeVal, string cardName): base(cardNum,sellingVal,tradeVal, cardName)
        {
            string resource_id = getResourceId();
            image_ = (Image)re_manager.GetObject(resource_id);
            backImage_ = (Image)re_manager.GetObject("cardback");
            CardName_ = "map";
        }
        public Map(Map map)
        {
            CardName_ = map.CardName_;
            string resource_id = getResourceId();
            image_ = (Image)re_manager.GetObject(resource_id);
        }


        public override void Draw(Graphics g, PictureBox p, int cardPos, Image image)
        {

        }

        /// <summary>
        /// Get the id of resource, to get each image to draw.
        /// </summary>
        /// <returns></returns>
        public override string getResourceId()
        {
            Console.WriteLine(CardName_);
            return CardName_;
        }



        public override string ToString()
        {
            return CardName_;
        }
    }
}
