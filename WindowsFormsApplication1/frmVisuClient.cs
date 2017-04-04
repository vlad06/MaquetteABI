using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmVisuClient : WindowsFormsApplication1.frmClient
    {
        private Client leClient;    //leClient permet de stocker le client passé en paramètre au constructeur de la form
        private Contact leContact;  //leContact permet d'avoir un contact global sur lequel on pourra travailler
        /// <summary>
        /// Ce constructeur reçoit un client passé en paramètre par la fenêtre appelante (frmGestionClient)
        /// </summary>
        /// <param name="unClient"></param>
        public frmVisuClient(Client unClient)
        {
            this.leClient = unClient; //on assigne le client passé en paramètre à notre attribut déclaré plus haut
            InitializeComponent();
            this.Size = new Size(370, 475); //on cache les contacts
            this.txtIdClient.Enabled = false;
            this.txtIdContact.Enabled = false;
            this.txtIdContact.Text = Contact.nContact.ToString();
        }
        /// <summary>
        /// on remplit les champs du form de visualisation avec les propriétés de l'objet passé en paramètre
        /// </summary>
        /// <param name="unClient"></param>
        private void afficheClient(Client unClient)
        {
            this.txtRaisonSociale.Text = unClient.RaisonSociale;
            this.txtIdClient.Text = unClient.IdClient.ToString();
            this.txtTelephone.Text = unClient.Telephone;
            this.cbxNature.Text = unClient.Nature;
            this.cbxTypeSociete.Text = unClient.TypeSociete;
            this.cbxActivite.Text = unClient.Activite;
            this.txtAdresse.Text = unClient.Adresse;
            this.txtCa.Text = unClient.Ca.ToString();
            this.txtEffectif.Text = unClient.Effectif.ToString();
            this.txtCommentComm.Text = unClient.CommentComm;
        }
        /// <summary>
        /// réecrit la datagrid grdContact avec la liste de contact contenue dans la classe client 
        /// </summary>
        private void majGrdContacts()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ID Contact", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Nom", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Prénom", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Téléphone", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Fonction", typeof(System.String)));
            DataRow dr;
            for (int i = 0; i < leClient.ListContact.Count; i++)
            {
                dr = dt.NewRow();
                dr[0] = leClient.ListContact[i].IdContact;
                dr[1] = leClient.ListContact[i].NomContact;
                dr[2] = leClient.ListContact[i].PrenomContact;
                dr[3] = leClient.ListContact[i].TelContact;
                dr[4] = leClient.ListContact[i].FonctionContact;
                //dr[5] = Donnees.listClient[i].TotalHeures;
                dt.Rows.Add(dr);
            }
            this.grdContact.DataSource = dt.DefaultView;
        }
        /// <summary>
        /// remplit les champs du grdContact avec les valeurs du contact passé en paramètre
        /// </summary>
        /// <param name="unContact"></param>
        private void afficheContact(Contact unContact)
        {
            this.txtIdContact.Text = unContact.IdContact.ToString();
            this.txtNomContact.Text = unContact.NomContact;
            this.txtPrenomContact.Text = unContact.PrenomContact;
            this.txtTelephoneContact.Text = unContact.TelContact;
            this.txtFonctionContact.Text = unContact.FonctionContact;
        }
        /// <summary>
        /// tente d'instancier un contact, renvoie true si c'est possible et false sinon
        /// </summary>
        /// <returns></returns>
        private bool instancieContact()
        {
            try
            {
                leContact = new Contact();
                leContact.IdContact = Contact.nContact;// int.Parse(txtIdContact.Text.Trim());
                leContact.NomContact = txtNomContact.Text;
                leContact.PrenomContact = txtPrenomContact.Text;
                leContact.TelContact = txtTelephoneContact.Text;
                leContact.FonctionContact = txtFonctionContact.Text;
                leClient.ListContact.Add(leContact);
                return true;
            }
            catch (Exception ex)
            {
                this.leClient = null;
                MessageBox.Show("Erreur :\n" + ex.Message, "Modification de contact");
                return false;
            }
        }
        /// <summary>
        /// tente de modifier un client, renvoie true si c'est possible et false sinon
        /// </summary>
        /// <returns></returns>
        private bool modifieClient()
        {
            try
            {
                //this.leClient.IdClient = int.Parse(base.txtIdClient.Text.Trim());
                this.leClient.RaisonSociale = base.txtRaisonSociale.Text;
                this.leClient.Nature = base.cbxNature.Text;
                this.leClient.TypeSociete = base.cbxTypeSociete.Text;
                this.leClient.Telephone = base.txtTelephone.Text;
                this.leClient.Adresse= base.txtAdresse.Text;
                this.leClient.Ca = decimal.Parse(base.txtCa.Text.Trim());
                this.leClient.Effectif = int.Parse(base.txtEffectif.Text.Trim());
                this.leClient.CommentComm = base.txtCommentComm.Text;
                return true;
            }
            catch (Exception ex)
            {
                this.leClient = null;
                MessageBox.Show("Erreur :\n" + ex.Message, "Modification de client");
                return false;
            }
        }/// <summary>
        /// tente de modifier un contact, renvoie true si c'est possible et false sinon
        /// </summary>
        /// <returns></returns>
        private bool modifieContact()
        {
            try
            {
                //this.leContact.IdContact=int.Parse(txtIdContact.Text.Trim());
                this.leContact.NomContact=txtNomContact.Text;
                this.leContact.PrenomContact=txtPrenomContact.Text;
                this.leContact.TelContact=txtTelephoneContact.Text;
                this.leContact.FonctionContact=txtFonctionContact.Text;
                return true;
            }
            catch(Exception ex)
            {
                this.leContact = null;
                MessageBox.Show("Erreur :\n" + ex.Message, "Modification de contact");
                return false;
            }
        }

        private void btnAfficherContact_Click(object sender, EventArgs e)
        {
            if (btnAfficherContact.Text == "Afficher les contacts >>")
            {
                btnAfficherContact.Text = "Cacher les contacts";
                this.Size = new Size(790, 475);
                this.Show();
                majGrdContacts();
            }
            else
            {
                btnAfficherContact.Text = "Afficher les contacts >>";
                this.Size = new Size(370, 475);
                this.Show();
            }
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            this.afficheClient(leClient);//on réinitialise
        }

        private void frmVisuClient_Load(object sender, EventArgs e)
        {
            this.afficheClient(this.leClient);
            this.readable();
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ID Contact", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Nom", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Prénom", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Téléphone", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Fonction", typeof(System.String)));
            this.grdContact.DataSource = dt.DefaultView;
        }

        private void btnValiderClient_Click(object sender, EventArgs e)
        {
            if (txtIdClient.Text == "")
            {
                MessageBox.Show(new Form { TopMost = true }, "l'ID du client ne doit pas être vide !!", "Attention", MessageBoxButtons.OK);
            }
            else if (this.modifieClient())
            {
                this.Close();
            }
        }

        private void frmVisuClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            Donnees.listFrmVisuClient.Remove(leClient.IdClient);
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValiderContact_Click(object sender, EventArgs e)
        {

        }

      
        private void readable()
        {
            //this.txtIdClient.Enabled = false;
            this.txtRaisonSociale.Enabled = false;
            this.cbxNature.Enabled = false;
            this.cbxTypeSociete.Enabled = false;
            this.cbxActivite.Enabled = false;
            this.txtCa.Enabled = false;
            this.txtEffectif.Enabled = false;
            this.txtTelephone.Enabled = false;
            this.txtAdresse.Enabled = false;
            this.txtCommentComm.Enabled = false;
            this.gbxAjoutContact.Enabled = false;
            this.gbxListeContact.Enabled = false;
            this.grdContact.Enabled = false;

        }

        private void writeable()
        {
            //this.txtIdClient.Enabled = true;
            this.txtRaisonSociale.Enabled = true;
            this.cbxNature.Enabled = true;
            this.cbxTypeSociete.Enabled = true;
            this.cbxActivite.Enabled = true;
            this.txtCa.Enabled = true;
            this.txtEffectif.Enabled = true;
            this.txtTelephone.Enabled = true;
            this.txtAdresse.Enabled = true;
            this.txtCommentComm.Enabled = true;
            this.gbxAjoutContact.Enabled = true;
            this.gbxListeContact.Enabled = true;
            this.grdContact.Enabled = true;
        }
        

        private void btnSupprimerContact_Click(object sender, EventArgs e)
        {
            if (grdContact.CurrentRow != null)
            {
                DialogResult dr = MessageBox.Show(new Form { TopMost = true }, "Etes-vous sûr de vouloir supprimer le contact sélectionné ?", "Attention",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(dr == DialogResult.OK)
                {
                    int iContact = this.grdContact.CurrentRow.Index;
                    Contact unContact = leClient.ListContact[iContact];
                    leClient.ListContact.Remove(unContact);
                    majGrdContacts();
                }
            }
        }

        private void btnRaz_Click(object sender, EventArgs e)
        {
            this.txtIdContact.Text = "";
            this.txtNomContact.Text = "";
            this.txtPrenomContact.Text = "";
            this.txtTelephoneContact.Text = "";
            this.txtFonctionContact.Text = "";

        }

        private void grdContact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int iContact = grdContact.CurrentRow.Index;//récupère l'indice du client cliqué dans la datagrid
            Contact unContact = leClient.ListContact[iContact];
            afficheContact(unContact);
        }

        private void btnModifierContact_Click(object sender, EventArgs e)
        {
            if (txtIdContact.Text == "")
            {
                MessageBox.Show(new Form { TopMost = true }, "l'ID du contact ne doit pas être vide !!", "Attention", MessageBoxButtons.OK);
            }
            else if (this.modifieContact())
            {
                majGrdContacts();
            }
        }
        private void btnAjouterContact_Click(object sender, EventArgs e)
        {
            if(txtIdContact.Text == "")
            {
                MessageBox.Show(new Form { TopMost = true }, "l'ID du contact ne doit pas être vide !!", "Attention", MessageBoxButtons.OK);
            }
            else if (this.instancieContact())
            {
                majGrdContacts();
                Contact.nContact++;
                this.txtIdContact.Text = Contact.nContact.ToString();
            }
        }

        private void btnDeverrouiller_Click(object sender, EventArgs e)
        {
            if (btnDeverrouiller.Text == "Dévérrouiller")
            {
                btnDeverrouiller.Text = "Vérrouiller";
                this.writeable();
                this.Show();
            }
            else
            {
                btnDeverrouiller.Text = "Dévérrouiller";
                this.readable();
                this.Show();
            }
        }

        private void frmVisuClient_Activated(object sender, EventArgs e)
        {
            this.txtIdContact.Text = Contact.nContact.ToString();
        }
    }
}
