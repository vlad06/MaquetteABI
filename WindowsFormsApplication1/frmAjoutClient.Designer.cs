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
            this.btnAjouterContact = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnulerClient = new System.Windows.Forms.Button();
            this.btnValiderClient = new System.Windows.Forms.Button();
            this.btnSupprimerContact = new System.Windows.Forms.Button();
            this.gbxAjoutContact = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.txtTotalHeures = new System.Windows.Forms.TextBox();
            this.lblTotalHeures = new System.Windows.Forms.Label();
            this.lblFonctionContact = new System.Windows.Forms.Label();
            this.lblIdContact = new System.Windows.Forms.Label();
            this.txtIdContact = new System.Windows.Forms.TextBox();
            this.txtTelephoneContact = new System.Windows.Forms.TextBox();
            this.lblNomContact = new System.Windows.Forms.Label();
            this.txtNomContact = new System.Windows.Forms.TextBox();
            this.lblPrenomContact = new System.Windows.Forms.Label();
            this.txtPrenomContact = new System.Windows.Forms.TextBox();
            this.txtFonctionContact = new System.Windows.Forms.TextBox();
            this.lblTelephoneContact = new System.Windows.Forms.Label();
            this.grdContact = new System.Windows.Forms.DataGridView();
            this.gbxListeContact = new System.Windows.Forms.GroupBox();
            this.gbxAjoutContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContact)).BeginInit();
            this.gbxListeContact.SuspendLayout();
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
            this.txtIdClient.Size = new System.Drawing.Size(158, 20);
            // 
            // txtRaisonSociale
            // 
            this.txtRaisonSociale.Size = new System.Drawing.Size(158, 20);
            // 
            // cbxActivite
            // 
            this.cbxActivite.Size = new System.Drawing.Size(158, 21);
            // 
            // btnAjouterContact
            // 
            this.btnAjouterContact.Location = new System.Drawing.Point(270, 6);
            this.btnAjouterContact.Name = "btnAjouterContact";
            this.btnAjouterContact.Size = new System.Drawing.Size(78, 40);
            this.btnAjouterContact.TabIndex = 45;
            this.btnAjouterContact.Text = "Ajouter un contact >>";
            this.btnAjouterContact.UseVisualStyleBackColor = true;
            this.btnAjouterContact.Click += new System.EventHandler(this.btnAjouterContact_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(333, 91);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(70, 23);
            this.btnAjouter.TabIndex = 33;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnAnnulerClient
            // 
            this.btnAnnulerClient.Location = new System.Drawing.Point(179, 408);
            this.btnAnnulerClient.Name = "btnAnnulerClient";
            this.btnAnnulerClient.Size = new System.Drawing.Size(70, 23);
            this.btnAnnulerClient.TabIndex = 47;
            this.btnAnnulerClient.Text = "Annuler";
            this.btnAnnulerClient.UseVisualStyleBackColor = true;
            this.btnAnnulerClient.Click += new System.EventHandler(this.btnAnnulerClient_Click);
            // 
            // btnValiderClient
            // 
            this.btnValiderClient.Location = new System.Drawing.Point(255, 408);
            this.btnValiderClient.Name = "btnValiderClient";
            this.btnValiderClient.Size = new System.Drawing.Size(93, 23);
            this.btnValiderClient.TabIndex = 48;
            this.btnValiderClient.Text = "Ajouter un client";
            this.btnValiderClient.UseVisualStyleBackColor = true;
            this.btnValiderClient.Click += new System.EventHandler(this.btnValiderClient_Click);
            // 
            // btnSupprimerContact
            // 
            this.btnSupprimerContact.Location = new System.Drawing.Point(270, 170);
            this.btnSupprimerContact.Name = "btnSupprimerContact";
            this.btnSupprimerContact.Size = new System.Drawing.Size(78, 40);
            this.btnSupprimerContact.TabIndex = 46;
            this.btnSupprimerContact.Text = "Supprimer un contact";
            this.btnSupprimerContact.UseVisualStyleBackColor = true;
            // 
            // gbxAjoutContact
            // 
            this.gbxAjoutContact.Controls.Add(this.btnAnnuler);
            this.gbxAjoutContact.Controls.Add(this.txtTotalHeures);
            this.gbxAjoutContact.Controls.Add(this.lblTotalHeures);
            this.gbxAjoutContact.Controls.Add(this.btnAjouter);
            this.gbxAjoutContact.Controls.Add(this.lblFonctionContact);
            this.gbxAjoutContact.Controls.Add(this.lblIdContact);
            this.gbxAjoutContact.Controls.Add(this.txtIdContact);
            this.gbxAjoutContact.Controls.Add(this.txtTelephoneContact);
            this.gbxAjoutContact.Controls.Add(this.lblNomContact);
            this.gbxAjoutContact.Controls.Add(this.txtNomContact);
            this.gbxAjoutContact.Controls.Add(this.lblPrenomContact);
            this.gbxAjoutContact.Controls.Add(this.txtPrenomContact);
            this.gbxAjoutContact.Controls.Add(this.txtFonctionContact);
            this.gbxAjoutContact.Controls.Add(this.lblTelephoneContact);
            this.gbxAjoutContact.Location = new System.Drawing.Point(354, 6);
            this.gbxAjoutContact.Name = "gbxAjoutContact";
            this.gbxAjoutContact.Size = new System.Drawing.Size(415, 120);
            this.gbxAjoutContact.TabIndex = 48;
            this.gbxAjoutContact.TabStop = false;
            this.gbxAjoutContact.Text = "Ajouter un contact :";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(257, 91);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(70, 23);
            this.btnAnnuler.TabIndex = 38;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // txtTotalHeures
            // 
            this.txtTotalHeures.Location = new System.Drawing.Point(283, 65);
            this.txtTotalHeures.Name = "txtTotalHeures";
            this.txtTotalHeures.Size = new System.Drawing.Size(120, 20);
            this.txtTotalHeures.TabIndex = 31;
            // 
            // lblTotalHeures
            // 
            this.lblTotalHeures.AutoSize = true;
            this.lblTotalHeures.Location = new System.Drawing.Point(203, 68);
            this.lblTotalHeures.Name = "lblTotalHeures";
            this.lblTotalHeures.Size = new System.Drawing.Size(74, 13);
            this.lblTotalHeures.TabIndex = 36;
            this.lblTotalHeures.Text = "Total Heures :";
            // 
            // lblFonctionContact
            // 
            this.lblFonctionContact.AutoSize = true;
            this.lblFonctionContact.Location = new System.Drawing.Point(203, 16);
            this.lblFonctionContact.Name = "lblFonctionContact";
            this.lblFonctionContact.Size = new System.Drawing.Size(54, 13);
            this.lblFonctionContact.TabIndex = 35;
            this.lblFonctionContact.Text = "Fonction :";
            // 
            // lblIdContact
            // 
            this.lblIdContact.AutoSize = true;
            this.lblIdContact.Location = new System.Drawing.Point(6, 16);
            this.lblIdContact.Name = "lblIdContact";
            this.lblIdContact.Size = new System.Drawing.Size(65, 13);
            this.lblIdContact.TabIndex = 20;
            this.lblIdContact.Text = "N° Contact :";
            // 
            // txtIdContact
            // 
            this.txtIdContact.Location = new System.Drawing.Point(77, 13);
            this.txtIdContact.Name = "txtIdContact";
            this.txtIdContact.Size = new System.Drawing.Size(120, 20);
            this.txtIdContact.TabIndex = 26;
            // 
            // txtTelephoneContact
            // 
            this.txtTelephoneContact.Location = new System.Drawing.Point(283, 39);
            this.txtTelephoneContact.Name = "txtTelephoneContact";
            this.txtTelephoneContact.Size = new System.Drawing.Size(120, 20);
            this.txtTelephoneContact.TabIndex = 30;
            // 
            // lblNomContact
            // 
            this.lblNomContact.AutoSize = true;
            this.lblNomContact.Location = new System.Drawing.Point(6, 42);
            this.lblNomContact.Name = "lblNomContact";
            this.lblNomContact.Size = new System.Drawing.Size(35, 13);
            this.lblNomContact.TabIndex = 21;
            this.lblNomContact.Text = "Nom :";
            // 
            // txtNomContact
            // 
            this.txtNomContact.Location = new System.Drawing.Point(77, 39);
            this.txtNomContact.Name = "txtNomContact";
            this.txtNomContact.Size = new System.Drawing.Size(120, 20);
            this.txtNomContact.TabIndex = 27;
            // 
            // lblPrenomContact
            // 
            this.lblPrenomContact.AutoSize = true;
            this.lblPrenomContact.Location = new System.Drawing.Point(6, 68);
            this.lblPrenomContact.Name = "lblPrenomContact";
            this.lblPrenomContact.Size = new System.Drawing.Size(49, 13);
            this.lblPrenomContact.TabIndex = 22;
            this.lblPrenomContact.Text = "Prénom :";
            // 
            // txtPrenomContact
            // 
            this.txtPrenomContact.Location = new System.Drawing.Point(77, 65);
            this.txtPrenomContact.Name = "txtPrenomContact";
            this.txtPrenomContact.Size = new System.Drawing.Size(120, 20);
            this.txtPrenomContact.TabIndex = 28;
            // 
            // txtFonctionContact
            // 
            this.txtFonctionContact.Location = new System.Drawing.Point(283, 13);
            this.txtFonctionContact.Name = "txtFonctionContact";
            this.txtFonctionContact.Size = new System.Drawing.Size(120, 20);
            this.txtFonctionContact.TabIndex = 29;
            // 
            // lblTelephoneContact
            // 
            this.lblTelephoneContact.AutoSize = true;
            this.lblTelephoneContact.Location = new System.Drawing.Point(203, 42);
            this.lblTelephoneContact.Name = "lblTelephoneContact";
            this.lblTelephoneContact.Size = new System.Drawing.Size(64, 13);
            this.lblTelephoneContact.TabIndex = 23;
            this.lblTelephoneContact.Text = "Téléphone :";
            // 
            // grdContact
            // 
            this.grdContact.AllowUserToAddRows = false;
            this.grdContact.AllowUserToDeleteRows = false;
            this.grdContact.AllowUserToOrderColumns = true;
            this.grdContact.AllowUserToResizeRows = false;
            this.grdContact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContact.Location = new System.Drawing.Point(6, 19);
            this.grdContact.MultiSelect = false;
            this.grdContact.Name = "grdContact";
            this.grdContact.ReadOnly = true;
            this.grdContact.RowHeadersVisible = false;
            this.grdContact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdContact.Size = new System.Drawing.Size(405, 251);
            this.grdContact.TabIndex = 50;
            // 
            // gbxListeContact
            // 
            this.gbxListeContact.Controls.Add(this.grdContact);
            this.gbxListeContact.Location = new System.Drawing.Point(354, 126);
            this.gbxListeContact.Name = "gbxListeContact";
            this.gbxListeContact.Size = new System.Drawing.Size(415, 276);
            this.gbxListeContact.TabIndex = 55;
            this.gbxListeContact.TabStop = false;
            this.gbxListeContact.Text = "Liste contacts :";
            // 
            // frmAjoutClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(774, 436);
            this.Controls.Add(this.btnSupprimerContact);
            this.Controls.Add(this.btnValiderClient);
            this.Controls.Add(this.btnAnnulerClient);
            this.Controls.Add(this.gbxListeContact);
            this.Controls.Add(this.gbxAjoutContact);
            this.Controls.Add(this.btnAjouterContact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAjoutClient";
            this.Text = "Ajout Client";
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
            this.Controls.SetChildIndex(this.btnAjouterContact, 0);
            this.Controls.SetChildIndex(this.gbxAjoutContact, 0);
            this.Controls.SetChildIndex(this.gbxListeContact, 0);
            this.Controls.SetChildIndex(this.btnAnnulerClient, 0);
            this.Controls.SetChildIndex(this.btnValiderClient, 0);
            this.Controls.SetChildIndex(this.btnSupprimerContact, 0);
            this.gbxAjoutContact.ResumeLayout(false);
            this.gbxAjoutContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContact)).EndInit();
            this.gbxListeContact.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAjouterContact;
        private System.Windows.Forms.GroupBox gbxAjoutContact;
        private System.Windows.Forms.Label lblIdContact;
        private System.Windows.Forms.TextBox txtIdContact;
        private System.Windows.Forms.Label lblFonctionContact;
        private System.Windows.Forms.TextBox txtTelephoneContact;
        private System.Windows.Forms.TextBox txtPrenomContact;
        private System.Windows.Forms.TextBox txtNomContact;
        private System.Windows.Forms.TextBox txtFonctionContact;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblTelephoneContact;
        private System.Windows.Forms.Label lblPrenomContact;
        private System.Windows.Forms.Label lblNomContact;
        private System.Windows.Forms.TextBox txtTotalHeures;
        private System.Windows.Forms.Label lblTotalHeures;
        internal System.Windows.Forms.DataGridView grdContact;
        private System.Windows.Forms.GroupBox gbxListeContact;
        private System.Windows.Forms.Button btnAnnulerClient;
        private System.Windows.Forms.Button btnValiderClient;
        private System.Windows.Forms.Button btnSupprimerContact;
        private System.Windows.Forms.Button btnAnnuler;
    }
}
