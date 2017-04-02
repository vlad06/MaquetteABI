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
        private Client leClient;

        public frmVisuClient(Client unClient)
        {
            this.leClient = unClient;
            InitializeComponent();
        }

        private void frmDetailClient_Load(object sender, EventArgs e)
        {
            this.afficheClient(this.leClient);
            this.readable();
        }

        private void afficheClient(Client unClient)
        {
            this.txtRaisonSociale.Text = unClient.RaisonSociale;
            this.txtNumeroClient.Text = unClient.IdClient.ToString();
            this.txtTelephoneClient.Text = unClient.Telephone;
            this.cbxNatureClient.Text = unClient.Nature;
            //this.txtFaxClient.Text = unClient.FaxClient;
            this.cbxTypeClient.Text = unClient.TypeSociete;
            //this.txtEmailClient.Text = unClient.EmailClient;
            this.txtAdresseClient.Text = unClient.Adresse;
            this.txtDomaine.Text = unClient.Activite;
            this.txtCAClient.Text = unClient.Ca.ToString();
            this.txtEffectifClient.Text = unClient.Effectif.ToString();
            this.txtCommentaire.Text = unClient.CommentComm;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (btnDeverouiller.Text == "Dévérrouiller")
            {
                this.writeable();
                btnDeverouiller.Text = "Vérrouiller";
            }
            else
            {
                this.readable();
                btnDeverouiller.Text = "Dévérrouiller";
            }
        }

        private void readable()
        {
            this.txtRaisonSociale.Enabled = false;
            this.txtNumeroClient.Enabled = false;
            this.txtTelephoneClient.Enabled = false;
            this.cbxNatureClient.Enabled = false;
            //this.txtFaxClient.Enabled = false;
            this.cbxTypeClient.Enabled = false;
            //this.txtEmailClient.Enabled = false;
            this.txtAdresseClient.Enabled = false;
            this.txtDomaine.Enabled = false;
            this.txtCAClient.Enabled = false;
            this.txtEffectifClient.Enabled = false;
            this.txtCommentaire.Enabled = false;
        }

        private void writeable()
        {
            this.txtRaisonSociale.Enabled = true;
            this.txtNumeroClient.Enabled = true;
            this.txtTelephoneClient.Enabled = true;
            this.cbxNatureClient.Enabled = true;
            //this.txtFaxClient.Enabled = true;
            this.cbxTypeClient.Enabled = true;
            //this.txtEmailClient.Enabled = true;
            this.txtAdresseClient.Enabled = true;
            this.txtDomaine.Enabled = true;
            this.txtCAClient.Enabled = true;
            this.txtEffectifClient.Enabled = true;
            this.txtCommentaire.Enabled = true;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (this.modifie())
            {
                this.DialogResult = DialogResult.OK;//fermeture du formDetailClient par clic sur le bouton valider avec modifications possibles
                this.Close();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.afficheClient(leClient);//on réinitialise
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool modifie()
        {
            try
            {
                this.leClient.IdClient = int.Parse(base.txtNumeroClient.Text.Trim());
                this.leClient.RaisonSociale = base.txtRaisonSociale.Text;
                this.leClient.Nature = base.cbxNatureClient.Text;
                this.leClient.TypeSociete = base.cbxTypeClient.Text;
                this.leClient.Telephone = base.txtTelephoneClient.Text;
                this.leClient.Adresse= base.txtAdresseClient.Text;
                this.leClient.Activite = base.txtDomaine.Text;
                this.leClient.Ca = decimal.Parse(base.txtCAClient.Text.Trim());
                this.leClient.Effectif = int.Parse(base.txtEffectifClient.Text.Trim());
                this.leClient.CommentComm = base.txtCommentaire.Text;
                return true;
            }
            catch (Exception ex)
            {
                this.leClient = null;
                MessageBox.Show("Erreur :\n" + ex.Message, "Modification de client");
                return false;
            }
        }

        private void btnVoirContact_Click(object sender, EventArgs e)
        {
            frmGestionContact frmCont = new frmGestionContact();
           // if (frmCont.grdContact.CurrentRow != null)
            //{
                int iContact;
                iContact = frmCont.grdContact.CurrentRow.Index;//récupère l'indice du client cliqué dans la datagrid
                Contact leContact = leClient.ArrayContact[iContact];
                frmCont.Show();
            //} else
           // {
             //   MessageBox.Show("Ce client n'a pas de contacts associés !", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
           // }
        }
    }
}
