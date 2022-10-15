using System;
using System.Diagnostics;

namespace Assignment2_Archeology
{
    public class Deck
    {
        public Card[] cards_;
        public int[] array1 = new int[] { 18, 16, 14, 8, 6, 4};
        public Deck()
        {

            //Card[]에 카드 72개를 집어 넣는다.
            cards_ = new Card[Form1.NUM_CARDS];
            //cards_ = new Card[5];
            int i = 1;
            int cardIndex = 1;
            

            foreach (TreasureCardValue value in Enum.GetValues(typeof(TreasureCardValue)))
            {
                for(int k = 1; k <= array1[i-1]; k++)
                {
                    cards_[cardIndex] = new Card(value);
                    /*Console.WriteLine("cards_["+ cardIndex + "] = " + cards_[cardIndex]);
                    Console.WriteLine(k + ". " + value + "입니다아");*/
                cardIndex++;
                }
            i++;
            }
            for(int j = 1; j< cardIndex; j++)
            {
            Console.WriteLine("cards_[" + j + "] = " + cards_[j]);
            }


            //ShuffleCards();
        }

        public void ShuffleCards()
        {
            Random rnd = new Random();
            for(int i = 0; i < Form1.NUM_CARDS; i++)
            {
                int cardPos1 = rnd.Next(0, Form1.NUM_CARDS);
                int cardPos2 = rnd.Next(0, Form1.NUM_CARDS);

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
            foreach (Card card in cards_)
            {
                Debug.WriteLine(card);
            }
        }




    }
}
