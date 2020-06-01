using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPangGame
{
    public partial class Form1 : Form
    {
        public int speed_left = 4; // Geschwindigkeit des Balls
        public int punkte = 0; // Gewonnene Punkte
        public int speed_top = 4;
        public int speedbottom = 4;

       
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true; // Bestimmt ob der Zeitgeber ausgeführt wird
            Cursor.Hide();
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.TopMost = true; // stellt Fenster im Hintergrund
            //this.Bounds = Screen.PrimaryScreen.Bounds; // Macht das Fenster als Vollbildschirm
            //racket.Top = playground.Height -60;

            endeSpielLbl.Left = (playground.Width/2) - (endeSpielLbl.Width/2);
            endeSpielLbl.Top = (playground.Height/2) - (endeSpielLbl.Height/2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);
            racket.Top = Cursor.Position.Y - (racket.Height / 2);
            ball.Left += speed_left; // bringt den Ball zur Bewegung
            ball.Top += speed_top;
            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right ) // Zusammenstoss
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top; // Änderung der Richtung
                punkte += 1;
                punkteLbl.Text = "Punkte : " + punkte;
                Random neuColor = new Random();
                Random neuColor1 = new Random();
                Random neuColor2 = new Random();
                playground.BackColor = Color.FromArgb(neuColor.Next(100,255),neuColor1.Next(0,99),neuColor2.Next(75,200));
            }
            if (ball.Left <= playground.Left)
            {
                speed_left = -speed_left;
                Random neuColor = new Random();
                Random neuColor1 = new Random();
                Random neuColor2 = new Random();
                playground.BackColor = Color.FromArgb(neuColor.Next(75, 150), neuColor1.Next(200, 255), neuColor2.Next(0, 100));
            }
            if ( ball.Right >= playground.Right)
            {

                speed_left = -speed_left;
                Random neuColor = new Random();
                Random neuColor1 = new Random();
                Random neuColor2 = new Random();
                playground.BackColor = Color.FromArgb(neuColor.Next(0, 100), neuColor1.Next(50, 99), neuColor2.Next(75, 200));
            }
            if (ball.Top <= playground.Top)
            {
                speed_top = -speed_top;
                Random neuColor = new Random();
                Random neuColor1 = new Random();
                Random neuColor2 = new Random();
                playground.BackColor = Color.FromArgb(neuColor.Next(100, 255), neuColor1.Next(200, 255), neuColor2.Next(75, 200));
            }
            if (ball.Bottom >= playground.Bottom)
            {

                timer1.Enabled = false;

                endeSpielLbl.Visible = true;
                // ball ist raus. Ende des Speils
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
            if (e.KeyCode == Keys.N)
            {
                speed_left = 4;
                speed_top = 4;
                ball.Top = 50;
                ball.Left = 50;
                punkte = 0;
                punkteLbl.Text = "Punkte : 0";
                playground.BackColor = Color.White;
                endeSpielLbl.Visible = false;
                timer1.Enabled = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                
            }
        }
    }
}
