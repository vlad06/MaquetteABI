using System;
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
        private frmAjoutClient frmAjout;
        public frmGestionClient()
        {
            InitializeComponent();
            this.btnDetailClient.Enabled = false;
            this.btnVoirContact.Enabled = false;
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

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            this.frmAjout = new frmAjoutClient();
            if (this.frmAjout.ShowDialog() == DialogResult.OK)
                {
                    this.afficheClients();
                }
        }

        private void btnAfficheListe_Click(object sender, EventArgs e)
        {
            creerClientTest();
        }
        private void grdClient_DoubleClick(object sender, EventArgs e)
        {
            afficheDetailClient();
        }
        private void btnDetailClient_Click(object sender, EventArgs e)
        {
                afficheDetailClient();
        }

        private void afficheDetailClient()
        {
            if (this.grdClient.CurrentRow != null)
            {
                int iClient = this.grdClient.CurrentRow.Index;//récupère l'indice du client cliqué dans la datagrid
                Client leClient = Donnees.ArrayClient[iClient];
                if (!isFormOpen())  //si la form client n'est pas encore ouverte
                {
                    frmVisuClient frmVisu = new frmVisuClient(leClient); //on crée une instance de la form client
                    frmVisu.Show(); //on l'ouvre
                    frmVisu.TopMost = true; //on force la form client au premier plan
                    //this.afficheClients();  //on met à jour la datagrid
                    Donnees.ArrayFrmClientOpened.Add(leClient.IdClient);    //on ajoute à la liste des fenêtres ouverte l'id du client affiché
                } else
                {
                    MessageBox.Show("Cette fenêtre client est déjà ouverte", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool isFormOpen()
        {
            int iClient = this.grdClient.CurrentRow.Index;
            Client leClient = Donnees.ArrayClient[iClient];
            for (int i = 0; i < Donnees.ArrayFrmClientOpened.Count; i++)
            {
                if (Donnees.ArrayFrmClientOpened[i] == leClient.IdClient)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Etes-vous sûr de vouloir supprimer le client sélectionné ?", "ATTENTION",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                int iClient = this.grdClient.CurrentRow.Index;
                Client leClient = Donnees.ArrayClient[iClient];
                Donnees.ArrayFrmClientOpened.Remove(leClient.IdClient);
                Donnees.ArrayClient.Remove(leClient);
                afficheClients();
            }
        }
    }
}
