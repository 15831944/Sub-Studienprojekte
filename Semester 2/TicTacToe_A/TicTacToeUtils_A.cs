using System;
using System.Windows.Forms;
using System.Drawing;

namespace TicTacToe
{
    class TicTacToeUtils_A
    {
        private int m_currentPlayer = 0;
        private int m_gemachteZuege = 0;

        private Button[] m_myControls;
        private ListBox[] m_Zuege;
        private Label m_messageLabel;
        private Button m_buttonToMove;

        /// <summary>
        /// A1:		# Bewertung: 
        /// </summary>
        private static Color markingColor
        {
            get { return Color.LightGreen; }
        }

        private static Color normColor
        {
            get { return Color.LightGray; }
        }

        private string playerSign
        {
            get
            {
                return m_currentPlayer == 0 ? "0" : "X";
            }
        }

        /// <summary>
        /// A2:		# Bewertung: 
        /// </summary>
        private Color playerColor
        {
            get
            {
                return m_currentPlayer == 0 ? Color.Red : Color.Blue;
            }
        }

        /// <summary>
        /// A3:		# Bewertung: 
        /// </summary>
        private void nextSpieler()
        {
            m_currentPlayer = m_currentPlayer == 0 ? 1 : 0;
        }

        private bool platzierModus
        {
            get
            {
                return m_gemachteZuege < 6;
            }
        }

        /// <summary>
        /// A4:		# Bewertung: 
        /// </summary>
        /// <param name="myControls"></param>
        /// <param name="zuege"></param>
        /// <param name="messageLabel"></param>
        public TicTacToeUtils_A(Button[] myControls, ListBox[] zuege, Label messageLabel)
        {
            m_myControls = myControls;
            m_Zuege = zuege;
            m_messageLabel = messageLabel;
        }

        /// <summary>
        /// A5:		# Bewertung: 
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="reset"></param>
        private void setEnabled(bool enabled, bool reset = false)
        {
            //6:		# Bewertung: 
            foreach (Button mm_t in m_myControls)
            {
                //7:		# Bewertung: 
                mm_t.Enabled = enabled;
                if (reset)
                {
                    //8:		# Bewertung: 
                    mm_t.Text = "";
                    //9:		# Bewertung: 
                    mm_t.BackColor = normColor;
                }
            }
        }

        private int getButtonNumber(Button but)
        {
            return Convert.ToInt32(but.Name.Substring(6));
        }

        private string getButtonPos(Button but)
        {
            int mm_i = getButtonNumber(but);
            int mm_z = 1 + mm_i / 3;
            int mm_s = 1 + (mm_i % 3);
            return string.Format("{0}-{1}", mm_z, mm_s);
        }

        private void resetMarkingColorOfButtons()
        {
            foreach (Button mm_but in m_myControls)
            {
                if (mm_but.BackColor == markingColor)
                {
                    mm_but.BackColor = normColor;
                }
            }
        }

        /// <summary>
        /// 10:		# Bewertung: 
        /// </summary>
        public void init()
        {
            setEnabled(true, true);
            for (int mm_i = 0; mm_i < 2; mm_i++)
            {
                //11:		# Bewertung: 
                m_Zuege[mm_i].Items.Clear();
            }
            //12:		# Bewertung: 
            m_messageLabel.Text = "";
            m_gemachteZuege = 0;
            m_currentPlayer = 0;
            //13:		# Bewertung: 
            showMoveMessage();
        }

        private void recordMoves(string log)
        {
            m_Zuege[m_currentPlayer].Items.Add(log);
        }

        /// <summary>
        /// 14:		# Bewertung: 
        /// </summary>
        /// <returns></returns>
        private bool checkWinner()
        {
            //15:		# Bewertung: 
            if (checkIfThereIsAWinner())
            {
                //16:		# Bewertung: 
                m_messageLabel.Text = string.Format("Spieler {0} hat gewonnen!", m_currentPlayer + 1);
                //17:		# Bewertung: 
                MessageBox.Show(string.Format("GAME OVER\n\nSpieler {0} hat gewonnen!", m_currentPlayer + 1));
                return true;
            }
            return false;
        }

       
        private void showMoveMessage(bool selectMove = false)
        {
            string mm_toDo = platzierModus ? "Stein platzieren" : selectMove ? "Stein zum Schieben wählen" : "Stein verschieben";
            m_messageLabel.Text = string.Format("Spieler {0}: Bitte {1}", m_currentPlayer + 1, mm_toDo);
        }

        /// <summary>
        /// 18:		# Bewertung: 
        /// </summary>
        /// <param name="clickedButton"></param>
        public void handleButtonClick(Button clickedButton)
        {
            //19:		# Bewertung: 
            if (clickedButton.BackColor == markingColor)
            {
                //20:		# Bewertung: 
                moveButton(clickedButton);
            }
            else
            {
                //21:		# Bewertung: 
                selectButton(clickedButton);
            }
        }

