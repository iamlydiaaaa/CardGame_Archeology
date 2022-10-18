using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Assignment2_Archeology
{
    public class Trade : Form1
    {
        public int tradeSum = 0;
        bool selected = false;
        public List<Card> card_;
        // left is the left-hand edge of the main part of the gate.
        // So the input pins are further left than left.
        public bool selected_;
        public int _left;

        // top is the top of the whole gate
        public int _top;

        public Trade(int left, int top)
        {
            _left = left;
            _top = top;
        }
        public int Left
        {
            get { return _left; }
        }

        /// <summary>
        /// Gets the top edge of the gate.
        /// </summary>
        public int Top
        {
            get { return _top; }
        }

        public bool Selected
        {
            get { return selected; }
            set { selected = value; }
        }

        public Trade()
        {
            Console.WriteLine("카드를 선택하시오");

            //1. Choose my card
            ChooseCard();
        }
        public Trade(int tradeSum, bool selected)
        {
            this.tradeSum = tradeSum;
            this.selected = selected;
        }
        public Trade(List<Card> cardList)
        {
            card_ = cardList;
        }

        public void ChooseCard()
        {

        }
    }
}
