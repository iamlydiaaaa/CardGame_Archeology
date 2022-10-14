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
        public static int PLAYER_SIZE = 5;
        public static int TRADE_SIZE = 5;
        protected System.Resources.ResourceManager resource_manager;

        int cardIndex = 0;
        System.Timers.Timer t;

        List<Card> dealt_hand = new List<Card>();
        Deck deck;

        public Form1()
        {
            InitializeComponent();
            resource_manager = Properties.Resources.ResourceManager;
            deck = new Deck();
            GetAHand();
        }

        private void GetAHand()
        {
            dealt_hand.Clear();
            //deck.ShuffleCards();
            for(int i = 0; i < PLAYER_SIZE; i++)
            {
                Card card = deck.GetCard(i);
                //card.UnFlip();
                dealt_hand.Add(card);
                Console.WriteLine("GetAHand: " + card);
            }

        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Elapsed += OnTimedEvent;
            t.Interval = 10;
            t.Enabled = true;
            t.Start();

            cardIndex = 0;
            GetAHand();
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
            //deck.ShuffleCards();
            for (int i = 1; i < PLAYER_SIZE; i++)
            {
                Card card = deck.GetCard(i);
                //card.UnFlip();
                dealt_hand.Add(card);
                Console.WriteLine("GetAHand: " + dealt_hand[i]);
            }

            Graphics g = e.Graphics;
            for (int i = 1; i < PLAYER_SIZE; i++)
            {
                Card c = dealt_hand[i];
                Console.WriteLine("dealt_hand[i] = " + dealt_hand[i]);
                c.DrawCard(g, pictureBoxPlayer1, i);
            }

            if (cardIndex == PLAYER_SIZE) t.Stop();
            cardIndex++;
        }
    }
}
