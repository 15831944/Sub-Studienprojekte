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

        
        private Color playerColor
        {
            get
            {
                return m_currentPlayer == 0 ? Color.Red : Color.Blue;
            }
        }

       
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

       
        /// <param name="myControls"></param>
        /// <param name="zuege"></param>
        /// <param name="messageLabel"></param>
        public TicTacToeUtils_A(Button[] myControls, ListBox[] zuege, Label messageLabel)
        {
            m_myControls = myControls;
            m_Zuege = zuege;
            m_messageLabel = messageLabel;
        }

       
        /// <param name="enabled"></param>
        /// <param name="reset"></param>
        private void setEnabled(bool enabled, bool reset = false)
        {
            
            foreach (Button mm_t in m_myControls)
            {
          
                mm_t.Enabled = enabled;
                if (reset)
                {
                   
                    mm_t.Text = "";
                 
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

        
        public void init()
        {
            setEnabled(true, true);
            for (int mm_i = 0; mm_i < 2; mm_i++)
            {
                
                m_Zuege[mm_i].Items.Clear();
            }
            
            m_messageLabel.Text = "";
            m_gemachteZuege = 0;
            m_currentPlayer = 0;
             
            showMoveMessage();
        }

        private void recordMoves(string log)
        {
            m_Zuege[m_currentPlayer].Items.Add(log);
        }

     
        private bool checkWinner()
        {
            
            if (checkIfThereIsAWinner())
            {
                 
                m_messageLabel.Text = string.Format("Spieler {0} hat gewonnen!", m_currentPlayer + 1);
                 
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

        /// <param name="clickedButton"></param>
        public void handleButtonClick(Button clickedButton)
        {
            
            if (clickedButton.BackColor == markingColor)
            {
                
                moveButton(clickedButton);
            }
            else
            {
                
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

       
        /// <param name="baseButtonNumber"></param>
        private void possibleMoves(int baseButtonNumber)
        {
           
            int mm_zeile = baseButtonNumber / 3;
            
            int mm_spalte = baseButtonNumber % 3;
             
            int mm_possiblePositions = 0;
            for (int mm_i = 0; mm_i < 3; mm_i++)
            {
                for (int mm_j = 0; mm_j < 3; mm_j++)
                {
                    
                    int mm_idx = mm_i * 3 + mm_j;
                     
                    if (((Math.Abs(mm_zeile - mm_i) == 1) && (mm_spalte - mm_j == 0))
                        || ((Math.Abs(mm_spalte - mm_j) == 1) && (mm_zeile - mm_i == 0)))
                    {
                         
                        if (m_myControls[mm_idx].Text == "")
                        {
                            
                            m_myControls[mm_idx].BackColor = markingColor;
                            mm_possiblePositions++;
                        }
                    }
                }
            }
             
            showMoveMessage(mm_possiblePositions == 0);
        }

       
        private int[,] m_Winners = new int[,]
				   {
						{0,1,2}, 
						{3,4,5}, 
						{6,7,8}, 
						{0,3,6}, 
						{1,4,7}, 
						{2,5,8}, 
						{0,4,8}, 
						{2,4,6}  
				   };

       
        private bool checkIfThereIsAWinner()
        {
            bool mm_gameOver = false;
            
            for (int mm_i = 0; mm_i < m_Winners.GetLength(0); mm_i++)
            {
                
                int mm_a = m_Winners[mm_i, 0], mm_b = m_Winners[mm_i, 1], mm_c = m_Winners[mm_i, 2];
               
                Button mm_b1= m_myControls[mm_a], mm_b2= m_myControls[mm_b], mm_b3  = m_myControls[mm_c];
                
                if (mm_b1.Text == "" || mm_b2.Text == "" || mm_b3.Text == "")
                {
                    continue;
                }
               
                if (mm_b1.Text == mm_b2.Text && mm_b2.Text == mm_b3.Text)
                {
                    
                    mm_b1.BackColor = mm_b2.BackColor = mm_b3.BackColor = Color.LightCoral;
                    
                    mm_gameOver = true;
                    
                    setEnabled(false);
                    
                    break;
                }
            }
            
            return mm_gameOver;
        }
    }
}


