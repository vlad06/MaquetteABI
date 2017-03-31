namespace WindowsFormsApplication1
{
    partial class frmClient
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEffectifClient = new System.Windows.Forms.TextBox();
            this.cbxNatureClient = new System.Windows.Forms.ComboBox();
            this.txtDomaine = new System.Windows.Forms.TextBox();
            this.txtCAClient = new System.Windows.Forms.TextBox();
            this.txtAdresseClient = new System.Windows.Forms.TextBox();
            this.lblFax = new System.Windows.Forms.Label();
            this.lblDomaine = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cbxTypeClient = new System.Windows.Forms.ComboBox();
            this.txtTelephoneClient = new System.Windows.Forms.TextBox();
            this.txtEmailClient = new System.Windows.Forms.TextBox();
            this.txtFaxClient = new System.Windows.Forms.TextBox();
            this.txtNumeroClient = new System.Windows.Forms.TextBox();
            this.txtRaisonSociale = new System.Windows.Forms.TextBox();
            this.lblEffectif = new System.Windows.Forms.Label();
            this.lblCA = new System.Windows.Forms.Label();
            this.lblNature = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblRaisonSociale = new System.Windows.Forms.Label();
            this.lblNumeroClient = new System.Windows.Forms.Label();
            this.txtCommentaire = new System.Windows.Forms.TextBox();
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCommentaire);
            this.groupBox1.Controls.Add(this.txtCommentaire);
            this.groupBox1.Controls.Add(this.txtEffectifClient);
            this.groupBox1.Controls.Add(this.cbxNatureClient);
            this.groupBox1.Controls.Add(this.txtDomaine);
            this.groupBox1.Controls.Add(this.txtCAClient);
            this.groupBox1.Controls.Add(this.txtAdresseClient);
            this.groupBox1.Controls.Add(this.lblFax);
            this.groupBox1.Controls.Add(this.lblDomaine);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.cbxTypeClient);
            this.groupBox1.Controls.Add(this.txtTelephoneClient);
            this.groupBox1.Controls.Add(this.txtEmailClient);
            this.groupBox1.Controls.Add(this.txtFaxClient);
            this.groupBox1.Controls.Add(this.txtNumeroClient);
            this.groupBox1.Controls.Add(this.txtRaisonSociale);
            this.groupBox1.Controls.Add(this.lblEffectif);
            this.groupBox1.Controls.Add(this.lblCA);
            this.groupBox1.Controls.Add(this.lblNature);
            this.groupBox1.Controls.Add(this.lblTelephone);
            this.groupBox1.Controls.Add(this.lblAdresse);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.lblRaisonSociale);
            this.groupBox1.Controls.Add(this.lblNumeroClient);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 497);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client";
            // 
            // txtEffectifClient
            // 
            this.txtEffectifClient.Location = new System.Drawing.Point(94, 252);
            this.txtEffectifClient.Name = "txtEffectifClient";
            this.txtEffectifClient.Size = new System.Drawing.Size(164, 20);
            this.txtEffectifClient.TabIndex = 21;
            // 
            // cbxNatureClient
            // 
            this.cbxNatureClient.FormattingEnabled = true;
            this.cbxNatureClient.Items.AddRange(new object[] {
            "Principale",
            "Secondaire",
            "Ancienne"});
            this.cbxNatureClient.Location = new System.Drawing.Point(373, 42);
            this.cbxNatureClient.Name = "cbxNatureClient";
            this.cbxNatureClient.Size = new System.Drawing.Size(142, 21);
            this.cbxNatureClient.TabIndex = 14;
            // 
            // txtDomaine
            // 
            this.txtDomaine.Location = new System.Drawing.Point(112, 200);
            this.txtDomaine.Name = "txtDomaine";
            this.txtDomaine.Size = new System.Drawing.Size(263, 20);
            this.txtDomaine.TabIndex = 19;
            // 
            // txtCAClient
            // 
            this.txtCAClient.Location = new System.Drawing.Point(94, 226);
            this.txtCAClient.Name = "txtCAClient";
            this.txtCAClient.Size = new System.Drawing.Size(164, 20);
            this.txtCAClient.TabIndex = 20;
            // 
            // txtAdresseClient
            // 
            this.txtAdresseClient.Location = new System.Drawing.Point(94, 122);
            this.txtAdresseClient.Multiline = true;
            this.txtAdresseClient.Name = "txtAdresseClient";
            this.txtAdresseClient.Size = new System.Drawing.Size(421, 72);
            this.txtAdresseClient.TabIndex = 18;
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(6, 72);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(30, 13);
            this.lblFax.TabIndex = 18;
            this.lblFax.Text = "Fax :";
            // 
            // lblDomaine
            // 
            this.lblDomaine.AutoSize = true;
            this.lblDomaine.Location = new System.Drawing.Point(6, 203);
            this.lblDomaine.Name = "lblDomaine";
            this.lblDomaine.Size = new System.Drawing.Size(100, 13);
            this.lblDomaine.TabIndex = 3;
            this.lblDomaine.Text = "Domaine d\'activité :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 99);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 13);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "E-mail :";
            // 
            // cbxTypeClient
            // 
            this.cbxTypeClient.FormattingEnabled = true;
            this.cbxTypeClient.Items.AddRange(new object[] {
            "Public",
            "Privé"});
            this.cbxTypeClient.Location = new System.Drawing.Point(373, 68);
            this.cbxTypeClient.Name = "cbxTypeClient";
            this.cbxTypeClient.Size = new System.Drawing.Size(142, 21);
            this.cbxTypeClient.TabIndex = 16;
            // 
            // txtTelephoneClient
            // 
            this.txtTelephoneClient.Location = new System.Drawing.Point(94, 42);
            this.txtTelephoneClient.Name = "txtTelephoneClient";
            this.txtTelephoneClient.Size = new System.Drawing.Size(164, 20);
            this.txtTelephoneClient.TabIndex = 13;
            // 
            // txtEmailClient
            // 
            this.txtEmailClient.Location = new System.Drawing.Point(94, 96);
            this.txtEmailClient.Name = "txtEmailClient";
            this.txtEmailClient.Size = new System.Drawing.Size(164, 20);
            this.txtEmailClient.TabIndex = 17;
            // 
            // txtFaxClient
            // 
            this.txtFaxClient.Location = new System.Drawing.Point(94, 69);
            this.txtFaxClient.Name = "txtFaxClient";
            this.txtFaxClient.Size = new System.Drawing.Size(164, 20);
            this.txtFaxClient.TabIndex = 15;
            // 
            // txtNumeroClient
            // 
            this.txtNumeroClient.Location = new System.Drawing.Point(373, 17);
            this.txtNumeroClient.Name = "txtNumeroClient";
            this.txtNumeroClient.Size = new System.Drawing.Size(142, 20);
            this.txtNumeroClient.TabIndex = 12;
            // 
            // txtRaisonSociale
            // 
            this.txtRaisonSociale.Location = new System.Drawing.Point(94, 16);
            this.txtRaisonSociale.Name = "txtRaisonSociale";
            this.txtRaisonSociale.Size = new System.Drawing.Size(204, 20);
            this.txtRaisonSociale.TabIndex = 11;
            // 
            // lblEffectif
            // 
            this.lblEffectif.AutoSize = true;
            this.lblEffectif.Location = new System.Drawing.Point(6, 255);
            this.lblEffectif.Name = "lblEffectif";
            this.lblEffectif.Size = new System.Drawing.Size(51, 13);
            this.lblEffectif.TabIndex = 8;
            this.lblEffectif.Text = "Effectifs :";
            // 
            // lblCA
            // 
            this.lblCA.AutoSize = true;
            this.lblCA.Location = new System.Drawing.Point(6, 229);
            this.lblCA.Name = "lblCA";
            this.lblCA.Size = new System.Drawing.Size(88, 13);
            this.lblCA.TabIndex = 7;
            this.lblCA.Text = "Chiffre d\'affaires :";
            // 
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.Location = new System.Drawing.Point(314, 45);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(45, 13);
            this.lblNature.TabIndex = 6;
            this.lblNature.Text = "Nature :";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(6, 45);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(64, 13);
            this.lblTelephone.TabIndex = 5;
            this.lblTelephone.Text = "Téléphone :";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(6, 125);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(51, 13);
            this.lblAdresse.TabIndex = 4;
            this.lblAdresse.Text = "Adresse :";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(314, 72);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(37, 13);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type :";
            // 
            // lblRaisonSociale
            // 
            this.lblRaisonSociale.AutoSize = true;
            this.lblRaisonSociale.Location = new System.Drawing.Point(6, 19);
            this.lblRaisonSociale.Name = "lblRaisonSociale";
            this.lblRaisonSociale.Size = new System.Drawing.Size(82, 13);
            this.lblRaisonSociale.TabIndex = 1;
            this.lblRaisonSociale.Text = "Raison sociale :";
            // 
            // lblNumeroClient
            // 
            this.lblNumeroClient.AutoSize = true;
            this.lblNumeroClient.Location = new System.Drawing.Point(314, 20);
            this.lblNumeroClient.Name = "lblNumeroClient";
            this.lblNumeroClient.Size = new System.Drawing.Size(53, 13);
            this.lblNumeroClient.TabIndex = 0;
            this.lblNumeroClient.Text = "N° client :";
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Location = new System.Drawing.Point(94, 287);
            this.txtCommentaire.Multiline = true;
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(421, 197);
            this.txtCommentaire.TabIndex = 22;
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Location = new System.Drawing.Point(6, 290);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(79, 13);
            this.lblCommentaire.TabIndex = 25;
            this.lblCommentaire.Text = "Commentaires :";
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 508);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmClient";
            this.Text = "GestionClient";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.TextBox txtEffectifClient;
        protected System.Windows.Forms.ComboBox cbxNatureClient;
        protected System.Windows.Forms.TextBox txtDomaine;
        protected System.Windows.Forms.TextBox txtCAClient;
        protected System.Windows.Forms.TextBox txtAdresseClient;
        protected System.Windows.Forms.Label lblFax;
        protected System.Windows.Forms.Label lblDomaine;
        protected System.Windows.Forms.Label lblEmail;
        protected System.Windows.Forms.ComboBox cbxTypeClient;
        protected System.Windows.Forms.TextBox txtTelephoneClient;
        protected System.Windows.Forms.TextBox txtEmailClient;
        protected System.Windows.Forms.TextBox txtFaxClient;
        protected System.Windows.Forms.TextBox txtNumeroClient;
        protected System.Windows.Forms.TextBox txtRaisonSociale;
        protected System.Windows.Forms.Label lblEffectif;
        protected System.Windows.Forms.Label lblCA;
        protected System.Windows.Forms.Label lblNature;
        protected System.Windows.Forms.Label lblTelephone;
        protected System.Windows.Forms.Label lblAdresse;
        protected System.Windows.Forms.Label lblType;
        protected System.Windows.Forms.Label lblRaisonSociale;
        protected System.Windows.Forms.Label lblNumeroClient;
        protected System.Windows.Forms.Label lblCommentaire;
        protected System.Windows.Forms.TextBox txtCommentaire;
    }
}