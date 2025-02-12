namespace GameXOROWindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartGame = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.labelFirstNameP2 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.labelFirstNameP1 = new System.Windows.Forms.Label();
            this.labPlayer1 = new System.Windows.Forms.Label();
            this.labPlayer2 = new System.Windows.Forms.Label();
            this.grbRoundResult = new System.Windows.Forms.GroupBox();
            this.labWinnerResult = new System.Windows.Forms.Label();
            this.labWinRoundCountResultP2 = new System.Windows.Forms.Label();
            this.labNamePlayer2 = new System.Windows.Forms.Label();
            this.labWinRoundCountResultP1 = new System.Windows.Forms.Label();
            this.labNamePlayer1 = new System.Windows.Forms.Label();
            this.labTheWinner = new System.Windows.Forms.Label();
            this.labCurrentRoundNumberRe = new System.Windows.Forms.Label();
            this.labCurrentRoundNumber = new System.Windows.Forms.Label();
            this.labCurrentPlayerResult = new System.Windows.Forms.Label();
            this.labCurrentPlayer = new System.Windows.Forms.Label();
            this.labRoundCountResult = new System.Windows.Forms.Label();
            this.labRoundCount = new System.Windows.Forms.Label();
            this.comRoundsChoice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResetGame = new System.Windows.Forms.Button();
            this.grbSquares = new System.Windows.Forms.GroupBox();
            this.btnSquare9 = new System.Windows.Forms.Button();
            this.btnSquare8 = new System.Windows.Forms.Button();
            this.btnSquare7 = new System.Windows.Forms.Button();
            this.btnSquare6 = new System.Windows.Forms.Button();
            this.btnSquare5 = new System.Windows.Forms.Button();
            this.btnSquare4 = new System.Windows.Forms.Button();
            this.btnSquare3 = new System.Windows.Forms.Button();
            this.btnSquare2 = new System.Windows.Forms.Button();
            this.btnSquare1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbRoundResult.SuspendLayout();
            this.grbSquares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.White;
            this.btnStartGame.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnStartGame.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnStartGame.FlatAppearance.BorderSize = 0;
            this.btnStartGame.Font = new System.Drawing.Font("Segoe Print", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.ForeColor = System.Drawing.Color.Maroon;
            this.btnStartGame.Location = new System.Drawing.Point(978, 6);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(106, 105);
            this.btnStartGame.TabIndex = 3;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.maskedTextBox1.BeepOnError = true;
            this.maskedTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox1.Location = new System.Drawing.Point(17, 29);
            this.maskedTextBox1.Mask = "LLL???????????";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(119, 22);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.ValidatingType = typeof(int);
            this.maskedTextBox1.Leave += new System.EventHandler(this.maskedTextBox1_Leave);
            // 
            // labelFirstNameP2
            // 
            this.labelFirstNameP2.AutoSize = true;
            this.labelFirstNameP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFirstNameP2.ForeColor = System.Drawing.Color.LightGray;
            this.labelFirstNameP2.Location = new System.Drawing.Point(30, 159);
            this.labelFirstNameP2.Name = "labelFirstNameP2";
            this.labelFirstNameP2.Size = new System.Drawing.Size(86, 20);
            this.labelFirstNameP2.TabIndex = 4;
            this.labelFirstNameP2.Text = "First Name";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.maskedTextBox2.BeepOnError = true;
            this.maskedTextBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.maskedTextBox2.Enabled = false;
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox2.Location = new System.Drawing.Point(16, 134);
            this.maskedTextBox2.Mask = "LLL???????????";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(118, 22);
            this.maskedTextBox2.TabIndex = 1;
            this.maskedTextBox2.ValidatingType = typeof(int);
            this.maskedTextBox2.Leave += new System.EventHandler(this.maskedTextBox2_Leave);
            // 
            // labelFirstNameP1
            // 
            this.labelFirstNameP1.AutoSize = true;
            this.labelFirstNameP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFirstNameP1.ForeColor = System.Drawing.Color.LightGray;
            this.labelFirstNameP1.Location = new System.Drawing.Point(30, 54);
            this.labelFirstNameP1.Name = "labelFirstNameP1";
            this.labelFirstNameP1.Size = new System.Drawing.Size(86, 20);
            this.labelFirstNameP1.TabIndex = 6;
            this.labelFirstNameP1.Text = "First Name";
            // 
            // labPlayer1
            // 
            this.labPlayer1.AutoSize = true;
            this.labPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labPlayer1.ForeColor = System.Drawing.Color.LightGray;
            this.labPlayer1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labPlayer1.Location = new System.Drawing.Point(12, 6);
            this.labPlayer1.Name = "labPlayer1";
            this.labPlayer1.Size = new System.Drawing.Size(78, 20);
            this.labPlayer1.TabIndex = 15;
            this.labPlayer1.Text = "Player 1 ";
            // 
            // labPlayer2
            // 
            this.labPlayer2.AutoSize = true;
            this.labPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labPlayer2.ForeColor = System.Drawing.Color.LightGray;
            this.labPlayer2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labPlayer2.Location = new System.Drawing.Point(12, 111);
            this.labPlayer2.Name = "labPlayer2";
            this.labPlayer2.Size = new System.Drawing.Size(73, 20);
            this.labPlayer2.TabIndex = 16;
            this.labPlayer2.Text = "Player 2";
            // 
            // grbRoundResult
            // 
            this.grbRoundResult.Controls.Add(this.labWinnerResult);
            this.grbRoundResult.Controls.Add(this.labWinRoundCountResultP2);
            this.grbRoundResult.Controls.Add(this.labNamePlayer2);
            this.grbRoundResult.Controls.Add(this.labWinRoundCountResultP1);
            this.grbRoundResult.Controls.Add(this.labNamePlayer1);
            this.grbRoundResult.Controls.Add(this.labTheWinner);
            this.grbRoundResult.Controls.Add(this.labCurrentRoundNumberRe);
            this.grbRoundResult.Controls.Add(this.labCurrentRoundNumber);
            this.grbRoundResult.Controls.Add(this.labCurrentPlayerResult);
            this.grbRoundResult.Controls.Add(this.labCurrentPlayer);
            this.grbRoundResult.Controls.Add(this.labRoundCountResult);
            this.grbRoundResult.Controls.Add(this.labRoundCount);
            this.grbRoundResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRoundResult.ForeColor = System.Drawing.Color.LightGray;
            this.grbRoundResult.Location = new System.Drawing.Point(17, 199);
            this.grbRoundResult.Name = "grbRoundResult";
            this.grbRoundResult.Size = new System.Drawing.Size(349, 319);
            this.grbRoundResult.TabIndex = 18;
            this.grbRoundResult.TabStop = false;
            this.grbRoundResult.Text = "Round Result ";
            // 
            // labWinnerResult
            // 
            this.labWinnerResult.AutoSize = true;
            this.labWinnerResult.ForeColor = System.Drawing.Color.Transparent;
            this.labWinnerResult.Location = new System.Drawing.Point(165, 258);
            this.labWinnerResult.Name = "labWinnerResult";
            this.labWinnerResult.Size = new System.Drawing.Size(85, 20);
            this.labWinnerResult.TabIndex = 30;
            this.labWinnerResult.Text = "No Player";
            // 
            // labWinRoundCountResultP2
            // 
            this.labWinRoundCountResultP2.AutoSize = true;
            this.labWinRoundCountResultP2.ForeColor = System.Drawing.Color.Transparent;
            this.labWinRoundCountResultP2.Location = new System.Drawing.Point(299, 164);
            this.labWinRoundCountResultP2.Name = "labWinRoundCountResultP2";
            this.labWinRoundCountResultP2.Size = new System.Drawing.Size(19, 20);
            this.labWinRoundCountResultP2.TabIndex = 26;
            this.labWinRoundCountResultP2.Text = "0";
            // 
            // labNamePlayer2
            // 
            this.labNamePlayer2.AutoSize = true;
            this.labNamePlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNamePlayer2.ForeColor = System.Drawing.Color.DarkOrange;
            this.labNamePlayer2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labNamePlayer2.Location = new System.Drawing.Point(27, 164);
            this.labNamePlayer2.Name = "labNamePlayer2";
            this.labNamePlayer2.Size = new System.Drawing.Size(75, 20);
            this.labNamePlayer2.TabIndex = 25;
            this.labNamePlayer2.Text = "Unknow: ";
            // 
            // labWinRoundCountResultP1
            // 
            this.labWinRoundCountResultP1.AutoSize = true;
            this.labWinRoundCountResultP1.ForeColor = System.Drawing.Color.Transparent;
            this.labWinRoundCountResultP1.Location = new System.Drawing.Point(299, 120);
            this.labWinRoundCountResultP1.Name = "labWinRoundCountResultP1";
            this.labWinRoundCountResultP1.Size = new System.Drawing.Size(19, 20);
            this.labWinRoundCountResultP1.TabIndex = 24;
            this.labWinRoundCountResultP1.Text = "0";
            // 
            // labNamePlayer1
            // 
            this.labNamePlayer1.AutoSize = true;
            this.labNamePlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNamePlayer1.ForeColor = System.Drawing.Color.DarkOrange;
            this.labNamePlayer1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labNamePlayer1.Location = new System.Drawing.Point(27, 120);
            this.labNamePlayer1.Name = "labNamePlayer1";
            this.labNamePlayer1.Size = new System.Drawing.Size(75, 20);
            this.labNamePlayer1.TabIndex = 23;
            this.labNamePlayer1.Text = "Unknow: ";
            // 
            // labTheWinner
            // 
            this.labTheWinner.AutoSize = true;
            this.labTheWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTheWinner.ForeColor = System.Drawing.Color.ForestGreen;
            this.labTheWinner.Location = new System.Drawing.Point(12, 253);
            this.labTheWinner.Name = "labTheWinner";
            this.labTheWinner.Size = new System.Drawing.Size(147, 25);
            this.labTheWinner.TabIndex = 29;
            this.labTheWinner.Text = "The Winner: ";
            // 
            // labCurrentRoundNumberRe
            // 
            this.labCurrentRoundNumberRe.AutoSize = true;
            this.labCurrentRoundNumberRe.ForeColor = System.Drawing.Color.Transparent;
            this.labCurrentRoundNumberRe.Location = new System.Drawing.Point(299, 76);
            this.labCurrentRoundNumberRe.Name = "labCurrentRoundNumberRe";
            this.labCurrentRoundNumberRe.Size = new System.Drawing.Size(19, 20);
            this.labCurrentRoundNumberRe.TabIndex = 22;
            this.labCurrentRoundNumberRe.Text = "0";
            // 
            // labCurrentRoundNumber
            // 
            this.labCurrentRoundNumber.AutoSize = true;
            this.labCurrentRoundNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCurrentRoundNumber.ForeColor = System.Drawing.Color.DarkOrange;
            this.labCurrentRoundNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labCurrentRoundNumber.Location = new System.Drawing.Point(27, 76);
            this.labCurrentRoundNumber.Name = "labCurrentRoundNumber";
            this.labCurrentRoundNumber.Size = new System.Drawing.Size(182, 20);
            this.labCurrentRoundNumber.TabIndex = 21;
            this.labCurrentRoundNumber.Text = "Current Round Number: ";
            // 
            // labCurrentPlayerResult
            // 
            this.labCurrentPlayerResult.AutoSize = true;
            this.labCurrentPlayerResult.ForeColor = System.Drawing.Color.Transparent;
            this.labCurrentPlayerResult.Location = new System.Drawing.Point(150, 208);
            this.labCurrentPlayerResult.Name = "labCurrentPlayerResult";
            this.labCurrentPlayerResult.Size = new System.Drawing.Size(85, 20);
            this.labCurrentPlayerResult.TabIndex = 28;
            this.labCurrentPlayerResult.Text = "No Player";
            // 
            // labCurrentPlayer
            // 
            this.labCurrentPlayer.AutoSize = true;
            this.labCurrentPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCurrentPlayer.ForeColor = System.Drawing.Color.DarkOrange;
            this.labCurrentPlayer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labCurrentPlayer.Location = new System.Drawing.Point(27, 208);
            this.labCurrentPlayer.Name = "labCurrentPlayer";
            this.labCurrentPlayer.Size = new System.Drawing.Size(117, 20);
            this.labCurrentPlayer.TabIndex = 17;
            this.labCurrentPlayer.Text = "Current Player: ";
            // 
            // labRoundCountResult
            // 
            this.labRoundCountResult.AutoSize = true;
            this.labRoundCountResult.ForeColor = System.Drawing.Color.Transparent;
            this.labRoundCountResult.Location = new System.Drawing.Point(299, 32);
            this.labRoundCountResult.Name = "labRoundCountResult";
            this.labRoundCountResult.Size = new System.Drawing.Size(0, 20);
            this.labRoundCountResult.TabIndex = 20;
            // 
            // labRoundCount
            // 
            this.labRoundCount.AutoSize = true;
            this.labRoundCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRoundCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.labRoundCount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labRoundCount.Location = new System.Drawing.Point(27, 32);
            this.labRoundCount.Name = "labRoundCount";
            this.labRoundCount.Size = new System.Drawing.Size(120, 20);
            this.labRoundCount.TabIndex = 19;
            this.labRoundCount.Text = "Rounds Count: ";
            // 
            // comRoundsChoice
            // 
            this.comRoundsChoice.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comRoundsChoice.FormattingEnabled = true;
            this.comRoundsChoice.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "7",
            "9"});
            this.comRoundsChoice.Location = new System.Drawing.Point(175, 29);
            this.comRoundsChoice.Name = "comRoundsChoice";
            this.comRoundsChoice.Size = new System.Drawing.Size(129, 21);
            this.comRoundsChoice.TabIndex = 2;
            this.comRoundsChoice.Leave += new System.EventHandler(this.comRoundsChoice_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(171, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Rounds Choice";
            // 
            // btnResetGame
            // 
            this.btnResetGame.BackColor = System.Drawing.Color.White;
            this.btnResetGame.Font = new System.Drawing.Font("Segoe Print", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetGame.ForeColor = System.Drawing.Color.Maroon;
            this.btnResetGame.Location = new System.Drawing.Point(16, 524);
            this.btnResetGame.Name = "btnResetGame";
            this.btnResetGame.Size = new System.Drawing.Size(350, 109);
            this.btnResetGame.TabIndex = 14;
            this.btnResetGame.Text = "Reset Game";
            this.btnResetGame.UseVisualStyleBackColor = false;
            this.btnResetGame.Click += new System.EventHandler(this.btnResetGame_Click);
            // 
            // grbSquares
            // 
            this.grbSquares.Controls.Add(this.btnSquare9);
            this.grbSquares.Controls.Add(this.btnSquare8);
            this.grbSquares.Controls.Add(this.btnSquare7);
            this.grbSquares.Controls.Add(this.btnSquare6);
            this.grbSquares.Controls.Add(this.btnSquare5);
            this.grbSquares.Controls.Add(this.btnSquare4);
            this.grbSquares.Controls.Add(this.btnSquare3);
            this.grbSquares.Controls.Add(this.btnSquare2);
            this.grbSquares.Controls.Add(this.btnSquare1);
            this.grbSquares.Controls.Add(this.button8);
            this.grbSquares.Controls.Add(this.button5);
            this.grbSquares.Controls.Add(this.button4);
            this.grbSquares.Controls.Add(this.button3);
            this.grbSquares.Controls.Add(this.button1);
            this.grbSquares.Location = new System.Drawing.Point(384, 134);
            this.grbSquares.Name = "grbSquares";
            this.grbSquares.Size = new System.Drawing.Size(687, 499);
            this.grbSquares.TabIndex = 27;
            this.grbSquares.TabStop = false;
            // 
            // btnSquare9
            // 
            this.btnSquare9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSquare9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSquare9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare9.Image = global::GameXOROWindowsForms.Properties.Resources.circle_question_svgrepo_com;
            this.btnSquare9.Location = new System.Drawing.Point(496, 348);
            this.btnSquare9.Name = "btnSquare9";
            this.btnSquare9.Size = new System.Drawing.Size(139, 124);
            this.btnSquare9.TabIndex = 12;
            this.btnSquare9.Tag = "?";
            this.btnSquare9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSquare9.UseVisualStyleBackColor = true;
            this.btnSquare9.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSquare8
            // 
            this.btnSquare8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSquare8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSquare8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare8.Image = global::GameXOROWindowsForms.Properties.Resources.circle_question_svgrepo_com;
            this.btnSquare8.Location = new System.Drawing.Point(271, 348);
            this.btnSquare8.Name = "btnSquare8";
            this.btnSquare8.Size = new System.Drawing.Size(139, 124);
            this.btnSquare8.TabIndex = 11;
            this.btnSquare8.Tag = "?";
            this.btnSquare8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSquare8.UseVisualStyleBackColor = true;
            this.btnSquare8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSquare7
            // 
            this.btnSquare7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSquare7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSquare7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare7.Image = global::GameXOROWindowsForms.Properties.Resources.circle_question_svgrepo_com;
            this.btnSquare7.Location = new System.Drawing.Point(52, 348);
            this.btnSquare7.Name = "btnSquare7";
            this.btnSquare7.Size = new System.Drawing.Size(139, 124);
            this.btnSquare7.TabIndex = 10;
            this.btnSquare7.Tag = "?";
            this.btnSquare7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSquare7.UseVisualStyleBackColor = true;
            this.btnSquare7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSquare6
            // 
            this.btnSquare6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSquare6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSquare6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare6.Image = global::GameXOROWindowsForms.Properties.Resources.circle_question_svgrepo_com;
            this.btnSquare6.Location = new System.Drawing.Point(496, 187);
            this.btnSquare6.Name = "btnSquare6";
            this.btnSquare6.Size = new System.Drawing.Size(139, 124);
            this.btnSquare6.TabIndex = 9;
            this.btnSquare6.Tag = "?";
            this.btnSquare6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSquare6.UseVisualStyleBackColor = true;
            this.btnSquare6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSquare5
            // 
            this.btnSquare5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSquare5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSquare5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare5.Image = global::GameXOROWindowsForms.Properties.Resources.circle_question_svgrepo_com;
            this.btnSquare5.Location = new System.Drawing.Point(271, 187);
            this.btnSquare5.Name = "btnSquare5";
            this.btnSquare5.Size = new System.Drawing.Size(139, 124);
            this.btnSquare5.TabIndex = 8;
            this.btnSquare5.Tag = "?";
            this.btnSquare5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSquare5.UseVisualStyleBackColor = true;
            this.btnSquare5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSquare4
            // 
            this.btnSquare4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSquare4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSquare4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare4.Image = global::GameXOROWindowsForms.Properties.Resources.circle_question_svgrepo_com;
            this.btnSquare4.Location = new System.Drawing.Point(52, 187);
            this.btnSquare4.Name = "btnSquare4";
            this.btnSquare4.Size = new System.Drawing.Size(139, 124);
            this.btnSquare4.TabIndex = 7;
            this.btnSquare4.Tag = "?";
            this.btnSquare4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSquare4.UseVisualStyleBackColor = true;
            this.btnSquare4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSquare3
            // 
            this.btnSquare3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSquare3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSquare3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare3.Image = global::GameXOROWindowsForms.Properties.Resources.circle_question_svgrepo_com;
            this.btnSquare3.Location = new System.Drawing.Point(496, 26);
            this.btnSquare3.Name = "btnSquare3";
            this.btnSquare3.Size = new System.Drawing.Size(139, 124);
            this.btnSquare3.TabIndex = 6;
            this.btnSquare3.Tag = "?";
            this.btnSquare3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSquare3.UseVisualStyleBackColor = true;
            this.btnSquare3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSquare2
            // 
            this.btnSquare2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSquare2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSquare2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare2.Image = global::GameXOROWindowsForms.Properties.Resources.question;
            this.btnSquare2.Location = new System.Drawing.Point(271, 26);
            this.btnSquare2.Name = "btnSquare2";
            this.btnSquare2.Size = new System.Drawing.Size(139, 124);
            this.btnSquare2.TabIndex = 5;
            this.btnSquare2.Tag = "?";
            this.btnSquare2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSquare2.UseVisualStyleBackColor = true;
            this.btnSquare2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSquare1
            // 
            this.btnSquare1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSquare1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSquare1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare1.ForeColor = System.Drawing.Color.Black;
            this.btnSquare1.Image = global::GameXOROWindowsForms.Properties.Resources.question;
            this.btnSquare1.Location = new System.Drawing.Point(52, 26);
            this.btnSquare1.Name = "btnSquare1";
            this.btnSquare1.Size = new System.Drawing.Size(139, 124);
            this.btnSquare1.TabIndex = 4;
            this.btnSquare1.Tag = "?";
            this.btnSquare1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSquare1.UseVisualStyleBackColor = true;
            this.btnSquare1.Click += new System.EventHandler(this.btn_Click);
            // 
            // button8
            // 
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Image = global::GameXOROWindowsForms.Properties.Resources.circle_question_svgrepo_com;
            this.button8.Location = new System.Drawing.Point(-191, 149);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(139, 124);
            this.button8.TabIndex = 19;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::GameXOROWindowsForms.Properties.Resources.circle_question_svgrepo_com;
            this.button5.Location = new System.Drawing.Point(-191, -12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 124);
            this.button5.TabIndex = 16;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::GameXOROWindowsForms.Properties.Resources.circle_question_svgrepo_com;
            this.button4.Location = new System.Drawing.Point(253, -173);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 124);
            this.button4.TabIndex = 15;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::GameXOROWindowsForms.Properties.Resources.circle_question_svgrepo_com;
            this.button3.Location = new System.Drawing.Point(28, -173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 124);
            this.button3.TabIndex = 14;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::GameXOROWindowsForms.Properties.Resources.circle_question_svgrepo_com;
            this.button1.Location = new System.Drawing.Point(-191, -173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 124);
            this.button1.TabIndex = 13;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GameXOROWindowsForms.Properties.Resources.tic_tac_toe_name;
            this.pictureBox1.Location = new System.Drawing.Point(326, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(581, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1096, 645);
            this.Controls.Add(this.grbSquares);
            this.Controls.Add(this.btnResetGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comRoundsChoice);
            this.Controls.Add(this.grbRoundResult);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labPlayer2);
            this.Controls.Add(this.labPlayer1);
            this.Controls.Add(this.labelFirstNameP1);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.labelFirstNameP2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btnStartGame);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.grbRoundResult.ResumeLayout(false);
            this.grbRoundResult.PerformLayout();
            this.grbSquares.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label labelFirstNameP2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label labelFirstNameP1;
        private System.Windows.Forms.Label labPlayer1;
        private System.Windows.Forms.Label labPlayer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grbRoundResult;
        private System.Windows.Forms.ComboBox comRoundsChoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labRoundCountResult;
        private System.Windows.Forms.Label labRoundCount;
        private System.Windows.Forms.Label labCurrentPlayerResult;
        private System.Windows.Forms.Label labCurrentPlayer;
        private System.Windows.Forms.Label labCurrentRoundNumberRe;
        private System.Windows.Forms.Label labCurrentRoundNumber;
        private System.Windows.Forms.Label labNamePlayer1;
        private System.Windows.Forms.Label labTheWinner;
        private System.Windows.Forms.Label labWinRoundCountResultP2;
        private System.Windows.Forms.Label labNamePlayer2;
        private System.Windows.Forms.Label labWinRoundCountResultP1;
        private System.Windows.Forms.Label labWinnerResult;
        private System.Windows.Forms.Button btnResetGame;
        private System.Windows.Forms.GroupBox grbSquares;
        private System.Windows.Forms.Button btnSquare9;
        private System.Windows.Forms.Button btnSquare8;
        private System.Windows.Forms.Button btnSquare7;
        private System.Windows.Forms.Button btnSquare6;
        private System.Windows.Forms.Button btnSquare5;
        private System.Windows.Forms.Button btnSquare4;
        private System.Windows.Forms.Button btnSquare3;
        private System.Windows.Forms.Button btnSquare2;
        private System.Windows.Forms.Button btnSquare1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}

