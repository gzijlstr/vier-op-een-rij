namespace FourInARowGame
{
    partial class Form1
    {
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblCurrentTurn;

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblCurrentTurn = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 600);

            for (int i = 0; i < this.tableLayoutPanel1.ColumnCount; i++)
            {
                this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f / this.tableLayoutPanel1.ColumnCount));
            }
            for (int i = 0; i < this.tableLayoutPanel1.RowCount; i++)
            {
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f / this.tableLayoutPanel1.RowCount));
            }

            // 
            // btnNewGame
            // 
            this.btnNewGame.Text = "Nieuw spel";
            this.btnNewGame.Location = new System.Drawing.Point(10, 610);
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);

            // 
            // btnExit
            // 
            this.btnExit.Text = "Exit";
            this.btnExit.Location = new System.Drawing.Point(100, 610);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // 
            // lblPlayer1
            // 
            this.lblPlayer1.Text = "Speler 1: ";
            this.lblPlayer1.Location = new System.Drawing.Point(10, 640);

            // 
            // lblPlayer2
            // 
            this.lblPlayer2.Text = "Speler 2: ";
            this.lblPlayer2.Location = new System.Drawing.Point(10, 670);

            // 
            // lblCurrentTurn
            // 
            this.lblCurrentTurn.Text = "Huidige Zet: ";
            this.lblCurrentTurn.Location = new System.Drawing.Point(200, 610);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(720, 720);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblCurrentTurn);
            this.Text = "Four In A Row Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }
    }
}
