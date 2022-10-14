using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Archeology
{
    public class Deck
    {
        protected Card[] cards_;

        public Deck()
        {
            //Card[]에 카드 72개를 집어 넣는다.
            //cards_ = new Card[Card.NUM_CARDS];
            cards_ = new Card[5];
            int i = 0;
            /*            for(int i=0; i<5; i++)
                        {
                            cards_[i] = new Card(CardFaceValue[i]);
                        }*/
            foreach (CardFaceValue val in Enum.GetValues(typeof(CardFaceValue)))
            {
                cards_[i] = new Card(val);
                //i++;
            }

            ShuffleCards();
        }

        public void ShuffleCards()
        {
        #if DETERMINISTIC //DEBUG
            Random random = new Random(72);
        #else
            Random rnd = new Random();
        #endif
            for(int i = 0; i < Card.NUM_CARDS; i++)
            {
                int cardPos1 = rnd.Next(0, Card.NUM_CARDS);
                int cardPos2 = rnd.Next(0, Card.NUM_CARDS);

                SwapCards(cardPos1, cardPos2);
            }
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





    }
}
