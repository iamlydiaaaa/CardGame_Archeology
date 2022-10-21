namespace Assignment2_Archeology
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxCenter = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer2 = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonDrawACard = new System.Windows.Forms.Button();
            this.labelLeftover = new System.Windows.Forms.Label();
            this.buttonTrade = new System.Windows.Forms.Button();
            this.buttonExplore = new System.Windows.Forms.Button();
            this.buttonMuseum = new System.Windows.Forms.Button();
            this.pictureBoxMarketPlace = new System.Windows.Forms.PictureBox();
            this.pictureBoxPyramidCenter = new System.Windows.Forms.PictureBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.listBoxPlayer1 = new System.Windows.Forms.ListBox();
            this.listBoxMarket = new System.Windows.Forms.ListBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonPassTurn = new System.Windows.Forms.Button();
            this.buttonPyramid1 = new System.Windows.Forms.Button();
            this.buttonPyramid2 = new System.Windows.Forms.Button();
            this.buttonPyramid3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelScore_1 = new System.Windows.Forms.Label();
            this.labelPlayerTurn = new System.Windows.Forms.Label();
            this.listBoxPlayer2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarketPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPyramidCenter)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCenter
            // 
            this.pictureBoxCenter.BackColor = System.Drawing.Color.Snow;
            this.pictureBoxCenter.Location = new System.Drawing.Point(12, 199);
            this.pictureBoxCenter.Name = "pictureBoxCenter";
            this.pictureBoxCenter.Size = new System.Drawing.Size(914, 300);
            this.pictureBoxCenter.TabIndex = 0;
            this.pictureBoxCenter.TabStop = false;
            // 
            // pictureBoxPlayer1
            // 
            this.pictureBoxPlayer1.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBoxPlayer1.Location = new System.Drawing.Point(12, 505);
            this.pictureBoxPlayer1.Name = "pictureBoxPlayer1";
            this.pictureBoxPlayer1.Size = new System.Drawing.Size(735, 175);
            this.pictureBoxPlayer1.TabIndex = 1;
            this.pictureBoxPlayer1.TabStop = false;
            this.pictureBoxPlayer1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPlayer1_MouseClick);
            // 
            // pictureBoxPlayer2
            // 
            this.pictureBoxPlayer2.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBoxPlayer2.Location = new System.Drawing.Point(12, 16);
            this.pictureBoxPlayer2.Name = "pictureBoxPlayer2";
            this.pictureBoxPlayer2.Size = new System.Drawing.Size(735, 177);
            this.pictureBoxPlayer2.TabIndex = 2;
            this.pictureBoxPlayer2.TabStop = false;
            this.pictureBoxPlayer2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPlayer2_MouseClick);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonStart.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonStart.Location = new System.Drawing.Point(1140, 317);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(156, 49);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonDrawACard
            // 
            this.buttonDrawACard.BackColor = System.Drawing.Color.Black;
            this.buttonDrawACard.BackgroundImage = global::Assignment2_Archeology.Properties.Resources.cardback;
            this.buttonDrawACard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDrawACard.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDrawACard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDrawACard.Location = new System.Drawing.Point(968, 310);
            this.buttonDrawACard.Name = "buttonDrawACard";
            this.buttonDrawACard.Size = new System.Drawing.Size(152, 249);
            this.buttonDrawACard.TabIndex = 4;
            this.buttonDrawACard.Text = "Draw A Card";
            this.buttonDrawACard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonDrawACard.UseVisualStyleBackColor = false;
            this.buttonDrawACard.Click += new System.EventHandler(this.buttonDrawACard_Click);
            // 
            // labelLeftover
            // 
            this.labelLeftover.AutoSize = true;
            this.labelLeftover.BackColor = System.Drawing.Color.Black;
            this.labelLeftover.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLeftover.ForeColor = System.Drawing.Color.White;
            this.labelLeftover.Location = new System.Drawing.Point(1014, 508);
            this.labelLeftover.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelLeftover.Name = "labelLeftover";
            this.labelLeftover.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.labelLeftover.Size = new System.Drawing.Size(61, 35);
            this.labelLeftover.TabIndex = 5;
            this.labelLeftover.Text = "72";
            this.labelLeftover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonTrade
            // 
            this.buttonTrade.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonTrade.Enabled = false;
            this.buttonTrade.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTrade.Location = new System.Drawing.Point(1150, 384);
            this.buttonTrade.Name = "buttonTrade";
            this.buttonTrade.Size = new System.Drawing.Size(133, 40);
            this.buttonTrade.TabIndex = 6;
            this.buttonTrade.Text = "Trade";
            this.buttonTrade.UseVisualStyleBackColor = false;
            this.buttonTrade.Click += new System.EventHandler(this.buttonTrade_Click);
            // 
            // buttonExplore
            // 
            this.buttonExplore.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonExplore.Enabled = false;
            this.buttonExplore.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExplore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExplore.Location = new System.Drawing.Point(1150, 427);
            this.buttonExplore.Name = "buttonExplore";
            this.buttonExplore.Size = new System.Drawing.Size(133, 40);
            this.buttonExplore.TabIndex = 7;
            this.buttonExplore.Text = "Explore";
            this.buttonExplore.UseVisualStyleBackColor = false;
            this.buttonExplore.Click += new System.EventHandler(this.buttonExplore_Click);
            // 
            // buttonMuseum
            // 
            this.buttonMuseum.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonMuseum.Enabled = false;
            this.buttonMuseum.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMuseum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMuseum.Location = new System.Drawing.Point(1150, 473);
            this.buttonMuseum.Name = "buttonMuseum";
            this.buttonMuseum.Size = new System.Drawing.Size(133, 40);
            this.buttonMuseum.TabIndex = 8;
            this.buttonMuseum.Text = "Museum";
            this.buttonMuseum.UseVisualStyleBackColor = false;
            this.buttonMuseum.Click += new System.EventHandler(this.buttonMuseum_Click);
            // 
            // pictureBoxMarketPlace
            // 
            this.pictureBoxMarketPlace.BackColor = System.Drawing.Color.Gray;
            this.pictureBoxMarketPlace.Location = new System.Drawing.Point(22, 223);
            this.pictureBoxMarketPlace.Name = "pictureBoxMarketPlace";
            this.pictureBoxMarketPlace.Size = new System.Drawing.Size(725, 223);
            this.pictureBoxMarketPlace.TabIndex = 9;
            this.pictureBoxMarketPlace.TabStop = false;
            this.pictureBoxMarketPlace.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMarketPlace_MouseClick);
            // 
            // pictureBoxPyramidCenter
            // 
            this.pictureBoxPyramidCenter.BackgroundImage = global::Assignment2_Archeology.Properties.Resources.pyramid;
            this.pictureBoxPyramidCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxPyramidCenter.Location = new System.Drawing.Point(1127, 27);
            this.pictureBoxPyramidCenter.Name = "pictureBoxPyramidCenter";
            this.pictureBoxPyramidCenter.Size = new System.Drawing.Size(156, 249);
            this.pictureBoxPyramidCenter.TabIndex = 10;
            this.pictureBoxPyramidCenter.TabStop = false;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Salmon;
            this.labelDescription.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(124, 451);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelDescription.Size = new System.Drawing.Size(129, 21);
            this.labelDescription.TabIndex = 13;
            this.labelDescription.Text = "Game Start";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxPlayer1
            // 
            this.listBoxPlayer1.FormattingEnabled = true;
            this.listBoxPlayer1.ItemHeight = 12;
            this.listBoxPlayer1.Location = new System.Drawing.Point(749, 508);
            this.listBoxPlayer1.Name = "listBoxPlayer1";
            this.listBoxPlayer1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxPlayer1.Size = new System.Drawing.Size(177, 172);
            this.listBoxPlayer1.TabIndex = 14;
            // 
            // listBoxMarket
            // 
            this.listBoxMarket.FormattingEnabled = true;
            this.listBoxMarket.ItemHeight = 12;
            this.listBoxMarket.Location = new System.Drawing.Point(749, 223);
            this.listBoxMarket.Name = "listBoxMarket";
            this.listBoxMarket.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxMarket.Size = new System.Drawing.Size(177, 220);
            this.listBoxMarket.TabIndex = 15;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonConfirm.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonConfirm.Location = new System.Drawing.Point(1140, 565);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(156, 60);
            this.buttonConfirm.TabIndex = 16;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.DimGray;
            this.buttonCancel.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(1150, 634);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(146, 35);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonPassTurn
            // 
            this.buttonPassTurn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonPassTurn.Enabled = false;
            this.buttonPassTurn.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPassTurn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPassTurn.Location = new System.Drawing.Point(1150, 519);
            this.buttonPassTurn.Name = "buttonPassTurn";
            this.buttonPassTurn.Size = new System.Drawing.Size(133, 40);
            this.buttonPassTurn.TabIndex = 18;
            this.buttonPassTurn.Text = "Pass -";
            this.buttonPassTurn.UseVisualStyleBackColor = false;
            this.buttonPassTurn.Click += new System.EventHandler(this.buttonPassTurn_Click);
            // 
            // buttonPyramid1
            // 
            this.buttonPyramid1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonPyramid1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPyramid1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPyramid1.Location = new System.Drawing.Point(1020, 27);
            this.buttonPyramid1.Name = "buttonPyramid1";
            this.buttonPyramid1.Size = new System.Drawing.Size(101, 83);
            this.buttonPyramid1.TabIndex = 20;
            this.buttonPyramid1.Text = "1 Map\r\n(3 Treasures)";
            this.buttonPyramid1.UseVisualStyleBackColor = false;
            this.buttonPyramid1.Click += new System.EventHandler(this.buttonPyramid1_Click);
            // 
            // buttonPyramid2
            // 
            this.buttonPyramid2.BackColor = System.Drawing.Color.Silver;
            this.buttonPyramid2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPyramid2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPyramid2.Location = new System.Drawing.Point(1020, 116);
            this.buttonPyramid2.Name = "buttonPyramid2";
            this.buttonPyramid2.Size = new System.Drawing.Size(101, 76);
            this.buttonPyramid2.TabIndex = 21;
            this.buttonPyramid2.Text = "2 Maps\r\n(5 Treasures)";
            this.buttonPyramid2.UseVisualStyleBackColor = false;
            this.buttonPyramid2.Click += new System.EventHandler(this.buttonPyramid2_Click);
            // 
            // buttonPyramid3
            // 
            this.buttonPyramid3.BackColor = System.Drawing.Color.Gold;
            this.buttonPyramid3.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPyramid3.ForeColor = System.Drawing.Color.Brown;
            this.buttonPyramid3.Location = new System.Drawing.Point(1020, 196);
            this.buttonPyramid3.Name = "buttonPyramid3";
            this.buttonPyramid3.Size = new System.Drawing.Size(101, 80);
            this.buttonPyramid3.TabIndex = 22;
            this.buttonPyramid3.Text = "3 Maps\r\n(7 Treasures)";
            this.buttonPyramid3.UseVisualStyleBackColor = false;
            this.buttonPyramid3.Click += new System.EventHandler(this.buttonPyramid3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 646);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Score: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelScore_1
            // 
            this.labelScore_1.AutoSize = true;
            this.labelScore_1.BackColor = System.Drawing.SystemColors.Info;
            this.labelScore_1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore_1.Location = new System.Drawing.Point(73, 646);
            this.labelScore_1.Name = "labelScore_1";
            this.labelScore_1.Size = new System.Drawing.Size(19, 23);
            this.labelScore_1.TabIndex = 24;
            this.labelScore_1.Text = "0";
            this.labelScore_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPlayerTurn
            // 
            this.labelPlayerTurn.AutoSize = true;
            this.labelPlayerTurn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPlayerTurn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerTurn.ForeColor = System.Drawing.Color.IndianRed;
            this.labelPlayerTurn.Location = new System.Drawing.Point(27, 450);
            this.labelPlayerTurn.Name = "labelPlayerTurn";
            this.labelPlayerTurn.Size = new System.Drawing.Size(92, 20);
            this.labelPlayerTurn.TabIndex = 25;
            this.labelPlayerTurn.Text = "PlayerTurn: 1";
            // 
            // listBoxPlayer2
            // 
            this.listBoxPlayer2.FormattingEnabled = true;
            this.listBoxPlayer2.ItemHeight = 12;
            this.listBoxPlayer2.Location = new System.Drawing.Point(749, 16);
            this.listBoxPlayer2.Name = "listBoxPlayer2";
            this.listBoxPlayer2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxPlayer2.Size = new System.Drawing.Size(177, 172);
            this.listBoxPlayer2.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(968, 579);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 32);
            this.label2.TabIndex = 27;
            this.label2.Text = "ID: 1573069\r\nName: Lydia Kim";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1332, 690);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxPlayer2);
            this.Controls.Add(this.labelPlayerTurn);
            this.Controls.Add(this.labelScore_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPyramid3);
            this.Controls.Add(this.buttonPyramid2);
            this.Controls.Add(this.buttonPyramid1);
            this.Controls.Add(this.buttonPassTurn);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.listBoxMarket);
            this.Controls.Add(this.listBoxPlayer1);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.pictureBoxPyramidCenter);
            this.Controls.Add(this.pictureBoxMarketPlace);
            this.Controls.Add(this.buttonMuseum);
            this.Controls.Add(this.buttonExplore);
            this.Controls.Add(this.buttonTrade);
            this.Controls.Add(this.labelLeftover);
            this.Controls.Add(this.buttonDrawACard);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBoxPlayer2);
            this.Controls.Add(this.pictureBoxPlayer1);
            this.Controls.Add(this.pictureBoxCenter);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarketPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPyramidCenter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCenter;
        private System.Windows.Forms.PictureBox pictureBoxPlayer1;
        private System.Windows.Forms.PictureBox pictureBoxPlayer2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonDrawACard;
        private System.Windows.Forms.Label labelLeftover;
        private System.Windows.Forms.Button buttonTrade;
        private System.Windows.Forms.Button buttonExplore;
        private System.Windows.Forms.Button buttonMuseum;
        private System.Windows.Forms.PictureBox pictureBoxMarketPlace;
        private System.Windows.Forms.PictureBox pictureBoxPyramidCenter;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.ListBox listBoxPlayer1;
        private System.Windows.Forms.ListBox listBoxMarket;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonPassTurn;
        private System.Windows.Forms.Button buttonPyramid1;
        private System.Windows.Forms.Button buttonPyramid2;
        private System.Windows.Forms.Button buttonPyramid3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelScore_1;
        private System.Windows.Forms.Label labelPlayerTurn;
        private System.Windows.Forms.ListBox listBoxPlayer2;
        private System.Windows.Forms.Label label2;
    }
}

