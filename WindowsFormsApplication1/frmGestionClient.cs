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
        //*******************************************************
        //*********************CONSTRUCTEURS*********************
        //*******************************************************
        public frmGestionClient()
        {
            InitializeComponent();
            Client.nClient=Outils.bestIdClient();
            this.btnExport.Visible = false; //pour un export éventuel de la datagrid vers une feuille excel
        }
        //*********************************************************TODO : faire une fonction de récupération de l'id client à partir de la liste pour éviter les 
        //********************METHODES INTERNES********************         erreurs avec le travail sur l'index du datagrid lorsqu'il est trié
        //*********************************************************       et arrêter de travailler sur les index du datagrid(source d'erreur)  

        /// <summary>
        /// affiche les headers puis certains attributs des clients de la liste sur la datagrid
        /// </summary>
        private void afficheClients()
        {
            DataTable dt = new DataTable();
            showGrdHeaders(dt); //affiche les headers sur la datagrid
            DataRow dr;
            foreach (TClient clientEF in Donnees.abiDb.TClient.ToList())
            {
                dr = dt.NewRow();   //dr(datarow) est une nouvelle ligne dt(datatable)
                dr[0] = clientEF.IdClient;          //  ligne clientEF n, première colonne
                dr[1] = clientEF.RaisonSociale;     //ligne clientEF n, deuxième colonne
                dr[2] = clientEF.Nature;            //ligne clientEF n, troisième colonne
                dr[3] = clientEF.Telephone;         //ligne clientEF n, quatrième colonne
                dr[4] = clientEF.Ca;                //ligne clientEF n, cinquième colonne
                dr[5] = clientEF.Effectif;          //ligne clientEF n, sixième colonne
                dt.Rows.Add(dr);    //adding the row to the datatable
            }
            //once the datatable is built, we can assign it to the datasource of the datagridview  
            this.grdClient.DataSource = dt; //une fois le couple (lignes,colonnes) construit, on l'affiche
        }
        /// <summary>
        /// affiche le client sélectionné dans la datagrid dans les champs de frmVisuClient
        /// </summary>
        private void afficheDetailClient()
        {
            if (this.grdClient.CurrentRow != null)
            {
                //int idClient = Convert.ToInt32(this.grdClient.SelectedRows[0].Cells[0].Value);//récupère l'id du client cliqué dans la datagrid
                int idClient = Convert.ToInt32(this.grdClient.CurrentRow.Cells[0].Value);
                TClient leClientEF = Donnees.abiDb.TClient.Find(idClient);
                Client leClient=new Client(
                    leClientEF.IdClient,
                    leClientEF.RaisonSociale,
                    leClientEF.TypeSociete,
                    leClientEF.Activite,
                    leClientEF.Adresse,
                    leClientEF.Nature,
                    leClientEF.Telephone,
                    leClientEF.Ca,
                    leClientEF.Effectif,
                    leClientEF.CommentComm);
                //foreach (Client cl in Donnees.listClient)
                //{
                //    if (cl.IdClient == idClient)
                //    {
                //        leClient = cl;
                //    }
                //}
                if (!isFormOpen())  //si la form client n'est pas encore ouverte
                {
                    this.frmVisu = new frmVisuClient(leClient); //on crée une instance de la form client
                    this.frmVisu.Show(); //on l'affiche
                    this.frmVisu.Activate();
                    //this.frmVisu.TopMost = true; //on force la form client au premier plan
                    this.frmVisu.FormClosing += new FormClosingEventHandler(this.fermeVisu);
                    Donnees.listFrmVisuClient.Add(leClient.IdClient, frmVisu); //ajoute au dico le couple (idclient,frmvisu)
                                                                               //qui nous permet de savoir que la form est ouverte
                }
                else
                {
                    Donnees.listFrmVisuClient.TryGetValue(leClient.IdClient, out frmVisu);//on récupère l'adresse de frmVisu ouverte
                    //frmVisu.TopMost = true;
                    //frmVisu.Focus();
                    this.frmVisu.Show();
                    this.frmVisu.Activate();
                    //frmVisu.Select();
                }
            }
        }
        /// <summary>
        /// "raffraichit" l'affichage sur la datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void fermeVisu(object sender, FormClosingEventArgs e)
        {
            this.afficheClients();
        }
        /// <summary>
        /// vérifie si la form sélectionnée est actuellement ouverte
        /// </summary>
        /// <returns></returns>
        private bool isFormOpen()
        {
            int idClient = Convert.ToInt32(this.grdClient.CurrentRow.Cells[0].Value);
            TClient leClientEF = Donnees.abiDb.TClient.Find(idClient);
            if (Donnees.listFrmVisuClient.ContainsKey(leClientEF.IdClient))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// affiche les en-têtes sur la datagrid
        /// </summary>
        /// <param name="dt"></param>
        private void showGrdHeaders(DataTable dt)
        {
            dt.Columns.Add(new DataColumn("ID Client", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Raison sociale", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Nature", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Téléphone", typeof(System.String)));
            dt.Columns.Add(new DataColumn("CA Client", typeof(System.Decimal)));
            dt.Columns.Add(new DataColumn("Effectif", typeof(System.Int32)));
            this.grdClient.DataSource = dt;
        }

        private void deleteClientFromDb()
        {
            if (this.grdClient.CurrentRow != null)
            {
                int idClient = Convert.ToInt32(this.grdClient.CurrentRow.Cells[0].Value);
                //RETROUVER LE CLIENT EF DANS LA COLLECTION DBCONTEXT
                TClient leClientEF = Donnees.abiDb.TClient.Find(idClient);
                //Client leClient = Donnees.listClient[idClient];
                //CONFIRMER LA SUPPRESSION :
                if (MessageBox.Show(new Form { TopMost = true }, "Voulez-vous supprimer définitivement ce client ?", "Attention",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (isFormOpen()) //on vérifie si la form qui va être supprimée à déjà été ouverte par l'utilisateur
                    {   //if the form is opened, we recuperate the reference from the list and we close the corresponding form
                        if (Donnees.listFrmVisuClient.ContainsKey(leClientEF.IdClient))   //si le dictionnaire contient la clé correspondant à la value idclient
                        {
                            frmVisuClient fvc = Donnees.listFrmVisuClient[leClientEF.IdClient]; //on récupère la référence de la form qui va être supprimée
                            fvc.Close();    //on ferme la form
                        }
                        Donnees.listFrmVisuClient.Remove(leClientEF.IdClient); //on supprime le couple (id,form) du dictionnaire
                        Donnees.abiDb.TClient.Remove(leClientEF);//ON SUPPRIME LE CLIENT DE LA COLLECTION EF
                        Donnees.abiDb.SaveChanges();
                        this.afficheClients();   //on met à jour l'affichage
                    }
                    else  //si il n'y a aucune fenêtre ouverte correspondant au client que l'on veut supprimer
                    {
                        //Donnees.listFrmVisuClient.Remove(leClientEF.IdClient);
                        Donnees.abiDb.TClient.Remove(leClientEF);//SUPPRIMER LE CLIENT DE LA COLLECTION EF
                        Donnees.abiDb.SaveChanges();
                        this.afficheClients();
                    }
                    Client.nClient = Outils.bestIdClient();
                }
            }
        }
        /// <summary>
        /// supprime de la liste le client sélectionné
        /// </summary>
        //private void suppressionClient()
        //{
        //    if (this.grdClient.CurrentRow != null)
        //    {
        //        DialogResult dr = MessageBox.Show(new Form { TopMost = true }, "Etes-vous sûr de vouloir supprimer le client sélectionné ?", "Attention",
        //            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        //        int iClient = this.grdClient.CurrentRow.Index;
        //        Client leClient = Donnees.listClient[iClient];
        //        if (dr == DialogResult.OK)
        //        {
        //            if (isFormOpen()) //on vérifie si la form qui va être supprimée à déjà été ouverte par l'utilisateur
        //            {
        //                dr = MessageBox.Show(new Form { TopMost = true }, "La suppression de ce client entrainera la fermeture de la fenêtre associée, supprimer quand même ?", "Attention",
        //                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        //                if (dr == DialogResult.OK)
        //                {
        //                    if (Donnees.listFrmVisuClient.ContainsKey(leClient.IdClient))   //si le dictionnaire contient la clé correspondant à la value idclient
        //                    {
        //                        frmVisuClient fvc = Donnees.listFrmVisuClient[leClient.IdClient]; //on récupère la référence de la form qui va être supprimée
        //                        fvc.Close();    //on ferme la form
        //                    }
        //                    Donnees.listFrmVisuClient.Remove(leClient.IdClient); //on supprime le couple (id,form) du dictionnaire
        //                    Donnees.listClient.Remove(leClient);        //on supprime le client de la liste client
        //                    afficheClients();   //on met à jour l'affichage
        //                }
        //            }
        //            else
        //            {
        //                Donnees.listFrmVisuClient.Remove(leClient.IdClient);
        //                Donnees.listClient.Remove(leClient);
        //                afficheClients();
        //            }
        //        }
        //    }
        //}
        /// <summary>
        /// Permet de créer une liste de client depuis un datagrid qui aurait été formé à partir d'une feuille excel
        /// </summary>
        private void buildClientListFromDataGrid()
        {
            Client theClient;
            for (int i = 0; i < 10; i++)
            {
                theClient = new Client(
                    Convert.ToInt32(grdClient.Rows[i].Cells[0].Value),      //ID client
                    Convert.ToString(grdClient.Rows[i].Cells[1].Value),     //raison sociale
                    "",
                    "",
                    "",
                    Convert.ToString(grdClient.Rows[i].Cells[2].Value),     //nature
                    Convert.ToString(grdClient.Rows[i].Cells[3].Value),     //téléphone
                    Convert.ToDecimal(grdClient.Rows[i].Cells[4].Value),    //chiffre d'affaire
                    Convert.ToInt32(grdClient.Rows[i].Cells[5].Value),      //effectif
                    ""
                    );
                //Donnees.listClient.Add(theClient);
            }
        }
        /// <summary>
        /// affiche une form d'ajout de client en mode modal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nouveauClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmAjout = new frmAjoutClient();
            if (this.frmAjout.ShowDialog() == DialogResult.OK)
            {
                this.afficheClients();
                Client.nClient++;
            }
        }

        private void supprimerClientToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.deleteClientFromDb();
        }
        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {
            this.deleteClientFromDb();
        }



        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listeClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.grdClient.CurrentRow != null)
            {
                this.afficheClients();
            }
        }

        private void viderListeClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            showGrdHeaders(dt);
        }

        private void frmGestionClient_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            showGrdHeaders(dt);
        }
        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            this.frmAjout = new frmAjoutClient();
            if (this.frmAjout.ShowDialog() == DialogResult.OK)
            {
                this.afficheClients();
                Client.nClient++;
            }
        }
        private void btnAfficheListe_Click(object sender, EventArgs e)
        {
            if(Donnees.abiDb.TClient.ToList().Count > 0)
            {
                this.afficheClients();
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
        /// <summary>
        /// permet de rechercher un client précis en faisant une recherche sur tous les critères du datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string rechercheID = string.Format("CONVERT([ID Client],System.String) like '%{0}%'", this.txtRechercher.Text);//recherche sur l'id client
                string rechercheRs = string.Format("OR [Raison sociale] like '%{0}%'", this.txtRechercher.Text);                // ou recherche sur la raison sociale
                string rechercheNature = string.Format("OR Nature like '%{0}%'", this.txtRechercher.Text);                      // ou recherche sur la nature
                string rechercheTel = string.Format("OR Téléphone like '%{0}%'", this.txtRechercher.Text);                      //ou recherche sur le telephone
                string rechercheCa = string.Format("OR CONVERT([CA Client],System.String) like '%{0}%'", this.txtRechercher.Text);  //ou recherche sur le chiffre d'affaire
                string rechercheEffectif = string.Format("OR CONVERT(Effectif,System.String) like '%{0}%'", this.txtRechercher.Text);//ou recherche sur l'effectif
                //on fait une recherche sur tous les critères à la fois
                ((DataView)(this.grdClient.DataSource)).RowFilter = rechercheID + rechercheRs + rechercheNature + rechercheTel + rechercheCa + rechercheEffectif;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :\n" + ex.Message, "Recherche ID Client");
            }
        }

        //private void frmGestionClient_Activated(object sender, EventArgs e)
        //{
        //    this.TopMost = true;
        //}

        private void btnViderListe_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            showGrdHeaders(dt);
        }

        private void btnAfficheTest_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection MyConnection;
                DataSet DtSet;
                OleDbDataAdapter MyCommand;
                MyConnection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:/Users/ADI/Desktop/testABI.xls';Extended Properties=Excel 8.0;");
                //MyConnection = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:/Users/DL-CDI/Desktop/Cours/testABI.xls';Extended Properties=Excel 8.0;");
                MyCommand = new OleDbDataAdapter("select * from [Feuil1$]", MyConnection);
                MyCommand.TableMappings.Add("Table", "TestTable");
                DtSet = new DataSet();
                MyCommand.Fill(DtSet);
                grdClient.DataSource = DtSet.Tables[0];
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            buildClientListFromDataGrid();
            //if (Donnees.listClient.Count > 0)
            {
                this.afficheClients();
            }
        }
    }
}
