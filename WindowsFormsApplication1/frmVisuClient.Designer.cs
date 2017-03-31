namespace WindowsFormsApplication1
{
    partial class frmVisuClient
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
            this.btnVoirContact = new System.Windows.Forms.Button();
            this.btnDeverouiller = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.btnValider);
            this.groupBox1.Controls.Add(this.btnQuitter);
            this.groupBox1.Controls.Add(this.btnVoirContact);
            this.groupBox1.Controls.Add(this.btnDeverouiller);
            this.groupBox1.Size = new System.Drawing.Size(528, 522);
            this.groupBox1.Controls.SetChildIndex(this.txtCommentaire, 0);
            this.groupBox1.Controls.SetChildIndex(this.lblCommentaire, 0);
            this.groupBox1.Controls.SetChildIndex(this.lblNumeroClient, 0);
            this.groupBox1.Controls.SetChildIndex(this.lblRaisonSociale, 0);
            this.groupBox1.Controls.SetChildIndex(this.lblType, 0);
            this.groupBox1.Controls.SetChildIndex(this.lblAdresse, 0);
            this.groupBox1.Controls.SetChildIndex(this.lblTelephone, 0);
            this.groupBox1.Controls.SetChildIndex(this.lblNature, 0);
            this.groupBox1.Controls.SetChildIndex(this.lblCA, 0);
            this.groupBox1.Controls.SetChildIndex(this.lblEffectif, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtRaisonSociale, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtNumeroClient, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtFaxClient, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtEmailClient, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtTelephoneClient, 0);
            this.groupBox1.Controls.SetChildIndex(this.cbxTypeClient, 0);
            this.groupBox1.Controls.SetChildIndex(this.lblEmail, 0);
            this.groupBox1.Controls.SetChildIndex(this.lblDomaine, 0);
            this.groupBox1.Controls.SetChildIndex(this.lblFax, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtAdresseClient, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtCAClient, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtDomaine, 0);
            this.groupBox1.Controls.SetChildIndex(this.cbxNatureClient, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtEffectifClient, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnDeverouiller, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnVoirContact, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnQuitter, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnValider, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnAnnuler, 0);
            // 
            // cbxNatureClient
            // 
            this.cbxNatureClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // cbxTypeClient
            // 
            this.cbxTypeClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTypeClient.Location = new System.Drawing.Point(373, 69);
            // 
            // txtNumeroClient
            // 
            this.txtNumeroClient.Location = new System.Drawing.Point(373, 16);
            // 
            // lblNumeroClient
            // 
            this.lblNumeroClient.Location = new System.Drawing.Point(314, 19);
            // 
            // btnVoirContact
            // 
            this.btnVoirContact.Location = new System.Drawing.Point(317, 226);
            this.btnVoirContact.Name = "btnVoirContact";
            this.btnVoirContact.Size = new System.Drawing.Size(172, 46);
            this.btnVoirContact.TabIndex = 4;
            this.btnVoirContact.Text = "Voir les contacts";
            this.btnVoirContact.UseVisualStyleBackColor = true;
            this.btnVoirContact.Click += new System.EventHandler(this.btnVoirContact_Click);
            // 
            // btnDeverouiller
            // 
            this.btnDeverouiller.Location = new System.Drawing.Point(140, 490);
            this.btnDeverouiller.Name = "btnDeverouiller";
            this.btnDeverouiller.Size = new System.Drawing.Size(118, 23);
            this.btnDeverouiller.TabIndex = 4;
            this.btnDeverouiller.Text = "Dévérouiller";
            this.btnDeverouiller.UseVisualStyleBackColor = true;
            this.btnDeverouiller.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(6, 490);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(128, 23);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler les mofifications";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(323, 490);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(93, 23);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(422, 490);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(93, 23);
            this.btnQuitter.TabIndex = 7;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // frmVisuClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(533, 527);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmVisuClient";
            this.Text = "Detail Client";
            this.Load += new System.EventHandler(this.frmDetailClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVoirContact;
        private System.Windows.Forms.Button btnDeverouiller;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnQuitter;
    }
}
