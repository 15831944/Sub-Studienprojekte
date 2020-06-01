using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class frmMain_A : Form
    {
        TicTacToeUtils_A m_tacToeUtils;

        public frmMain_A()
        {
            InitializeComponent();
            Button[] mm_ButtonArray = new Button[9] { button0, button1, button2, button3, button4, button5, button6, button7, button8 };
            ListBox[] mm_Zuege = new ListBox[] { lbZuegeSpieler1, lbZuegeSpieler2 };
            m_tacToeUtils = new TicTacToeUtils_A(mm_ButtonArray, mm_Zuege, messageLabel);
            m_tacToeUtils.init();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button mm_but = (Button)sender;
            m_tacToeUtils.handleButtonClick(mm_but);
        }

        private void endeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void neuesSpielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_tacToeUtils.init();
        }

        private void einstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEinstellungen_A mm_einstellungen = new frmEinstellungen_A();
            if (DialogResult.OK == mm_einstellungen.ShowDialog())
            {
                
            }
        }

    }
}
