using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   
     
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
 label1.Text = e.Location.ToString();
            string xmaus, ymaus;
            int xma, yma;
            xmaus = e.Location.X.ToString();
            ymaus = e.Location.Y.ToString();
            xma = Convert.ToInt32(xmaus);
            yma = Convert.ToInt32(ymaus);
            Point mausposition = new Point(xma, yma);

            string Punktx, Punkty;
            int x, y;

            Punktx = button1.Location.X.ToString();
            Punkty = button1.Location.Y.ToString();
            x = Convert.ToInt32(Punktx);
            y = Convert.ToInt32(Punkty);
            Point a = new Point(0, 0);

            int x1, y1;
            x1 = Convert.ToInt32(Punktx) + 50;
            y1 = Convert.ToInt32(Punkty);
            Point b = new Point(50, 0);

            int xm, ym;
            xm = Convert.ToInt32(Punktx) + 25;
            ym = Convert.ToInt32(Punkty) + 25;
            Point mp = new Point(25, 25);

            Point c = new Point(0, 50);
            Point d = new Point(50, 50);

           
            GraphicsPath grphPath1 = new GraphicsPath();
            grphPath1.AddPolygon(new Point[] { a, b, mp });
            bool oben = grphPath1.IsVisible(mausposition);

            GraphicsPath grphPath2 = new GraphicsPath();
            grphPath2.AddPolygon(new Point[] { d, b, mp });
            bool rechts = grphPath2.IsVisible(mausposition);

            GraphicsPath grphPath3 = new GraphicsPath();
            grphPath3.AddPolygon(new Point[] { c, d, mp });
            bool unten = grphPath3.IsVisible(mausposition);

            GraphicsPath grphPath4 = new GraphicsPath();
            grphPath4.AddPolygon(new Point[] { c, a, mp });
            bool links = grphPath4.IsVisible(mausposition);

           
                if (oben & button1.Location.Y > 0)
                {
                    button1.Location = new System.Drawing.Point(button1.Location.X, button1.Location.Y - 50);

                }


                else if (rechts & button1.Location. X < 450)
                {
                    button1.Location = new System.Drawing.Point(button1.Location.X + 50, button1.Location.Y);
                }

                else if (unten & button1.Location.Y < 450)
                {
                    button1.Location = new System.Drawing.Point(button1.Location.X, button1.Location.Y + 50);
                }

                else if (links & button1.Location.X > 0)
                {
                    button1.Location = new System.Drawing.Point(button1.Location.X - 50, button1.Location.Y);
                }

            else {
                button1.Location = new System.Drawing.Point(button1.Location.X , button1.Location.Y);
            }
            
        }
    }
          
    }

