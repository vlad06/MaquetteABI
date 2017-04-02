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
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.txtCommentaire = new System.Windows.Forms.TextBox();
            this.txtEffectifClient = new System.Windows.Forms.TextBox();
            this.cbxNatureClient = new System.Windows.Forms.ComboBox();
            this.txtDomaine = new System.Windows.Forms.TextBox();
            this.txtCAClient = new System.Windows.Forms.TextBox();
            this.txtAdresseClient = new System.Windows.Forms.TextBox();
            this.lblDomaine = new System.Windows.Forms.Label();
            this.cbxTypeClient = new System.Windows.Forms.ComboBox();
            this.txtTelephoneClient = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Location = new System.Drawing.Point(12, 282);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(79, 13);
            this.lblCommentaire.TabIndex = 45;
            this.lblCommentaire.Text = "Commentaires :";
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Location = new System.Drawing.Point(106, 279);
            this.txtCommentaire.Multiline = true;
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(254, 113);
            this.txtCommentaire.TabIndex = 44;
            // 
            // txtEffectifClient
            // 
            this.txtEffectifClient.Location = new System.Drawing.Point(106, 164);
            this.txtEffectifClient.Name = "txtEffectifClient";
            this.txtEffectifClient.Size = new System.Drawing.Size(202, 20);
            this.txtEffectifClient.TabIndex = 43;
            // 
            // cbxNatureClient
            // 
            this.cbxNatureClient.FormattingEnabled = true;
            this.cbxNatureClient.Items.AddRange(new object[] {
            "Principale",
            "Secondaire",
            "Ancienne"});
            this.cbxNatureClient.Location = new System.Drawing.Point(106, 58);
            this.cbxNatureClient.Name = "cbxNatureClient";
            this.cbxNatureClient.Size = new System.Drawing.Size(202, 21);
            this.cbxNatureClient.TabIndex = 38;
            // 
            // txtDomaine
            // 
            this.txtDomaine.Location = new System.Drawing.Point(106, 112);
            this.txtDomaine.Name = "txtDomaine";
            this.txtDomaine.Size = new System.Drawing.Size(202, 20);
            this.txtDomaine.TabIndex = 41;
            // 
            // txtCAClient
            // 
            this.txtCAClient.Location = new System.Drawing.Point(106, 138);
            this.txtCAClient.Name = "txtCAClient";
            this.txtCAClient.Size = new System.Drawing.Size(202, 20);
            this.txtCAClient.TabIndex = 42;
            // 
            // txtAdresseClient
            // 
            this.txtAdresseClient.Location = new System.Drawing.Point(106, 216);
            this.txtAdresseClient.Multiline = true;
            this.txtAdresseClient.Name = "txtAdresseClient";
            this.txtAdresseClient.Size = new System.Drawing.Size(254, 57);
            this.txtAdresseClient.TabIndex = 40;
            // 
            // lblDomaine
            // 
            this.lblDomaine.AutoSize = true;
            this.lblDomaine.Location = new System.Drawing.Point(12, 115);
            this.lblDomaine.Name = "lblDomaine";
            this.lblDomaine.Size = new System.Drawing.Size(48, 13);
            this.lblDomaine.TabIndex = 29;
            this.lblDomaine.Text = "Activité :";
            // 
            // cbxTypeClient
            // 
            this.cbxTypeClient.FormattingEnabled = true;
            this.cbxTypeClient.Items.AddRange(new object[] {
            "Public",
            "Privé"});
            this.cbxTypeClient.Location = new System.Drawing.Point(106, 85);
            this.cbxTypeClient.Name = "cbxTypeClient";
            this.cbxTypeClient.Size = new System.Drawing.Size(202, 21);
            this.cbxTypeClient.TabIndex = 39;
            // 
            // txtTelephoneClient
            // 
            this.txtTelephoneClient.Location = new System.Drawing.Point(106, 190);
            this.txtTelephoneClient.Name = "txtTelephoneClient";
            this.txtTelephoneClient.Size = new System.Drawing.Size(202, 20);
            this.txtTelephoneClient.TabIndex = 37;
            // 
            // txtNumeroClient
            // 
            this.txtNumeroClient.Location = new System.Drawing.Point(106, 6);
            this.txtNumeroClient.Name = "txtNumeroClient";
            this.txtNumeroClient.Size = new System.Drawing.Size(202, 20);
            this.txtNumeroClient.TabIndex = 36;
            // 
            // txtRaisonSociale
            // 
            this.txtRaisonSociale.Location = new System.Drawing.Point(106, 32);
            this.txtRaisonSociale.Name = "txtRaisonSociale";
            this.txtRaisonSociale.Size = new System.Drawing.Size(202, 20);
            this.txtRaisonSociale.TabIndex = 35;
            // 
            // lblEffectif
            // 
            this.lblEffectif.AutoSize = true;
            this.lblEffectif.Location = new System.Drawing.Point(12, 167);
            this.lblEffectif.Name = "lblEffectif";
            this.lblEffectif.Size = new System.Drawing.Size(51, 13);
            this.lblEffectif.TabIndex = 34;
            this.lblEffectif.Text = "Effectifs :";
            // 
            // lblCA
            // 
            this.lblCA.AutoSize = true;
            this.lblCA.Location = new System.Drawing.Point(12, 141);
            this.lblCA.Name = "lblCA";
            this.lblCA.Size = new System.Drawing.Size(88, 13);
            this.lblCA.TabIndex = 33;
            this.lblCA.Text = "Chiffre d\'affaires :";
            // 
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.Location = new System.Drawing.Point(12, 61);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(45, 13);
            this.lblNature.TabIndex = 32;
            this.lblNature.Text = "Nature :";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(12, 193);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(64, 13);
            this.lblTelephone.TabIndex = 31;
            this.lblTelephone.Text = "Téléphone :";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(12, 219);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(51, 13);
            this.lblAdresse.TabIndex = 30;
            this.lblAdresse.Text = "Adresse :";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 88);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(37, 13);
            this.lblType.TabIndex = 28;
            this.lblType.Text = "Type :";
            // 
            // lblRaisonSociale
            // 
            this.lblRaisonSociale.AutoSize = true;
            this.lblRaisonSociale.Location = new System.Drawing.Point(12, 35);
            this.lblRaisonSociale.Name = "lblRaisonSociale";
            this.lblRaisonSociale.Size = new System.Drawing.Size(82, 13);
            this.lblRaisonSociale.TabIndex = 27;
            this.lblRaisonSociale.Text = "Raison sociale :";
            // 
            // lblNumeroClient
            // 
            this.lblNumeroClient.AutoSize = true;
            this.lblNumeroClient.Location = new System.Drawing.Point(12, 9);
            this.lblNumeroClient.Name = "lblNumeroClient";
            this.lblNumeroClient.Size = new System.Drawing.Size(53, 13);
            this.lblNumeroClient.TabIndex = 26;
            this.lblNumeroClient.Text = "N° client :";
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 396);
            this.Controls.Add(this.lblCommentaire);
            this.Controls.Add(this.txtCommentaire);
            this.Controls.Add(this.txtEffectifClient);
            this.Controls.Add(this.cbxNatureClient);
            this.Controls.Add(this.txtDomaine);
            this.Controls.Add(this.txtCAClient);
            this.Controls.Add(this.txtAdresseClient);
            this.Controls.Add(this.lblDomaine);
            this.Controls.Add(this.cbxTypeClient);
            this.Controls.Add(this.txtTelephoneClient);
            this.Controls.Add(this.txtNumeroClient);
            this.Controls.Add(this.txtRaisonSociale);
            this.Controls.Add(this.lblEffectif);
            this.Controls.Add(this.lblCA);
            this.Controls.Add(this.lblNature);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblRaisonSociale);
            this.Controls.Add(this.lblNumeroClient);
            this.Name = "frmClient";
            this.Text = "GestionClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblCommentaire;
        protected System.Windows.Forms.TextBox txtCommentaire;
        protected System.Windows.Forms.TextBox txtEffectifClient;
        protected System.Windows.Forms.ComboBox cbxNatureClient;
        protected System.Windows.Forms.TextBox txtDomaine;
        protected System.Windows.Forms.TextBox txtCAClient;
        protected System.Windows.Forms.TextBox txtAdresseClient;
        protected System.Windows.Forms.Label lblDomaine;
        protected System.Windows.Forms.ComboBox cbxTypeClient;
        protected System.Windows.Forms.TextBox txtTelephoneClient;
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
    }
}