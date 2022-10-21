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
        public List<Card> cards_;
        public int cardIndex = 0;
        public Deck()
        {
            // Add cards to Cards list
            cards_ = new List<Card>();

            CreateCard(new Shard());
            CreateCard(new Scrap());
            CreateCard(new Talisman());
            CreateCard(new Coin());
            CreateCard(new Cup());
            CreateCard(new Mask());
        }

        /// <summary>
        /// It creates card to the list
        /// </summary>
        /// <param name="card"></param>
        public void CreateCard(Card card)
        {
            for(int i = 0; i < card.CardNum; i++)
            {
                cards_.Add(card);
                cardIndex++;
            }
        }

        /// <summary>
        /// It shuffles cards randomly
        /// </summary>
        public void ShuffleCards()
        {
            Random rnd = new Random();
            for(int i = 0; i < cards_.Count; i++)
            {
                int cardPos1 = rnd.Next(0, cards_.Count);
                int cardPos2 = rnd.Next(0, cards_.Count);

                SwapCards(cardPos1, cardPos2);
            }
        }

        /// <summary>
        /// get a card from cards_ list be in order
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Card GetCard(int i)
        {
            return cards_[i];
        }

        /// <summary>
        /// It swaps cards.
        /// </summary>
        /// <param name="cardPos1"></param>
        /// <param name="cardPos2"></param>
        public void SwapCards(int cardPos1, int cardPos2)
        {
            //카드 맞바꾸기
            Card tmp = cards_[cardPos1];
            cards_[cardPos1] = cards_[cardPos2];
            cards_[cardPos2] = tmp;
        }
    }
}
