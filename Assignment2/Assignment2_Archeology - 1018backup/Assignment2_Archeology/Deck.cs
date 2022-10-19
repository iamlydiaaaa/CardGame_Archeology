using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Assignment2_Archeology
{
    public class Deck
    {
        //public Card[] cards_;
        public List<Card> cards_;
        public int[] array1 = new int[] { 18, 16, 14, 8, 6, 4};
        public int cardIndex = 0;
        public Deck()
        {

            //Card[]에 카드 72개를 집어 넣는다.
            cards_ = new List<Card>();
            //cards_ = new Card[5];
            int i = 0;
            

            foreach (TreasureCardValue value in Enum.GetValues(typeof(TreasureCardValue)))
            {
                for(int k = 1; k <= array1[i]; k++)
                {
                    cards_.Add(new Treasure(value));

                    cardIndex++;
                }
                i++;
            }
/*            for (int k = 1; k <= 6; k++)
            {
                cards_[cardIndex] = new Map();

                cardIndex++;
            }*/
/*            for (int j = 0; j< cardIndex; j++)
            {
            Console.WriteLine("-- Deck.cs_line_33 :cards_[" + j + "] = " + cards_[j]);
            }*/
            //foreach(Card c in cards_)
            //{
            //    Console.WriteLine("-- Deck.cs_line_33 : = " + c);

            //}


            //ShuffleCards();
        }

        public void ShuffleCards()
        {
            Random rnd = new Random();
            for(int i = 0; i < cards_.Count; i++)
            {
                int cardPos1 = rnd.Next(0, cards_.Count);
                int cardPos2 = rnd.Next(0, cards_.Count);

                SwapCards(cardPos1, cardPos2);
            }

/*#if DETERMINISTIC //DEBUG
            Random random = new Random(20);
#else
            Random rnd = new Random();
#endif
            for (int i = 0; i < Card.NUM_CARDS; i++)
            {
                int cardPos1 = rnd.Next(0, Card.NUM_CARDS);
                int cardPos2 = rnd.Next(0, Card.NUM_CARDS);

                SwapCards(cardPos1, cardPos2);
            }*/
        }

        public Card GetCard(int i)
        {
            return cards_[i];
        }

        public void SwapCards(int cardPos1, int cardPos2)
        {
            //카드 맞바꾸기
            Card tmp = cards_[cardPos1];
            cards_[cardPos1] = cards_[cardPos2];
            cards_[cardPos2] = tmp;
        }
        public void WriteLineAllCards()
        {
            foreach (Treasure card in cards_)
            {
                Console.WriteLine(card);
            }
        }




    }
}
