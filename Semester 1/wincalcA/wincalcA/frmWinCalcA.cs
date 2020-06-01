using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winCalcA
{
    /// <summary>
    /// definition der über mehrere Dateien verteilten Klasse frmWinCalcA, die von der Klasse Form erbt und öffentlich ist
    /// </summary>
    public partial class frmWinCalcA : Form
    {
        /// <summary>
        /// definition der öffentlichen enumeration names Operator
        /// </summary>
        public enum Operator
        {
            none,
            add,
            subtract,
            multiply,
            divide,
            modulo,
            sqrt
        }

        // privates Variable vom Typ Operator namens currentOperator deklarieren
        //und ihm den Wert none aus der enumeration Operator zuweisen
        private Operator currentOperator = Operator.none;

        // definition der privaten Variable names firstNumber vom Typ double (Gleitkommazahl, doppelte Genauigkeit), der der Wert 0 zugewiesen wird.
        private double firstNumber = 0;
        private double secondNumber = 0;
        // definition der privaten Variable names newNumberBegun vom Typ bool(true / false), der der Wert false zugewiesen wird.
        private bool newNumberBegun = false;
        private bool calculationDone = false;

        // definition der privaten Variable names isDecimal vom Typ bool
        private bool isDecimal
        {
            // Die Funktion kann gelesen werden; in den Klammern steht genaueres dazu.
            get
            {
                // Wenn die Eigenschaft Text am Objekt txtResult einen Punkt enthält
                if (txtResult.Text.Contains('.'))
                {
                    return true;
                }
                return false;
            }
        }

        private System.Globalization.CultureInfo cultureInfoUS;

        /// <summary>
        /// definition eines Konstuktors
        /// </summary>
        public frmWinCalcA()
        {
            // aufruf der Funktion InitializeComponents()
            InitializeComponent();
            cultureInfoUS = new System.Globalization.CultureInfo("en-US");
        }

        /// <summary>
        /// 
        /// <summary>
        /// <param name="textset"></param>
        public void setText(String textset)
        {
            //
            if (textset.Equals("clear"))
            {
                //
                txtResult.Text = "";
                firstNumber = 0;
                secondNumber = 0;
                currentOperator = Operator.none;
            }
            else if (textset.Equals("removelast"))
            {
                //
                txtResult.Text = txtResult.Text.Length == 0 ? "" : txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            }
            else
            {
                //
                if (newNumberBegun)
                {
                    //
                    txtResult.Text = textset;
                    //
                    newNumberBegun = false;
                }
                else
                {
                    txtResult.Text += textset;
                }

                //Wenn eine Rechnung beendet wurde und eine neue Zahl eingegeben wird,
                //startet damit neue Berechnung, Konstanten-Funktion ist damit wieder ausgeschaltet
                if (calculationDone)
                {
                    //neue Rechnung...
                    calculationDone = false;
                    //Operator zurücksetzen, damit mit neuer Rechnung begonnen werden kann
                    currentOperator = Operator.none;
                }
            }
            btnEquals.Select();
        }

        /// <summary>
        /// 
        /// <summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="op"></param>
        public void Calc(double num1, double num2, Operator op)
        {
            //
            bool error = false;
            double res = 0;
            //
            switch (op)
            {
                //
                case Operator.add:
                    res = num1 + num2;
                    break;
                case Operator.subtract:
                    res = num1 - num2;
                    break;
                case Operator.multiply:
                    res = num1 * num2;
                    break;
                case Operator.divide:
                    res = num1 / num2;
                    break;
                case Operator.modulo:
                    res = num1 % num2;
                    break;
                case Operator.sqrt:
                    res = Math.Sqrt(num1);
                    break;
                default:
                    error = true;
                    break;
            }
            //
            txtResult.Text = error ? "" : res.ToString();
            calculationDone = true;
        }

        /// <summary>
        /// Die Funktion parseVal parst einen String-Wert in einen Double-Wert
        /// Durch das Abfangen fehlerhafter möglicher Werte durch die GUI sollte
        /// das immer klappen, gibt es trotzdem Parse-Fehler, gibt die Funktion
        /// den Wert 0 zurück
        /// </summary>
        /// <param name="val">der zu parsende String-Wert</param>
        /// <returns>der geparste Double-Wert (0 bei einem Parse-Fehler)</returns>
        double parseVal(string val)
        {
            //merk Dir die aktuelle einstellung der CultureInfo des OS
            System.Globalization.CultureInfo CurrentCultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            //setze die CultureInfo des Threads auf Englisch (Punkt ist Dezimaltrenner - wichtig beim Parsen!)
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfoUS;
            //Komma durch Punkt im Wert ersetzen, damit korrekt geparst wird
            val = val.Replace(",", ".");
            double ret = 0;
            //Wenn das Parsen nicht erfolgreich ist, wird der Rückgabewert 0
            if (!double.TryParse(val, out ret))
            {
                ret = 0;
            }
            //CultureInfo auf Ausgangszustand zurücksetzen
            System.Threading.Thread.CurrentThread.CurrentCulture = CurrentCultureInfo;
            //Geparsten Wert zurückgeben
            return ret;
        }

        /// <summary>
        /// 
        /// </summary>
        private void doEquals()
        {
            //
            if ((txtResult.Text.Length == 0) || (currentOperator == Operator.none))
            {
                //
                return;
            }
            double curValue = parseVal(txtResult.Text.ToString());

            //Wenn keine neue Zahl eingegeben wurde, also keine Rechnung abgeschlossen ist,
            //merk dir die gerade aktuelle als Rechen-Konstante in secondNumber,
            //Wenn dann ein zweites Mal auf = geklickt wird, steht calculationDone auf true,
            //hier passiert also nichts!
            //Dann ist aber in secondNumber immer noch der alte konstante Wert und curValue stellt das 
            //letzte Zwischenergebnis dar, das mit der Konstante verrechnet wird
            if (!calculationDone)
            {
                //
                secondNumber = curValue;
                //
                curValue = firstNumber;
            }
            //
            Calc(curValue, secondNumber, currentOperator);
            //
            newNumberBegun = true;
        }

        /// <summary>
        /// definition der privaten Funktion setOparator ohne Rückgabewert, der als Argument ein Objekt vom Typ Oparator erwartet
        /// </summary>
        /// <param name="operation">operation wird der zu setztende Operator übergeben </param>
        private void setOperator(Operator operation)
        {
            // Wenn die Länge der Eigenschaft Text am Objekt txtResult größer als 0 ist...
            if (txtResult.Text.Length > 0)
            {
                //Wenn anstelle von "=" ein weiterer Operator gedrückt wird, so muß das 
                //Zwischenergebnis berechnet werden, dazu muß aber eine zweiteZahl ohne 
                //0-Länge vorhanden sein und auch ein Operator muß gesetzt sein.
                if ((txtResult.Text.Length != 0) && (currentOperator != Operator.none))
                {
                    // der Variablen erg vom Typ double wird der Rückgabewert von parseVal übergeben.
                    //die Funktion parseVal bekommt als Argument die Eigenschaft Text vom Objekt txtResult als String übergeben
                    double erg = parseVal(txtResult.Text.ToString());
                    Calc(firstNumber, erg, currentOperator);
                }
                if ((currentOperator == Operator.sqrt))
                {
                    if ((txtResult.Text.Length >= 0)) Calc(parseVal(txtResult.Text.ToString()), 0, operation);
                    else MessageBox.Show("Es kann keine Wurzel aus einer negativen Zahl gezogen werden");
                }
                // der Variablen currentOperator wird der Wert von operation zugewiesen
                currentOperator = operation;
                // der Variablen firstNumber wird der Rückgabewert von parseVal übergeben.
                //die Funktion parseVal bekommt als Argument die Eigenschaft Text vom Objekt txtResult als String übergeben
                firstNumber = parseVal(txtResult.Text.ToString());
                // der Variablen newNumberBegun wird der true zugewiesen
                newNumberBegun = true;
                calculationDone = false;
                // die Funktion Select() wird am Objekt btnEquals aufgerufen
                btnEquals.Select();
            }
        }

        /// <summary>
        /// deklaration der privaten Funktion changeSign ohne Rückgabewert und ohne Argumente
        /// </summary>
        private void changeSign()
        {
            double storNum;
            // Wenn die Länge der eigenschaft Text am Objekt txtResult größer als 0 ist ...
            if (txtResult.Text.Length > 0)
            {
                // der Variablen storNum wird der Rückgabewert der der Funktion parseVal übergebeben
                //die Funktion parseVal bekommt als Argument die Eigenschaft Text vom Objekt txtResult als String übergeben
                storNum = parseVal(txtResult.Text.ToString());
                // die Varibale storNum wird negiert
                storNum *= -1;
                // der eigenschaft Text am Objekt txtResult wird der wert von storNum als String übergeben
                txtResult.Text = storNum.ToString();
            }
            btnEquals.Select();
        }

        /// <summary>
        /// 
        /// </summary>
        private void setDecimal()
        {
            //
            if (!isDecimal)
            {
                //
                setText(".");
            }
            //
            btnEquals.Select();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zahl_Click(object sender, System.EventArgs e)
        {
            string was = ((Button)sender).Text;
            setText(was);
        }

        private void btnEquals_Click(object sender, System.EventArgs e)
        {
            doEquals();
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            newNumberBegun = false;
            setText("clear");
        }

        /// <summary>
        /// Beim aufruf der Funktion wird ein operator gesetzt
        /// </summary>
        /// <param name="sender">sender vom Typ object bezeichnet das objekt von dem aus die funktion Aufgerufen wird</param>
        /// <param name="e">e vom Typ System.EventArgs bezeichnet die zusätzlichen eigenschaften wie die Funktion aufgerufen wurde</param>
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            setOperator(Operator.add);
        }

        private void btnSubtract_Click(object sender, System.EventArgs e)
        {
            setOperator(Operator.subtract);
        }
        private void btnMultiply_Click(object sender, System.EventArgs e)
        {
            setOperator(Operator.multiply);
        }
        private void btnDivide_Click(object sender, System.EventArgs e)
        {
            setOperator(Operator.divide);
        }

        private void btnNegative_Click(object sender, System.EventArgs e)
        {
            changeSign();
        }

        private void btnDecimal_Click(object sender, System.EventArgs e)
        {
            setDecimal();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Btn_KeyDown(object sender, KeyEventArgs e)
        {
            //
            filterKeys(e.KeyValue);
            //Der Event gilt als behandelt und wird nicht weiter betrachtet
            //wenn e.Handled auf true gesetzt wird
            e.Handled = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_KeyPress(object sender, KeyPressEventArgs e)
        {
            //
            filterKeys(e.KeyChar);
            //Der Event gilt als behandelt und wird nicht weiter betrachtet,
            //wenn e.Handled auf true gesetzt wird
            e.Handled = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyValue"></param>
        /// <returns></returns>
        public void filterKeys(int keyValue)
        {
            switch (keyValue)
            {
                case 13:
                    doEquals();
                    break;
                case 8:
                    setText("removelast");
                    break;
                case 46:
                    setText("clear");
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyCode"></param>
        /// <returns></returns>
        public void filterKeys(char keyCode)
        {
            switch (keyCode)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    setText(keyCode.ToString());
                    break;
                case '+':
                    setOperator(Operator.add);
                    break;
                case '-':
                    if (txtResult.Text.Length == 0)
                    {
                        setText("-");
                    }
                    else
                    {
                        setOperator(Operator.subtract);
                    }
                    break;
                case '*':
                case 'x':
                    setOperator(Operator.multiply);
                    break;
                case '/':
                case ':':
                    setOperator(Operator.divide);
                    break;
                case '=':
                    doEquals();
                    break;
                case '.':
                case ',':
                    setDecimal();
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtResult_Enter(object sender, EventArgs e)
        {
            btnEquals.Select();
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            setOperator(Operator.modulo);
        }

        private void btn_sqrt_Click(object sender, EventArgs e)
        {
            setOperator(Operator.sqrt);
        }
    }
}


//Erreichbare Punkte: 26
//Erreicht wurden: 