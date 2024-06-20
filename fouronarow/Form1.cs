using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FourInARowGame
{
    public partial class Form1 : Form
    {
        private char[,] board;
        private char currentPlayer;
        private int moveCount;
        private Stopwatch stopwatch;
        private PictureBox[,] pictureBoxes;
        private string player1Name;
        private string player2Name;

        public Form1(string player1, string player2)
        {
            InitializeComponent();
            this.player1Name = player1;
            this.player2Name = player2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void InitializeGame()
        {
            board = new char[6, 7];
            currentPlayer = 'X';
            moveCount = 0;
            stopwatch = new Stopwatch();
            stopwatch.Start();

            pictureBoxes = new PictureBox[6, 7];
            tableLayoutPanel1.Controls.Clear();

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    pictureBoxes[i, j] = new PictureBox
                    {
                        Dock = DockStyle.Fill,
                        BackColor = Color.White,
                        Margin = new Padding(0)
                    };
                    pictureBoxes[i, j].Click += PictureBox_Click;
                    tableLayoutPanel1.Controls.Add(pictureBoxes[i, j], j, i);
                    board[i, j] = '.';
                }
            }

            lblPlayer1.Text = $"Speler 1: {player1Name}";
            lblPlayer2.Text = $"Speler 2: {player2Name}";
            lblCurrentTurn.Text = "Huidige zet: Speler 1 (X)";
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedBox = sender as PictureBox;
            int col = tableLayoutPanel1.GetColumn(clickedBox);
            int row = DropToken(col);

            if (row != -1)
            {
                moveCount++;
                pictureBoxes[row, col].BackColor = currentPlayer == 'X' ? Color.Blue : Color.Red;

                if (CheckWinner())
                {
                    stopwatch.Stop();
                    MessageBox.Show($"Speler {(currentPlayer == 'X' ? player1Name : player2Name)} wint! het duurde {moveCount} moves en {stopwatch.Elapsed.Seconds} seconden.");
                    if (MessageBox.Show("Opnieuw spelen?", "nog een keer?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        InitializeGame();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
                    lblCurrentTurn.Text = $"Huidige zet: Speler {(currentPlayer == 'X' ? player1Name : player2Name)} ({currentPlayer})";
                }
            }
        }

        private int DropToken(int col)
        {
            for (int row = 5; row >= 0; row--)
            {
                if (board[row, col] == '.')
                {
                    board[row, col] = currentPlayer;
                    return row;
                }
            }
            return -1;
        }

        private bool CheckWinner()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (board[i, j] == currentPlayer)
                    {
                        if (CheckDirection(i, j, 1, 0) || CheckDirection(i, j, 0, 1) || CheckDirection(i, j, 1, 1) || CheckDirection(i, j, 1, -1))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private bool CheckDirection(int row, int col, int rowDir, int colDir)
        {
            int count = 1;

            for (int i = 1; i < 4; i++)
            {
                int newRow = row + i * rowDir;
                int newCol = col + i * colDir;

                if (newRow >= 0 && newRow < 6 && newCol >= 0 && newCol < 7 && board[newRow, newCol] == currentPlayer)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            return count >= 4;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}






