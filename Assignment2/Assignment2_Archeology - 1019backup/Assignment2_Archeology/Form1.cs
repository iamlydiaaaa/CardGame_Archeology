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

        List<Card> Pyramid = new List<Card>();

        List<Card> PyramidThree = new List<Card>();
        List<Card> PyramidFive = new List<Card>();
        List<Card> PyramidSeven = new List<Card>();

        Deck deck;
        Trade trade;

        bool start = false;
        bool active = false;
        bool drawACard = false;
        bool tradeMode = true;

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
            Invalidate();

            //make new random card lists
            foreach (Card c in deck.cards_)
            {
                Card card = deck.GetCard(cardIndex);
                //card.UnFlip();
                deck_card.Add(card);
                //Console.WriteLine("deck_card[" + cardIndex + "] = " + c);
                cardIndex++;
            }
            deck.ShuffleCards();
        }
        private void getRandomCards(Graphics graphics, List<Card> playerList, int CardSize, bool cardType, bool drawACard)
        {
            Random rand = new Random();
            Card card ;
            int xpos = 10;
            int count = 0;
            if (drawACard) {
                count = playerList.Count - 1;
                xpos = playerList[count].XPos;
            }
            else { xpos = 10; }
            Console.WriteLine(playerList.Count.ToString() + "****현재 xpos: " + xpos.ToString()+", count: " + count.ToString());
            //draw cards
            for (int i = 0; i < CardSize; i++)
            {
                int randNum = rand.Next(1, cardIndex);
                playerList.Add(deck_card[randNum]);
                if (drawACard) { card = playerList[count + 1]; }
                else { card = playerList[i]; }
                deck_card.RemoveAt(randNum);
                cardIndex--;

                //If the card type is not for pyramid cards, then execute the code
                if (cardType)
                {
                    playerList[i].DrawCard(graphics, pictureBoxCenter, xpos, playerList[i].Image);
                   xpos += (playerList[i].Image.Width/4) +10;
                    playerList[i].XPos = xpos;
                }
                else
                {
                    labelPyramid1.Text = "3";
                }
                Console.WriteLine(cardIndex.ToString() + ". " + playerList[i].ToString());
                Console.WriteLine("XPos: " + playerList[i].XPos.ToString()+ " / YPos: " + playerList[i].YPos.ToString());
            }

            labelLeftover.Text = cardIndex.ToString();

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
            getRandomCards(p1, Listplayer1,PLAYER_SIZE,true,false);
            getRandomCards(p2, Listplayer2, PLAYER_SIZE,true, false);
            getRandomCards(p3, marketPlace,5,true, false);

            Console.WriteLine("Treasure Card added to the Pyramid");
            getRandomCards(g, PyramidThree, 3, false, false);
            getRandomCards(g, PyramidFive, 5, false, false);
            getRandomCards(g, PyramidSeven, 7, false, false);

            Console.WriteLine("Additional Card added to the Pyramid");
            addCardtoDeck(new Map());
            addCardtoDeck(new Thief());
            addCardtoDeck(new SandStorm());

            start = true;
            if (start)
            {
                buttonStart.Text = "RESTART";
                labelLeftover.Text = cardIndex.ToString();

            }
        }

        private void addCardtoDeck(Card c)
        {
            Console.WriteLine(c.CardName + "카드 deck에 추가");
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
                getRandomCards(p1, Listplayer1, 1, true,true);
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

            //trade활성화
            active = true;
        }

        private void buttonTrade_Click(object sender, EventArgs e)
        {
            if (active)
            {
                labelDescription.Text = "Trade Mode";
                tradeMode = true;
            }
            else
            {
                MessageBox.Show("Unavailable !");
            }
            //trade = new Trade(marketPlace);

        }


        private void pictureBoxPlayer1_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("누름 : " + e.X.ToString() + ", " + e.Y.ToString());

            if (tradeMode)
            {
                for(int i = 0; i < Listplayer1.Count; i++)
                {
                    Console.WriteLine(Listplayer1[i].ToString() + " , value: " +
                        Listplayer1[i].XPos.ToString() + ", " +
                        Listplayer1[i].YPos.ToString());

                }
/*                foreach (Card card in Listplayer1)
                {
                        Console.WriteLine(card.ToString() + " , value: " + card.XPos.ToString() + ", " + card.YPos.ToString());
                }*/
                //trade = new Trade(Listplayer1);
/*                foreach (Card card in Listplayer1)
                {
                    //Console.WriteLine(card.ToString() + ": " + card.XPos.ToString() + ", " + card.YPos.ToString());
                    if (card.IsMouseOn(e.X, e.Y))
                    {
                        //trade.Selected = true;
                        //trade.tradeSum += card.TradeValue;
                        Console.WriteLine(card.ToString() + " 성공, value: " + card.XPos.ToString() + ", " + card.YPos.ToString());
                       // Console.WriteLine(card.CardName + " 성공, value: " + card.TradeValue.ToString()+", TradeVal: "+card.TradeValue.ToString());
                        //break;
                    }
                    else
                    {
                        Console.WriteLine(card.ToString() + " 실패, value: " + card.XPos.ToString() + ", " + card.YPos.ToString());
                    }
                }*/
            }
            else
            {
                MessageBox.Show("Unavailable 2 !");
            }
        }

        private void Close()
        {
            Application.Exit();
        }
    }
}
