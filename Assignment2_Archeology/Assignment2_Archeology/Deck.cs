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
            int i = 0;
            int cardIndex = 0;
            

                    cards_ = new Card[Form1.NUM_CARDS];
                    foreach (TreasureCardValue value in Enum.GetValues(typeof(TreasureCardValue)))
                    {
                        for (int k = 0; k < array1[i]; k++)
                        {
                            cards_[cardIndex] = new Treasure(value);
                            cardIndex++;
                            Console.WriteLine("-- Deck.cs_line_33 :cards_[" + cardIndex + "] = " + cards_[cardIndex]);

                        }
                        i++;
                    }
                    for (int k = 0; k < 6; k++)
                    {
                        cards_[cardIndex] = new Map();
                        cardIndex++;
                        Console.WriteLine("-- Map.cs_line_33 :cards_[" + cardIndex + "] = " + cards_[cardIndex]);

                    }
            
            Console.WriteLine(cardIndex);
            

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
            foreach (Treasure card in cards_)
            {
                Debug.WriteLine(card);
            }
        }




    }
}
