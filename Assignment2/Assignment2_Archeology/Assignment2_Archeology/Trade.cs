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


        public bool Selected
        {
            get { return selected; }
            set { selected = value; }
        }
        public List<Card> ChooseCard(List<Card> temp)
        {
            //Console.WriteLine("누름 : " + mouseX_.ToString() + ", " + mouseY_.ToString());
            int index = 1;
            int add = 0;
            
            foreach (Card card in card_)
            {
                //Console.WriteLine(card.ToString() + ": " + card.XPos.ToString() + ", " + card.YPos.ToString());
                if (card.IsMouseOn(mouseX_, mouseY_, index))
                {
                    //trade.Selected = true;
                    //trade.tradeSum += card.TradeValue;
                    temp.Add(card);
                    Console.WriteLine(card.ToString() + " 성공, value: " + card.XPos.ToString() + ", " + card.YPos.ToString());
                    //Console.WriteLine("card.TradeValue = " + card.TradeValue.ToString());
                    tradeSum = card.TradeValue;
                    break;
                }
                index++;
            }
            return temp;
        }

        public int CalculateSum()
        {
            return tradeSum;
        }
    }
}