        private void selectButton(Button button)
        {
            if (platzierModus)
            {
                if (button.Text == "")
                {
                    m_gemachteZuege++;
                    button.Text = playerSign;
                    button.ForeColor = playerColor;
                    recordMoves(string.Format("Platziert auf {0}", getButtonPos(button)));
                    if (!checkWinner())
                    {
                        nextSpieler();
                        showMoveMessage(true);
                    }
                }
            }
            else
            {
                resetMarkingColorOfButtons();
                if (button.Text == playerSign)
                {
                    m_buttonToMove = button;
                    possibleMoves(getButtonNumber(m_buttonToMove));
                }
                else
                {
                    showMoveMessage(true);
                }
            }
        }

        private void moveButton(Button newPosition)
        {
            m_gemachteZuege++;
            m_buttonToMove.Text = "";
            newPosition.Text = playerSign;
            newPosition.ForeColor = playerColor;
            recordMoves(string.Format("Von {0} auf {1} verschoben", getButtonPos(m_buttonToMove), getButtonPos(newPosition)));
            resetMarkingColorOfButtons();
            if (!checkWinner())
            {
                nextSpieler();
                showMoveMessage();
            }
        }

        /// <summary>
        /// 22:		# Bewertung: 
        /// </summary>
        /// <param name="baseButtonNumber"></param>
        private void possibleMoves(int baseButtonNumber)
        {
            //23:		# Bewertung: 
            int mm_zeile = baseButtonNumber / 3;
            //24:		# Bewertung: 
            int mm_spalte = baseButtonNumber % 3;
            //25:		# Bewertung: 
            int mm_possiblePositions = 0;
            for (int mm_i = 0; mm_i < 3; mm_i++)
            {
                for (int mm_j = 0; mm_j < 3; mm_j++)
                {
                    //26:		# Bewertung: 
                    int mm_idx = mm_i * 3 + mm_j;
                    //27:		# Bewertung: 
                    if (((Math.Abs(mm_zeile - mm_i) == 1) && (mm_spalte - mm_j == 0))
                        || ((Math.Abs(mm_spalte - mm_j) == 1) && (mm_zeile - mm_i == 0)))
                    {
                        //28:		# Bewertung: 
                        if (m_myControls[mm_idx].Text == "")
                        {
                            //29:		# Bewertung: 
                            m_myControls[mm_idx].BackColor = markingColor;
                            mm_possiblePositions++;
                        }
                    }
                }
            }
            //30:		# Bewertung: 
            showMoveMessage(mm_possiblePositions == 0);
        }

        //Beispielkommentar
        // m_Winners enthält alle Kombinationen bei denen ein Spieler gewonnen hat
        private int[,] m_Winners = new int[,]
				   {
						{0,1,2}, //erste Reihe
						{3,4,5}, //zweite Reihe
						{6,7,8}, //dritte Reihe
						{0,3,6}, //erste Spalte
						{1,4,7}, //zweite Spalte
						{2,5,8}, //dritte Spalte
						{0,4,8}, //Hauptdiagonale
						{2,4,6}  //Nebendiagonale
				   };

        //Beispielkommentar
        /// <summary>
        /// Prüft, ob es eine Kombination dreier gleicher Einträge in einer Reihe gibt
        /// mögliche Gewinner-Kombinationen sind in m_Winners abgelegt
        /// </summary>
        /// <returns></returns>
        private bool checkIfThereIsAWinner()
        {
            bool mm_gameOver = false;
            //Alle Einträge im m_Winners-Feld durchlaufen
            for (int mm_i = 0; mm_i < m_Winners.GetLength(0); mm_i++)
            {
                //Die Indizes der drei Buttons in einer Reihe merken
                int mm_a = m_Winners[mm_i, 0], mm_b = m_Winners[mm_i, 1], mm_c = m_Winners[mm_i, 2];
                //Und damit die Buttons selbst holen
                Button mm_b1= m_myControls[mm_a], mm_b2= m_myControls[mm_b], mm_b3  = m_myControls[mm_c];
                //Wenn einer der Buttons nicht gesetzt ist, zum nächsten Eintrag in m_Winners gehen
                if (mm_b1.Text == "" || mm_b2.Text == "" || mm_b3.Text == "")
                {
                    continue;
                }
                //Wenn die drei Einträge gleich sind, gibt es einen Gewinner
                if (mm_b1.Text == mm_b2.Text && mm_b2.Text == mm_b3.Text)
                {
                    //Die Gewinner-Reihe einfärben
                    mm_b1.BackColor = mm_b2.BackColor = mm_b3.BackColor = Color.LightCoral;
                    //Das Spiel ist vorbei
                    mm_gameOver = true;
                    //Button inaktiv schalten (keine Klicks mehr möglich)
                    setEnabled(false);
                    //Beenden der for-Schleife
                    break;
                }
            }
            //Rückgabe, ob Spiel zu Ende ist
            return mm_gameOver;
        }
    }
}


//mögliche Punktezahl 30, erreicht: 