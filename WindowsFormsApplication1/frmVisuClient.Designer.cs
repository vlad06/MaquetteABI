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
            this.button1 = new System.Windows.Forms.Button();
            this.gbxContact = new System.Windows.Forms.GroupBox();
            this.grdContact = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSupprimerContact = new System.Windows.Forms.Button();
            this.gbxAjoutContact = new System.Windows.Forms.GroupBox();
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
            this.button3 = new System.Windows.Forms.Button();
            this.txtFonctionContact = new System.Windows.Forms.TextBox();
            this.lblTelephoneContact = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.gbxContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContact)).BeginInit();
            this.gbxAjoutContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Size = new System.Drawing.Size(276, 123);
            // 
            // txtEffectifClient
            // 
            this.txtEffectifClient.Size = new System.Drawing.Size(199, 20);
            // 
            // cbxNatureClient
            // 
            this.cbxNatureClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // txtAdresseClient
            // 
            this.txtAdresseClient.Size = new System.Drawing.Size(273, 57);
            // 
            // cbxTypeClient
            // 
            this.cbxTypeClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // txtTelephoneClient
            // 
            this.txtTelephoneClient.Size = new System.Drawing.Size(199, 20);
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
            this.btnDeverouiller.Text = "Dévérrouiller";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 73);
            this.button1.TabIndex = 46;
            this.button1.Text = "Afficher les contacts";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gbxContact
            // 
            this.gbxContact.Controls.Add(this.grdContact);
            this.gbxContact.Controls.Add(this.button2);
            this.gbxContact.Controls.Add(this.btnSupprimerContact);
            this.gbxContact.Location = new System.Drawing.Point(388, 134);
            this.gbxContact.Name = "gbxContact";
            this.gbxContact.Size = new System.Drawing.Size(417, 268);
            this.gbxContact.TabIndex = 57;
            this.gbxContact.TabStop = false;
            this.gbxContact.Text = "Liste Contacts :";
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 54;
            this.button2.Text = "Quitter";
            this.button2.UseVisualStyleBackColor = true;
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
            this.gbxAjoutContact.Controls.Add(this.button3);
            this.gbxAjoutContact.Controls.Add(this.txtFonctionContact);
            this.gbxAjoutContact.Controls.Add(this.lblTelephoneContact);
            this.gbxAjoutContact.Controls.Add(this.button4);
            this.gbxAjoutContact.Location = new System.Drawing.Point(388, 6);
            this.gbxAjoutContact.Name = "gbxAjoutContact";
            this.gbxAjoutContact.Size = new System.Drawing.Size(417, 122);
            this.gbxAjoutContact.TabIndex = 56;
            this.gbxAjoutContact.TabStop = false;
            this.gbxAjoutContact.Text = "Contact sélectionné :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(292, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Total Heures :";
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
            this.txtTelephoneContact.Location = new System.Drawing.Point(292, 39);
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(82, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "Annuler";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtFonctionContact
            // 
            this.txtFonctionContact.Location = new System.Drawing.Point(292, 13);
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 93);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 23);
            this.button4.TabIndex = 33;
            this.button4.Text = "Valider";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frmVisuClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(810, 409);
            this.Controls.Add(this.gbxContact);
            this.Controls.Add(this.gbxAjoutContact);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmVisuClient";
            this.Text = "Detail Client";
            this.Load += new System.EventHandler(this.frmDetailClient_Load);
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
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.gbxAjoutContact, 0);
            this.Controls.SetChildIndex(this.gbxContact, 0);
            this.gbxContact.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdContact)).EndInit();
            this.gbxAjoutContact.ResumeLayout(false);
            this.gbxAjoutContact.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVoirContact;
        private System.Windows.Forms.Button btnDeverouiller;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbxContact;
        internal System.Windows.Forms.DataGridView grdContact;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSupprimerContact;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtFonctionContact;
        private System.Windows.Forms.Label lblTelephoneContact;
        private System.Windows.Forms.Button button4;
    }
}
