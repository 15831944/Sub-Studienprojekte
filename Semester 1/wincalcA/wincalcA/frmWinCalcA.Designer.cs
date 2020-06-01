namespace winCalcA
{
    partial class frmWinCalcA
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
        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// Most of these just set the controls and the properties for them. There are some event handlers that I will explain as I go along.
        /// <summary>
        private void InitializeComponent()
        {
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnModulo = new System.Windows.Forms.Button();
            this.btn_sqrt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn2.Location = new System.Drawing.Point(48, 40);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(32, 32);
            this.btn2.TabIndex = 13;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.Click += new System.EventHandler(this.zahl_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn3.Location = new System.Drawing.Point(88, 40);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(32, 32);
            this.btn3.TabIndex = 12;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.Click += new System.EventHandler(this.zahl_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn0.Location = new System.Drawing.Point(48, 160);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(32, 32);
            this.btn0.TabIndex = 5;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.Click += new System.EventHandler(this.zahl_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn1.Location = new System.Drawing.Point(8, 40);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(32, 32);
            this.btn1.TabIndex = 14;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.Click += new System.EventHandler(this.zahl_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn6.Location = new System.Drawing.Point(88, 80);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(32, 32);
            this.btn6.TabIndex = 9;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.Click += new System.EventHandler(this.zahl_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn7.Location = new System.Drawing.Point(8, 120);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(32, 32);
            this.btn7.TabIndex = 8;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.Click += new System.EventHandler(this.zahl_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn4.Location = new System.Drawing.Point(8, 80);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(32, 32);
            this.btn4.TabIndex = 11;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.Click += new System.EventHandler(this.zahl_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(136, 160);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(32, 32);
            this.btnDivide.TabIndex = 2;
            this.btnDivide.TabStop = false;
            this.btnDivide.Text = "/";
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn9.Location = new System.Drawing.Point(88, 120);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(32, 32);
            this.btn9.TabIndex = 6;
            this.btn9.TabStop = false;
            this.btn9.Text = "9";
            this.btn9.Click += new System.EventHandler(this.zahl_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(136, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 32);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "+";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(136, 80);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(32, 32);
            this.btnSubtract.TabIndex = 4;
            this.btnSubtract.TabStop = false;
            this.btnSubtract.Text = "-";
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.Location = new System.Drawing.Point(88, 200);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(32, 32);
            this.btnDecimal.TabIndex = 17;
            this.btnDecimal.TabStop = false;
            this.btnDecimal.Text = ".";
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(8, 200);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(32, 32);
            this.btnClear.TabIndex = 0;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "C";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(8, 8);
            this.txtResult.Name = "txtResult";
            this.txtResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtResult.Size = new System.Drawing.Size(160, 23);
            this.txtResult.TabIndex = 15;
            this.txtResult.TabStop = false;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResult.Enter += new System.EventHandler(this.txtResult_Enter);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(136, 120);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(32, 32);
            this.btnMultiply.TabIndex = 3;
            this.btnMultiply.TabStop = false;
            this.btnMultiply.Text = "*";
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn5.Location = new System.Drawing.Point(48, 80);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(32, 32);
            this.btn5.TabIndex = 10;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.Click += new System.EventHandler(this.zahl_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(48, 120);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(32, 32);
            this.btn8.TabIndex = 7;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.Click += new System.EventHandler(this.zahl_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(136, 200);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(32, 32);
            this.btnEquals.TabIndex = 1;
            this.btnEquals.TabStop = false;
            this.btnEquals.Text = "=";
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegative.Location = new System.Drawing.Point(48, 200);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(32, 32);
            this.btnNegative.TabIndex = 16;
            this.btnNegative.TabStop = false;
            this.btnNegative.Text = "+/-";
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btnModulo
            // 
            this.btnModulo.Location = new System.Drawing.Point(88, 160);
            this.btnModulo.Name = "btnModulo";
            this.btnModulo.Size = new System.Drawing.Size(32, 32);
            this.btnModulo.TabIndex = 18;
            this.btnModulo.Text = "%";
            this.btnModulo.UseVisualStyleBackColor = true;
            this.btnModulo.Click += new System.EventHandler(this.btnModulo_Click);
            // 
            // btn_sqrt
            // 
            this.btn_sqrt.Location = new System.Drawing.Point(8, 160);
            this.btn_sqrt.Name = "btn_sqrt";
            this.btn_sqrt.Size = new System.Drawing.Size(32, 32);
            this.btn_sqrt.TabIndex = 19;
            this.btn_sqrt.Text = "sqrt";
            this.btn_sqrt.UseVisualStyleBackColor = true;
            this.btn_sqrt.Click += new System.EventHandler(this.btn_sqrt_Click);
            // 
            // frmWinCalcA
            // 
            this.AcceptButton = this.btnEquals;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(176, 243);
            this.Controls.Add(this.btn_sqrt);
            this.Controls.Add(this.btnModulo);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnAdd);
            this.KeyPreview = true;
            this.Name = "frmWinCalcA";
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Btn_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Btn_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnDecimal;


        #endregion
        private System.Windows.Forms.Button btnModulo;
        private System.Windows.Forms.Button btn_sqrt;
    }
}

