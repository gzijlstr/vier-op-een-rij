using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace FourInARowGame
{
    public partial class Class1 : Form
    {
        private char[,] board;
        private char currentPlayer;
        private int moveCount;
        private Stopwatch stopwatch;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            board = new char[6, 7];
            currentPlayer = 'X';
            moveCount = 0;
            stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    board[i, j] = '.';
                    pictureBoxes[i, j].BackColor = System.Drawing.Color.White;
                }
            }

            lblCurrentTurn.Text = "Current Turn: Player 1 (X)";
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedBox = sender as PictureBox;
            int col = tableLayoutPanel1.GetColumn(clickedBox);
            int row = DropToken(col);

            if (row != -1)
            {
                moveCount++;
                pictureBoxes[row, col].BackColor = currentPlayer == 'X' ? System.Drawing.Color.Blue : System.Drawing.Color.Red;

                if (CheckWinner())
                {
                    stopwatch.Stop();
                    MessageBox.Show($"Player {(currentPlayer == 'X' ? 1 : 2)} wins! It took {moveCount} moves and {stopwatch.Elapsed.Seconds} seconds.");
                    if (MessageBox.Show("Do you want to play again?", "Play Again", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                    lblCurrentTurn.Text = $"Current Turn: Player {(currentPlayer == 'X' ? 1 : 2)} ({currentPlayer})";
                }
            }
        }

        private int DropToken(int col)
        {
            for (int row = 0; row < 6; row++)
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
            // Check for horizontal, vertical and diagonal wins
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
