using System;
using System.Windows.Forms;

namespace FourInARowGame
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            string player1Name = txtPlayer1.Text.Trim();
            string player2Name = txtPlayer2.Text.Trim();

            if (string.IsNullOrEmpty(player1Name) || string.IsNullOrEmpty(player2Name))
            {
                MessageBox.Show("Beide spelersnamen moeten ingevuld worden.");
                return;
            }

            Form1 gameForm = new Form1(player1Name, player2Name);
            gameForm.Show();
            this.Hide();
        }
    }
}
