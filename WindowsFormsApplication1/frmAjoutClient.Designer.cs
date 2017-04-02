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
            this.btnAjoutContact = new System.Windows.Forms.Button();
            this.gbxAjoutContact = new System.Windows.Forms.GroupBox();
            this.lblFonctionContact = new System.Windows.Forms.Label();
            this.lblIdContact = new System.Windows.Forms.Label();
            this.txtIdContact = new System.Windows.Forms.TextBox();
            this.txtTelephoneContact = new System.Windows.Forms.TextBox();
            this.lblNomContact = new System.Windows.Forms.Label();
            this.txtNomContact = new System.Windows.Forms.TextBox();
            this.lblPrenomContact = new System.Windows.Forms.Label();
            this.txtPrenomContact = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFonctionContact = new System.Windows.Forms.TextBox();
            this.lblTelephoneContact = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnSupprimerContact = new System.Windows.Forms.Button();
            this.grdContact = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbxContact = new System.Windows.Forms.GroupBox();
            this.gbxAjoutContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContact)).BeginInit();
            this.gbxContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Size = new System.Drawing.Size(242, 123);
            // 
            // txtEffectifClient
            // 
            this.txtEffectifClient.Size = new System.Drawing.Size(158, 20);
            // 
            // cbxNatureClient
            // 
            this.cbxNatureClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNatureClient.Size = new System.Drawing.Size(158, 21);
            // 
            // txtDomaine
            // 
            this.txtDomaine.Size = new System.Drawing.Size(158, 20);
            // 
            // txtCAClient
            // 
            this.txtCAClient.Size = new System.Drawing.Size(158, 20);
            // 
            // txtAdresseClient
            // 
            this.txtAdresseClient.Size = new System.Drawing.Size(242, 57);
            // 
            // cbxTypeClient
            // 
            this.cbxTypeClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTypeClient.Size = new System.Drawing.Size(158, 21);
            // 
            // txtTelephoneClient
            // 
            this.txtTelephoneClient.Size = new System.Drawing.Size(158, 20);
            // 
            // txtNumeroClient
            // 
            this.txtNumeroClient.Size = new System.Drawing.Size(158, 20);
            // 
            // txtRaisonSociale
            // 
            this.txtRaisonSociale.Size = new System.Drawing.Size(158, 20);
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
            // btnAjoutContact
            // 
            this.btnAjoutContact.Location = new System.Drawing.Point(280, 6);
            this.btnAjoutContact.Name = "btnAjoutContact";
            this.btnAjoutContact.Size = new System.Drawing.Size(68, 40);
            this.btnAjoutContact.TabIndex = 47;
            this.btnAjoutContact.Text = "Ajouter un contact >>";
            this.btnAjoutContact.UseVisualStyleBackColor = true;
            // 
            // gbxAjoutContact
            // 
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
            this.gbxAjoutContact.Controls.Add(this.button1);
            this.gbxAjoutContact.Controls.Add(this.txtFonctionContact);
            this.gbxAjoutContact.Controls.Add(this.lblTelephoneContact);
            this.gbxAjoutContact.Controls.Add(this.button2);
            this.gbxAjoutContact.Location = new System.Drawing.Point(354, 6);
            this.gbxAjoutContact.Name = "gbxAjoutContact";
            this.gbxAjoutContact.Size = new System.Drawing.Size(417, 122);
            this.gbxAjoutContact.TabIndex = 48;
            this.gbxAjoutContact.TabStop = false;
            this.gbxAjoutContact.Text = "Ajouter un contact :";
            // 
            // lblFonctionContact
            // 
            this.lblFonctionContact.AutoSize = true;
            this.lblFonctionContact.Location = new System.Drawing.Point(213, 16);
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
            this.txtIdContact.Size = new System.Drawing.Size(118, 20);
            this.txtIdContact.TabIndex = 26;
            // 
            // txtTelephoneContact
            // 
            this.txtTelephoneContact.Location = new System.Drawing.Point(283, 39);
            this.txtTelephoneContact.Name = "txtTelephoneContact";
            this.txtTelephoneContact.Size = new System.Drawing.Size(118, 20);
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
            this.txtNomContact.Size = new System.Drawing.Size(118, 20);
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
            this.txtPrenomContact.Size = new System.Drawing.Size(118, 20);
            this.txtPrenomContact.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Annuler";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtFonctionContact
            // 
            this.txtFonctionContact.Location = new System.Drawing.Point(283, 13);
            this.txtFonctionContact.Name = "txtFonctionContact";
            this.txtFonctionContact.Size = new System.Drawing.Size(118, 20);
            this.txtFonctionContact.TabIndex = 29;
            // 
            // lblTelephoneContact
            // 
            this.lblTelephoneContact.AutoSize = true;
            this.lblTelephoneContact.Location = new System.Drawing.Point(213, 42);
            this.lblTelephoneContact.Name = "lblTelephoneContact";
            this.lblTelephoneContact.Size = new System.Drawing.Size(64, 13);
            this.lblTelephoneContact.TabIndex = 23;
            this.lblTelephoneContact.Text = "Téléphone :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Valider";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(308, 235);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(103, 23);
            this.btnQuitter.TabIndex = 54;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerContact
            // 
            this.btnSupprimerContact.Location = new System.Drawing.Point(9, 235);
            this.btnSupprimerContact.Name = "btnSupprimerContact";
            this.btnSupprimerContact.Size = new System.Drawing.Size(103, 23);
            this.btnSupprimerContact.TabIndex = 53;
            this.btnSupprimerContact.Text = "Supprimer contact";
            this.btnSupprimerContact.UseVisualStyleBackColor = true;
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
            this.grdContact.Size = new System.Drawing.Size(405, 210);
            this.grdContact.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Total Heures :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(283, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 37;
            // 
            // gbxContact
            // 
            this.gbxContact.Controls.Add(this.grdContact);
            this.gbxContact.Controls.Add(this.btnQuitter);
            this.gbxContact.Controls.Add(this.btnSupprimerContact);
            this.gbxContact.Location = new System.Drawing.Point(354, 134);
            this.gbxContact.Name = "gbxContact";
            this.gbxContact.Size = new System.Drawing.Size(417, 268);
            this.gbxContact.TabIndex = 55;
            this.gbxContact.TabStop = false;
            this.gbxContact.Text = "Contacts :";
            // 
            // frmAjoutClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(777, 406);
            this.Controls.Add(this.gbxContact);
            this.Controls.Add(this.gbxAjoutContact);
            this.Controls.Add(this.btnAjoutContact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAjoutClient";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Ajout Client";
            this.Controls.SetChildIndex(this.lblNumeroClient, 0);
            this.Controls.SetChildIndex(this.lblRaisonSociale, 0);
            this.Controls.SetChildIndex(this.lblType, 0);
            this.Controls.SetChildIndex(this.lblAdresse, 0);
            this.Controls.SetChildIndex(this.lblTelephone, 0);
            this.Controls.SetChildIndex(this.lblNature, 0);
            this.Controls.SetChildIndex(this.lblCA, 0);
            this.Controls.SetChildIndex(this.lblEffectif, 0);
            this.Controls.SetChildIndex(this.txtRaisonSociale, 0);
            this.Controls.SetChildIndex(this.txtNumeroClient, 0);
            this.Controls.SetChildIndex(this.txtTelephoneClient, 0);
            this.Controls.SetChildIndex(this.cbxTypeClient, 0);
            this.Controls.SetChildIndex(this.lblDomaine, 0);
            this.Controls.SetChildIndex(this.txtAdresseClient, 0);
            this.Controls.SetChildIndex(this.txtCAClient, 0);
            this.Controls.SetChildIndex(this.txtDomaine, 0);
            this.Controls.SetChildIndex(this.cbxNatureClient, 0);
            this.Controls.SetChildIndex(this.txtEffectifClient, 0);
            this.Controls.SetChildIndex(this.txtCommentaire, 0);
            this.Controls.SetChildIndex(this.lblCommentaire, 0);
            this.Controls.SetChildIndex(this.btnAjoutContact, 0);
            this.Controls.SetChildIndex(this.gbxAjoutContact, 0);
            this.Controls.SetChildIndex(this.gbxContact, 0);
            this.gbxAjoutContact.ResumeLayout(false);
            this.gbxAjoutContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContact)).EndInit();
            this.gbxContact.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAjouterContacts;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjoutContact;
        private System.Windows.Forms.GroupBox gbxAjoutContact;
        private System.Windows.Forms.Label lblIdContact;
        private System.Windows.Forms.TextBox txtIdContact;
        private System.Windows.Forms.Label lblFonctionContact;
        private System.Windows.Forms.TextBox txtTelephoneContact;
        private System.Windows.Forms.TextBox txtPrenomContact;
        private System.Windows.Forms.TextBox txtNomContact;
        private System.Windows.Forms.TextBox txtFonctionContact;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblTelephoneContact;
        private System.Windows.Forms.Label lblPrenomContact;
        private System.Windows.Forms.Label lblNomContact;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnSupprimerContact;
        internal System.Windows.Forms.DataGridView grdContact;
        private System.Windows.Forms.GroupBox gbxContact;
    }
}
