namespace FourInARowGame
{
    partial class StartForm
    {
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;

        private void InitializeComponent()
        {
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblPlayer1
            // 
            this.lblPlayer1.Text = "Speler 1 Naam:";
            this.lblPlayer1.Location = new System.Drawing.Point(10, 10);

            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Location = new System.Drawing.Point(10, 30);
            this.txtPlayer1.Size = new System.Drawing.Size(200, 20);

            // 
            // lblPlayer2
            // 
            this.lblPlayer2.Text = "Speler 2 Naam:";
            this.lblPlayer2.Location = new System.Drawing.Point(10, 60);

            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Location = new System.Drawing.Point(10, 80);
            this.txtPlayer2.Size = new System.Drawing.Size(200, 20);

            // 
            // btnStartGame
            // 
            this.btnStartGame.Text = "Start Spel";
            this.btnStartGame.Location = new System.Drawing.Point(10, 110);
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);

            // 
            // StartForm
            // 
            this.ClientSize = new System.Drawing.Size(230, 150);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.txtPlayer1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.txtPlayer2);
            this.Controls.Add(this.btnStartGame);
            this.Text = "Start Scherm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
