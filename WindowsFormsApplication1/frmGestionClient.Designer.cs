namespace WindowsFormsApplication1
{
    partial class frmGestionClient
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
            this.components = new System.ComponentModel.Container();
            this.msGestionClient = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerClientToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viderListeClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grdClient = new System.Windows.Forms.DataGridView();
            this.txtRechercher = new System.Windows.Forms.TextBox();
            this.btnModifierClient = new System.Windows.Forms.Button();
            this.btnDetailClient = new System.Windows.Forms.Button();
            this.btnAfficherListe = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSupprimerClient = new System.Windows.Forms.Button();
            this.btnAjouterClient = new System.Windows.Forms.Button();
            this.btnViderListe = new System.Windows.Forms.Button();
            this.msGestionClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClient)).BeginInit();
            this.SuspendLayout();
            // 
            // msGestionClient
            // 
            this.msGestionClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.afficherToolStripMenuItem});
            this.msGestionClient.Location = new System.Drawing.Point(0, 0);
            this.msGestionClient.Name = "msGestionClient";
            this.msGestionClient.Size = new System.Drawing.Size(1091, 24);
            this.msGestionClient.TabIndex = 4;
            this.msGestionClient.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauClientToolStripMenuItem,
            this.supprimerClientToolStripMenuItem2,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // nouveauClientToolStripMenuItem
            // 
            this.nouveauClientToolStripMenuItem.Name = "nouveauClientToolStripMenuItem";
            this.nouveauClientToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.nouveauClientToolStripMenuItem.Text = "Nouveau client";
            this.nouveauClientToolStripMenuItem.Click += new System.EventHandler(this.nouveauClientToolStripMenuItem_Click);
            // 
            // supprimerClientToolStripMenuItem2
            // 
            this.supprimerClientToolStripMenuItem2.Name = "supprimerClientToolStripMenuItem2";
            this.supprimerClientToolStripMenuItem2.Size = new System.Drawing.Size(161, 22);
            this.supprimerClientToolStripMenuItem2.Text = "Supprimer client";
            this.supprimerClientToolStripMenuItem2.Click += new System.EventHandler(this.supprimerClientToolStripMenuItem2_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // afficherToolStripMenuItem
            // 
            this.afficherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeClientsToolStripMenuItem,
            this.viderListeClientsToolStripMenuItem});
            this.afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            this.afficherToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.afficherToolStripMenuItem.Text = "Outils";
            // 
            // listeClientsToolStripMenuItem
            // 
            this.listeClientsToolStripMenuItem.Name = "listeClientsToolStripMenuItem";
            this.listeClientsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.listeClientsToolStripMenuItem.Text = "Afficher liste clients";
            this.listeClientsToolStripMenuItem.Click += new System.EventHandler(this.listeClientsToolStripMenuItem_Click);
            // 
            // viderListeClientsToolStripMenuItem
            // 
            this.viderListeClientsToolStripMenuItem.Name = "viderListeClientsToolStripMenuItem";
            this.viderListeClientsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.viderListeClientsToolStripMenuItem.Text = "Vider liste clients";
            this.viderListeClientsToolStripMenuItem.Click += new System.EventHandler(this.viderListeClientsToolStripMenuItem_Click);
            // 
            // grdClient
            // 
            this.grdClient.AllowUserToAddRows = false;
            this.grdClient.AllowUserToDeleteRows = false;
            this.grdClient.AllowUserToOrderColumns = true;
            this.grdClient.AllowUserToResizeRows = false;
            this.grdClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClient.Location = new System.Drawing.Point(184, 43);
            this.grdClient.MultiSelect = false;
            this.grdClient.Name = "grdClient";
            this.grdClient.ReadOnly = true;
            this.grdClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdClient.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grdClient.RowHeadersVisible = false;
            this.grdClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdClient.Size = new System.Drawing.Size(899, 550);
            this.grdClient.TabIndex = 6;
            this.grdClient.DoubleClick += new System.EventHandler(this.grdClient_DoubleClick);
            // 
            // txtRechercher
            // 
            this.txtRechercher.Location = new System.Drawing.Point(15, 43);
            this.txtRechercher.Name = "txtRechercher";
            this.txtRechercher.Size = new System.Drawing.Size(160, 20);
            this.txtRechercher.TabIndex = 7;
            this.txtRechercher.TextChanged += new System.EventHandler(this.txtRechercher_TextChanged);
            // 
            // btnModifierClient
            // 
            this.btnModifierClient.Location = new System.Drawing.Point(32, 235);
            this.btnModifierClient.Name = "btnModifierClient";
            this.btnModifierClient.Size = new System.Drawing.Size(121, 52);
            this.btnModifierClient.TabIndex = 11;
            this.btnModifierClient.Text = "Passer les clients au premier plan";
            this.btnModifierClient.UseVisualStyleBackColor = true;
            // 
            // btnDetailClient
            // 
            this.btnDetailClient.Location = new System.Drawing.Point(12, 206);
            this.btnDetailClient.Name = "btnDetailClient";
            this.btnDetailClient.Size = new System.Drawing.Size(163, 23);
            this.btnDetailClient.TabIndex = 1;
            this.btnDetailClient.Text = "Details client";
            this.btnDetailClient.UseVisualStyleBackColor = true;
            this.btnDetailClient.Click += new System.EventHandler(this.btnDetailClient_Click);
            // 
            // btnAfficherListe
            // 
            this.btnAfficherListe.Location = new System.Drawing.Point(12, 148);
            this.btnAfficherListe.Name = "btnAfficherListe";
            this.btnAfficherListe.Size = new System.Drawing.Size(163, 23);
            this.btnAfficherListe.TabIndex = 0;
            this.btnAfficherListe.Text = "Afficher liste clients";
            this.btnAfficherListe.UseVisualStyleBackColor = true;
            this.btnAfficherListe.Click += new System.EventHandler(this.btnAfficheListe_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(12, 541);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(78, 52);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "Export to  Excel";
            this.toolTip1.SetToolTip(this.btnExport, "Convertit la liste de\r\nclients en feuille excel");
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Location = new System.Drawing.Point(12, 27);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(72, 13);
            this.lblRecherche.TabIndex = 15;
            this.lblRecherche.Text = "Rechercher : ";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(100, 541);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(78, 52);
            this.btnImport.TabIndex = 16;
            this.btnImport.Text = "Import from  Excel";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnSupprimerClient
            // 
            this.btnSupprimerClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerClient.Image = global::WindowsFormsApplication1.Properties.Resources.boutonSupprimer;
            this.btnSupprimerClient.Location = new System.Drawing.Point(15, 69);
            this.btnSupprimerClient.Name = "btnSupprimerClient";
            this.btnSupprimerClient.Size = new System.Drawing.Size(61, 61);
            this.btnSupprimerClient.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnSupprimerClient, "Supprimer un client");
            this.btnSupprimerClient.UseVisualStyleBackColor = true;
            this.btnSupprimerClient.Click += new System.EventHandler(this.btnSupprimerClient_Click);
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterClient.Image = global::WindowsFormsApplication1.Properties.Resources.BoutonAjouter;
            this.btnAjouterClient.Location = new System.Drawing.Point(114, 69);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(61, 61);
            this.btnAjouterClient.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnAjouterClient, "Ajouter un client");
            this.btnAjouterClient.UseVisualStyleBackColor = true;
            this.btnAjouterClient.Click += new System.EventHandler(this.btnAjouterClient_Click);
            // 
            // btnViderListe
            // 
            this.btnViderListe.Location = new System.Drawing.Point(12, 177);
            this.btnViderListe.Name = "btnViderListe";
            this.btnViderListe.Size = new System.Drawing.Size(163, 23);
            this.btnViderListe.TabIndex = 17;
            this.btnViderListe.Text = "Vider liste clients";
            this.btnViderListe.UseVisualStyleBackColor = true;
            this.btnViderListe.Click += new System.EventHandler(this.btnViderListe_Click);
            // 
            // frmGestionClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 597);
            this.Controls.Add(this.btnViderListe);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.lblRecherche);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSupprimerClient);
            this.Controls.Add(this.btnDetailClient);
            this.Controls.Add(this.btnModifierClient);
            this.Controls.Add(this.btnAfficherListe);
            this.Controls.Add(this.btnAjouterClient);
            this.Controls.Add(this.txtRechercher);
            this.Controls.Add(this.grdClient);
            this.Controls.Add(this.msGestionClient);
            this.MainMenuStrip = this.msGestionClient;
            this.Name = "frmGestionClient";
            this.Text = "gestionClient";
            this.Activated += new System.EventHandler(this.frmGestionClient_Activated);
            this.Load += new System.EventHandler(this.frmGestionClient_Load);
            this.msGestionClient.ResumeLayout(false);
            this.msGestionClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msGestionClient;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem;
        private System.Windows.Forms.DataGridView grdClient;
        private System.Windows.Forms.ToolStripMenuItem listeClientsToolStripMenuItem;
        private System.Windows.Forms.TextBox txtRechercher;
        private System.Windows.Forms.Button btnSupprimerClient;
        private System.Windows.Forms.Button btnModifierClient;
        private System.Windows.Forms.Button btnAjouterClient;
        private System.Windows.Forms.Button btnDetailClient;
        private System.Windows.Forms.Button btnAfficherListe;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnViderListe;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerClientToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viderListeClientsToolStripMenuItem;
    }
}

