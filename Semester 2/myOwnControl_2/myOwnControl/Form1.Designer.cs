namespace myOwnControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.myTextBox3 = new myOwnControl.myTextBox();
            this.myTextBox2 = new myOwnControl.myTextBox();
            this.myTextBox1 = new myOwnControl.myTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "int";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "intpos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "double";
            // 
            // myTextBox3
            // 
            this.myTextBox3.Location = new System.Drawing.Point(126, 131);
            this.myTextBox3.Name = "myTextBox3";
            this.myTextBox3.showMessageBox = false;
            this.myTextBox3.Size = new System.Drawing.Size(100, 20);
            this.myTextBox3.TabIndex = 2;
            this.myTextBox3.ZahlenTyp = myOwnControl.myTextBox.eZahlenTyp.Double;
            // 
            // myTextBox2
            // 
            this.myTextBox2.Location = new System.Drawing.Point(126, 82);
            this.myTextBox2.Name = "myTextBox2";
            this.myTextBox2.showMessageBox = false;
            this.myTextBox2.Size = new System.Drawing.Size(100, 20);
            this.myTextBox2.TabIndex = 1;
            this.myTextBox2.ZahlenTyp = myOwnControl.myTextBox.eZahlenTyp.IntegerPositiv;
            // 
            // myTextBox1
            // 
            this.myTextBox1.Location = new System.Drawing.Point(126, 42);
            this.myTextBox1.Name = "myTextBox1";
            this.myTextBox1.showMessageBox = true;
            this.myTextBox1.Size = new System.Drawing.Size(100, 20);
            this.myTextBox1.TabIndex = 0;
            this.myTextBox1.ZahlenTyp = myOwnControl.myTextBox.eZahlenTyp.Integer;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(233, 44);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myTextBox3);
            this.Controls.Add(this.myTextBox2);
            this.Controls.Add(this.myTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myTextBox myTextBox1;
        private myTextBox myTextBox2;
        private myTextBox myTextBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;

    }
}

