using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmAjoutClient : WindowsFormsApplication1.frmClient
    {
        public frmAjoutClient()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (this.instancieClient())
            {
                Client.NClient += 1;
                this.DialogResult = DialogResult.OK;
            }
        }

        private bool instancieClient()
        {
            Client nouveauClient = new Client();
            try
            {
                nouveauClient.NumeroClient = int.Parse(base.txtNumeroClient.Text.Trim());
                nouveauClient.RaisonSociale = base.txtRaisonSociale.Text;
                nouveauClient.NatureClient = base.cbxNatureClient.Text;
                nouveauClient.TypeClient = base.cbxTypeClient.Text;
                nouveauClient.TelephoneClient = base.txtTelephoneClient.Text;
                nouveauClient.FaxClient = base.txtFaxClient.Text;
                nouveauClient.EmailClient = base.txtEmailClient.Text;
                nouveauClient.AdresseClient = base.txtAdresseClient.Text;
                nouveauClient.DomaineClient = base.txtDomaine.Text;
                nouveauClient.CaClient = decimal.Parse(base.txtCAClient.Text.Trim());
                nouveauClient.EffectifClient = int.Parse(base.txtEffectifClient.Text.Trim());
                nouveauClient.CommentComm = base.txtCommentaire.Text;
                Donnees.ArrayClient.Add(nouveauClient);
                return true;
            }
            catch(Exception ex)
            {
                nouveauClient = null;
                MessageBox.Show("Erreur :\n" + ex.Message, "Ajout de client");
                return false;
            }
            
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAjouterContacts_Click(object sender, EventArgs e)
        {
            frmAjoutContact frmAddCont = new frmAjoutContact();
            if (frmAddCont.ShowDialog() == DialogResult.OK)
            {
                frmGestionContact frmGestCont = new frmGestionContact();
            }
        }
    }
}
