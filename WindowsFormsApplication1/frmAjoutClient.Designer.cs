namespace WindowsFormsApplication1
{
    partial class frmAjoutClient
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
            this.components = new System.ComponentModel.Container();
            this.btnAnnulerClient = new System.Windows.Forms.Button();
            this.btnAjouterClient = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEffectif
            // 
            this.txtEffectif.Size = new System.Drawing.Size(158, 20);
            // 
            // cbxNature
            // 
            this.cbxNature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNature.Size = new System.Drawing.Size(158, 21);
            // 
            // txtCa
            // 
            this.txtCa.Size = new System.Drawing.Size(158, 20);
            // 
            // cbxTypeSociete
            // 
            this.cbxTypeSociete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTypeSociete.Size = new System.Drawing.Size(158, 21);
            // 
            // txtTelephone
            // 
            this.txtTelephone.Size = new System.Drawing.Size(158, 20);
            // 
            // txtIdClient
            // 
            this.txtIdClient.ReadOnly = true;
            this.txtIdClient.Size = new System.Drawing.Size(158, 20);
            // 
            // txtRaisonSociale
            // 
            this.txtRaisonSociale.Size = new System.Drawing.Size(158, 20);
            // 
            // cbxActivite
            // 
            this.cbxActivite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxActivite.Size = new System.Drawing.Size(158, 21);
            // 
            // btnAnnulerClient
            // 
            this.btnAnnulerClient.Location = new System.Drawing.Point(282, 46);
            this.btnAnnulerClient.Name = "btnAnnulerClient";
            this.btnAnnulerClient.Size = new System.Drawing.Size(66, 34);
            this.btnAnnulerClient.TabIndex = 47;
            this.btnAnnulerClient.Text = "Annuler";
            this.btnAnnulerClient.UseVisualStyleBackColor = true;
            this.btnAnnulerClient.Click += new System.EventHandler(this.btnAnnulerClient_Click);
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.Location = new System.Drawing.Point(282, 6);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(66, 34);
            this.btnAjouterClient.TabIndex = 48;
            this.btnAjouterClient.Text = "Ajouter un client";
            this.btnAjouterClient.UseVisualStyleBackColor = true;
            this.btnAjouterClient.Click += new System.EventHandler(this.btnValiderClient_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAjoutClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(375, 406);
            this.Controls.Add(this.btnAjouterClient);
            this.Controls.Add(this.btnAnnulerClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAjoutClient";
            this.Text = "Ajout Client";
            this.Activated += new System.EventHandler(this.frmAjoutClient_Activated);
            this.Controls.SetChildIndex(this.cbxActivite, 0);
            this.Controls.SetChildIndex(this.lblIdClient, 0);
            this.Controls.SetChildIndex(this.lblRaisonSociale, 0);
            this.Controls.SetChildIndex(this.lblTypeSociete, 0);
            this.Controls.SetChildIndex(this.lblAdresse, 0);
            this.Controls.SetChildIndex(this.lblTelephone, 0);
            this.Controls.SetChildIndex(this.lblNature, 0);
            this.Controls.SetChildIndex(this.lblCa, 0);
            this.Controls.SetChildIndex(this.lblEffectif, 0);
            this.Controls.SetChildIndex(this.txtRaisonSociale, 0);
            this.Controls.SetChildIndex(this.txtIdClient, 0);
            this.Controls.SetChildIndex(this.txtTelephone, 0);
            this.Controls.SetChildIndex(this.cbxTypeSociete, 0);
            this.Controls.SetChildIndex(this.lblActivite, 0);
            this.Controls.SetChildIndex(this.txtAdresse, 0);
            this.Controls.SetChildIndex(this.txtCa, 0);
            this.Controls.SetChildIndex(this.cbxNature, 0);
            this.Controls.SetChildIndex(this.txtEffectif, 0);
            this.Controls.SetChildIndex(this.txtCommentComm, 0);
            this.Controls.SetChildIndex(this.lblCommentComm, 0);
            this.Controls.SetChildIndex(this.btnAnnulerClient, 0);
            this.Controls.SetChildIndex(this.btnAjouterClient, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAnnulerClient;
        private System.Windows.Forms.Button btnAjouterClient;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
