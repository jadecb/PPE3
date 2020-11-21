namespace PPEGSB
{
    partial class FRapportsDeVisite
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btNouveau = new System.Windows.Forms.Button();
            this.btEnregistrer = new System.Windows.Forms.Button();
            this.tbxBilan = new System.Windows.Forms.RichTextBox();
            this.Precedent = new System.Windows.Forms.Button();
            this.Suivant = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbxMotif = new System.Windows.Forms.TextBox();
            this.tbxDateRapport = new System.Windows.Forms.TextBox();
            this.cbxPraticien = new System.Windows.Forms.ComboBox();
            this.tbxNumRap = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.jguillerminDataSet1 = new PPEGSB.jguillerminDataSet();
            this.svpresenterTableAdapter1 = new PPEGSB.jguillerminDataSetTableAdapters.SVPRESENTERTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jguillerminDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btNouveau);
            this.panel2.Controls.Add(this.btEnregistrer);
            this.panel2.Controls.Add(this.tbxBilan);
            this.panel2.Controls.Add(this.Precedent);
            this.panel2.Controls.Add(this.Suivant);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.tbxMotif);
            this.panel2.Controls.Add(this.tbxDateRapport);
            this.panel2.Controls.Add(this.cbxPraticien);
            this.panel2.Controls.Add(this.tbxNumRap);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(118, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 436);
            this.panel2.TabIndex = 12;
            // 
            // btNouveau
            // 
            this.btNouveau.Location = new System.Drawing.Point(688, 36);
            this.btNouveau.Name = "btNouveau";
            this.btNouveau.Size = new System.Drawing.Size(111, 52);
            this.btNouveau.TabIndex = 21;
            this.btNouveau.Text = "Nouveau";
            this.btNouveau.UseVisualStyleBackColor = true;
            this.btNouveau.Click += new System.EventHandler(this.btNouveau_Click);
            // 
            // btEnregistrer
            // 
            this.btEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btEnregistrer.Location = new System.Drawing.Point(678, 366);
            this.btEnregistrer.Name = "btEnregistrer";
            this.btEnregistrer.Size = new System.Drawing.Size(110, 38);
            this.btEnregistrer.TabIndex = 20;
            this.btEnregistrer.Text = "Enregistrer";
            this.btEnregistrer.UseVisualStyleBackColor = true;
            this.btEnregistrer.Click += new System.EventHandler(this.btEnregistrer_Click);
            // 
            // tbxBilan
            // 
            this.tbxBilan.Location = new System.Drawing.Point(87, 233);
            this.tbxBilan.Name = "tbxBilan";
            this.tbxBilan.Size = new System.Drawing.Size(157, 96);
            this.tbxBilan.TabIndex = 19;
            this.tbxBilan.Text = "";
            // 
            // Precedent
            // 
            this.Precedent.Location = new System.Drawing.Point(249, 352);
            this.Precedent.Name = "Precedent";
            this.Precedent.Size = new System.Drawing.Size(111, 52);
            this.Precedent.TabIndex = 17;
            this.Precedent.Text = "Précèdent";
            this.Precedent.UseVisualStyleBackColor = true;
            this.Precedent.Click += new System.EventHandler(this.Precedent_Click);
            // 
            // Suivant
            // 
            this.Suivant.Location = new System.Drawing.Point(407, 352);
            this.Suivant.Name = "Suivant";
            this.Suivant.Size = new System.Drawing.Size(111, 52);
            this.Suivant.TabIndex = 16;
            this.Suivant.Text = "Suivant";
            this.Suivant.UseVisualStyleBackColor = true;
            this.Suivant.Click += new System.EventHandler(this.Suivant_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label13.Location = new System.Drawing.Point(391, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(178, 25);
            this.label13.TabIndex = 15;
            this.label13.Text = "Offre d\'échantillons";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(396, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(316, 133);
            this.dataGridView1.TabIndex = 13;
            // 
            // tbxMotif
            // 
            this.tbxMotif.Location = new System.Drawing.Point(144, 196);
            this.tbxMotif.Name = "tbxMotif";
            this.tbxMotif.Size = new System.Drawing.Size(121, 20);
            this.tbxMotif.TabIndex = 13;
            // 
            // tbxDateRapport
            // 
            this.tbxDateRapport.Location = new System.Drawing.Point(144, 156);
            this.tbxDateRapport.Name = "tbxDateRapport";
            this.tbxDateRapport.Size = new System.Drawing.Size(121, 20);
            this.tbxDateRapport.TabIndex = 13;
            // 
            // cbxPraticien
            // 
            this.cbxPraticien.FormattingEnabled = true;
            this.cbxPraticien.Location = new System.Drawing.Point(144, 108);
            this.cbxPraticien.Name = "cbxPraticien";
            this.cbxPraticien.Size = new System.Drawing.Size(121, 21);
            this.cbxPraticien.TabIndex = 13;
            // 
            // tbxNumRap
            // 
            this.tbxNumRap.Enabled = false;
            this.tbxNumRap.Location = new System.Drawing.Point(183, 68);
            this.tbxNumRap.Name = "tbxNumRap";
            this.tbxNumRap.Size = new System.Drawing.Size(82, 20);
            this.tbxNumRap.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label12.Location = new System.Drawing.Point(12, 233);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 25);
            this.label12.TabIndex = 13;
            this.label12.Text = "BILAN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.Location = new System.Drawing.Point(12, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 25);
            this.label11.TabIndex = 13;
            this.label11.Text = "Motif Visite";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.Location = new System.Drawing.Point(12, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "Date Rapport";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(12, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Praticien";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(12, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Numéro Rapport";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label7.Location = new System.Drawing.Point(192, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 31);
            this.label7.TabIndex = 1;
            this.label7.Text = "Rapports De Visite";
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1031, 25);
            this.fillByToolStrip.TabIndex = 14;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // jguillerminDataSet1
            // 
            this.jguillerminDataSet1.DataSetName = "jguillerminDataSet";
            this.jguillerminDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // svpresenterTableAdapter1
            // 
            this.svpresenterTableAdapter1.ClearBeforeFill = true;
            // 
            // FRapportsDeVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 501);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.panel2);
            this.Name = "FRapportsDeVisite";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FRapportsDeVisite_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jguillerminDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxMotif;
        private System.Windows.Forms.TextBox tbxDateRapport;
        private System.Windows.Forms.ComboBox cbxPraticien;
        private System.Windows.Forms.TextBox tbxNumRap;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDDEPOTLEGALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEchantillonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Button Suivant;
        private System.Windows.Forms.Button Precedent;
        private System.Windows.Forms.RichTextBox tbxBilan;
        private System.Windows.Forms.Button btEnregistrer;
        private System.Windows.Forms.Button btNouveau;
        private jguillerminDataSet jguillerminDataSet1;
        private jguillerminDataSetTableAdapters.SVPRESENTERTableAdapter svpresenterTableAdapter1;
    }
}