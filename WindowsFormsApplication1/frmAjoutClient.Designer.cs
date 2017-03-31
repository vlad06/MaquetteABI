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
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouterContacts = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnValider);
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.btnAjouterContacts);
            this.groupBox1.Size = new System.Drawing.Size(526, 519);
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
            this.groupBox1.Controls.SetChildIndex(this.btnAjouterContacts, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnAnnuler, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnValider, 0);
            // 
            // cbxNatureClient
            // 
            this.cbxNatureClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // cbxTypeClient
            // 
            this.cbxTypeClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // lblNumeroClient
            // 
            this.lblNumeroClient.Location = new System.Drawing.Point(314, 19);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(359, 490);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 24;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(440, 490);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 25;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnAjouterContacts
            // 
            this.btnAjouterContacts.Location = new System.Drawing.Point(317, 226);
            this.btnAjouterContacts.Name = "btnAjouterContacts";
            this.btnAjouterContacts.Size = new System.Drawing.Size(172, 46);
            this.btnAjouterContacts.TabIndex = 23;
            this.btnAjouterContacts.Text = "Ajouter contact(s)";
            this.btnAjouterContacts.UseVisualStyleBackColor = true;
            this.btnAjouterContacts.Click += new System.EventHandler(this.btnAjouterContacts_Click);
            // 
            // frmAjoutClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(531, 523);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAjoutClient";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Ajout Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAjouterContacts;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
    }
}
