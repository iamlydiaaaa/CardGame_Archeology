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

        public bool playerTurn;

        List<Card> deck_card = new List<Card>();
        List<Card> marketPlace = new List<Card>();
        List<Card> Listplayer1 = new List<Card>();
        List<Card> Listplayer2 = new List<Card>();

        List<Card> Pyramid = new List<Card>();

        List<Card> PyramidThree = new List<Card>();
        List<Card> PyramidFive = new List<Card>();
        List<Card> PyramidSeven = new List<Card>();

        List<Card> tempList1 = new List<Card>();
        List<Card> tempList2 = new List<Card>();

        Deck deck;
        Trade trade;

        bool start = false;
        bool active = false;
        bool drawACard = false;
        bool tradePlayer = false;
        bool confirmTrade1 = false;
        bool confirmTrade2 = false;
        bool confirmTrade3 = false;
        bool tradeMarket = false;
        bool cancel = false;
        bool confirmExplore = false;

        public Form1()
        {
            InitializeComponent();
            resource_manager = Properties.Resources.ResourceManager;
            deck = new Deck();
            pictureBoxPyramidCenter.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        /// <summary>
        /// START버튼이나 reset버튼 누르면 생성하는 메소드. 카드를 새로 섞어서 나눠준다.
        /// </summary>
        private void GetAHand()
        {
                cardIndex = 0;
                //make new random card lists
                foreach (Card c in deck.cards_)
                {
                    Card card = deck.GetCard(cardIndex);
                    //card.UnFlip();
                    deck_card.Add(card);
                    cardIndex++;
                }
                deck.ShuffleCards();
        }

        /// <summary>
        /// 1. 카드를 랜덤으로 각각 리스트에 넣어준다.
        /// 2. 카드 덱에 리스트를 그린다.
        /// 3. 카드목록에 리스트를 추가한다.
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="playerList"></param>
        /// <param name="CardSize"></param>
        /// <param name="cardType"></param>
        /// <param name="add"></param>
        private void AddCards(Graphics graphics, List<Card> playerList, int CardSize, bool cardType, bool add)
        {
            int xpos = 10;
            Card c;

            Random rand = new Random();
            int count = playerList.Count - 1;
            //draw cards
            for (int i = 0; i < CardSize; i++)
            {
                //카드 리스트에 새로 추가하기
                int randNum = rand.Next(1, cardIndex);
                playerList.Add(deck_card[randNum]);

                //만약 기존에 있는 거에 추가하는 거면
                if (add) {
                    xpos = (count + 1) * 85 + 10;
                    c = playerList[count + 1];
                    c.XPos = xpos; // 85 * 현재 인덱스+1
                }
                //만약 처음 새로 리스트 만드는 거면
                else { 
                    c = playerList[i];
                    c.XPos = xpos;
                }
                deck_card.RemoveAt(randNum);
                cardIndex--;
                Console.WriteLine(cardIndex.ToString() + ". " + playerList[count + 1] + ". " + c.XPos.ToString());
            }
            DrawCards(graphics,  playerList, listBoxPlayer1, cardType, add);
            labelLeftover.Text = cardIndex.ToString();

        }

        /// <summary>
        /// 시작버튼
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

            //보물카드 새로 섞기
            GetAHand();

            //섞은 보물카드 나눠주기
            Console.WriteLine("Players & MarketPlace added card");
            AddCards(p1, Listplayer1,PLAYER_SIZE,true,false);

            AddCards(p2, Listplayer2, PLAYER_SIZE,true,false);
            AddCards(p3, marketPlace,5,true, false);

            Console.WriteLine("Treasure Card added to the Pyramid");
            AddCards(g, PyramidThree, 3, false, false);
            AddCards(g, PyramidFive, 5, false, false);
            AddCards(g, PyramidSeven, 7, false, false);

            //남은 덱에 특수카드 추가하기
            Console.WriteLine("Additional Card added to the Pyramid");
            addCardtoDeck(new Map());
            addCardtoDeck(new Thief());
            addCardtoDeck(new SandStorm());

            //listbox에 써넣기
            addToListBox(listBoxPlayer1, Listplayer1);
            addToListBox(listBoxMarket, marketPlace);

            //다음동작 실행
            labelDescription.Text = "Click Draw a card button.";
            start = true;
            if (start)
            {
                buttonStart.Text = "RESTART";
                labelLeftover.Text = cardIndex.ToString();
            }
        }

        /// <summary>
        /// listbox에 각각의 카드 써넣기
        /// </summary>
        /// <param name="listBox"></param>
        /// <param name="card_"></param>
        private void addToListBox(ListBox listBox, List<Card> card_)
        {
            listBox.Items.Clear();
            foreach (Card d in card_)
            {
                listBox.Items.Add(d);
            }
        }

        /// <summary>
        /// 특수 카드를 deck리스트에 추가
        /// </summary>
        /// <param name="c"></param>
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

        /// <summary>
        /// 카드 한 장 뽑아오기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDrawACard_Click(object sender, EventArgs e)
        {
            if (start)
            {
                Graphics p1 = pictureBoxPlayer1.CreateGraphics();
                AddCards(p1, Listplayer1, 1, true, true);
                Action();

            }
            else
            {
                MessageBox.Show("Please start the game first.");
            }
        }
        /// <summary>
        /// Action 기능을 활성화한다.
        /// </summary>
        private void Action()
        {
            labelDescription.Text = "Choose Actions: 1.Trade, 2.Explore, 3.Museum";
            active = true; //trade활성화
        }

        /// <summary>
        /// 1. Trade의 액션을 취한다. 가장 마지막에 active false 필수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTrade_Click(object sender, EventArgs e)
        {
            if (active)
            {
                labelDescription.Text = "Trade Mode: Choose cards from your cardList to change.";
                tradePlayer = true;
            }
            else
            {
                MessageBox.Show("Unavailable !");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cardslist"></param>
        /// <param name="temp"></param>
        /// <param name="list"></param>
        /// <param name="order"></param>
        /// <param name="e"></param>
        private void TradeAction
            (List<Card> Cardslist, List<Card> temp, ListBox list, 
             bool order, MouseEventArgs e)
        {
            int mouseX = e.X;
            int mouseY = e.Y;
            
            if (order)
            {
                trade = new Trade(Cardslist, mouseX, mouseY);
                trade.ChooseCard(temp);
                list.Items.Add(trade.ToString());
                labelDescription.Text = "1.Click Confirm button to confirm change";
                //tradeSum += trade.CalculateSum();
                //Console.WriteLine("ㅠㅠ---" + tradeSum.ToString());
            }
            else
            {
                MessageBox.Show("Unavailable 2 !");
            }
        }

        /// <summary>
        /// 카드 선택할 때 수행하는 동작들 모두 컨트롤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxPlayer1_MouseClick(object sender, MouseEventArgs e)
        {
            TradeAction(Listplayer1, tempList1, listBoxPlayer1,  tradePlayer, e);
            if (tradePlayer) confirmTrade1 = true;
        }
        private void pictureBoxMarketPlace_MouseClick(object sender, MouseEventArgs e)
        {
            //int tradeSum_2 = 0;

            TradeAction(marketPlace, tempList2, listBoxMarket, tradeMarket, e);
            if (tradeMarket) confirmTrade2 = true;
        }        

        
        private void DrawCards(Graphics graphics, List<Card> playerList, ListBox listBox, bool cardType, bool add)
        {
            int xpos = 10;
            foreach (Card c in playerList)
            {
                //카드 덱에 그리기
                if (cardType)
                {
                    c.DrawCard(graphics, pictureBoxCenter, xpos, c.Image);
                    addToListBox(listBox, playerList);
                }
                else
                //If the card type is for pyramid cards, then execute the code
                {
                    labelPyramid1.Text = "3";
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
            if (confirmTrade1) {
                //마켓에서 카드 한장 고르는 버튼 활성화
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
                //교환 가능한지 확인하기

                //교환하기
                foreach (Card c in tempList1)
                {
                    marketPlace.Add(c);
                    Listplayer1.Remove(c);
                }
                foreach (Card c in tempList2)
                {
                    Listplayer1.Add(c);
                    marketPlace.Remove(c);
                }
                Cancel();
                confirmTrade3 = false;
                labelDescription.Text = "Exchange successed !";
            }

            //2. EXPLORE Mode
            if (confirmExplore)
            {

                    labelDescription.Text = "You choosed " + listBoxPyramids.SelectedItem;

                confirmExplore = !confirmExplore;
            }
            Console.WriteLine(labelDescription.Text);

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
            tempList1.Clear();
            tempList2.Clear();
            pictureBoxPlayer1.Refresh();
            pictureBoxMarketPlace.Refresh();
            listBoxMarket.Items.Clear();
            listBoxPlayer1.Items.Clear();

            Graphics p1 = pictureBoxPlayer1.CreateGraphics();
            //Graphics p2 = pictureBoxPlayer2.CreateGraphics();
            Graphics p3 = pictureBoxMarketPlace.CreateGraphics();
            DrawCards(p1, Listplayer1, listBoxPlayer1, true, false);
            DrawCards(p3, marketPlace, listBoxMarket, true, false);

            if (cancel)
            {
                cancel = false;
                Action();
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

            listBoxPlayer1.Items.Clear();
            listBoxMarket.Items.Clear();
            pictureBoxPlayer1.Refresh();
            pictureBoxMarketPlace.Refresh();

        }

        /// <summary>
        /// Alters the player turn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPassTurn_Click(object sender, EventArgs e)
        {
            playerTurn = !playerTurn;
        }

        private void buttonExplore_Click(object sender, EventArgs e)
        {
            int hasMapCard = 0;
            //this only executes when player has at least one map card
            foreach(Card c in Listplayer1)
            {
                if (c is Map) hasMapCard ++;
            }
            labelDescription.Text = "You have " + hasMapCard.ToString() + "of Map cards.";
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

            //1.임시 카드리스트 생성 : tempList1;
            //2.카드 선택
            //while (confirm == true)
            //                만약(index = 0 || 선택한거.equals(list[0]) 이면
            //                선택한카드 리스트에 add
            while (true)
            {
                //if()
            }
            //else 에러!
            //—
            //price = list[0]의 sellingValue[list개수]
            //
            //플레이어점수 += price
        }
    }
}
