﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class frmGestionClient : Form
    {
        public frmGestionClient()
        {
            InitializeComponent();
            btnSupprimerClient.Enabled = false;

        }

        private void afficheClients()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ID Client", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Raison sociale", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Nature", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Telephone", typeof(System.String)));
            dt.Columns.Add(new DataColumn("CA Client", typeof(System.Decimal)));
            dt.Columns.Add(new DataColumn("Effectif", typeof(System.Int32)));

            DataRow dr;
            for(int i = 0; i < Donnees.ArrayClient.Count; i++)
            {
                dr = dt.NewRow();
                dr[0] = Donnees.ArrayClient[i].IdClient;
                dr[1] = Donnees.ArrayClient[i].RaisonSociale;
                dr[2] = Donnees.ArrayClient[i].Nature;
                dr[3] = Donnees.ArrayClient[i].Telephone;
                dr[4] = Donnees.ArrayClient[i].Ca;
                dr[5] = Donnees.ArrayClient[i].Effectif;
                dt.Rows.Add(dr);
            }
            this.grdClient.DataSource = dt;
        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
        { 
            frmAjoutClient frmAdd = new frmAjoutClient();
            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                this.afficheClients();
            }
            this.afficheClients();
        }

        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("êtes-vous sûr de vouloir effacer ce client ?", "Attention!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            int iClient = this.grdClient.CurrentRow.Index;
            if(dr == DialogResult.Yes && this.grdClient.CurrentRow != null)
            {
                if(iClient >= 0)
                {
                    Client unClient = Donnees.ArrayClient[iClient];
                    Donnees.ArrayClient.Remove(unClient);
                    Client.nClient--;
                    this.afficheClients();
                }
            }
            if(dr == DialogResult.No)
            {
                
            }
            if (Client.NClient == 0)
            {
                this.btnSupprimerClient.Enabled = false;
            }
        }

        private void grdClient_DoubleClick(object sender, EventArgs e)
        {
            if (this.grdClient.CurrentRow != null)
            {
                int iClient;
                iClient = this.grdClient.CurrentRow.Index;//récupère l'indice du client cliqué dans la datagrid
                Client leClient = Donnees.ArrayClient[iClient];
                frmVisuClient frmDetail = new frmVisuClient(leClient);
                frmDetail.Show();
                this.afficheClients();
            }
        }

        private void frmGestionClient_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ID Client", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Raison sociale", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Nature", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Telephone", typeof(System.String)));
            dt.Columns.Add(new DataColumn("CA Client", typeof(System.Decimal)));
            dt.Columns.Add(new DataColumn("Effectif", typeof(System.Int32)));
            this.grdClient.DataSource = dt;
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjoutClient frmAdd = new frmAjoutClient();
            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                this.afficheClients();
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listeClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            creerClientTest();
        }

        private void grdClient_SelectionChanged(object sender, EventArgs e)
        {
            this.btnSupprimerClient.Enabled = true;

        }

        private void btnAfficheListe_Click(object sender, EventArgs e)
        {
            creerClientTest();
        }

        private void creerClientTest()
        {
            for (int i = 1; i < 10; i++)
            {
                Client Client1 = new Client();
                Client1.IdClient = i;
                Client1.RaisonSociale = "SA " + i;
                Client1.Nature = "Principale";
                Client1.TypeSociete = "Privé";
                Client1.Telephone = "049332581" + i;
                Client1.Adresse = i + " ,route de turin 06000 NICE";
                Client1.Activite = "Industrie";
                Client1.Ca = i * 10000;
                Client1.Effectif = i * 2;
                Client1.CommentComm = i + ") Putain de bordel de merde...";
                Donnees.ArrayClient.Add(Client1);
            }
            this.afficheClients();
        }

        private void btnDetailClient_Click(object sender, EventArgs e)
        {
            if (this.grdClient.CurrentRow != null)
            {
                int iClient;
                iClient = this.grdClient.CurrentRow.Index;//récupère l'indice du client cliqué dans la datagrid
                Client leClient = Donnees.ArrayClient[iClient];
                frmVisuClient frmDetail = new frmVisuClient(leClient);
                frmDetail.Show();
                this.afficheClients();
            }
        }

        private void btnVoirContact_Click(object sender, EventArgs e)
        {
            frmGestionContact frmc = new frmGestionContact();
            frmc.Show();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
