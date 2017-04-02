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
            this.lblCommentComm = new System.Windows.Forms.Label();
            this.txtCommentComm = new System.Windows.Forms.TextBox();
            this.txtEffectif = new System.Windows.Forms.TextBox();
            this.cbxNature = new System.Windows.Forms.ComboBox();
            this.txtActivite = new System.Windows.Forms.TextBox();
            this.txtCa = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lblActivite = new System.Windows.Forms.Label();
            this.cbxTypeSociete = new System.Windows.Forms.ComboBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtIdClient = new System.Windows.Forms.TextBox();
            this.txtRaisonSociale = new System.Windows.Forms.TextBox();
            this.lblEffectif = new System.Windows.Forms.Label();
            this.lblCa = new System.Windows.Forms.Label();
            this.lblNature = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblTypeSociete = new System.Windows.Forms.Label();
            this.lblRaisonSociale = new System.Windows.Forms.Label();
            this.lblIdClient = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCommentComm
            // 
            this.lblCommentComm.AutoSize = true;
            this.lblCommentComm.Location = new System.Drawing.Point(12, 282);
            this.lblCommentComm.Name = "lblCommentComm";
            this.lblCommentComm.Size = new System.Drawing.Size(79, 13);
            this.lblCommentComm.TabIndex = 45;
            this.lblCommentComm.Text = "Commentaires :";
            // 
            // txtCommentComm
            // 
            this.txtCommentComm.Location = new System.Drawing.Point(106, 279);
            this.txtCommentComm.Multiline = true;
            this.txtCommentComm.Name = "txtCommentComm";
            this.txtCommentComm.Size = new System.Drawing.Size(242, 123);
            this.txtCommentComm.TabIndex = 44;
            // 
            // txtEffectif
            // 
            this.txtEffectif.Location = new System.Drawing.Point(106, 164);
            this.txtEffectif.Name = "txtEffectif";
            this.txtEffectif.Size = new System.Drawing.Size(202, 20);
            this.txtEffectif.TabIndex = 43;
            // 
            // cbxNature
            // 
            this.cbxNature.FormattingEnabled = true;
            this.cbxNature.Items.AddRange(new object[] {
            "Principale",
            "Secondaire",
            "Ancienne"});
            this.cbxNature.Location = new System.Drawing.Point(106, 58);
            this.cbxNature.Name = "cbxNature";
            this.cbxNature.Size = new System.Drawing.Size(202, 21);
            this.cbxNature.TabIndex = 38;
            // 
            // txtActivite
            // 
            this.txtActivite.Location = new System.Drawing.Point(106, 112);
            this.txtActivite.Name = "txtActivite";
            this.txtActivite.Size = new System.Drawing.Size(202, 20);
            this.txtActivite.TabIndex = 41;
            // 
            // txtCa
            // 
            this.txtCa.Location = new System.Drawing.Point(106, 138);
            this.txtCa.Name = "txtCa";
            this.txtCa.Size = new System.Drawing.Size(202, 20);
            this.txtCa.TabIndex = 42;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(106, 216);
            this.txtAdresse.Multiline = true;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(242, 57);
            this.txtAdresse.TabIndex = 40;
            // 
            // lblActivite
            // 
            this.lblActivite.AutoSize = true;
            this.lblActivite.Location = new System.Drawing.Point(12, 115);
            this.lblActivite.Name = "lblActivite";
            this.lblActivite.Size = new System.Drawing.Size(48, 13);
            this.lblActivite.TabIndex = 29;
            this.lblActivite.Text = "Activité :";
            // 
            // cbxTypeSociete
            // 
            this.cbxTypeSociete.FormattingEnabled = true;
            this.cbxTypeSociete.Items.AddRange(new object[] {
            "Public",
            "Privé"});
            this.cbxTypeSociete.Location = new System.Drawing.Point(106, 85);
            this.cbxTypeSociete.Name = "cbxTypeSociete";
            this.cbxTypeSociete.Size = new System.Drawing.Size(202, 21);
            this.cbxTypeSociete.TabIndex = 39;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(106, 190);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(202, 20);
            this.txtTelephone.TabIndex = 37;
            // 
            // txtIdClient
            // 
            this.txtIdClient.Location = new System.Drawing.Point(106, 6);
            this.txtIdClient.Name = "txtIdClient";
            this.txtIdClient.Size = new System.Drawing.Size(202, 20);
            this.txtIdClient.TabIndex = 36;
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
            // lblCa
            // 
            this.lblCa.AutoSize = true;
            this.lblCa.Location = new System.Drawing.Point(12, 141);
            this.lblCa.Name = "lblCa";
            this.lblCa.Size = new System.Drawing.Size(88, 13);
            this.lblCa.TabIndex = 33;
            this.lblCa.Text = "Chiffre d\'affaires :";
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
            // lblTypeSociete
            // 
            this.lblTypeSociete.AutoSize = true;
            this.lblTypeSociete.Location = new System.Drawing.Point(12, 88);
            this.lblTypeSociete.Name = "lblTypeSociete";
            this.lblTypeSociete.Size = new System.Drawing.Size(37, 13);
            this.lblTypeSociete.TabIndex = 28;
            this.lblTypeSociete.Text = "Type :";
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
            // lblIdClient
            // 
            this.lblIdClient.AutoSize = true;
            this.lblIdClient.Location = new System.Drawing.Point(12, 9);
            this.lblIdClient.Name = "lblIdClient";
            this.lblIdClient.Size = new System.Drawing.Size(53, 13);
            this.lblIdClient.TabIndex = 26;
            this.lblIdClient.Text = "N° client :";
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 406);
            this.Controls.Add(this.lblCommentComm);
            this.Controls.Add(this.txtCommentComm);
            this.Controls.Add(this.txtEffectif);
            this.Controls.Add(this.cbxNature);
            this.Controls.Add(this.txtActivite);
            this.Controls.Add(this.txtCa);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.lblActivite);
            this.Controls.Add(this.cbxTypeSociete);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtIdClient);
            this.Controls.Add(this.txtRaisonSociale);
            this.Controls.Add(this.lblEffectif);
            this.Controls.Add(this.lblCa);
            this.Controls.Add(this.lblNature);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblTypeSociete);
            this.Controls.Add(this.lblRaisonSociale);
            this.Controls.Add(this.lblIdClient);
            this.Name = "frmClient";
            this.Text = "GestionClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblCommentComm;
        protected System.Windows.Forms.TextBox txtCommentComm;
        protected System.Windows.Forms.TextBox txtEffectif;
        protected System.Windows.Forms.ComboBox cbxNature;
        protected System.Windows.Forms.TextBox txtActivite;
        protected System.Windows.Forms.TextBox txtCa;
        protected System.Windows.Forms.TextBox txtAdresse;
        protected System.Windows.Forms.Label lblActivite;
        protected System.Windows.Forms.ComboBox cbxTypeSociete;
        protected System.Windows.Forms.TextBox txtTelephone;
        protected System.Windows.Forms.TextBox txtIdClient;
        protected System.Windows.Forms.TextBox txtRaisonSociale;
        protected System.Windows.Forms.Label lblEffectif;
        protected System.Windows.Forms.Label lblCa;
        protected System.Windows.Forms.Label lblNature;
        protected System.Windows.Forms.Label lblTelephone;
        protected System.Windows.Forms.Label lblAdresse;
        protected System.Windows.Forms.Label lblTypeSociete;
        protected System.Windows.Forms.Label lblRaisonSociale;
        protected System.Windows.Forms.Label lblIdClient;
    }
}