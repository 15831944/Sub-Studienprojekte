namespace magischesQuadrat
{
    partial class frmMainA
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
            this.btnStart = new System.Windows.Forms.Button();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.nudSizeMagicSquare = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeMagicSquare)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(138, 7);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scMain.IsSplitterFixed = true;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.nudSizeMagicSquare);
            this.scMain.Panel1.Controls.Add(this.btnStart);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.ScMainPanel2Paint);
            this.scMain.Size = new System.Drawing.Size(596, 418);
            this.scMain.SplitterDistance = 33;
            this.scMain.TabIndex = 1;
            // 
            // nudSizeMagicSquare
            // 
            this.nudSizeMagicSquare.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSizeMagicSquare.Location = new System.Drawing.Point(12, 7);
            this.nudSizeMagicSquare.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.nudSizeMagicSquare.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSizeMagicSquare.Name = "nudSizeMagicSquare";
            this.nudSizeMagicSquare.Size = new System.Drawing.Size(120, 20);
            this.nudSizeMagicSquare.TabIndex = 1;
            this.nudSizeMagicSquare.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSizeMagicSquare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudSizeMagicSquare_KeyPress);
            this.nudSizeMagicSquare.Validating += new System.ComponentModel.CancelEventHandler(this.nudSizeMagicSquare_Validating);
            // 
            // frmMainA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 418);
            this.Controls.Add(this.scMain);
            this.Name = "frmMainA";
            this.Text = "Magisches Quadrat";
            this.scMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeMagicSquare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.NumericUpDown nudSizeMagicSquare;
    }
}