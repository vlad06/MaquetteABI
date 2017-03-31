namespace WindowsFormsApplication1
{
    partial class frmAjoutContact
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
            this.lblNumeroContact = new System.Windows.Forms.Label();
            this.lblNomContact = new System.Windows.Forms.Label();
            this.lblPrenomContact = new System.Windows.Forms.Label();
            this.lblTelephoneContact = new System.Windows.Forms.Label();
            this.lblTotalHeures = new System.Windows.Forms.Label();
            this.lblEmailContact = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.txtNumeroContact = new System.Windows.Forms.TextBox();
            this.txtFonctionContact = new System.Windows.Forms.TextBox();
            this.txtNomContact = new System.Windows.Forms.TextBox();
            this.txtPrenomContact = new System.Windows.Forms.TextBox();
            this.txtTelephoneContact = new System.Windows.Forms.TextBox();
            this.txtTotalHeures = new System.Windows.Forms.TextBox();
            this.txtEmailContact = new System.Windows.Forms.TextBox();
            this.lblFonctionContact = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumeroContact
            // 
            this.lblNumeroContact.AutoSize = true;
            this.lblNumeroContact.Location = new System.Drawing.Point(12, 18);
            this.lblNumeroContact.Name = "lblNumeroContact";
            this.lblNumeroContact.Size = new System.Drawing.Size(65, 13);
            this.lblNumeroContact.TabIndex = 0;
            this.lblNumeroContact.Text = "N° Contact :";
            // 
            // lblNomContact
            // 
            this.lblNomContact.AutoSize = true;
            this.lblNomContact.Location = new System.Drawing.Point(11, 44);
            this.lblNomContact.Name = "lblNomContact";
            this.lblNomContact.Size = new System.Drawing.Size(35, 13);
            this.lblNomContact.TabIndex = 1;
            this.lblNomContact.Text = "Nom :";
            // 
            // lblPrenomContact
            // 
            this.lblPrenomContact.AutoSize = true;
            this.lblPrenomContact.Location = new System.Drawing.Point(11, 70);
            this.lblPrenomContact.Name = "lblPrenomContact";
            this.lblPrenomContact.Size = new System.Drawing.Size(49, 13);
            this.lblPrenomContact.TabIndex = 2;
            this.lblPrenomContact.Text = "Prénom :";
            // 
            // lblTelephoneContact
            // 
            this.lblTelephoneContact.AutoSize = true;
            this.lblTelephoneContact.Location = new System.Drawing.Point(11, 122);
            this.lblTelephoneContact.Name = "lblTelephoneContact";
            this.lblTelephoneContact.Size = new System.Drawing.Size(64, 13);
            this.lblTelephoneContact.TabIndex = 3;
            this.lblTelephoneContact.Text = "Téléphone :";
            // 
            // lblTotalHeures
            // 
            this.lblTotalHeures.AutoSize = true;
            this.lblTotalHeures.Location = new System.Drawing.Point(11, 175);
            this.lblTotalHeures.Name = "lblTotalHeures";
            this.lblTotalHeures.Size = new System.Drawing.Size(122, 13);
            this.lblTotalHeures.TabIndex = 4;
            this.lblTotalHeures.Text = "Total heures travaillées :";
            // 
            // lblEmailContact
            // 
            this.lblEmailContact.AutoSize = true;
            this.lblEmailContact.Location = new System.Drawing.Point(11, 149);
            this.lblEmailContact.Name = "lblEmailContact";
            this.lblEmailContact.Size = new System.Drawing.Size(41, 13);
            this.lblEmailContact.TabIndex = 5;
            this.lblEmailContact.Text = "E-mail :";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(139, 207);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(70, 23);
            this.btnValider.TabIndex = 15;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(215, 207);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(70, 23);
            this.btnAnnuler.TabIndex = 16;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // txtNumeroContact
            // 
            this.txtNumeroContact.Location = new System.Drawing.Point(82, 15);
            this.txtNumeroContact.Name = "txtNumeroContact";
            this.txtNumeroContact.Size = new System.Drawing.Size(208, 20);
            this.txtNumeroContact.TabIndex = 8;
            // 
            // txtFonctionContact
            // 
            this.txtFonctionContact.Location = new System.Drawing.Point(82, 93);
            this.txtFonctionContact.Name = "txtFonctionContact";
            this.txtFonctionContact.Size = new System.Drawing.Size(208, 20);
            this.txtFonctionContact.TabIndex = 11;
            // 
            // txtNomContact
            // 
            this.txtNomContact.Location = new System.Drawing.Point(82, 41);
            this.txtNomContact.Name = "txtNomContact";
            this.txtNomContact.Size = new System.Drawing.Size(208, 20);
            this.txtNomContact.TabIndex = 9;
            // 
            // txtPrenomContact
            // 
            this.txtPrenomContact.Location = new System.Drawing.Point(82, 67);
            this.txtPrenomContact.Name = "txtPrenomContact";
            this.txtPrenomContact.Size = new System.Drawing.Size(208, 20);
            this.txtPrenomContact.TabIndex = 10;
            // 
            // txtTelephoneContact
            // 
            this.txtTelephoneContact.Location = new System.Drawing.Point(82, 119);
            this.txtTelephoneContact.Name = "txtTelephoneContact";
            this.txtTelephoneContact.Size = new System.Drawing.Size(208, 20);
            this.txtTelephoneContact.TabIndex = 12;
            // 
            // txtTotalHeures
            // 
            this.txtTotalHeures.Location = new System.Drawing.Point(139, 172);
            this.txtTotalHeures.Name = "txtTotalHeures";
            this.txtTotalHeures.Size = new System.Drawing.Size(151, 20);
            this.txtTotalHeures.TabIndex = 14;
            // 
            // txtEmailContact
            // 
            this.txtEmailContact.Location = new System.Drawing.Point(82, 146);
            this.txtEmailContact.Name = "txtEmailContact";
            this.txtEmailContact.Size = new System.Drawing.Size(208, 20);
            this.txtEmailContact.TabIndex = 13;
            // 
            // lblFonctionContact
            // 
            this.lblFonctionContact.AutoSize = true;
            this.lblFonctionContact.Location = new System.Drawing.Point(12, 96);
            this.lblFonctionContact.Name = "lblFonctionContact";
            this.lblFonctionContact.Size = new System.Drawing.Size(54, 13);
            this.lblFonctionContact.TabIndex = 19;
            this.lblFonctionContact.Text = "Fonction :";
            // 
            // frmAjoutContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 238);
            this.Controls.Add(this.lblFonctionContact);
            this.Controls.Add(this.txtEmailContact);
            this.Controls.Add(this.txtTotalHeures);
            this.Controls.Add(this.txtTelephoneContact);
            this.Controls.Add(this.txtPrenomContact);
            this.Controls.Add(this.txtNomContact);
            this.Controls.Add(this.txtFonctionContact);
            this.Controls.Add(this.txtNumeroContact);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblEmailContact);
            this.Controls.Add(this.lblTotalHeures);
            this.Controls.Add(this.lblTelephoneContact);
            this.Controls.Add(this.lblPrenomContact);
            this.Controls.Add(this.lblNomContact);
            this.Controls.Add(this.lblNumeroContact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAjoutContact";
            this.Text = "AjoutContact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroContact;
        private System.Windows.Forms.Label lblNomContact;
        private System.Windows.Forms.Label lblPrenomContact;
        private System.Windows.Forms.Label lblTelephoneContact;
        private System.Windows.Forms.Label lblTotalHeures;
        private System.Windows.Forms.Label lblEmailContact;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TextBox txtNumeroContact;
        private System.Windows.Forms.TextBox txtFonctionContact;
        private System.Windows.Forms.TextBox txtNomContact;
        private System.Windows.Forms.TextBox txtPrenomContact;
        private System.Windows.Forms.TextBox txtTelephoneContact;
        private System.Windows.Forms.TextBox txtTotalHeures;
        private System.Windows.Forms.TextBox txtEmailContact;
        private System.Windows.Forms.Label lblFonctionContact;
    }
}