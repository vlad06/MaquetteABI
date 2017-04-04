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
        private frmVisuClient frmVisu;
        public frmGestionClient()
        {
            InitializeComponent();
            this.btnDetailClient.Enabled = false;
            //this.btnSupprimerClient.Enabled = false;
        }

        private void afficheClients()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ID Client", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Raison sociale", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Nature", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Téléphone", typeof(System.String)));
            dt.Columns.Add(new DataColumn("CA Client", typeof(System.Decimal)));
            dt.Columns.Add(new DataColumn("Effectif", typeof(System.Int32)));

            DataRow dr;
            for(int i = 0; i < Donnees.listClient.Count; i++)
            {
                dr = dt.NewRow();
                dr[0] = Donnees.listClient[i].IdClient;
                dr[1] = Donnees.listClient[i].RaisonSociale;
                dr[2] = Donnees.listClient[i].Nature;
                dr[3] = Donnees.listClient[i].Telephone;
                dr[4] = Donnees.listClient[i].Ca;
                dr[5] = Donnees.listClient[i].Effectif;
                dt.Rows.Add(dr);
            }
            this.grdClient.DataSource = dt.DefaultView;
        }

        private void frmGestionClient_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ID Client", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Raison sociale", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Nature", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Téléphone", typeof(System.String)));
            dt.Columns.Add(new DataColumn("CA Client", typeof(System.Decimal)));
            dt.Columns.Add(new DataColumn("Effectif", typeof(System.Int32)));
            this.grdClient.DataSource = dt.DefaultView;
        }


        private void creerClientTest()
        {
            for (int i = 1; i < 5; i++)
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
                Donnees.listClient.Add(Client1);
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
            if(this.grdClient.CurrentRow == null)
            {
                creerClientTest();
            }
        }
        private void grdClient_DoubleClick(object sender, EventArgs e)
        {
            this.afficheDetailClient();
        }
        private void btnDetailClient_Click(object sender, EventArgs e)
        {
            this.afficheDetailClient();
        }

        private void afficheDetailClient()
        {
            if (this.grdClient.CurrentRow != null)
            {
                int iClient = this.grdClient.CurrentRow.Index;//récupère l'indice du client cliqué dans la datagrid
                Client leClient = Donnees.listClient[iClient];
                if (!isFormOpen())  //si la form client n'est pas encore ouverte
                {
                    this.frmVisu = new frmVisuClient(leClient); //on crée une instance de la form client
                    this.frmVisu.Show(); //on l'affiche
                    this.frmVisu.TopMost = true; //on force la form client au premier plan
                    this.frmVisu.FormClosing += new FormClosingEventHandler(this.fermeVisu);
                    Donnees.listFrmVisuClient.Add(leClient.IdClient, frmVisu); //ajoute au dico le couple (idclient,frmvisu)
                }
                else
                {
                    MessageBox.Show(new Form { TopMost = true },"Cette fenêtre client est déjà ouverte", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void fermeVisu(object sender, FormClosingEventArgs e)
        {
            this.afficheClients();
        }

        private bool isFormOpen()
        {
            int iClient = this.grdClient.CurrentRow.Index;
            Client leClient = Donnees.listClient[iClient];
            if (Donnees.listFrmVisuClient.ContainsKey(leClient.IdClient))
            {
                return true;
            }
            return false;
        }

        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {
            if (this.grdClient.CurrentRow != null)
            {
                DialogResult dr = MessageBox.Show(new Form { TopMost = true }, "Etes-vous sûr de vouloir supprimer le client sélectionné ?", "Attention",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                int iClient = this.grdClient.CurrentRow.Index;
                Client leClient = Donnees.listClient[iClient];
                if (dr == DialogResult.OK)
                {
                    if (isFormOpen())
                    {
                        dr = MessageBox.Show(new Form { TopMost = true }, "La suppression de ce client entrainera la fermeture de la fenêtre associée, supprimer quand même ?", "Attention",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (dr == DialogResult.OK)
                        {
                            if (Donnees.listFrmVisuClient.ContainsKey(leClient.IdClient))
                            {
                                frmVisuClient fvc = Donnees.listFrmVisuClient[leClient.IdClient];
                                fvc.Close();
                            }
                            Donnees.listFrmVisuClient.Remove(leClient.IdClient);
                            Donnees.listClient.Remove(leClient);
                            Client.nClient--;
                            afficheClients();
                        }
                    }
                    else
                    {
                        Donnees.listFrmVisuClient.Remove(leClient.IdClient);
                        Donnees.listClient.Remove(leClient);
                        afficheClients();
                    }
                }
            }

        }

        private void grdClient_SelectionChanged(object sender, EventArgs e)
        {
            if(this.grdClient.CurrentRow != null)
            {
                this.btnDetailClient.Enabled = true;
            }else
            {
                this.btnDetailClient.Enabled = false;
            }
        }

        private void btnModifierClient_Click(object sender, EventArgs e)
        {
            
        }

        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string rechercheID = string.Format("CONVERT([ID Client],System.String) like '%{0}%'", this.txtRechercher.Text);
                string rechercheRs = string.Format("OR [Raison sociale] like '%{0}%'", this.txtRechercher.Text);
                string rechercheNature = string.Format("OR Nature like '%{0}%'", this.txtRechercher.Text);
                string rechercheTel = string.Format("OR Téléphone like '%{0}%'", this.txtRechercher.Text);
                string rechercheCa = string.Format("OR CONVERT([CA Client],System.String) like '%{0}%'", this.txtRechercher.Text);
                string rechercheEffectif = string.Format("OR CONVERT(Effectif,System.String) like '%{0}%'", this.txtRechercher.Text);

                ((DataView)(this.grdClient.DataSource)).RowFilter = rechercheID+rechercheRs+rechercheNature+rechercheTel+rechercheCa+rechercheEffectif;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :\n" + ex.Message, "Recherche ID Client");
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
