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

        public List<Card>[] PyramidCards = new List<Card>[3];
        List<Card> PyramidThree = new List<Card>();
        List<Card> PyramidFive = new List<Card>();
        List<Card> PyramidSeven = new List<Card>();

        Deck deck;

        bool start = false;
        bool active = false;
        bool drawACard = false;

        public Form1()
        {
            InitializeComponent();
            resource_manager = Properties.Resources.ResourceManager;
            deck = new Deck();
            pictureBoxPyramidCenter.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void GetAHand()
        {
            //보물카드 초기화 후 새로 섞음
            deck_card.Clear();
            marketPlace.Clear();
            Listplayer1.Clear();
            Listplayer2.Clear();


            //make new random card lists
            foreach (Card c in deck.cards_)
            {
                Card card = deck.GetCard(cardIndex);
                //card.UnFlip();
                deck_card.Add(card);
                Console.WriteLine("deck_card[" + cardIndex + "] = " + c);
                cardIndex++;
            }
            deck.ShuffleCards();
        }
        private void getRandomCards(Graphics graphics, List<Card> playerList, int CardSize, bool cardType)
        {
            Random rand = new Random();
            int xpos = 10;

            //draw cards
            for (int i = 0; i < CardSize; i++)
            {
                int randNum = rand.Next(1, cardIndex);
                playerList.Add(deck_card[randNum]);
                Card c = playerList[i];
                deck_card.RemoveAt(randNum);
                cardIndex--;

                //If the card type is not for pyramid cards, then execute the code
                if (cardType)
                {
                    c.DrawCard(graphics, pictureBoxCenter, xpos, c.Image);
                   xpos += (c.Image.Width/4) +10;
                    c.XPos = xpos;
                }
                else
                {
                    labelPyramid1.Text = "3";
                }
                Console.WriteLine(cardIndex.ToString() + ". " + playerList[i]);
                Console.WriteLine(c.XPos + "의 위치: " + c.XPos.ToString());

            }

            labelLeftover.Text = cardIndex.ToString();

        }

        private void AddCards(Graphics graphics, List<Card> playerList, int CardSize, bool cardType)
        {
            Random rand = new Random();
            int count = playerList.Count -1;
            int xpos = playerList[count].XPos;
            foreach (Card card in playerList)
            {
                Console.WriteLine("ㅎㅎㅎㅎㅎㅎㅎㅎㅎㅎ" +card);
            }

            Console.WriteLine("***** " + xpos.ToString());

            //draw cards
            int randNum = rand.Next(1, cardIndex);
            playerList.Add(deck_card[randNum]);
            Card c = playerList[count+1];
            deck_card.RemoveAt(randNum);
            cardIndex--;

            //If the card type is not for pyramid cards, then execute the code
            c.DrawCard(graphics, pictureBoxCenter, xpos, c.Image);
            xpos += (c.Image.Width / 4) + 10;
            c.XPos = xpos;

            Console.WriteLine(cardIndex.ToString() + ". " + playerList[count + 1]);
            Console.WriteLine(c.XPos + "의 위치: " + c.XPos.ToString());

            labelLeftover.Text = cardIndex.ToString();
            foreach(Card card in playerList)
            {
                Console.WriteLine("이거는: " +card);
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

            //보물카드 새로 섞기
            cardIndex = 0;
            GetAHand();

            //섞은 보물카드 나눠주기
            Console.WriteLine("Players & MarketPlace added card");
            getRandomCards(p1, Listplayer1,PLAYER_SIZE,true);
            getRandomCards(p2, Listplayer2, PLAYER_SIZE,true);
            getRandomCards(p3, marketPlace,5,true);

            Console.WriteLine("Treasure Card added to the Pyramid");
            getRandomCards(g, PyramidThree, 3, false);
            getRandomCards(g, PyramidFive, 5, false);
            getRandomCards(g, PyramidSeven, 7, false);

            Console.WriteLine("Additional Card added to the Pyramid");
            addCardtoDeck(new Map());
            addCardtoDeck(new Thief());
            addCardtoDeck(new SandStorm());


            //foreach (Card card in deck_card)
            //{
            //    Console.WriteLine("Deck에 남은 카드: " + card + " / ");
            //}


            start = true;
            if (start)
            {
                buttonStart.Text = "RESTART";
                labelLeftover.Text = cardIndex.ToString();

            }
        }

        private void addCardtoDeck(Card c)
        {
            Console.Write(c.CardName + "카드 deck에 추가");
            for (int k = 1; k <= c.CardNum; k++)
            {
                //card.UnFlip();
                deck_card.Add(c);
                cardIndex++;
            }            
        }

        private void Action()
        {
            labelDescription.Text = "Choose Actions.";
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
            if (start)
            {
                Graphics p1 = pictureBoxPlayer1.CreateGraphics();
                AddCards(p1, Listplayer1, 1, true);
                active = true;
                if (active)
                {
                    Action();
                }
            }
            else
            {
                MessageBox.Show("Please start the game first.");
            }
        }

        private void buttonTrade_Click(object sender, EventArgs e)
        {
            //trade활성화
            active = true;


        }


    }
}
