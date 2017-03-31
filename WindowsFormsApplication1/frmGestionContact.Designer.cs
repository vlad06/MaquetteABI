namespace WindowsFormsApplication1
{
    partial class frmGestionContact
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
            this.grdContact = new System.Windows.Forms.DataGridView();
            this.txtRechercher = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnAjouterContact = new System.Windows.Forms.Button();
            this.btnModifierContact = new System.Windows.Forms.Button();
            this.btnSupprimerContact = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdContact)).BeginInit();
            this.SuspendLayout();
            // 
            // grdContact
            // 
            this.grdContact.AllowUserToAddRows = false;
            this.grdContact.AllowUserToDeleteRows = false;
            this.grdContact.AllowUserToOrderColumns = true;
            this.grdContact.AllowUserToResizeRows = false;
            this.grdContact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdContact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContact.Location = new System.Drawing.Point(2, 32);
            this.grdContact.MultiSelect = false;
            this.grdContact.Name = "grdContact";
            this.grdContact.ReadOnly = true;
            this.grdContact.RowHeadersVisible = false;
            this.grdContact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdContact.Size = new System.Drawing.Size(614, 254);
            this.grdContact.TabIndex = 0;
            // 
            // txtRechercher
            // 
            this.txtRechercher.Location = new System.Drawing.Point(2, 5);
            this.txtRechercher.Name = "txtRechercher";
            this.txtRechercher.Size = new System.Drawing.Size(208, 20);
            this.txtRechercher.TabIndex = 1;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(219, 3);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(72, 23);
            this.btnRechercher.TabIndex = 2;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // btnAjouterContact
            // 
            this.btnAjouterContact.Location = new System.Drawing.Point(2, 292);
            this.btnAjouterContact.Name = "btnAjouterContact";
            this.btnAjouterContact.Size = new System.Drawing.Size(103, 23);
            this.btnAjouterContact.TabIndex = 3;
            this.btnAjouterContact.Text = "Ajouter contact";
            this.btnAjouterContact.UseVisualStyleBackColor = true;
            this.btnAjouterContact.Click += new System.EventHandler(this.btnAjouterContact_Click);
            // 
            // btnModifierContact
            // 
            this.btnModifierContact.Location = new System.Drawing.Point(111, 292);
            this.btnModifierContact.Name = "btnModifierContact";
            this.btnModifierContact.Size = new System.Drawing.Size(103, 23);
            this.btnModifierContact.TabIndex = 4;
            this.btnModifierContact.Text = "Modifier contact";
            this.btnModifierContact.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerContact
            // 
            this.btnSupprimerContact.Location = new System.Drawing.Point(219, 292);
            this.btnSupprimerContact.Name = "btnSupprimerContact";
            this.btnSupprimerContact.Size = new System.Drawing.Size(103, 23);
            this.btnSupprimerContact.TabIndex = 5;
            this.btnSupprimerContact.Text = "Supprimer contact";
            this.btnSupprimerContact.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(514, 292);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(103, 23);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // frmGestionContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 323);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnSupprimerContact);
            this.Controls.Add(this.btnModifierContact);
            this.Controls.Add(this.btnAjouterContact);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.txtRechercher);
            this.Controls.Add(this.grdContact);
            this.Name = "frmGestionContact";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.frmGestionContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRechercher;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnAjouterContact;
        private System.Windows.Forms.Button btnModifierContact;
        private System.Windows.Forms.Button btnSupprimerContact;
        private System.Windows.Forms.Button btnQuitter;
        internal System.Windows.Forms.DataGridView grdContact;
    }
}