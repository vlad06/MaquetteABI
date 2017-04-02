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
            this.btnQuitter = new System.Windows.Forms.Button();
            this.gbxListeContact = new System.Windows.Forms.GroupBox();
            this.grdContact = new System.Windows.Forms.DataGridView();
            this.gbxAjoutContact = new System.Windows.Forms.GroupBox();
            this.btnAnnulerContact = new System.Windows.Forms.Button();
            this.btnValiderContact = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnAfficherContact = new System.Windows.Forms.Button();
            this.btnDeverrouiller = new System.Windows.Forms.Button();
            this.btnValiderClient = new System.Windows.Forms.Button();
            this.btnReinitialiser = new System.Windows.Forms.Button();
            this.gbxListeContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContact)).BeginInit();
            this.gbxAjoutContact.SuspendLayout();
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
            // gbxListeContact
            // 
            this.gbxListeContact.Controls.Add(this.grdContact);
            this.gbxListeContact.Location = new System.Drawing.Point(354, 126);
            this.gbxListeContact.Name = "gbxListeContact";
            this.gbxListeContact.Size = new System.Drawing.Size(415, 276);
            this.gbxListeContact.TabIndex = 57;
            this.gbxListeContact.TabStop = false;
            this.gbxListeContact.Text = "Liste Contacts :";
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
            // gbxAjoutContact
            // 
            this.gbxAjoutContact.Controls.Add(this.btnAnnulerContact);
            this.gbxAjoutContact.Controls.Add(this.btnValiderContact);
            this.gbxAjoutContact.Controls.Add(this.textBox1);
            this.gbxAjoutContact.Controls.Add(this.label1);
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
            this.gbxAjoutContact.TabIndex = 56;
            this.gbxAjoutContact.TabStop = false;
            this.gbxAjoutContact.Text = "Contact sélectionné :";
            // 
            // btnAnnulerContact
            // 
            this.btnAnnulerContact.Location = new System.Drawing.Point(257, 91);
            this.btnAnnulerContact.Name = "btnAnnulerContact";
            this.btnAnnulerContact.Size = new System.Drawing.Size(70, 23);
            this.btnAnnulerContact.TabIndex = 39;
            this.btnAnnulerContact.Text = "Annuler";
            this.btnAnnulerContact.UseVisualStyleBackColor = true;
            // 
            // btnValiderContact
            // 
            this.btnValiderContact.Location = new System.Drawing.Point(333, 91);
            this.btnValiderContact.Name = "btnValiderContact";
            this.btnValiderContact.Size = new System.Drawing.Size(70, 23);
            this.btnValiderContact.TabIndex = 38;
            this.btnValiderContact.Text = "Valider";
            this.btnValiderContact.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(283, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Total Heures :";
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
            // btnAfficherContact
            // 
            this.btnAfficherContact.Location = new System.Drawing.Point(270, 6);
            this.btnAfficherContact.Name = "btnAfficherContact";
            this.btnAfficherContact.Size = new System.Drawing.Size(78, 40);
            this.btnAfficherContact.TabIndex = 58;
            this.btnAfficherContact.Text = "Afficher les contacts >>";
            this.btnAfficherContact.UseVisualStyleBackColor = true;
            this.btnAfficherContact.Click += new System.EventHandler(this.btnAfficherContact_Click);
            // 
            // btnDeverrouiller
            // 
            this.btnDeverrouiller.Location = new System.Drawing.Point(270, 51);
            this.btnDeverrouiller.Name = "btnDeverrouiller";
            this.btnDeverrouiller.Size = new System.Drawing.Size(78, 40);
            this.btnDeverrouiller.TabIndex = 59;
            this.btnDeverrouiller.Text = "Dévérrouiller";
            this.btnDeverrouiller.UseVisualStyleBackColor = true;
            // 
            // btnValiderClient
            // 
            this.btnValiderClient.Location = new System.Drawing.Point(245, 408);
            this.btnValiderClient.Name = "btnValiderClient";
            this.btnValiderClient.Size = new System.Drawing.Size(103, 23);
            this.btnValiderClient.TabIndex = 60;
            this.btnValiderClient.Text = "Valider";
            this.btnValiderClient.UseVisualStyleBackColor = true;
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.Location = new System.Drawing.Point(136, 408);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(103, 23);
            this.btnReinitialiser.TabIndex = 61;
            this.btnReinitialiser.Text = "Réinitialiser";
            this.btnReinitialiser.UseVisualStyleBackColor = true;
            this.btnReinitialiser.Click += new System.EventHandler(this.btnReinitialiser_Click);
            // 
            // frmVisuClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(774, 436);
            this.Controls.Add(this.btnReinitialiser);
            this.Controls.Add(this.btnValiderClient);
            this.Controls.Add(this.btnDeverrouiller);
            this.Controls.Add(this.btnAfficherContact);
            this.Controls.Add(this.gbxListeContact);
            this.Controls.Add(this.gbxAjoutContact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmVisuClient";
            this.Text = "Detail Client";
            this.Load += new System.EventHandler(this.frmVisuClient_Load);
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
            this.Controls.SetChildIndex(this.gbxAjoutContact, 0);
            this.Controls.SetChildIndex(this.gbxListeContact, 0);
            this.Controls.SetChildIndex(this.btnAfficherContact, 0);
            this.Controls.SetChildIndex(this.btnDeverrouiller, 0);
            this.Controls.SetChildIndex(this.btnValiderClient, 0);
            this.Controls.SetChildIndex(this.btnReinitialiser, 0);
            this.gbxListeContact.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdContact)).EndInit();
            this.gbxAjoutContact.ResumeLayout(false);
            this.gbxAjoutContact.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.GroupBox gbxListeContact;
        internal System.Windows.Forms.DataGridView grdContact;
        private System.Windows.Forms.GroupBox gbxAjoutContact;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFonctionContact;
        private System.Windows.Forms.Label lblIdContact;
        private System.Windows.Forms.TextBox txtIdContact;
        private System.Windows.Forms.TextBox txtTelephoneContact;
        private System.Windows.Forms.Label lblNomContact;
        private System.Windows.Forms.TextBox txtNomContact;
        private System.Windows.Forms.Label lblPrenomContact;
        private System.Windows.Forms.TextBox txtPrenomContact;
        private System.Windows.Forms.TextBox txtFonctionContact;
        private System.Windows.Forms.Label lblTelephoneContact;
        private System.Windows.Forms.Button btnAfficherContact;
        private System.Windows.Forms.Button btnDeverrouiller;
        private System.Windows.Forms.Button btnValiderClient;
        private System.Windows.Forms.Button btnReinitialiser;
        private System.Windows.Forms.Button btnValiderContact;
        private System.Windows.Forms.Button btnAnnulerContact;
    }
}
