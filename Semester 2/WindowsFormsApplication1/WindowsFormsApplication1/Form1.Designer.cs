namespace MyLibTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.Value = new System.Windows.Forms.TextBox();
            this.Att = new System.Windows.Forms.TextBox();
            this.SectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.excel_open_Button = new System.Windows.Forms.Button();
            this.tbStartFolder = new System.Windows.Forms.TextBox();
            this.iteratorStart = new System.Windows.Forms.Button();
            this.btnDirselect = new System.Windows.Forms.Button();
            this.numTextbox1 = new MyLib.NumTextbox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(233, 38);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(100, 20);
            this.Value.TabIndex = 1;
            // 
            // Att
            // 
            this.Att.Location = new System.Drawing.Point(118, 38);
            this.Att.Name = "Att";
            this.Att.Size = new System.Drawing.Size(100, 20);
            this.Att.TabIndex = 2;
            // 
            // SectName
            // 
            this.SectName.Location = new System.Drawing.Point(12, 38);
            this.SectName.Name = "SectName";
            this.SectName.Size = new System.Drawing.Size(100, 20);
            this.SectName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sectionname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Att";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Value";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(503, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(204, 420);
            this.listBox1.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(37, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Sect_anzeigen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(37, 165);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(253, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Attribut_Hinzu";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(190, 195);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            // 
            // excel_open_Button
            // 
            this.excel_open_Button.Location = new System.Drawing.Point(22, 349);
            this.excel_open_Button.Name = "excel_open_Button";
            this.excel_open_Button.Size = new System.Drawing.Size(75, 23);
            this.excel_open_Button.TabIndex = 14;
            this.excel_open_Button.Text = "Excel Open";
            this.excel_open_Button.UseVisualStyleBackColor = true;
            this.excel_open_Button.Click += new System.EventHandler(this.excel_open_Button_Click);
            // 
            // tbStartFolder
            // 
            this.tbStartFolder.Location = new System.Drawing.Point(139, 303);
            this.tbStartFolder.Name = "tbStartFolder";
            this.tbStartFolder.Size = new System.Drawing.Size(303, 20);
            this.tbStartFolder.TabIndex = 15;
            // 
            // iteratorStart
            // 
            this.iteratorStart.Location = new System.Drawing.Point(139, 329);
            this.iteratorStart.Name = "iteratorStart";
            this.iteratorStart.Size = new System.Drawing.Size(75, 23);
            this.iteratorStart.TabIndex = 16;
            this.iteratorStart.Text = "Start";
            this.iteratorStart.UseVisualStyleBackColor = true;
            this.iteratorStart.Click += new System.EventHandler(this.iteratorStart_Click);
            // 
            // btnDirselect
            // 
            this.btnDirselect.Location = new System.Drawing.Point(448, 302);
            this.btnDirselect.Name = "btnDirselect";
            this.btnDirselect.Size = new System.Drawing.Size(36, 23);
            this.btnDirselect.TabIndex = 17;
            this.btnDirselect.Text = "...";
            this.btnDirselect.UseVisualStyleBackColor = true;
            this.btnDirselect.Click += new System.EventHandler(this.btnDirselect_Click);
            // 
            // numTextbox1
            // 
            this.numTextbox1.Location = new System.Drawing.Point(2, 305);
            this.numTextbox1.MaxAnzStellen = 5;
            this.numTextbox1.Name = "numTextbox1";
            this.numTextbox1.Size = new System.Drawing.Size(100, 20);
            this.numTextbox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.btnDirselect);
            this.Controls.Add(this.iteratorStart);
            this.Controls.Add(this.tbStartFolder);
            this.Controls.Add(this.excel_open_Button);
            this.Controls.Add(this.numTextbox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SectName);
            this.Controls.Add(this.Att);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.TextBox Att;
        private System.Windows.Forms.TextBox SectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private MyLib.NumTextbox numTextbox1;
        private System.Windows.Forms.Button excel_open_Button;
        private System.Windows.Forms.TextBox tbStartFolder;
        private System.Windows.Forms.Button iteratorStart;
        private System.Windows.Forms.Button btnDirselect;
    }
}

