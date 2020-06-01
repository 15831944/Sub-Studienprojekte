namespace Ini_DAtei
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
            this.datei_Inhalt_einsehen = new System.Windows.Forms.Button();
            this.dateipfad_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sektionen_ListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.attribute_Listbox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.wert_des_attribute_textbox = new System.Windows.Forms.TextBox();
            this.Loeschen_Button = new System.Windows.Forms.Button();
            this.Bearbeiten_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.hinzufuegen_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datei_Inhalt_einsehen
            // 
            this.datei_Inhalt_einsehen.Location = new System.Drawing.Point(620, 482);
            this.datei_Inhalt_einsehen.Margin = new System.Windows.Forms.Padding(4);
            this.datei_Inhalt_einsehen.Name = "datei_Inhalt_einsehen";
            this.datei_Inhalt_einsehen.Size = new System.Drawing.Size(100, 76);
            this.datei_Inhalt_einsehen.TabIndex = 0;
            this.datei_Inhalt_einsehen.Text = "Dateiinhalt einsehen";
            this.datei_Inhalt_einsehen.UseVisualStyleBackColor = true;
            this.datei_Inhalt_einsehen.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateipfad_textbox
            // 
            this.dateipfad_textbox.Location = new System.Drawing.Point(16, 42);
            this.dateipfad_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.dateipfad_textbox.Name = "dateipfad_textbox";
            this.dateipfad_textbox.Size = new System.Drawing.Size(519, 22);
            this.dateipfad_textbox.TabIndex = 1;
            this.dateipfad_textbox.TextChanged += new System.EventHandler(this.dateipfad_textbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dateipfad";
            // 
            // sektionen_ListBox
            // 
            this.sektionen_ListBox.FormattingEnabled = true;
            this.sektionen_ListBox.ItemHeight = 16;
            this.sektionen_ListBox.Location = new System.Drawing.Point(20, 138);
            this.sektionen_ListBox.Margin = new System.Windows.Forms.Padding(4);
            this.sektionen_ListBox.Name = "sektionen_ListBox";
            this.sektionen_ListBox.ScrollAlwaysVisible = true;
            this.sektionen_ListBox.Size = new System.Drawing.Size(275, 420);
            this.sektionen_ListBox.TabIndex = 4;
            this.sektionen_ListBox.SelectedIndexChanged += new System.EventHandler(this.sektionen_ListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sektionen";
            // 
            // attribute_Listbox
            // 
            this.attribute_Listbox.FormattingEnabled = true;
            this.attribute_Listbox.ItemHeight = 16;
            this.attribute_Listbox.Location = new System.Drawing.Point(331, 138);
            this.attribute_Listbox.Margin = new System.Windows.Forms.Padding(4);
            this.attribute_Listbox.Name = "attribute_Listbox";
            this.attribute_Listbox.ScrollAlwaysVisible = true;
            this.attribute_Listbox.Size = new System.Drawing.Size(269, 420);
            this.attribute_Listbox.TabIndex = 6;
            this.attribute_Listbox.SelectedIndexChanged += new System.EventHandler(this.attribute_Listbox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Attributte";
            // 
            // wert_des_attribute_textbox
            // 
            this.wert_des_attribute_textbox.Location = new System.Drawing.Point(620, 138);
            this.wert_des_attribute_textbox.Name = "wert_des_attribute_textbox";
            this.wert_des_attribute_textbox.ReadOnly = true;
            this.wert_des_attribute_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.wert_des_attribute_textbox.Size = new System.Drawing.Size(257, 22);
            this.wert_des_attribute_textbox.TabIndex = 8;
            // 
            // Loeschen_Button
            // 
            this.Loeschen_Button.Location = new System.Drawing.Point(620, 385);
            this.Loeschen_Button.Name = "Loeschen_Button";
            this.Loeschen_Button.Size = new System.Drawing.Size(100, 90);
            this.Loeschen_Button.TabIndex = 9;
            this.Loeschen_Button.Text = "Löschen";
            this.Loeschen_Button.UseVisualStyleBackColor = true;
            // 
            // Bearbeiten_Button
            // 
            this.Bearbeiten_Button.Location = new System.Drawing.Point(755, 385);
            this.Bearbeiten_Button.Name = "Bearbeiten_Button";
            this.Bearbeiten_Button.Size = new System.Drawing.Size(106, 90);
            this.Bearbeiten_Button.TabIndex = 10;
            this.Bearbeiten_Button.Text = "Bearbeiten";
            this.Bearbeiten_Button.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(617, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Wert";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(575, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(226, 37);
            this.button4.TabIndex = 12;
            this.button4.Text = "Datei durchsuchen";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // hinzufuegen_Button
            // 
            this.hinzufuegen_Button.Location = new System.Drawing.Point(755, 482);
            this.hinzufuegen_Button.Name = "hinzufuegen_Button";
            this.hinzufuegen_Button.Size = new System.Drawing.Size(106, 76);
            this.hinzufuegen_Button.TabIndex = 13;
            this.hinzufuegen_Button.Text = "Hinzufügen";
            this.hinzufuegen_Button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 592);
            this.Controls.Add(this.hinzufuegen_Button);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Bearbeiten_Button);
            this.Controls.Add(this.Loeschen_Button);
            this.Controls.Add(this.wert_des_attribute_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.attribute_Listbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sektionen_ListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateipfad_textbox);
            this.Controls.Add(this.datei_Inhalt_einsehen);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button datei_Inhalt_einsehen;
        private System.Windows.Forms.TextBox dateipfad_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox sektionen_ListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox attribute_Listbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox wert_des_attribute_textbox;
        private System.Windows.Forms.Button Bearbeiten_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Loeschen_Button;
        private System.Windows.Forms.Button hinzufuegen_Button;
    }
}

