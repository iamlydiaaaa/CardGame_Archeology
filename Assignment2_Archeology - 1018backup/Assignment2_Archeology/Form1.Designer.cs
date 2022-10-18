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
            this.labelPyramid1 = new System.Windows.Forms.Label();
            this.pictureBoxpyramid = new System.Windows.Forms.PictureBox();
            this.labelDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarketPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPyramidCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxpyramid)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCenter
            // 
            this.pictureBoxCenter.BackColor = System.Drawing.Color.Snow;
            this.pictureBoxCenter.Location = new System.Drawing.Point(12, 171);
            this.pictureBoxCenter.Name = "pictureBoxCenter";
            this.pictureBoxCenter.Size = new System.Drawing.Size(1094, 353);
            this.pictureBoxCenter.TabIndex = 0;
            this.pictureBoxCenter.TabStop = false;
            // 
            // pictureBoxPlayer1
            // 
            this.pictureBoxPlayer1.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBoxPlayer1.Location = new System.Drawing.Point(12, 542);
            this.pictureBoxPlayer1.Name = "pictureBoxPlayer1";
            this.pictureBoxPlayer1.Size = new System.Drawing.Size(640, 138);
            this.pictureBoxPlayer1.TabIndex = 1;
            this.pictureBoxPlayer1.TabStop = false;
            this.pictureBoxPlayer1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxPlayer1_Paint);
            // 
            // pictureBoxPlayer2
            // 
            this.pictureBoxPlayer2.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBoxPlayer2.Location = new System.Drawing.Point(12, 16);
            this.pictureBoxPlayer2.Name = "pictureBoxPlayer2";
            this.pictureBoxPlayer2.Size = new System.Drawing.Size(640, 135);
            this.pictureBoxPlayer2.TabIndex = 2;
            this.pictureBoxPlayer2.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonStart.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonStart.Location = new System.Drawing.Point(672, 530);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(133, 43);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonDrawACard
            // 
            this.buttonDrawACard.BackColor = System.Drawing.Color.Crimson;
            this.buttonDrawACard.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDrawACard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDrawACard.Location = new System.Drawing.Point(529, 269);
            this.buttonDrawACard.Name = "buttonDrawACard";
            this.buttonDrawACard.Size = new System.Drawing.Size(114, 135);
            this.buttonDrawACard.TabIndex = 4;
            this.buttonDrawACard.Text = "Draw A Card";
            this.buttonDrawACard.UseVisualStyleBackColor = false;
            this.buttonDrawACard.Click += new System.EventHandler(this.buttonDrawACard_Click);
            // 
            // labelLeftover
            // 
            this.labelLeftover.AutoSize = true;
            this.labelLeftover.BackColor = System.Drawing.Color.Firebrick;
            this.labelLeftover.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLeftover.Location = new System.Drawing.Point(557, 355);
            this.labelLeftover.Name = "labelLeftover";
            this.labelLeftover.Size = new System.Drawing.Size(58, 19);
            this.labelLeftover.TabIndex = 5;
            this.labelLeftover.Text = "(Deck)";
            this.labelLeftover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonTrade
            // 
            this.buttonTrade.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonTrade.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTrade.Location = new System.Drawing.Point(672, 589);
            this.buttonTrade.Name = "buttonTrade";
            this.buttonTrade.Size = new System.Drawing.Size(133, 26);
            this.buttonTrade.TabIndex = 6;
            this.buttonTrade.Text = "Trade";
            this.buttonTrade.UseVisualStyleBackColor = false;
            this.buttonTrade.Click += new System.EventHandler(this.buttonTrade_Click);
            // 
            // buttonExplore
            // 
            this.buttonExplore.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonExplore.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExplore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExplore.Location = new System.Drawing.Point(672, 621);
            this.buttonExplore.Name = "buttonExplore";
            this.buttonExplore.Size = new System.Drawing.Size(133, 26);
            this.buttonExplore.TabIndex = 7;
            this.buttonExplore.Text = "Explore";
            this.buttonExplore.UseVisualStyleBackColor = false;
            // 
            // buttonMuseum
            // 
            this.buttonMuseum.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonMuseum.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMuseum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMuseum.Location = new System.Drawing.Point(672, 653);
            this.buttonMuseum.Name = "buttonMuseum";
            this.buttonMuseum.Size = new System.Drawing.Size(133, 26);
            this.buttonMuseum.TabIndex = 8;
            this.buttonMuseum.Text = "Museum";
            this.buttonMuseum.UseVisualStyleBackColor = false;
            // 
            // pictureBoxMarketPlace
            // 
            this.pictureBoxMarketPlace.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBoxMarketPlace.Location = new System.Drawing.Point(22, 269);
            this.pictureBoxMarketPlace.Name = "pictureBoxMarketPlace";
            this.pictureBoxMarketPlace.Size = new System.Drawing.Size(501, 135);
            this.pictureBoxMarketPlace.TabIndex = 9;
            this.pictureBoxMarketPlace.TabStop = false;
            // 
            // pictureBoxPyramidCenter
            // 
            this.pictureBoxPyramidCenter.Image = global::Assignment2_Archeology.Properties.Resources.pyramid;
            this.pictureBoxPyramidCenter.Location = new System.Drawing.Point(804, 192);
            this.pictureBoxPyramidCenter.Name = "pictureBoxPyramidCenter";
            this.pictureBoxPyramidCenter.Size = new System.Drawing.Size(236, 314);
            this.pictureBoxPyramidCenter.TabIndex = 10;
            this.pictureBoxPyramidCenter.TabStop = false;
            // 
            // labelPyramid1
            // 
            this.labelPyramid1.AutoSize = true;
            this.labelPyramid1.BackColor = System.Drawing.Color.SaddleBrown;
            this.labelPyramid1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPyramid1.ForeColor = System.Drawing.Color.White;
            this.labelPyramid1.Location = new System.Drawing.Point(798, 111);
            this.labelPyramid1.Name = "labelPyramid1";
            this.labelPyramid1.Size = new System.Drawing.Size(87, 32);
            this.labelPyramid1.TabIndex = 11;
            this.labelPyramid1.Text = "1 Map\r\n(3 Treasures)";
            this.labelPyramid1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxpyramid
            // 
            this.pictureBoxpyramid.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBoxpyramid.Location = new System.Drawing.Point(804, 65);
            this.pictureBoxpyramid.Name = "pictureBoxpyramid";
            this.pictureBoxpyramid.Size = new System.Drawing.Size(75, 125);
            this.pictureBoxpyramid.TabIndex = 12;
            this.pictureBoxpyramid.TabStop = false;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(369, 494);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(68, 12);
            this.labelDescription.TabIndex = 13;
            this.labelDescription.Text = "Game Start";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 690);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelPyramid1);
            this.Controls.Add(this.pictureBoxpyramid);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxpyramid)).EndInit();
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
        private System.Windows.Forms.Label labelPyramid1;
        private System.Windows.Forms.PictureBox pictureBoxpyramid;
        private System.Windows.Forms.Label labelDescription;
    }
}

