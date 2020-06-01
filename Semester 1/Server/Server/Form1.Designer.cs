namespace Server
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
            this.hintergrund = new System.Windows.Forms.Panel();
            this.kundenverwaltungBox = new System.Windows.Forms.GroupBox();
            this.kundenEntfernen = new System.Windows.Forms.Button();
            this.diskussionServerKundeAnfangen = new System.Windows.Forms.Button();
            this.kundenliste = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ipAdressbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameKundebox = new System.Windows.Forms.TextBox();
            this.neuerKunde = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schliessenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neueenKundenEintragenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schliessenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hintergrund.SuspendLayout();
            this.kundenverwaltungBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hintergrund
            // 
            this.hintergrund.Controls.Add(this.kundenverwaltungBox);
            this.hintergrund.Controls.Add(this.tableLayoutPanel1);
            this.hintergrund.Controls.Add(this.neuerKunde);
            this.hintergrund.Controls.Add(this.menuStrip1);
            this.hintergrund.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hintergrund.Location = new System.Drawing.Point(0, 0);
            this.hintergrund.Name = "hintergrund";
            this.hintergrund.Size = new System.Drawing.Size(484, 297);
            this.hintergrund.TabIndex = 0;
            // 
            // kundenverwaltungBox
            // 
            this.kundenverwaltungBox.Controls.Add(this.kundenEntfernen);
            this.kundenverwaltungBox.Controls.Add(this.diskussionServerKundeAnfangen);
            this.kundenverwaltungBox.Controls.Add(this.kundenliste);
            this.kundenverwaltungBox.Controls.Add(this.label3);
            this.kundenverwaltungBox.Location = new System.Drawing.Point(12, 38);
            this.kundenverwaltungBox.Name = "kundenverwaltungBox";
            this.kundenverwaltungBox.Size = new System.Drawing.Size(460, 256);
            this.kundenverwaltungBox.TabIndex = 4;
            this.kundenverwaltungBox.TabStop = false;
            this.kundenverwaltungBox.Text = "Kundenverwaltung";
            // 
            // kundenEntfernen
            // 
            this.kundenEntfernen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kundenEntfernen.Location = new System.Drawing.Point(357, 211);
            this.kundenEntfernen.Name = "kundenEntfernen";
            this.kundenEntfernen.Size = new System.Drawing.Size(97, 30);
            this.kundenEntfernen.TabIndex = 3;
            this.kundenEntfernen.Text = "Entfernen";
            this.kundenEntfernen.UseVisualStyleBackColor = true;
            this.kundenEntfernen.Click += new System.EventHandler(this.kundenEntfernen_Click);
            // 
            // diskussionServerKundeAnfangen
            // 
            this.diskussionServerKundeAnfangen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diskussionServerKundeAnfangen.Location = new System.Drawing.Point(357, 68);
            this.diskussionServerKundeAnfangen.Name = "diskussionServerKundeAnfangen";
            this.diskussionServerKundeAnfangen.Size = new System.Drawing.Size(97, 33);
            this.diskussionServerKundeAnfangen.TabIndex = 2;
            this.diskussionServerKundeAnfangen.Text = "neue Nachricht";
            this.diskussionServerKundeAnfangen.UseVisualStyleBackColor = true;
            this.diskussionServerKundeAnfangen.Click += new System.EventHandler(this.diskussionServerKundeAnfangen_Click);
            // 
            // kundenliste
            // 
            this.kundenliste.FormattingEnabled = true;
            this.kundenliste.HorizontalScrollbar = true;
            this.kundenliste.Location = new System.Drawing.Point(8, 68);
            this.kundenliste.Name = "kundenliste";
            this.kundenliste.Size = new System.Drawing.Size(316, 173);
            this.kundenliste.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kundenliste";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ipAdressbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameKundebox, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 36);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(338, 103);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ipAdressbox
            // 
            this.ipAdressbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ipAdressbox.Location = new System.Drawing.Point(172, 44);
            this.ipAdressbox.MaxLength = 12;
            this.ipAdressbox.Name = "ipAdressbox";
            this.ipAdressbox.Size = new System.Drawing.Size(163, 20);
            this.ipAdressbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP Addresse";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name ";
            // 
            // nameKundebox
            // 
            this.nameKundebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameKundebox.Location = new System.Drawing.Point(3, 44);
            this.nameKundebox.Name = "nameKundebox";
            this.nameKundebox.Size = new System.Drawing.Size(163, 20);
            this.nameKundebox.TabIndex = 2;
            // 
            // neuerKunde
            // 
            this.neuerKunde.Location = new System.Drawing.Point(356, 38);
            this.neuerKunde.Name = "neuerKunde";
            this.neuerKunde.Size = new System.Drawing.Size(75, 103);
            this.neuerKunde.TabIndex = 2;
            this.neuerKunde.Text = "neuer Kunde";
            this.neuerKunde.UseVisualStyleBackColor = true;
            this.neuerKunde.Click += new System.EventHandler(this.neuerKunde_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionenToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionenToolStripMenuItem
            // 
            this.optionenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schliessenToolStripMenuItem,
            this.neueenKundenEintragenToolStripMenuItem,
            this.schliessenToolStripMenuItem1});
            this.optionenToolStripMenuItem.Name = "optionenToolStripMenuItem";
            this.optionenToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.optionenToolStripMenuItem.Text = "Optionen";
            // 
            // schliessenToolStripMenuItem
            // 
            this.schliessenToolStripMenuItem.Name = "schliessenToolStripMenuItem";
            this.schliessenToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.schliessenToolStripMenuItem.Text = "Hauptmenü";
            this.schliessenToolStripMenuItem.Click += new System.EventHandler(this.schliessenToolStripMenuItem_Click);
            // 
            // neueenKundenEintragenToolStripMenuItem
            // 
            this.neueenKundenEintragenToolStripMenuItem.Name = "neueenKundenEintragenToolStripMenuItem";
            this.neueenKundenEintragenToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.neueenKundenEintragenToolStripMenuItem.Text = "neuen Kunden eintragen";
            this.neueenKundenEintragenToolStripMenuItem.Click += new System.EventHandler(this.neueenKundenEintragenToolStripMenuItem_Click);
            // 
            // schliessenToolStripMenuItem1
            // 
            this.schliessenToolStripMenuItem1.Name = "schliessenToolStripMenuItem1";
            this.schliessenToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.schliessenToolStripMenuItem1.Text = "Schliessen";
            this.schliessenToolStripMenuItem1.Click += new System.EventHandler(this.schliessenToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 297);
            this.Controls.Add(this.hintergrund);
            this.Name = "Form1";
            this.Text = "Hauptserver";
            this.hintergrund.ResumeLayout(false);
            this.hintergrund.PerformLayout();
            this.kundenverwaltungBox.ResumeLayout(false);
            this.kundenverwaltungBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel hintergrund;
        private System.Windows.Forms.Button neuerKunde;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox ipAdressbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameKundebox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schliessenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox kundenverwaltungBox;
        private System.Windows.Forms.Button kundenEntfernen;
        private System.Windows.Forms.Button diskussionServerKundeAnfangen;
        private System.Windows.Forms.ListBox kundenliste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem neueenKundenEintragenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schliessenToolStripMenuItem1;
    }
}

