namespace PingPangGame
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playground = new System.Windows.Forms.Panel();
            this.endeSpielLbl = new System.Windows.Forms.Label();
            this.punkteLbl = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.racket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.Controls.Add(this.endeSpielLbl);
            this.playground.Controls.Add(this.punkteLbl);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.racket);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(789, 452);
            this.playground.TabIndex = 0;
            // 
            // endeSpielLbl
            // 
            this.endeSpielLbl.AutoSize = true;
            this.endeSpielLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endeSpielLbl.Location = new System.Drawing.Point(219, 58);
            this.endeSpielLbl.Name = "endeSpielLbl";
            this.endeSpielLbl.Size = new System.Drawing.Size(505, 275);
            this.endeSpielLbl.TabIndex = 1;
            this.endeSpielLbl.Text = "Game Over\r\n\r\nN -Neues Spiel\r\nEsc- Spiel Schliessen\r\n ";
            this.endeSpielLbl.Visible = false;
            // 
            // punkteLbl
            // 
            this.punkteLbl.AutoSize = true;
            this.punkteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punkteLbl.Location = new System.Drawing.Point(22, 13);
            this.punkteLbl.Name = "punkteLbl";
            this.punkteLbl.Size = new System.Drawing.Size(191, 37);
            this.punkteLbl.TabIndex = 2;
            this.punkteLbl.Text = "Punkte  :  0";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Red;
            this.ball.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ball.BackgroundImage")));
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.InitialImage = ((System.Drawing.Image)(resources.GetObject("ball.InitialImage")));
            this.ball.Location = new System.Drawing.Point(29, 77);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(102, 102);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.Black;
            this.racket.Location = new System.Drawing.Point(241, 386);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(287, 20);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 452);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label punkteLbl;
        private System.Windows.Forms.Label endeSpielLbl;
    }
}

