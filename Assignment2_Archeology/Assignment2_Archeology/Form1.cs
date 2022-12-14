using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;

namespace Assignment2_Archeology
{
    public partial class Form1 : Form
    {
        //The number of cards which players and trade center belongs to
        public static int PLAYER_SIZE = 4;
        public static int TRADE_SIZE = 5;
        public static int NUM_CARDS = 72;

        protected System.Resources.ResourceManager resource_manager;

        public static int cardIndex = 0;
        //System.Timers.Timer t;

        List<Card> deck_card = new List<Card>();
        List<Card> marketPlace = new List<Card>();
        List<Card> Listplayer1 = new List<Card>();
        List<Card> Listplayer2 = new List<Card>();

        public List<Card>[] MapCards = new List<Card>[3];
        List<Card> PyramidThree = new List<Card>();
        List<Card> PyramidFive = new List<Card>();
        List<Card> PyramidSeven = new List<Card>();

        private Card cards = null;

        Deck deck;
        Map map;

        bool trade = false;

        public Form1()
        {
            InitializeComponent();
            resource_manager = Properties.Resources.ResourceManager;
            deck = new Deck();
            pictureBoxPyramidCenter.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void GetAHand()
        {

            deck_card.Clear();
            marketPlace.Clear();
            Listplayer1.Clear();
            Listplayer2.Clear();


            //make new random card lists
            for (int i = 0; i < NUM_CARDS; i++)
            {
                Card card = deck.GetCard(i);
                //card.UnFlip();
                deck_card.Add(card);
                Console.WriteLine("deck_card[" + i + "] = " + deck_card[i]);
                cardIndex++;
            }
            //cards = new Map(6, 3, 3);
            //for(int i=1; i<=6; i++)
            //{
            //    cards = deck.GetCard(i);
            //    deck_card.Add(cards);
            //    Console.WriteLine("Mapcard: [" + i + "] = " + deck_card[i]);
            //    cardIndex++;
            //}

            deck.ShuffleCards();
        }
        private void getRandomCards(Graphics graphics, List<Card> playerList, int CardSize, int cp, bool cardType)
        {
            Random rand = new Random();
            int CardPos = cp;
            int CARD_GAP = 90;

            //draw cards
            for (int i = 0; i < CardSize; i++)
            {
                int randNum = rand.Next(1, cardIndex);
                playerList.Add(deck_card[randNum]);
                Treasure c = (Treasure)playerList[i];
                deck_card.RemoveAt(randNum);
                cardIndex--;

                //If the card type is not for pyramid cards, then execute the code
                if (cardType)
                {
                    c.DrawCard(graphics, pictureBoxCenter, CardPos, c.Image);
                    CardPos += CARD_GAP;
                }
                labelLeftover.Text = cardIndex.ToString();
                Console.WriteLine(cardIndex.ToString());
            }

            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBoxCenter.CreateGraphics();
            Graphics p1 = pictureBoxPlayer1.CreateGraphics();
            Graphics p2 = pictureBoxPlayer2.CreateGraphics();
            Graphics p3 = pictureBoxMarketPlace.CreateGraphics();
            //t = new System.Timers.Timer();
            //t.Elapsed += OnTimedEvent;
            //t.Interval = 10;
            //t.Enabled = true;
            //t.Start();

            cardIndex = 0;
            GetAHand();
            getRandomCards(p1, Listplayer1,PLAYER_SIZE,10,true);
            getRandomCards(p2, Listplayer2, PLAYER_SIZE,10,true);
            getRandomCards(p3, marketPlace,5,10,true);
            getRandomCards(g, PyramidThree,3,10,false);
            labelPyramid1.Text = PyramidThree.Count.ToString();

            Console.WriteLine(marketPlace.ToString());

        }

        // Specify what you want to happen when the Elapsed event is raised.
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {

            Invoke(new Action(() => pictureBoxPlayer1.Refresh()));
            //Invoke(new Action(() => pictureBoxPlayer2.Refresh()));
            //Invoke(new Action(() => pictureBoxCenter.Refresh()));
        }

        private void pictureBoxPlayer1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void buttonDrawACard_Click(object sender, EventArgs e)
        {
            Graphics p1 = pictureBoxPlayer1.CreateGraphics();
            getRandomCards(p1, Listplayer1, 1,300,true);
        }

        private void buttonTrade_Click(object sender, EventArgs e)
        {
            //trade활성화
            trade = true;


        }


    }
}
