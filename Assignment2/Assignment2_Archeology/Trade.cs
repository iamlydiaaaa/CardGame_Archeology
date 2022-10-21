using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Assignment2_Archeology
{
    public class Trade 
    {
        public int tradeSum = 0;
        bool selected = false;
        public List<Card> card_;

        public bool selected_;
        public int mouseX_;
        public int mouseY_;

        public Trade()
        {
            Console.WriteLine("[TRADE Mode] Choose Cards.");

        }
        public Trade(int tradeSum, bool selected)
        {
            this.tradeSum = tradeSum;
            this.selected = selected;
        }
        public Trade(List<Card> cardList, int mouseX, int mouseY)
        {
            card_ = cardList;
            this.mouseX_ = mouseX;
            this.mouseY_ = mouseY;
        }


        /// <summary>
        /// It checks if the card is selected
        /// </summary>
        public bool Selected
        {
            get { return selected; }
            set { selected = value; }
        }

        /// <summary>
        /// It adds the card which the user selected to the tempList
        /// </summary>
        /// <param name="temp"></param>
        /// <returns>the information of card  that user selected</returns>
        public List<Card> ChooseCard(List<Card> temp)
        {
            int index = 1;
            
            foreach (Card card in card_)
            {
                if (card.IsMouseOn(mouseX_, mouseY_, index))
                {
                    //trade.Selected = true;
                    //trade.tradeSum += card.TradeValue;
                    temp.Add(card);
                    Console.WriteLine(card.ToString() + " Success, value: " + card.XPos.ToString() + ", " + card.YPos.ToString());
                    tradeSum = card.TradeValue;
                    break;
                }
                index++;
            }
            return temp;
        }

        /// <summary>
        /// It calculates the sum of the trade value
        /// </summary>
        /// <returns></returns>
        public int CalculateSum()
        {
            return tradeSum;
        }

        public override string ToString()
        {
            return "Sum: " + tradeSum.ToString();
        }
    }
}
