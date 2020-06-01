namespace Server
{
    partial class Sever_Kunde_Diskussion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.NachrichtLoeschenButton = new System.Windows.Forms.Button();
            this.nachrichtAnKundenSendenButton = new System.Windows.Forms.Button();
            this.nachtrichtDesServers = new System.Windows.Forms.TextBox();
            this.diskussionSeverKundenBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NachrichtLoeschenButton);
            this.panel1.Controls.Add(this.nachrichtAnKundenSendenButton);
            this.panel1.Controls.Add(this.nachtrichtDesServers);
            this.panel1.Controls.Add(this.diskussionSeverKundenBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 397);
            this.panel1.TabIndex = 0;
            // 
            // NachrichtLoeschenButton
            // 
            this.NachrichtLoeschenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NachrichtLoeschenButton.Location = new System.Drawing.Point(413, 16);
            this.NachrichtLoeschenButton.Name = "NachrichtLoeschenButton";
            this.NachrichtLoeschenButton.Size = new System.Drawing.Size(75, 76);
            this.NachrichtLoeschenButton.TabIndex = 3;
            this.NachrichtLoeschenButton.Text = "Nachricht löschen";
            this.NachrichtLoeschenButton.UseVisualStyleBackColor = true;
            this.NachrichtLoeschenButton.Click += new System.EventHandler(this.NachrichtLoeschenButton_Click);
            // 
            // nachrichtAnKundenSendenButton
            // 
            this.nachrichtAnKundenSendenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nachrichtAnKundenSendenButton.Location = new System.Drawing.Point(413, 304);
            this.nachrichtAnKundenSendenButton.Name = "nachrichtAnKundenSendenButton";
            this.nachrichtAnKundenSendenButton.Size = new System.Drawing.Size(75, 81);
            this.nachrichtAnKundenSendenButton.TabIndex = 2;
            this.nachrichtAnKundenSendenButton.Text = "Nachricht senden";
            this.nachrichtAnKundenSendenButton.UseVisualStyleBackColor = true;
            this.nachrichtAnKundenSendenButton.Click += new System.EventHandler(this.nachrichtAnKundenSendenButton_Click);
            // 
            // nachtrichtDesServers
            // 
            this.nachtrichtDesServers.Location = new System.Drawing.Point(12, 304);
            this.nachtrichtDesServers.Multiline = true;
            this.nachtrichtDesServers.Name = "nachtrichtDesServers";
            this.nachtrichtDesServers.Size = new System.Drawing.Size(367, 81);
            this.nachtrichtDesServers.TabIndex = 1;
            this.nachtrichtDesServers.TextChanged += new System.EventHandler(this.nachtrichtDesServers_TextChanged);
            // 
            // diskussionSeverKundenBox
            // 
            this.diskussionSeverKundenBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diskussionSeverKundenBox.FormattingEnabled = true;
            this.diskussionSeverKundenBox.HorizontalScrollbar = true;
            this.diskussionSeverKundenBox.Location = new System.Drawing.Point(12, 16);
            this.diskussionSeverKundenBox.Name = "diskussionSeverKundenBox";
            this.diskussionSeverKundenBox.Size = new System.Drawing.Size(367, 251);
            this.diskussionSeverKundenBox.TabIndex = 0;
            // 
            // Sever_Kunde_Diskussion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 397);
            this.Controls.Add(this.panel1);
            this.Name = "Sever_Kunde_Diskussion";
            this.Text = "Sever_Kunde_Diskussion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NachrichtLoeschenButton;
        private System.Windows.Forms.Button nachrichtAnKundenSendenButton;
        private System.Windows.Forms.TextBox nachtrichtDesServers;
        private System.Windows.Forms.ListBox diskussionSeverKundenBox;
    }
}