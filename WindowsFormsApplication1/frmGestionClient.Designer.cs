﻿namespace WindowsFormsApplication1
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
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feuilleExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grdClient = new System.Windows.Forms.DataGridView();
            this.txtRechercher = new System.Windows.Forms.TextBox();
            this.btnModifierClient = new System.Windows.Forms.Button();
            this.btnDetailClient = new System.Windows.Forms.Button();
            this.btnAfficheListe = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSupprimerClient = new System.Windows.Forms.Button();
            this.btnAjouterClient = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.msGestionClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClient)).BeginInit();
            this.SuspendLayout();
            // 
            // msGestionClient
            // 
            this.msGestionClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.afficherToolStripMenuItem,
            this.aideToolStripMenuItem});
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
            this.quitterToolStripMenuItem,
            this.quitterToolStripMenuItem1,
            this.quitterToolStripMenuItem2});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // nouveauClientToolStripMenuItem
            // 
            this.nouveauClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem});
            this.nouveauClientToolStripMenuItem.Name = "nouveauClientToolStripMenuItem";
            this.nouveauClientToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.nouveauClientToolStripMenuItem.Text = "Nouveau";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.feuilleExcelToolStripMenuItem});
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.quitterToolStripMenuItem.Text = "Ouvrir";
            // 
            // feuilleExcelToolStripMenuItem
            // 
            this.feuilleExcelToolStripMenuItem.Name = "feuilleExcelToolStripMenuItem";
            this.feuilleExcelToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.feuilleExcelToolStripMenuItem.Text = "Feuille Excel";
            // 
            // quitterToolStripMenuItem1
            // 
            this.quitterToolStripMenuItem1.Name = "quitterToolStripMenuItem1";
            this.quitterToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.quitterToolStripMenuItem1.Text = "Enregistrer sous";
            // 
            // quitterToolStripMenuItem2
            // 
            this.quitterToolStripMenuItem2.Name = "quitterToolStripMenuItem2";
            this.quitterToolStripMenuItem2.Size = new System.Drawing.Size(157, 22);
            this.quitterToolStripMenuItem2.Text = "Quitter";
            // 
            // afficherToolStripMenuItem
            // 
            this.afficherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeClientsToolStripMenuItem});
            this.afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            this.afficherToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.afficherToolStripMenuItem.Text = "Afficher";
            // 
            // listeClientsToolStripMenuItem
            // 
            this.listeClientsToolStripMenuItem.Name = "listeClientsToolStripMenuItem";
            this.listeClientsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.listeClientsToolStripMenuItem.Text = "Liste clients";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // grdClient
            // 
            this.grdClient.AllowUserToAddRows = false;
            this.grdClient.AllowUserToDeleteRows = false;
            this.grdClient.AllowUserToOrderColumns = true;
            this.grdClient.AllowUserToResizeColumns = false;
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
            this.grdClient.SelectionChanged += new System.EventHandler(this.grdClient_SelectionChanged);
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
            this.btnModifierClient.Location = new System.Drawing.Point(59, 349);
            this.btnModifierClient.Name = "btnModifierClient";
            this.btnModifierClient.Size = new System.Drawing.Size(76, 52);
            this.btnModifierClient.TabIndex = 11;
            this.btnModifierClient.Text = "Modifier un client";
            this.btnModifierClient.UseVisualStyleBackColor = true;
            this.btnModifierClient.Click += new System.EventHandler(this.btnModifierClient_Click);
            // 
            // btnDetailClient
            // 
            this.btnDetailClient.Location = new System.Drawing.Point(12, 214);
            this.btnDetailClient.Name = "btnDetailClient";
            this.btnDetailClient.Size = new System.Drawing.Size(163, 23);
            this.btnDetailClient.TabIndex = 1;
            this.btnDetailClient.Text = "Details client";
            this.btnDetailClient.UseVisualStyleBackColor = true;
            this.btnDetailClient.Click += new System.EventHandler(this.btnDetailClient_Click);
            // 
            // btnAfficheListe
            // 
            this.btnAfficheListe.Location = new System.Drawing.Point(12, 185);
            this.btnAfficheListe.Name = "btnAfficheListe";
            this.btnAfficheListe.Size = new System.Drawing.Size(163, 23);
            this.btnAfficheListe.TabIndex = 0;
            this.btnAfficheListe.Text = "Afficher liste clients";
            this.btnAfficheListe.UseVisualStyleBackColor = true;
            this.btnAfficheListe.Click += new System.EventHandler(this.btnAfficheListe_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(99, 416);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(78, 52);
            this.btnConvert.TabIndex = 14;
            this.btnConvert.Text = "Convert to  Excel";
            this.btnConvert.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 52);
            this.button1.TabIndex = 16;
            this.button1.Text = "Import from  Excel";
            this.button1.UseVisualStyleBackColor = true;
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
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // frmGestionClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 597);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblRecherche);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnSupprimerClient);
            this.Controls.Add(this.btnDetailClient);
            this.Controls.Add(this.btnModifierClient);
            this.Controls.Add(this.btnAfficheListe);
            this.Controls.Add(this.btnAjouterClient);
            this.Controls.Add(this.txtRechercher);
            this.Controls.Add(this.grdClient);
            this.Controls.Add(this.msGestionClient);
            this.MainMenuStrip = this.msGestionClient;
            this.Name = "frmGestionClient";
            this.Text = "gestionClient";
            this.Load += new System.EventHandler(this.frmGestionClient_Load);
            this.msGestionClient.ResumeLayout(false);
            this.msGestionClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msGestionClient;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.DataGridView grdClient;
        private System.Windows.Forms.ToolStripMenuItem nouveauClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeClientsToolStripMenuItem;
        private System.Windows.Forms.TextBox txtRechercher;
        private System.Windows.Forms.Button btnSupprimerClient;
        private System.Windows.Forms.Button btnModifierClient;
        private System.Windows.Forms.Button btnAjouterClient;
        private System.Windows.Forms.Button btnDetailClient;
        private System.Windows.Forms.Button btnAfficheListe;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feuilleExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem2;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

