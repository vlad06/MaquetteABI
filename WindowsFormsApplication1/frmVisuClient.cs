using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmVisuClient : WindowsFormsApplication1.frmClient
    {
        private Client leClient;    //leClient permet de stocker le client passé en paramètre au constructeur de la form

        //********************************************************
        //************************CONSTRUCTEURS*******************
        //********************************************************
        /// <summary>
        /// Ce constructeur reçoit un client passé en paramètre par la fenêtre appelante (frmGestionClient)
        /// </summary>
        /// <param name="unClient"></param>
        public frmVisuClient(Client unClient)
        {
            this.leClient = unClient; //on assigne le client passé en paramètre à notre attribut déclaré plus haut
            InitializeComponent();
            this.Size = new Size(385, 450); //on cache les contacts
            this.txtIdClient.Enabled = false;   //les contrôles Id clients et contacts sont inaccessibles à l'utilisateur
            this.txtIdContact.Enabled = false;  //TODO:FAIRE UNE FONCTION POUR GERER LES BOUTONS ENABLED
            this.txtIdContact.Text = Outils.bestIdContact().ToString(); //on récupère une id de client juste au dessus de l'id client la plus haute afin d'optimiser
        }
        //********************************************************
        //************************METHODES************************
        //********************************************************
        /// <summary>
        /// on remplit les champs du form de visualisation avec les propriétés de l'objet passé en paramètre
        /// </summary>
        /// <param name="unClient"></param>
        private void afficheClient(Client unClient)
        {
            this.txtIdClient.Text = unClient.IdClient.ToString();
            this.txtRaisonSociale.Text = unClient.RaisonSociale;
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
            //on fait une requête pour récupérer la liste de contacts liée au client sélectionné
            IEnumerable<TContact> listContactEF = from lCont in Donnees.abiDb.TContact.ToList()
                                                  where lCont.IdClient == leClient.IdClient
                                                  select lCont;
            foreach (TContact unContactEF in listContactEF)
            {
                dr = dt.NewRow();
                dr[0] = unContactEF.IdContact;
                dr["Nom"] = unContactEF.NomContact;
                dr["Prénom"] = unContactEF.PrenomContact;
                dr["Téléphone"] = unContactEF.TelContact;
                dr["Fonction"] = unContactEF.FonctionContact;
                dt.Rows.Add(dr);
            }
            this.grdContact.DataSource = dt;
        }
        private void razContactFields()
        {
            this.txtIdContact.Text = "";
            this.txtNomContact.Text = "";
            this.txtPrenomContact.Text = "";
            this.txtTelephoneContact.Text = "";
            this.txtFonctionContact.Text = "";
        }

        private void fillContactFields()
        {
            if(grdContact.CurrentRow != null)
            {
                this.txtIdContact.Text = grdContact.CurrentRow.Cells[0].Value.ToString();
                this.txtNomContact.Text = grdContact.CurrentRow.Cells[1].Value.ToString();
                this.txtPrenomContact.Text = grdContact.CurrentRow.Cells[2].Value.ToString();
                this.txtTelephoneContact.Text = grdContact.CurrentRow.Cells[3].Value.ToString();
                this.txtFonctionContact.Text = grdContact.CurrentRow.Cells[4].Value.ToString();
            }
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
            Contact nouveauContact = new Contact();
            try    //pour parer aux éventuels problèmes
            {
                nouveauContact.IdContact = Outils.bestIdContact();
                nouveauContact.NomContact = txtNomContact.Text;
                nouveauContact.PrenomContact = txtPrenomContact.Text;
                nouveauContact.TelContact = txtTelephoneContact.Text;
                nouveauContact.FonctionContact = txtFonctionContact.Text;

                TContact nouveauContactEF = new TContact();
                nouveauContactEF.IdContact = nouveauContact.IdContact;
                nouveauContactEF.NomContact = nouveauContact.NomContact;
                nouveauContactEF.PrenomContact = nouveauContact.PrenomContact;
                nouveauContactEF.TelContact = nouveauContact.TelContact;
                nouveauContactEF.FonctionContact= nouveauContact.FonctionContact;
                nouveauContactEF.IdClient = leClient.IdClient;

                Donnees.abiDb.TContact.Add(nouveauContactEF);
                Donnees.abiDb.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                this.leClient = null;
                MessageBox.Show("Erreur :\n" + ex.Message, "Ajout de contact");
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
                this.leClient.RaisonSociale = base.txtRaisonSociale.Text.ToUpper();
                this.leClient.Nature = base.cbxNature.Text;
                this.leClient.TypeSociete = base.cbxTypeSociete.Text;
                this.leClient.Activite = base.cbxActivite.Text;
                this.leClient.Telephone = base.txtTelephone.Text;
                this.leClient.Adresse = base.txtAdresse.Text;
                this.leClient.Ca = decimal.Parse(base.txtCa.Text.Trim());
                this.leClient.Effectif = int.Parse(base.txtEffectif.Text.Trim());
                this.leClient.CommentComm = base.txtCommentComm.Text;

                TClient leClientEF = Donnees.abiDb.TClient.Find(leClient.IdClient);

                leClientEF.RaisonSociale = leClient.RaisonSociale;
                leClientEF.Nature = leClient.Nature;
                leClientEF.TypeSociete = leClient.TypeSociete;
                leClientEF.Activite = leClient.Activite;
                leClientEF.Telephone = leClient.Telephone;
                leClientEF.Adresse = leClient.Adresse;
                leClientEF.Ca = leClient.Ca;
                leClientEF.Effectif = leClient.Effectif;
                leClientEF.CommentComm = leClient.CommentComm;

                Donnees.abiDb.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                this.leClient = null;
                MessageBox.Show("Erreur :\n" + ex.Message, "Modification de client");
                return false;
            }
        }
        /// <summary>
        /// tente de modifier un contact, renvoie true si c'est possible et false sinon
        /// </summary>
        /// <returns></returns>
        private bool modifieContact()
        {   //on récupère la valeur de l'id contact dans la cellule correspondante
            int idContact = Convert.ToInt32(this.grdContact.CurrentRow.Cells[0].Value);
            TContact leContactEF = Donnees.abiDb.TContact.Find(idContact);
            try
            {
                leContactEF.NomContact = txtNomContact.Text.ToUpper();
                leContactEF.PrenomContact = txtPrenomContact.Text.ToLower();
                leContactEF.TelContact = txtTelephoneContact.Text;
                leContactEF.FonctionContact = txtFonctionContact.Text;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :\n" + ex.Message, "Modification de contact");
                return false;
            }
        }
        private Boolean isFieldsClientValid()
        {
            bool valid = true;
            if (!Outils.isRaisonSocialeValid(this.txtRaisonSociale.Text.Trim()))
            {
                errorProvider2.SetError(this.txtRaisonSociale, "Raison Sociale invalide !");
                valid = false;
            }
            else
            {
                errorProvider2.SetError(this.txtRaisonSociale, String.Empty);
            }
            return valid;
        }
        private Boolean isFieldsContactValid()
        {
            bool valid = true;
            if (!Outils.isNomValid(this.txtNomContact.Text.Trim()))
            {
                errorProvider2.SetError(this.txtNomContact, "Nom contact invalide !");
                valid = false;
            }
            else
            {
                errorProvider2.SetError(this.txtNomContact, String.Empty);
            }
            return valid;
        }

        //********************************************************
        //************************EVENTS**************************
        //********************************************************
        private void btnAfficherContact_Click(object sender, EventArgs e)
        {
            if (btnAfficherContact.Text == "Afficher les contacts >>")
            {
                btnAfficherContact.Text = "Cacher les contacts";
                this.Size = new Size(825, 450);
                this.Show();
                majGrdContacts();
                fillContactFields();
            }
            else
            {
                btnAfficherContact.Text = "Afficher les contacts >>";
                this.Size = new Size(385, 450);
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
            this.readable();  //on passe le form en lecture seule pour éviter les erreurs de manipulation
            majGrdContacts();
        }

        private void btnValiderClient_Click(object sender, EventArgs e)
        {
            if (isFieldsClientValid())
            {
                if (this.modifieClient())
                {
                    this.Close();
                }
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
        /// <summary>
        /// passe les contrôles de la form en disabled pour éviter les mauvaises manipulations
        /// </summary>
        private void readable()
        {
            this.txtRaisonSociale.ReadOnly = true;
            this.cbxNature.Enabled = false;
            this.cbxTypeSociete.Enabled = false;
            this.cbxActivite.Enabled = false;
            this.txtCa.ReadOnly = true;
            this.txtEffectif.ReadOnly = true;
            this.txtTelephone.ReadOnly = true;
            this.txtAdresse.ReadOnly = true;
            this.txtCommentComm.ReadOnly = true;
            this.gbxAjoutContact.Enabled = false;
            this.gbxListeContact.Enabled = false;
            this.grdContact.Enabled = false;
        }
        /// <summary>
        /// passe les contrôles en enabled pour permettre de faire des modifications
        /// </summary>
        private void writeable()
        {
            this.txtRaisonSociale.ReadOnly = false;
            this.cbxNature.Enabled = true;
            this.cbxTypeSociete.Enabled = true;
            this.cbxActivite.Enabled = true;
            this.txtCa.ReadOnly = false;
            this.txtEffectif.ReadOnly = false;
            this.txtTelephone.ReadOnly = false;
            this.txtAdresse.ReadOnly = false;
            this.txtCommentComm.ReadOnly = false;
            this.gbxAjoutContact.Enabled = true;
            this.gbxListeContact.Enabled = true;
            this.grdContact.Enabled = true;
        }
        
        /// <summary>
        /// permet de supprimer un contact de la liste de contacts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerContact_Click(object sender, EventArgs e)
        {
            if (grdContact.CurrentRow != null)
            {
                DialogResult dr = MessageBox.Show(new Form { TopMost = true }, "Etes-vous sûr de vouloir supprimer le contact sélectionné ?", "Attention",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(dr == DialogResult.OK)
                {
                    int idContact = Convert.ToInt32(this.grdContact.CurrentRow.Cells[0].Value);
                    TContact leContactEF = Donnees.abiDb.TContact.Find(idContact);
                    Donnees.abiDb.TContact.Remove(leContactEF);
                    Donnees.abiDb.SaveChanges();
                    majGrdContacts();
                }
            }
        }
        /// <summary>
        /// vide tous les champs des contrôles liés aux contacts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRaz_Click(object sender, EventArgs e)
        {
            razContactFields();
        }
        /// <summary>
        /// raffraichit les champs des contrôles liés aux contacts avec les valeurs associés dans le contact selectionné dans la datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdContact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.grdContact.CurrentRow != null)
            {
                int idContact = Convert.ToInt32(this.grdContact.SelectedRows[0].Cells[0].Value);//on récupère la valeur de l'id contact dans la cellule correspondante
                TContact leContactEF = Donnees.abiDb.TContact.Find(idContact);
                Contact leContact = new Contact(
                    leContactEF.IdContact,
                    leContactEF.NomContact,
                    leContactEF.PrenomContact,
                    leContactEF.TelContact,
                    leContactEF.FonctionContact);
                afficheContact(leContact);
            }
            
        }
        /// <summary>
        /// modifie un contact, met à jour la grid et vide les txtbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierContact_Click(object sender, EventArgs e)
        {
            if (isFieldsContactValid())
            {
                if (this.grdContact.CurrentRow != null)
                {
                    if (this.modifieContact())
                    {
                        majGrdContacts();
                        razContactFields();
                    }
                }

            }
        }
        /// <summary>
        /// ajoute un contact, met à jour la grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterContact_Click(object sender, EventArgs e)
        {
            if (isFieldsContactValid())
            {
                if (this.instancieContact())
                {
                    majGrdContacts();
                    razContactFields();
                }
            }
        }

        private void btnDeverrouiller_Click(object sender, EventArgs e)
        {
            if (btnUnlock.Text == "Débloquer")
            {
                btnUnlock.Text = "Bloquer";
                this.writeable();
                this.Show();
            }
            else
            {
                btnUnlock.Text = "Débloquer";
                this.readable();
                this.Show();
            }
        }

        private void frmVisuClient_Activated(object sender, EventArgs e)
        {
            this.txtIdContact.Text = Outils.bestIdContact().ToString();
        }
    
        private void btnAjouterContact_MouseHover(object sender, EventArgs e)
        {
            this.txtIdContact.Text = Outils.bestIdContact().ToString();
        }
    }
}
