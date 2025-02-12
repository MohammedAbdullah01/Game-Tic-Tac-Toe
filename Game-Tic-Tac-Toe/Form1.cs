using GameXOROWindowsForms.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace GameXOROWindowsForms
{
    public partial class Form1 : Form
    {
        struct stInformationPlayer
        {
            public string PlayerName;
            public byte RepeatWins;
            public char PlayingWithPiece;

            public stInformationPlayer(string playerName, byte repeatWins, char playingWithPiece)
            {
                PlayerName = playerName;
                RepeatWins = repeatWins;
                PlayingWithPiece = playingWithPiece;
            }
        }

        struct stInformationRound
        {
            public byte RoundsCount;
            public byte CurrentRoundNumber;
            public stInformationPlayer Player1;
            public stInformationPlayer Player2;
            public string CurrentPlayer;
            public string WhoWinner;
            public short NumberOfPlayerClicks;
            

            public stInformationRound(byte roundsCount, stInformationPlayer player1, stInformationPlayer player2)
            {
                RoundsCount = roundsCount;
                CurrentRoundNumber = 1; // Start from round 1
                Player1 = player1;
                Player2 = player2;
                CurrentPlayer = player1.PlayerName; // Default to Player1
                WhoWinner = "Draw";
                NumberOfPlayerClicks = 0;
            }
        }

        stInformationPlayer Player1 = default;
        stInformationPlayer Player2 = default;
        stInformationRound RoundsInformation;

        enPlayer PlayerTurn;

        enum enPlayer
        {
            Player1, Player2
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.White;
            Pen pen = new Pen(color, 15);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 400, 300, 1050, 300);
            e.Graphics.DrawLine(pen, 400, 460, 1050, 460);

            e.Graphics.DrawLine(pen, 610, 140, 610, 620);
            e.Graphics.DrawLine(pen, 840, 140, 840, 628);
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            if (!ValidatePlayerName(maskedTextBox1, "Player 1"))
                return;

            Player1.PlayerName = maskedTextBox1.Text.Trim();

            // Only move focus if there's valid input
            maskedTextBox1.Enabled = false;
            maskedTextBox2.Enabled = true;
            maskedTextBox2.Focus();
        }

        private void maskedTextBox2_Leave(object sender, EventArgs e)
        {
            if (!ValidatePlayerName(maskedTextBox2, "Player 2"))
                return;

            string player2Name = maskedTextBox2.Text.Trim();

            if (Player1.PlayerName.ToLower() == player2Name.ToLower())
            {
                MessageBox.Show("The names of the two players cannot be identical.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskedTextBox2.Clear();
                maskedTextBox2.Focus();
                return;
            }

            Player2.PlayerName = player2Name;
            maskedTextBox2.Enabled = false;
            comRoundsChoice.Enabled = true;
            comRoundsChoice.Focus();
        }

        private bool ValidatePlayerName(MaskedTextBox textBox, string playerLabel)
        {
            if (textBox == null) return false;

            string input = textBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(input) || input.Length < 3)
            {
                MessageBox.Show($"Please enter a valid name for {playerLabel} (at least 3 letters).", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return false;
            }
            return true;
        }

        private void comRoundsChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comRoundsChoice.SelectedIndex >= 0)
            {
                RoundsInformation.RoundsCount = Convert.ToByte(comRoundsChoice.SelectedItem);
                comRoundsChoice.Enabled = false;
                btnStartGame.Enabled = true;
            }
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void StartGame()
        {
            RoundsInformation.CurrentRoundNumber = 1;
            grbSquares.Enabled = true;
            btnStartGame.Enabled = false;

            labRoundCountResult.Text = RoundsInformation.RoundsCount.ToString();
            labCurrentRoundNumberRe.Text = RoundsInformation.CurrentRoundNumber.ToString();
            labNamePlayer1.Text = Player1.PlayerName;
            labNamePlayer2.Text = Player2.PlayerName;
            labCurrentPlayerResult.Text = Player1.PlayerName;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            HandleButtonClick((Button)sender);
        }

        private void HandleButtonClick(Button btn)
        {
            if (btn.Tag.ToString() == "?")
            {
                btn.Tag = PlayerTurn == enPlayer.Player1 ? "X" : "O";
                btn.Image = PlayerTurn == enPlayer.Player1 ? Resources.X : Resources.O;

                PlayerTurn = PlayerTurn == enPlayer.Player1 ? enPlayer.Player2 : enPlayer.Player1;
                labCurrentPlayerResult.Text = PlayerTurn == enPlayer.Player1 ? RoundsInformation.Player1.PlayerName : RoundsInformation.Player2.PlayerName;

                CheckWinner();
            }
            else

            {
                MessageBox.Show("Wrong Choice", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckWinner()
        {
            if (CheckLine(btnSquare1, btnSquare2, btnSquare3) || // Row 1
                CheckLine(btnSquare4, btnSquare5, btnSquare6) || // Row 2
                CheckLine(btnSquare7, btnSquare8, btnSquare9) || // Row 3
                CheckLine(btnSquare1, btnSquare4, btnSquare7) || // Column 1
                CheckLine(btnSquare2, btnSquare5, btnSquare8) || // Column 2
                CheckLine(btnSquare3, btnSquare6, btnSquare9) || // Column 3
                CheckLine(btnSquare1, btnSquare5, btnSquare9) || // Diagonal 1
                CheckLine(btnSquare3, btnSquare5, btnSquare7))   // Diagonal 2
            {
                RoundsInformation.NumberOfPlayerClicks = 0;
                GameOver();
            }
            else
            {
                RoundsInformation.NumberOfPlayerClicks++;
                if (RoundsInformation.NumberOfPlayerClicks == 9)
                {
                    // Round is a draw
                    MessageBox.Show($"Round {RoundsInformation.CurrentRoundNumber} ended in a draw!", "Round Draw", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RoundsInformation.WhoWinner = "Draw";

                    if (IsRoundEnd())
                    {
                        MessageBox.Show("All rounds ended in a draw!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetGame();
                    }
                    else
                    {
                        PrepareNextRound();
                    }
                }
            }
        }


        private bool CheckLine(Button btn1, Button btn2, Button btn3)
        {
            string tag1 = btn1.Tag?.ToString();
            string tag2 = btn2.Tag?.ToString();
            string tag3 = btn3.Tag?.ToString();

            if (string.IsNullOrEmpty(tag1) || tag1 == "?" || tag1 != tag2 || tag1 != tag3)
                return false;

            bool isPlayer1 = tag1 == "X";

            if (isPlayer1)
                UpdateScore(ref RoundsInformation.Player1);
            else
                UpdateScore(ref RoundsInformation.Player2);

            short p1 = Player1.RepeatWins;
            short p2 = Player2.RepeatWins;
            FromTheStartingPlayerInRound();
            return true;
        }

        private void UpdateScore(ref stInformationPlayer player)
        {
            player.RepeatWins++;

            if (player.PlayerName == RoundsInformation.Player1.PlayerName)
            {
                RoundsInformation.Player1 = player; // Ensure struct update
                labWinRoundCountResultP1.Text = player.RepeatWins.ToString();
            }
            else
            {
                RoundsInformation.Player2 = player; // Ensure struct update
                labWinRoundCountResultP2.Text = player.RepeatWins.ToString();
            }
        }


        private void FromTheStartingPlayerInRound()
        {
            if (RoundsInformation.Player1.RepeatWins > RoundsInformation.Player2.RepeatWins)
            {
                PlayerTurn = enPlayer.Player1;
            }
            else if (RoundsInformation.Player2.RepeatWins > RoundsInformation.Player1.RepeatWins)
            {
                PlayerTurn = enPlayer.Player2;
            }
            else
            {
                // If equal wins or all draws, randomize starting player
                PlayerTurn = (new Random().Next(0, 2) == 0) ? enPlayer.Player1 : enPlayer.Player2;
            }

            labCurrentPlayerResult.Text = PlayerTurn == enPlayer.Player1 ? RoundsInformation.Player1.PlayerName : RoundsInformation.Player2.PlayerName;
        }

        private void GameOver()
        {
            WhoWin();

            string message = (RoundsInformation.WhoWinner != "Draw")
                ? $"The game ended with the player winning: {RoundsInformation.WhoWinner}"
                : "The game ended in a draw.";

            if (IsRoundEnd())
            {
                MessageBox.Show(message, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labWinnerResult.Text = RoundsInformation.WhoWinner;
                ResetGame();
            }
            else
            {
                message = (RoundsInformation.WhoWinner != "Draw")
                    ? $"Winner of round {RoundsInformation.CurrentRoundNumber}: {RoundsInformation.WhoWinner}\nMoving to the next round!"
                    : $"Round {RoundsInformation.CurrentRoundNumber} ended in a draw.\nMoving to the next round!";

                MessageBox.Show(message, "Next Round", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PrepareNextRound();
            }
        }

        private void PrepareNextRound()
        {
            DefaultGroubSquares(); // Reset board for new round
            grbSquares.Enabled = true;

            RoundsInformation.CurrentRoundNumber++;
            labCurrentRoundNumberRe.Text = RoundsInformation.CurrentRoundNumber.ToString();
            FromTheStartingPlayerInRound();
        }

        private void WhoWin()
        {
            if (RoundsInformation.Player1.RepeatWins > RoundsInformation.Player2.RepeatWins)
            {
                RoundsInformation.WhoWinner = Player1.PlayerName;
            }
            else if (RoundsInformation.Player2.RepeatWins > RoundsInformation.Player1.RepeatWins)
            {
                RoundsInformation.WhoWinner = Player2.PlayerName;
            }
            else
            {
                RoundsInformation.WhoWinner = "Draw"; // If equal wins, the game is a draw
            }
        }

        private void btnResetGame_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void ResetGame()
        {
            DefaultPlayersData();
            DefaultRoundsChoice();
            DefaultGroubSquares();
            grbSquares.Enabled = false;
            DefaultRoundResult();

            btnStartGame.Enabled = false;
        }

        private void DefaultPlayersData()
        {
            // Set masks to require exactly 3 letters followed by optional letters (up to 10 total)
            maskedTextBox1.Mask = "LLL??????";
            maskedTextBox2.Mask = "LLL??????";

            // Prevent spaces from resetting the input and skip literals for better input handling
            maskedTextBox1.ResetOnSpace = false;
            maskedTextBox1.SkipLiterals = false;
            maskedTextBox2.ResetOnSpace = false;
            maskedTextBox2.SkipLiterals = false;

            maskedTextBox1.Enabled = true;
            maskedTextBox1.Clear();
            maskedTextBox1.Focus();
            maskedTextBox2.Clear();

            maskedTextBox2.Enabled = false;
        }

        private void DefaultRoundsChoice()
        {
            comRoundsChoice.SelectedIndex = -1;
            comRoundsChoice.Text = string.Empty;

            comRoundsChoice.Enabled = false;
        }

        private void DefaultGroubSquares()
        {
            foreach (Button btn in grbSquares.Controls.OfType<Button>())
            {
                btn.Image = Resources.question;
                btn.Tag = "?";
            }
        }

        private void DefaultRoundResult()
        {
            labRoundCountResult.Text =
                labCurrentRoundNumberRe.Text =
                labWinRoundCountResultP1.Text =
                labWinRoundCountResultP2.Text = "0";

            labNamePlayer1.Text =
                labNamePlayer2.Text =
                labCurrentPlayerResult.Text =
                labWinnerResult.Text = "Unknown";
        }

        private bool IsRoundEnd()
        {
            return RoundsInformation.RoundsCount == RoundsInformation.CurrentRoundNumber;
        }

    }
}
