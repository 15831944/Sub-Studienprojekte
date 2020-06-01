namespace Ini_DAtei
{
    partial class Bearbeiten_Sektion
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sektionNamenÄndernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vorgehenweiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Attribute_Listbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Wert_Textbox = new System.Windows.Forms.TextBox();
            this.aenderung_vornehmen_button = new System.Windows.Forms.Button();
            this.alles_speichern_und_schliessen_button = new System.Windows.Forms.Button();
            this.abbrechen_button = new System.Windows.Forms.Button();
            this.attribut_name_aendern_textbox = new System.Windows.Forms.TextBox();
            this.wert_aendern_textbox = new System.Windows.Forms.TextBox();
            this.attribut_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wert_label = new System.Windows.Forms.Label();
            this.loeschen_Button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.attribute_hinzufuegen_button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.vorgehenweiseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(703, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sektionNamenÄndernToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // sektionNamenÄndernToolStripMenuItem
            // 
            this.sektionNamenÄndernToolStripMenuItem.Name = "sektionNamenÄndernToolStripMenuItem";
            this.sektionNamenÄndernToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.sektionNamenÄndernToolStripMenuItem.Text = "Sektion-Namen ändern";
            // 
            // vorgehenweiseToolStripMenuItem
            // 
            this.vorgehenweiseToolStripMenuItem.Name = "vorgehenweiseToolStripMenuItem";
            this.vorgehenweiseToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.vorgehenweiseToolStripMenuItem.Text = "Vorgehenweise";
            // 
            // Attribute_Listbox
            // 
            this.Attribute_Listbox.FormattingEnabled = true;
            this.Attribute_Listbox.ItemHeight = 16;
            this.Attribute_Listbox.Location = new System.Drawing.Point(12, 121);
            this.Attribute_Listbox.Name = "Attribute_Listbox";
            this.Attribute_Listbox.ScrollAlwaysVisible = true;
            this.Attribute_Listbox.Size = new System.Drawing.Size(282, 340);
            this.Attribute_Listbox.TabIndex = 1;
            this.Attribute_Listbox.SelectedIndexChanged += new System.EventHandler(this.Attribute_Listbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Attribute";
            // 
            // Wert_Textbox
            // 
            this.Wert_Textbox.Location = new System.Drawing.Point(300, 121);
            this.Wert_Textbox.Multiline = true;
            this.Wert_Textbox.Name = "Wert_Textbox";
            this.Wert_Textbox.ReadOnly = true;
            this.Wert_Textbox.Size = new System.Drawing.Size(399, 158);
            this.Wert_Textbox.TabIndex = 3;
            // 
            // aenderung_vornehmen_button
            // 
            this.aenderung_vornehmen_button.Location = new System.Drawing.Point(300, 404);
            this.aenderung_vornehmen_button.Name = "aenderung_vornehmen_button";
            this.aenderung_vornehmen_button.Size = new System.Drawing.Size(129, 57);
            this.aenderung_vornehmen_button.TabIndex = 4;
            this.aenderung_vornehmen_button.Text = "Änderung vornehmen";
            this.aenderung_vornehmen_button.UseVisualStyleBackColor = true;
            this.aenderung_vornehmen_button.Click += new System.EventHandler(this.aenderung_vornehmen_button_Click);
            // 
            // alles_speichern_und_schliessen_button
            // 
            this.alles_speichern_und_schliessen_button.Location = new System.Drawing.Point(570, 404);
            this.alles_speichern_und_schliessen_button.Name = "alles_speichern_und_schliessen_button";
            this.alles_speichern_und_schliessen_button.Size = new System.Drawing.Size(129, 57);
            this.alles_speichern_und_schliessen_button.TabIndex = 5;
            this.alles_speichern_und_schliessen_button.Text = "Alles Speichern und Schließen";
            this.alles_speichern_und_schliessen_button.UseVisualStyleBackColor = true;
            this.alles_speichern_und_schliessen_button.Click += new System.EventHandler(this.alles_speichern_und_schliessen_button_Click);
            // 
            // abbrechen_button
            // 
            this.abbrechen_button.Location = new System.Drawing.Point(570, 478);
            this.abbrechen_button.Name = "abbrechen_button";
            this.abbrechen_button.Size = new System.Drawing.Size(129, 57);
            this.abbrechen_button.TabIndex = 6;
            this.abbrechen_button.Text = "Abbrechen";
            this.abbrechen_button.UseVisualStyleBackColor = true;
            this.abbrechen_button.Click += new System.EventHandler(this.abbrechen_button_Click);
            // 
            // attribut_name_aendern_textbox
            // 
            this.attribut_name_aendern_textbox.Location = new System.Drawing.Point(300, 313);
            this.attribut_name_aendern_textbox.Name = "attribut_name_aendern_textbox";
            this.attribut_name_aendern_textbox.Size = new System.Drawing.Size(399, 22);
            this.attribut_name_aendern_textbox.TabIndex = 7;
            // 
            // wert_aendern_textbox
            // 
            this.wert_aendern_textbox.Location = new System.Drawing.Point(300, 357);
            this.wert_aendern_textbox.Name = "wert_aendern_textbox";
            this.wert_aendern_textbox.Size = new System.Drawing.Size(399, 22);
            this.wert_aendern_textbox.TabIndex = 8;
            // 
            // attribut_label
            // 
            this.attribut_label.AutoSize = true;
            this.attribut_label.Location = new System.Drawing.Point(301, 290);
            this.attribut_label.Name = "attribut_label";
            this.attribut_label.Size = new System.Drawing.Size(144, 17);
            this.attribut_label.TabIndex = 9;
            this.attribut_label.Text = "zu änderndes Attribut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Werte";
            // 
            // wert_label
            // 
            this.wert_label.AutoSize = true;
            this.wert_label.Location = new System.Drawing.Point(301, 338);
            this.wert_label.Name = "wert_label";
            this.wert_label.Size = new System.Drawing.Size(127, 17);
            this.wert_label.TabIndex = 11;
            this.wert_label.Text = "zu ändernder Wert";
            // 
            // loeschen_Button
            // 
            this.loeschen_Button.Location = new System.Drawing.Point(435, 404);
            this.loeschen_Button.Name = "loeschen_Button";
            this.loeschen_Button.Size = new System.Drawing.Size(129, 57);
            this.loeschen_Button.TabIndex = 12;
            this.loeschen_Button.Text = "Löschen";
            this.loeschen_Button.UseVisualStyleBackColor = true;
            this.loeschen_Button.Click += new System.EventHandler(this.loeschen_Button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            // 
            // attribute_hinzufuegen_button
            // 
            this.attribute_hinzufuegen_button.Location = new System.Drawing.Point(435, 478);
            this.attribute_hinzufuegen_button.Name = "attribute_hinzufuegen_button";
            this.attribute_hinzufuegen_button.Size = new System.Drawing.Size(129, 57);
            this.attribute_hinzufuegen_button.TabIndex = 14;
            this.attribute_hinzufuegen_button.Text = "Attribute Hinzufügen";
            this.attribute_hinzufuegen_button.UseVisualStyleBackColor = true;
            this.attribute_hinzufuegen_button.Click += new System.EventHandler(this.attribute_hinzufuegen_button_Click);
            // 
            // Bearbeiten_Sektion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 609);
            this.Controls.Add(this.attribute_hinzufuegen_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.loeschen_Button);
            this.Controls.Add(this.wert_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.attribut_label);
            this.Controls.Add(this.wert_aendern_textbox);
            this.Controls.Add(this.attribut_name_aendern_textbox);
            this.Controls.Add(this.abbrechen_button);
            this.Controls.Add(this.alles_speichern_und_schliessen_button);
            this.Controls.Add(this.aenderung_vornehmen_button);
            this.Controls.Add(this.Wert_Textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Attribute_Listbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Bearbeiten_Sektion";
            this.Text = "1 wq";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sektionNamenÄndernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vorgehenweiseToolStripMenuItem;
        private System.Windows.Forms.ListBox Attribute_Listbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Wert_Textbox;
        private System.Windows.Forms.Button aenderung_vornehmen_button;
        private System.Windows.Forms.Button alles_speichern_und_schliessen_button;
        private System.Windows.Forms.Button abbrechen_button;
        private System.Windows.Forms.TextBox attribut_name_aendern_textbox;
        private System.Windows.Forms.TextBox wert_aendern_textbox;
        private System.Windows.Forms.Label attribut_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label wert_label;
        private System.Windows.Forms.Button loeschen_Button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button attribute_hinzufuegen_button;
    }
}