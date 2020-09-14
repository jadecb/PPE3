namespace PPE_4
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labIdentifier = new System.Windows.Forms.Label();
            this.TXTUtilisateur = new System.Windows.Forms.TextBox();
            this.TXTMdp = new System.Windows.Forms.TextBox();
            this.BTNOk = new System.Windows.Forms.Button();
            this.BTNQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labIdentifier
            // 
            this.labIdentifier.AutoSize = true;
            this.labIdentifier.BackColor = System.Drawing.Color.Transparent;
            this.labIdentifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIdentifier.ForeColor = System.Drawing.Color.DarkBlue;
            this.labIdentifier.Location = new System.Drawing.Point(305, 49);
            this.labIdentifier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labIdentifier.Name = "labIdentifier";
            this.labIdentifier.Size = new System.Drawing.Size(250, 39);
            this.labIdentifier.TabIndex = 0;
            this.labIdentifier.Text = "Identifiez vous";
            // 
            // TXTUtilisateur
            // 
            this.TXTUtilisateur.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TXTUtilisateur.Location = new System.Drawing.Point(313, 114);
            this.TXTUtilisateur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXTUtilisateur.Name = "TXTUtilisateur";
            this.TXTUtilisateur.Size = new System.Drawing.Size(263, 22);
            this.TXTUtilisateur.TabIndex = 1;
            // 
            // TXTMdp
            // 
            this.TXTMdp.Location = new System.Drawing.Point(313, 146);
            this.TXTMdp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXTMdp.Name = "TXTMdp";
            this.TXTMdp.Size = new System.Drawing.Size(263, 22);
            this.TXTMdp.TabIndex = 2;
            // 
            // BTNOk
            // 
            this.BTNOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNOk.ForeColor = System.Drawing.Color.DarkBlue;
            this.BTNOk.Location = new System.Drawing.Point(605, 134);
            this.BTNOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNOk.Name = "BTNOk";
            this.BTNOk.Size = new System.Drawing.Size(75, 44);
            this.BTNOk.TabIndex = 3;
            this.BTNOk.Text = "OK";
            this.BTNOk.UseVisualStyleBackColor = true;
            // 
            // BTNQuitter
            // 
            this.BTNQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNQuitter.ForeColor = System.Drawing.Color.DarkBlue;
            this.BTNQuitter.Location = new System.Drawing.Point(775, 462);
            this.BTNQuitter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNQuitter.Name = "BTNQuitter";
            this.BTNQuitter.Size = new System.Drawing.Size(104, 33);
            this.BTNQuitter.TabIndex = 4;
            this.BTNQuitter.Text = "Quitter";
            this.BTNQuitter.UseVisualStyleBackColor = true;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PPE_4.Properties.Resources.New_Canvas;
            this.ClientSize = new System.Drawing.Size(928, 563);
            this.Controls.Add(this.BTNQuitter);
            this.Controls.Add(this.BTNOk);
            this.Controls.Add(this.TXTMdp);
            this.Controls.Add(this.TXTUtilisateur);
            this.Controls.Add(this.labIdentifier);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RAPPORT_VISITE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labIdentifier;
        private System.Windows.Forms.TextBox TXTUtilisateur;
        private System.Windows.Forms.TextBox TXTMdp;
        private System.Windows.Forms.Button BTNOk;
        private System.Windows.Forms.Button BTNQuitter;
    }
}

