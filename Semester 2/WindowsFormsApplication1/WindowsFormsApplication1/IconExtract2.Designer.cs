namespace MyLibTest
{
    partial class IconExtract2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.small_icon = new System.Windows.Forms.CheckBox();
            this.tbt_Filaname = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.excel_open_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 66);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(117, 75);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // small_icon
            // 
            this.small_icon.AutoSize = true;
            this.small_icon.Location = new System.Drawing.Point(13, 128);
            this.small_icon.Name = "small_icon";
            this.small_icon.Size = new System.Drawing.Size(78, 17);
            this.small_icon.TabIndex = 3;
            this.small_icon.Text = "Small_Icon";
            this.small_icon.UseVisualStyleBackColor = true;
            this.small_icon.CheckedChanged += new System.EventHandler(this.big_icon_CheckedChanged);
            // 
            // tbt_Filaname
            // 
            this.tbt_Filaname.Location = new System.Drawing.Point(117, 12);
            this.tbt_Filaname.Name = "tbt_Filaname";
            this.tbt_Filaname.Size = new System.Drawing.Size(258, 20);
            this.tbt_Filaname.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Open_file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Start.Location = new System.Drawing.Point(275, 57);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(86, 53);
            this.btn_Start.TabIndex = 6;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.button3_Click);
            // 
            // excel_open_Button
            // 
            this.excel_open_Button.Location = new System.Drawing.Point(193, 180);
            this.excel_open_Button.Name = "excel_open_Button";
            this.excel_open_Button.Size = new System.Drawing.Size(75, 23);
            this.excel_open_Button.TabIndex = 15;
            this.excel_open_Button.Text = "Excel Open";
            this.excel_open_Button.UseVisualStyleBackColor = true;
            this.excel_open_Button.Click += new System.EventHandler(this.excel_open_Button_Click);
            // 
            // IconExtract2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 262);
            this.Controls.Add(this.excel_open_Button);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbt_Filaname);
            this.Controls.Add(this.small_icon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "IconExtract2";
            this.Text = "IconExtract";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox small_icon;
        private System.Windows.Forms.TextBox tbt_Filaname;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button excel_open_Button;
    }
}