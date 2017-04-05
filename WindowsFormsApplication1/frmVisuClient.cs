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
            this.Size = new Size(370, 450); //on cache les contacts
            this.txtIdClient.Enabled = false;   //les Id clients et contacs sont inaccessibles à l'utilisateur
            this.txtIdContact.Enabled = false;
            this.txtIdContact.Text = Contact.nContact.ToString();   //on attribue automatiquement un id pour le futur contact qui serait crée
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
                //dr[5] = Donnees.listClient[i].TotalHeures;    //en prévision d'une utilisation future
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
            try    //pour parer aux éventuels problèmes
            {
                leContact = new Contact();
                leContact.IdContact = Contact.nContact;
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
                this.leClient.RaisonSociale = base.txtRaisonSociale.Text.ToUpper();
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
                this.leContact.NomContact=txtNomContact.Text.ToUpper();
                this.leContact.PrenomContact=txtPrenomContact.Text.ToLower();
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
                this.Size = new Size(820, 450);
                this.Show();
                majGrdContacts();
            }
            else
            {
                btnAfficherContact.Text = "Afficher les contacts >>";
                this.Size = new Size(370, 450);
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
            if (isFieldsClientValid())
            {
                if (this.modifieClient())
                {
                    //MessageBox.Show(new Form { TopMost = true }, "Modification du client acceptée !", "Client modifié", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
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
            if (this.cbxNature.Text == "")
            {
                errorProvider2.SetError(this.cbxNature, "Nature société requise !");
                valid = false;
            }
            else
            {
                errorProvider2.SetError(this.cbxNature, String.Empty);
            }
            if (this.cbxTypeSociete.Text == "")
            {
                errorProvider2.SetError(this.cbxTypeSociete, "Type société requis !");
                valid = false;
            }
            else
            {
                errorProvider2.SetError(this.cbxTypeSociete, String.Empty);
            }
            if (this.cbxActivite.Text == "")
            {
                errorProvider2.SetError(this.cbxActivite, "Activité requise !");
            }
            else
            {
                errorProvider2.SetError(this.cbxActivite, String.Empty);
            }
            if (!Outils.isCaValid(this.txtCa.Text.Trim()))
            {
                errorProvider2.SetError(this.txtCa, "Chiffre d'affaire invalide !");
                valid = false;
            }
            else
            {
                errorProvider2.SetError(this.txtCa, String.Empty);
            }
            if (!(Outils.isEffectifValid(this.txtEffectif.Text.Trim())))
            {
                errorProvider2.SetError(this.txtEffectif, "Effectif invalide !");
                valid = false;
            }
            else
            {
                errorProvider2.SetError(this.txtEffectif, String.Empty);
            }
            if (!(Outils.isTelephoneValid(this.txtTelephone.Text.Trim())))
            {
                errorProvider2.SetError(this.txtTelephone, "Téléphone invalide !");
                valid = false;
            }
            else
            {
                errorProvider2.SetError(this.txtTelephone, String.Empty);
            }
            if (this.txtAdresse.Text.Trim() == "")
            {
                errorProvider2.SetError(this.txtAdresse, "Adresse requise !");
                valid = false;
            }
            else
            {
                errorProvider2.SetError(this.txtAdresse, String.Empty);
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
            if (!Outils.isPrenomValid(this.txtPrenomContact.Text.Trim()))
            {
                errorProvider2.SetError(this.txtPrenomContact, "Prénom contact invalide !");
                valid = false;
            }
            else
            {
                errorProvider2.SetError(this.txtPrenomContact, String.Empty);
            }
            if (!Outils.isFonctionValid(this.txtFonctionContact.Text.Trim()))
            {
                errorProvider2.SetError(this.txtFonctionContact, "Fonction contact invalide !");
                valid = false;
            }
            else
            {
                errorProvider2.SetError(this.txtFonctionContact, String.Empty);
            }
            if (!Outils.isTelephoneValid(this.txtTelephoneContact.Text.Trim()))
            {
                errorProvider2.SetError(this.txtTelephoneContact, "Téléphone contact invalide !");
            }
            else
            {
                errorProvider2.SetError(this.txtTelephoneContact, String.Empty);
            }
            return valid;
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
        /// <summary>
        /// passe les contrôles en enabled pour permettre de faire des modifications
        /// </summary>
        private void writeable()
        {
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
                    int iContact = this.grdContact.CurrentRow.Index;
                    Contact unContact = leClient.ListContact[iContact];
                    leClient.ListContact.Remove(unContact);
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
            this.txtIdContact.Text = "";
            this.txtNomContact.Text = "";
            this.txtPrenomContact.Text = "";
            this.txtTelephoneContact.Text = "";
            this.txtFonctionContact.Text = "";

        }
        /// <summary>
        /// raffraichit les champs des contrôles liés aux contacts avec les valeurs associés dans le contact selectionné dans la datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdContact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int iContact = grdContact.CurrentRow.Index;//récupère l'indice du client cliqué dans la datagrid
            Contact unContact = leClient.ListContact[iContact];
            afficheContact(unContact);
        }
        /// <summary>
        /// modifie un contact et met à jour la grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierContact_Click(object sender, EventArgs e)
        {
            if (isFieldsContactValid())
            {
                if (this.modifieContact())
                {
                    majGrdContacts();
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
                    Donnees.listContact.Add(Contact.nContact, leContact);
                    majGrdContacts();
                    Contact.nContact++;
                    this.txtIdContact.Text = Contact.nContact.ToString();
                }
            }
        }

        private void btnDeverrouiller_Click(object sender, EventArgs e)
        {
            if (btnUnlock.Text == "Unlock")
            {
                btnUnlock.Text = "Lock";
                this.writeable();
                this.Show();
            }
            else
            {
                btnUnlock.Text = "Unlock";
                this.readable();
                this.Show();
            }
        }

        private void frmVisuClient_Activated(object sender, EventArgs e)
        {
            this.txtIdContact.Text = Contact.nContact.ToString();
        }

        private bool testFields()
        {
            return false;
        }
    }
}
