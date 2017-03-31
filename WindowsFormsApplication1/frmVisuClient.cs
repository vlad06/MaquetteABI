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
            this.txtNumeroClient.Text = unClient.NumeroClient.ToString();
            this.txtTelephoneClient.Text = unClient.TelephoneClient;
            this.cbxNatureClient.Text = unClient.NatureClient;
            this.txtFaxClient.Text = unClient.FaxClient;
            this.cbxTypeClient.Text = unClient.TypeClient;
            this.txtEmailClient.Text = unClient.EmailClient;
            this.txtAdresseClient.Text = unClient.AdresseClient;
            this.txtDomaine.Text = unClient.DomaineClient;
            this.txtCAClient.Text = unClient.CaClient.ToString();
            this.txtEffectifClient.Text = unClient.EffectifClient.ToString();
            this.txtCommentaire.Text = unClient.CommentComm;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (btnDeverouiller.Text == "Dévérouiller")
            {
                this.writeable();
                btnDeverouiller.Text = "Vérouiller";
            }
            else
            {
                this.readable();
                btnDeverouiller.Text = "Dévérouiller";
            }
        }

        private void readable()
        {
            this.txtRaisonSociale.Enabled = false;
            this.txtNumeroClient.Enabled = false;
            this.txtTelephoneClient.Enabled = false;
            this.cbxNatureClient.Enabled = false;
            this.txtFaxClient.Enabled = false;
            this.cbxTypeClient.Enabled = false;
            this.txtEmailClient.Enabled = false;
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
            this.txtFaxClient.Enabled = true;
            this.cbxTypeClient.Enabled = true;
            this.txtEmailClient.Enabled = true;
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
                this.leClient.NumeroClient = int.Parse(base.txtNumeroClient.Text.Trim());
                this.leClient.RaisonSociale = base.txtRaisonSociale.Text;
                this.leClient.NatureClient = base.cbxNatureClient.Text;
                this.leClient.TypeClient = base.cbxTypeClient.Text;
                this.leClient.TelephoneClient = base.txtTelephoneClient.Text;
                this.leClient.FaxClient = base.txtFaxClient.Text;
                this.leClient.EmailClient = base.txtEmailClient.Text;
                this.leClient.AdresseClient = base.txtAdresseClient.Text;
                this.leClient.DomaineClient = base.txtDomaine.Text;
                this.leClient.CaClient = decimal.Parse(base.txtCAClient.Text.Trim());
                this.leClient.EffectifClient = int.Parse(base.txtEffectifClient.Text.Trim());
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
            if (frmCont.grdContact.CurrentRow != null)
            {
                int iContact;
                iContact = frmCont.grdContact.CurrentRow.Index;//récupère l'indice du client cliqué dans la datagrid
                Contact leContact = Donnees.ArrayContact[iContact];
                frmCont.Show();
            } else
            {
                MessageBox.Show("Ce client n'a pas de contacts associés !", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
