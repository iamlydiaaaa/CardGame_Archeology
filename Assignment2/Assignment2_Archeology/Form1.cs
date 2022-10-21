using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment2_Archeology
{
    // Name: Lydia Kim
    // ID: 1573069

    //I have made:
    //1. shuffle cards and deal cards
    //2. trade card (couldn't wrote code of calculating trade value)
    //3. explore pyramid
    //4. selling museum -> not available
    //5. restart the game
    //6. cancel action

    public partial class Form1 : Form
    {
        //The number of cards which players and trade center belongs to
        public static int PLAYER_SIZE = 4;
        public static int TRADE_SIZE = 5;
        public static int NUM_CARDS = 72;

        protected System.Resources.ResourceManager resource_manager;

        public static int cardIndex = 0;

        public bool playerTurn = true;

        List<Card> deck_card = new List<Card>();
        List<Card> marketPlace = new List<Card>();
        List<Card> Listplayer1 = new List<Card>();
        List<Card> Listplayer2 = new List<Card>();

        List<Card> PyramidThree = new List<Card>();
        List<Card> PyramidFive = new List<Card>();
        List<Card> PyramidSeven = new List<Card>();

        List<Card> tempList1 = new List<Card>();
        List<Card> tempList2 = new List<Card>();

        Deck deck;
        Trade trade;

        bool start = false;
        bool drawACard = false;

        bool confirmTrade1 = false;
        bool confirmTrade2 = false;
        bool confirmTrade3 = false;
        bool confirmExplore = false;
        bool tradeMode = false;
        bool tradePlayer = false;
        bool tradeMarket = false;
        bool cancel = false;
        bool sellMode = false;

        public int hasMapCard;
        public int idx = 1;

        public Form1()
        {
            InitializeComponent();
            resource_manager = Properties.Resources.ResourceManager;
            deck = new Deck();
            pictureBoxPyramidCenter.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        /// <summary>
        /// A method which gets card and shuffles card to start the game
        /// </summary>
        private void GetAHand()
        {
            cardIndex = 0;
            //make new random card lists
            foreach (Card c in deck.cards_)
            {
                Card card = deck.GetCard(cardIndex);
                deck_card.Add(card);
                cardIndex++;
            }
            deck.ShuffleCards();
        }

        /// <summary>
        /// 1. Deal random cards to each lists
        /// 2. Draw each list of cards to deck
        /// 3. Add each list of cards to the listbox
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="playerList"></param>
        /// <param name="CardSize"></param>
        /// <param name="cardType"></param>
        /// <param name="add"></param>
        private void AddCards(Graphics graphics, List<Card> playerList, int CardSize, bool cardType, bool add)
        {
            int xpos = 10;
            int randNum;
            Card c;

            Random rand = new Random();
            int count = playerList.Count - 1;

            //add new cards
            for (int i = 0; i < CardSize; i++)
            {
                if (cardIndex != 1)
                {
                   randNum = rand.Next(1, cardIndex);
                }
                else { randNum = 0; }
                
                playerList.Add(deck_card[randNum]);

                //IF adding card to the exsisting card lists
                if (add)
                {
                    c = playerList[count + 1];
                }
                //ELSE IF adding card to new card lists
                else
                {
                    c = playerList[i];
                }
                c.XPos = xpos;

                deck_card.RemoveAt(randNum);
                cardIndex--;
                Console.WriteLine(cardIndex.ToString() + ". " + playerList[count + 1] + ". " + c.XPos.ToString());

            }
            if(playerTurn) DrawCards(graphics, playerList, listBoxPlayer1, cardType);
            else DrawCards(graphics, playerList, listBoxPlayer2, cardType);
            labelLeftover.Text = cardIndex.ToString();
        }

        /// <summary>
        /// Start & Restart button which refreshes the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            Restart();
            Graphics g = pictureBoxCenter.CreateGraphics();
            Graphics p1 = pictureBoxPlayer1.CreateGraphics();
            Graphics p2 = pictureBoxPlayer2.CreateGraphics();
            Graphics p3 = pictureBoxMarketPlace.CreateGraphics();

            //Shuffle cards
            GetAHand();

            //Deal cards to players and to market place
            Console.WriteLine("Players & MarketPlace added card");
            AddCards(p1, Listplayer1, PLAYER_SIZE, true, false);
            AddCards(p2, Listplayer2, PLAYER_SIZE, true, false);
            AddCards(p3, marketPlace, 5, true, false);

            //Deal cards to 3 pyramids
            Console.WriteLine("Treasure Card added to the Pyramid");
            AddCards(g, PyramidThree, 3, false, false);
            AddCards(g, PyramidFive, 5, false, false);
            AddCards(g, PyramidSeven, 7, false, false);

            //Add special cards to deck
            Console.WriteLine("Additional Card added to the Pyramid");
            addCardtoDeck(new Map());
            addCardtoDeck(new Thief());
            addCardtoDeck(new SandStorm());

            //Add each card lists to the listbox
            addToListBox(listBoxPlayer1, Listplayer1);
            addToListBox(listBoxPlayer2, Listplayer2);
            addToListBox(listBoxMarket, marketPlace);

            //Begin next action
            labelDescription.Text = "Click Draw a card button.";
            start = true;
            drawACard = true;
            if (start)
            {
                buttonStart.Text = "RESTART";
                labelLeftover.Text = cardIndex.ToString();
            }
        }

        /// <summary>
        /// Add each card lists to the listbox
        /// </summary>
        /// <param name="listBox"></param>
        /// <param name="card_"></param>
        private void addToListBox(ListBox listBox, List<Card> card_)
        {
            listBox.Items.Clear();
            listBox.Items.Add("[Card]".PadRight(10) + "Trade".PadRight(10) + "Selling_Val");
            foreach (Card d in card_)
            {
                listBox.Items.Add(d);
            }
        }

        /// <summary>
        /// Add special cards to deck
        /// </summary>
        /// <param name="c"></param>
        private void addCardtoDeck(Card c)
        {
            for (int k = 1; k <= c.CardNum; k++)
            {
                deck_card.Add(c);
                cardIndex++;
            }
        }

        /// <summary>
        /// It draws "one" card and leads to next step -> action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDrawACard_Click(object sender, EventArgs e)
        {
            //The game continues until the cardIndex is 0
            if (cardIndex != 0)
            {
                if (drawACard)
                {
                    drawACard = false;
                    if (playerTurn)
                    {
                        Graphics p1 = pictureBoxPlayer1.CreateGraphics();
                        AddCards(p1, Listplayer1, 1, true, true);
                    }
                    else
                    {
                        Graphics p2 = pictureBoxPlayer2.CreateGraphics();
                        AddCards(p2, Listplayer2, 1, true, true);
                    }
                    
                    ActivateButtons();
                }
                else
                {
                    MessageBox.Show("Unavailable!");
                }
            }
            else
            {
                MessageBox.Show("No more Card.");
                buttonDrawACard.Enabled = false;
            }
        }
        /// <summary>
        /// Activate the action buttons
        /// </summary>
        private void ActivateButtons()
        {
            labelDescription.Text = "Choose Actions: 1.Trade, 2.Explore, 3.Museum 4. Pass";
            buttonTrade.Enabled = true;
            buttonExplore.Enabled = true;
            buttonMuseum.Enabled = true;
            buttonPassTurn.Enabled = true;
        }

        /// <summary>
        /// Deactivate the action buttons
        /// </summary>
        private void DeActivateButtons()
        {
            buttonTrade.Enabled = false;
            buttonExplore.Enabled = false;
            buttonMuseum.Enabled = false;
            buttonPassTurn.Enabled = false;
        }

        /// <summary>
        /// 1. Trade mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTrade_Click(object sender, EventArgs e)
        {
            labelDescription.Text = "Trade Mode: Choose cards from your cardList to change.";
            DeActivateButtons();
            tradeMode = true;
            tradePlayer = true;
        }

        /// <summary>
        /// 2. It deals Trade actions
        /// </summary>
        /// <param name="Cardslist"></param>
        /// <param name="temp"></param>
        /// <param name="list"></param>
        /// <param name="order"></param>
        /// <param name="e"></param>
        private void TradeAction(List<Card> Cardslist, List<Card> temp, 
             bool order, MouseEventArgs e)
        {
            int mouseX = e.X;
            int mouseY = e.Y;

            if (tradePlayer) confirmTrade1 = true;

            if (tradeMode)
            {
                
                if (order)
                {
                    trade = new Trade(Cardslist, mouseX, mouseY);
                    trade.ChooseCard(temp);
                    labelDescription.Text = "1.Click Confirm button to confirm change";
                }
                else
                {
                    MessageBox.Show("Unavailable 2 !");
                }

                for (int i = 0; i < tempList1.Count; i++)
                {
                    Console.Write("----" + tempList1[i]);
                }
            }
            else if (sellMode)
            {
                SellMuseum(Listplayer1, tempList1, listBoxPlayer1, sellMode, e);
            }

            
        }

        /// <summary>
        /// It deals the Museum action 
        /// </summary>
        /// <param name="Cardslist"></param>
        /// <param name="temp"></param>
        /// <param name="list"></param>
        /// <param name="order"></param>
        /// <param name="e"></param>
        private void SellMuseum(List<Card> Cardslist, List<Card> temp, ListBox list,
             bool order, MouseEventArgs e)
        {
            int mouseX = e.X;
            int mouseY = e.Y;

            if (order)
            {
                trade = new Trade(Cardslist, mouseX, mouseY);
                foreach (Card card in Cardslist)
                {
                    if (card.IsMouseOn(mouseX, mouseY, idx))
                    {
                        Console.WriteLine(card);
                        if (idx == 1)
                        {

                        }
                        else if (idx >= 2 && temp[0].CardName.Equals(card.CardName))
                        {

                        }
                        else
                        {
                            MessageBox.Show("Only Available to choose same card!");
                        }
                        trade.Selected = true;
                        trade.tradeSum += card.TradeValue;

                    }

                }

                list.Items.Add(trade.ToString());
            }
            else
            {
                MessageBox.Show("Unavailable !");
            }
        }

        /// <summary>
        /// It controls all actions when the user clicks the player_1's picture box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxPlayer1_MouseClick(object sender, MouseEventArgs e)
        {
            TradeAction(Listplayer1, tempList1, true, e);
        }

        /// <summary>
        /// It controls all actions when the user clicks the player_2's picture box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxPlayer2_MouseClick(object sender, MouseEventArgs e)
        {
            TradeAction(Listplayer2, tempList1, true, e);
        }

        /// <summary>
        /// It controls all actions when the user clicks the MarketPlace's picture box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxMarketPlace_MouseClick(object sender, MouseEventArgs e)
        {
            TradeAction(marketPlace, tempList2, tradeMarket, e);
            if (tradeMarket) confirmTrade2 = true;
        }


        /// <summary>
        /// It draws the card image to the each player's and marketplace's picture boxes.
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="playerList"></param>
        /// <param name="listBox"></param>
        /// <param name="cardType"></param>
        /// <param name="add"></param>
        private void DrawCards(Graphics graphics, List<Card> playerList, ListBox listBox, bool cardType)
        {
            int xpos = 10;
            foreach (Card c in playerList)
            {
                if (cardType)
                {
                    c.DrawCard(graphics, pictureBoxCenter, xpos, c.Image);
                    addToListBox(listBox, playerList);
                }
                xpos += (c.Image.Width / 4) + 10;
            }
        }

        /// <summary>
        /// Confirm button which controls many actions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            //1. Trade Mode
            //1-1  IF player choosed cards from own cardList and clicked 'Confirm' then 
            if (confirmTrade1)
            {
                tradePlayer = false;
                tradeMarket = true;
                confirmTrade1 = false;
                labelDescription.Text = "Choose cards From market";
            }

            //1-2  IF player choosed cards from MarketList and clicked 'Confirm' then 
            if (confirmTrade2)
            {
                tradeMarket = false;
                confirmTrade3 = true;
                confirmTrade2 = false;
                labelDescription.Text = "Click Confirm button to exchange";
            }
            //1-3 EXCHANGE Cards, AND finish the trade mode.
            if (confirmTrade3)
            {
                //Exchange cards
                foreach (Card c in tempList1)
                {
                    marketPlace.Add(c);
                    Listplayer1.Remove(c);
                    Console.WriteLine("tempList1: " +c);
                }
                foreach (Card c in tempList2)
                {
                    if(playerTurn) Listplayer1.Add(c);
                    else Listplayer2.Add(c);
                    marketPlace.Remove(c);
                    Console.WriteLine("tempList2: " +c);

                }
                Cancel();
                confirmTrade3 = false;
                labelDescription.Text = "Exchange successed !";
                changeTurn();
            }

            Console.WriteLine(labelDescription.Text);

        }

        /// <summary>
        /// Explore Pyramid action.
        /// </summary>
        private void ExplorePyramid(List<Card> pyramid, List<Card> player, int pyramidNum, Button btn)
        {
            //2. EXPLORE Mode

            labelDescription.Text = "You choosed " + btn.Text;
            if (confirmExplore)
            {
                if (pyramidNum <= hasMapCard)
                {
                    //Firstly, remove map card from player's deck
                    for (int i = 0; i < pyramidNum; i++)
                    {
                        foreach (Card c in player)
                        {
                            if (c.CardName.Equals("map"))
                            {
                                player.Remove(c);
                                break;
                            }
                        }
                    }

                    //Then, add cards from selected Pyramid dummy to player's deck
                    for (int i = 0; i < pyramid.Count; i++)
                    {
                        player.Add(pyramid[i]);
                    }
                    //Redraw cards and lists
                    Cancel();

                    //Remove that pyramid
                    pyramid.Clear();
                    //no more use for the button.
                    btn.Enabled = false;

                    confirmExplore = false;

                    labelDescription.Text = "Successed to explore the Pyramid!";

                    // Lastly, change turn
                    changeTurn();
                }
                else
                {
                    MessageBox.Show("You don't have enough card. Choose another dummy.");
                }
            }
            else
            {
                MessageBox.Show("Unavailable");
            }
        }

        private void changeTurn()
        {
            drawACard = true;
            playerTurn = !playerTurn;

            if (playerTurn) labelPlayerTurn.Text = "PlayerTurn: 1";
            else labelPlayerTurn.Text = "PlayerTurn: 2";
        }


        /// <summary>
        /// Explore pyramid button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExplore_Click(object sender, EventArgs e)
        {
            DeActivateButtons();
            if(playerTurn) HasMapCard(Listplayer1);
            else HasMapCard(Listplayer2);
        }

        private void HasMapCard(List<Card> player)
        {
            hasMapCard = 0;
            //this only executes when player has at least one map card
            foreach (Card c in player)
            {
                if (c is Map) hasMapCard++;
            }
            labelDescription.Text = "You have " + hasMapCard.ToString() + "of Map cards.\n Choose one in the list and click confirm button.";
            if (hasMapCard >= 1) confirmExplore = true;
            else { MessageBox.Show("You don't have enough map card to explore."); }
        }

        /// <summary>
        /// Sell treasures to the museum
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMuseum_Click(object sender, EventArgs e)
        {
            DeActivateButtons();
            labelDescription.Text = "Choose cards to sell.";
            sellMode = true;
        }


        private void buttonPyramid1_Click(object sender, EventArgs e)
        {
            if(playerTurn) ExplorePyramid(PyramidThree,Listplayer1, 1, buttonPyramid1);
            else ExplorePyramid(PyramidThree,Listplayer2, 1, buttonPyramid1);
        }

        private void buttonPyramid2_Click(object sender, EventArgs e)
        {
            if (playerTurn) ExplorePyramid(PyramidFive, Listplayer1, 2, buttonPyramid2);
            else ExplorePyramid(PyramidFive, Listplayer2, 2, buttonPyramid2);
        }

        private void buttonPyramid3_Click(object sender, EventArgs e)
        {
            if (playerTurn) ExplorePyramid(PyramidSeven, Listplayer1, 3, buttonPyramid3);
            else ExplorePyramid(PyramidSeven, Listplayer2, 3, buttonPyramid3);
        }


        /// <summary>
        /// Alters the player turn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPassTurn_Click(object sender, EventArgs e)
        {
            DeActivateButtons();
            changeTurn();
            
        }


        /// <summary>
        /// It cancels actions and returns to choose action mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            cancel = true;
            Cancel();
        }

        /// <summary>
        /// It cancels actions and returns to choose action mode
        /// </summary>
        private void Cancel()
        {
            confirmTrade1 = false;
            confirmTrade2 = false;

            pictureBoxPlayer1.Refresh();
            pictureBoxPlayer2.Refresh();
            pictureBoxMarketPlace.Refresh();
            listBoxMarket.Items.Clear();
            listBoxPlayer1.Items.Clear();
            listBoxPlayer2.Items.Clear();

            Graphics p1 = pictureBoxPlayer1.CreateGraphics();
            Graphics p2 = pictureBoxPlayer2.CreateGraphics();
            Graphics p3 = pictureBoxMarketPlace.CreateGraphics();
            DrawCards(p1, Listplayer1, listBoxPlayer1, true);
            DrawCards(p2, Listplayer2, listBoxPlayer2, true);
            DrawCards(p3, marketPlace, listBoxMarket, true);
            tempList1.Clear();
            tempList2.Clear();
            if (cancel)
            {
                cancel = false;
                ActivateButtons();
            }
        }

        /// <summary>
        /// Restarts the game which resets everything
        /// This method will Initialize the cards, and shuffle cards
        /// </summary>
        private void Restart()
        {
            deck_card.Clear();
            marketPlace.Clear();
            Listplayer1.Clear();
            Listplayer2.Clear();
            PyramidThree.Clear();
            PyramidFive.Clear();
            PyramidSeven.Clear();

            listBoxPlayer1.Items.Clear();
            listBoxPlayer2.Items.Clear();
            listBoxMarket.Items.Clear();
            pictureBoxPlayer1.Refresh();
            pictureBoxPlayer2.Refresh();
            pictureBoxMarketPlace.Refresh();

            buttonPyramid1.Enabled = true;
            buttonPyramid2.Enabled = true;
            buttonPyramid3.Enabled = true;
        }


    }
}
