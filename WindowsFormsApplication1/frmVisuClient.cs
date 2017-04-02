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
        private frmVisuClient frmVisu;
        private Client leClient;    //leClient est un attribut de la classe visu et permettra de stocker 
                                    //le client passé en paramètre au constructeur de la form
        /// <summary>
        /// Ce constructeur reçoit un client passé en paramètre par la fenêtre appelante (frmGestionClient)
        /// </summary>
        /// <param name="unClient"></param>
        public frmVisuClient(Client unClient)
        {
            this.leClient = unClient; //on assigne le client passé en paramètre à notre attribut déclaré plus haut
            InitializeComponent();
            this.Size = new Size(370, 475); //on cache les contacts
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
        /*
        private void readable()
        {
            this.txtRaisonSociale.Enabled = false;
            this.txtIdClient.Enabled = false;
            this.txtTelephone.Enabled = false;
            this.cbxNature.Enabled = false;
            this.cbxTypeSociete.Enabled = false;
            this.txtAdresse.Enabled = false;
            this.txtCa.Enabled = false;
            this.txtEffectif.Enabled = false;
            this.txtCommentComm.Enabled = false;
        }

        private void writeable()
        {
            this.txtRaisonSociale.Enabled = true;
            this.txtIdClient.Enabled = true;
            this.txtTelephone.Enabled = true;
            this.cbxNature.Enabled = true;
            this.cbxTypeSociete.Enabled = true;
            this.txtAdresse.Enabled = true;
            this.txtCa.Enabled = true;
            this.txtEffectif.Enabled = true;
            this.txtCommentComm.Enabled = true;
        }*/

        private bool modifie()
        {
            try
            {
                this.leClient.IdClient = int.Parse(base.txtIdClient.Text.Trim());
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
        }

        private void btnAfficherContact_Click(object sender, EventArgs e)
        {
            if (btnAfficherContact.Text == "Afficher les contacts >>")
            {
                btnAfficherContact.Text = "Cacher les contacts";
                this.Size = new Size(790, 475);
                this.gbxAjoutContact.Enabled = true;
                this.gbxListeContact.Enabled = true;
                this.Show();
            }
            else
            {
                btnAfficherContact.Text = "Afficher les contacts >>";
                this.Size = new Size(370, 475);
                this.gbxAjoutContact.Enabled = false;
                this.gbxListeContact.Enabled = false;
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
        }

        private void btnValiderClient_Click(object sender, EventArgs e)
        {
            if (this.modifie())
            {

            }
        }

        private void frmVisuClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            Donnees.ArrayFrmClientOpened.Remove(leClient.IdClient);
        }
    }
}
