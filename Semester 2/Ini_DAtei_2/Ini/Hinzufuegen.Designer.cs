namespace Ini_DAtei
{
    partial class Bearbeitung_Hinzufuegen
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
            this.fertigUndNeueSektionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vorgehenweiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Sektion_Textbox = new System.Windows.Forms.TextBox();
            this.sektion_label = new System.Windows.Forms.Label();
            this.attribut_label = new System.Windows.Forms.Label();
            this.wert_label = new System.Windows.Forms.Label();
            this.Attribut_TextBox = new System.Windows.Forms.TextBox();
            this.wert_Textbox = new System.Windows.Forms.TextBox();
            this.abbrechen_Button = new System.Windows.Forms.Button();
            this.zurueck_button = new System.Windows.Forms.Button();
            this.fertig_Button = new System.Windows.Forms.Button();
            this.weitere_Attribute_Button = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(582, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fertigUndNeueSektionToolStripMenuItem,
            this.schließenToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // fertigUndNeueSektionToolStripMenuItem
            // 
            this.fertigUndNeueSektionToolStripMenuItem.Name = "fertigUndNeueSektionToolStripMenuItem";
            this.fertigUndNeueSektionToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.fertigUndNeueSektionToolStripMenuItem.Text = "Fertig und neue Sektion";
            // 
            // schließenToolStripMenuItem
            // 
            this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
            this.schließenToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.schließenToolStripMenuItem.Text = "Schließen";
            // 
            // vorgehenweiseToolStripMenuItem
            // 
            this.vorgehenweiseToolStripMenuItem.Name = "vorgehenweiseToolStripMenuItem";
            this.vorgehenweiseToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.vorgehenweiseToolStripMenuItem.Text = "Vorgehenweise";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Sektion_Textbox
            // 
            this.Sektion_Textbox.Location = new System.Drawing.Point(32, 98);
            this.Sektion_Textbox.Name = "Sektion_Textbox";
            this.Sektion_Textbox.Size = new System.Drawing.Size(524, 22);
            this.Sektion_Textbox.TabIndex = 2;
            this.Sektion_Textbox.TextChanged += new System.EventHandler(this.Sektion_Textbox_TextChanged);
            // 
            // sektion_label
            // 
            this.sektion_label.AutoSize = true;
            this.sektion_label.Location = new System.Drawing.Point(29, 78);
            this.sektion_label.Name = "sektion_label";
            this.sektion_label.Size = new System.Drawing.Size(90, 17);
            this.sektion_label.TabIndex = 3;
            this.sektion_label.Text = "Sektionname";
            // 
            // attribut_label
            // 
            this.attribut_label.AutoSize = true;
            this.attribut_label.Location = new System.Drawing.Point(29, 135);
            this.attribut_label.Name = "attribut_label";
            this.attribut_label.Size = new System.Drawing.Size(61, 17);
            this.attribut_label.TabIndex = 4;
            this.attribut_label.Text = "Attribute";
            // 
            // wert_label
            // 
            this.wert_label.AutoSize = true;
            this.wert_label.Location = new System.Drawing.Point(29, 194);
            this.wert_label.Name = "wert_label";
            this.wert_label.Size = new System.Drawing.Size(46, 17);
            this.wert_label.TabIndex = 5;
            this.wert_label.Text = "Werte";
            // 
            // Attribut_TextBox
            // 
            this.Attribut_TextBox.Location = new System.Drawing.Point(32, 155);
            this.Attribut_TextBox.Name = "Attribut_TextBox";
            this.Attribut_TextBox.Size = new System.Drawing.Size(524, 22);
            this.Attribut_TextBox.TabIndex = 6;
            this.Attribut_TextBox.TextChanged += new System.EventHandler(this.Attribut_TextBox_TextChanged);
            // 
            // wert_Textbox
            // 
            this.wert_Textbox.Location = new System.Drawing.Point(32, 214);
            this.wert_Textbox.Name = "wert_Textbox";
            this.wert_Textbox.Size = new System.Drawing.Size(524, 22);
            this.wert_Textbox.TabIndex = 7;
            // 
            // abbrechen_Button
            // 
            this.abbrechen_Button.Location = new System.Drawing.Point(32, 264);
            this.abbrechen_Button.Name = "abbrechen_Button";
            this.abbrechen_Button.Size = new System.Drawing.Size(100, 60);
            this.abbrechen_Button.TabIndex = 8;
            this.abbrechen_Button.Text = "Abbrechen";
            this.abbrechen_Button.UseVisualStyleBackColor = true;
            this.abbrechen_Button.Click += new System.EventHandler(this.abbrechen_Button_Click);
            // 
            // zurueck_button
            // 
            this.zurueck_button.Location = new System.Drawing.Point(174, 264);
            this.zurueck_button.Name = "zurueck_button";
            this.zurueck_button.Size = new System.Drawing.Size(100, 60);
            this.zurueck_button.TabIndex = 9;
            this.zurueck_button.Text = "Zurück";
            this.zurueck_button.UseVisualStyleBackColor = true;
            this.zurueck_button.Click += new System.EventHandler(this.zurueck_button_Click);
            // 
            // fertig_Button
            // 
            this.fertig_Button.Location = new System.Drawing.Point(309, 264);
            this.fertig_Button.Name = "fertig_Button";
            this.fertig_Button.Size = new System.Drawing.Size(100, 60);
            this.fertig_Button.TabIndex = 10;
            this.fertig_Button.Text = "Fertig";
            this.fertig_Button.UseVisualStyleBackColor = true;
            this.fertig_Button.Click += new System.EventHandler(this.fertig_Button_Click);
            // 
            // weitere_Attribute_Button
            // 
            this.weitere_Attribute_Button.Location = new System.Drawing.Point(458, 264);
            this.weitere_Attribute_Button.Name = "weitere_Attribute_Button";
            this.weitere_Attribute_Button.Size = new System.Drawing.Size(100, 60);
            this.weitere_Attribute_Button.TabIndex = 11;
            this.weitere_Attribute_Button.Text = "weitere Attribute";
            this.weitere_Attribute_Button.UseVisualStyleBackColor = true;
            this.weitere_Attribute_Button.Click += new System.EventHandler(this.weitere_Attribute_Button_Click);
            // 
            // Bearbeitung_Hinzufuegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 338);
            this.Controls.Add(this.weitere_Attribute_Button);
            this.Controls.Add(this.fertig_Button);
            this.Controls.Add(this.zurueck_button);
            this.Controls.Add(this.abbrechen_Button);
            this.Controls.Add(this.wert_Textbox);
            this.Controls.Add(this.Attribut_TextBox);
            this.Controls.Add(this.wert_label);
            this.Controls.Add(this.attribut_label);
            this.Controls.Add(this.sektion_label);
            this.Controls.Add(this.Sektion_Textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Bearbeitung_Hinzufuegen";
            this.Text = "Bearbeitung_Hinzufuegen";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fertigUndNeueSektionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vorgehenweiseToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Sektion_Textbox;
        private System.Windows.Forms.Label sektion_label;
        private System.Windows.Forms.Label attribut_label;
        private System.Windows.Forms.Label wert_label;
        private System.Windows.Forms.TextBox Attribut_TextBox;
        private System.Windows.Forms.TextBox wert_Textbox;
        private System.Windows.Forms.Button abbrechen_Button;
        private System.Windows.Forms.Button zurueck_button;
        private System.Windows.Forms.Button fertig_Button;
        private System.Windows.Forms.Button weitere_Attribute_Button;
    }
}