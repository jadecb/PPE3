namespace PPE_4
{
    partial class GestionCompteRendus
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
            this.labGestion = new System.Windows.Forms.Label();
            this.GB = new System.Windows.Forms.GroupBox();
            this.CBOXComptesRendus = new System.Windows.Forms.CheckBox();
            this.CBOXVisiteurs = new System.Windows.Forms.CheckBox();
            this.CBOXPraticiens = new System.Windows.Forms.CheckBox();
            this.CBOXMedicament = new System.Windows.Forms.CheckBox();
            this.CBOXQuitter = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labGestion
            // 
            this.labGestion.AutoSize = true;
            this.labGestion.Font = new System.Drawing.Font("PMingLiU-ExtB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGestion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labGestion.Location = new System.Drawing.Point(198, 35);
            this.labGestion.Name = "labGestion";
            this.labGestion.Size = new System.Drawing.Size(353, 29);
            this.labGestion.TabIndex = 0;
            this.labGestion.Text = "Gestion des comptes rendus";
            // 
            // GB
            // 
            this.GB.BackColor = System.Drawing.SystemColors.Control;
            this.GB.Controls.Add(this.CBOXQuitter);
            this.GB.Controls.Add(this.CBOXMedicament);
            this.GB.Controls.Add(this.CBOXPraticiens);
            this.GB.Controls.Add(this.CBOXVisiteurs);
            this.GB.Controls.Add(this.CBOXComptesRendus);
            this.GB.Location = new System.Drawing.Point(188, 67);
            this.GB.Name = "GB";
            this.GB.Size = new System.Drawing.Size(595, 354);
            this.GB.TabIndex = 2;
            this.GB.TabStop = false;
            // 
            // CBOXComptesRendus
            // 
            this.CBOXComptesRendus.AutoSize = true;
            this.CBOXComptesRendus.Location = new System.Drawing.Point(15, 43);
            this.CBOXComptesRendus.Name = "CBOXComptesRendus";
            this.CBOXComptesRendus.Size = new System.Drawing.Size(107, 17);
            this.CBOXComptesRendus.TabIndex = 0;
            this.CBOXComptesRendus.Text = "Comptes-Rendus";
            this.CBOXComptesRendus.UseVisualStyleBackColor = true;
            // 
            // CBOXVisiteurs
            // 
            this.CBOXVisiteurs.AutoSize = true;
            this.CBOXVisiteurs.Location = new System.Drawing.Point(15, 66);
            this.CBOXVisiteurs.Name = "CBOXVisiteurs";
            this.CBOXVisiteurs.Size = new System.Drawing.Size(65, 17);
            this.CBOXVisiteurs.TabIndex = 1;
            this.CBOXVisiteurs.Text = "Visiteurs";
            this.CBOXVisiteurs.UseVisualStyleBackColor = true;
            // 
            // CBOXPraticiens
            // 
            this.CBOXPraticiens.AutoSize = true;
            this.CBOXPraticiens.Location = new System.Drawing.Point(15, 89);
            this.CBOXPraticiens.Name = "CBOXPraticiens";
            this.CBOXPraticiens.Size = new System.Drawing.Size(72, 17);
            this.CBOXPraticiens.TabIndex = 2;
            this.CBOXPraticiens.Text = "Praticiens";
            this.CBOXPraticiens.UseVisualStyleBackColor = true;
            // 
            // CBOXMedicament
            // 
            this.CBOXMedicament.AutoSize = true;
            this.CBOXMedicament.Location = new System.Drawing.Point(15, 112);
            this.CBOXMedicament.Name = "CBOXMedicament";
            this.CBOXMedicament.Size = new System.Drawing.Size(84, 17);
            this.CBOXMedicament.TabIndex = 3;
            this.CBOXMedicament.Text = "Medicament";
            this.CBOXMedicament.UseVisualStyleBackColor = true;
            // 
            // CBOXQuitter
            // 
            this.CBOXQuitter.AutoSize = true;
            this.CBOXQuitter.Location = new System.Drawing.Point(15, 135);
            this.CBOXQuitter.Name = "CBOXQuitter";
            this.CBOXQuitter.Size = new System.Drawing.Size(57, 17);
            this.CBOXQuitter.TabIndex = 4;
            this.CBOXQuitter.Text = "Quitter";
            this.CBOXQuitter.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PPE_4.Properties.Resources.New_Canvas2;
            this.pictureBox1.Location = new System.Drawing.Point(4, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 110);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // GestionCompteRendus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(668, 403);
            this.Controls.Add(this.GB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labGestion);
            this.Name = "GestionCompteRendus";
            this.Text = "Gestion des comptes rendus";
            this.GB.ResumeLayout(false);
            this.GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labGestion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GB;
        private System.Windows.Forms.CheckBox CBOXQuitter;
        private System.Windows.Forms.CheckBox CBOXMedicament;
        private System.Windows.Forms.CheckBox CBOXPraticiens;
        private System.Windows.Forms.CheckBox CBOXVisiteurs;
        private System.Windows.Forms.CheckBox CBOXComptesRendus;
    }
}