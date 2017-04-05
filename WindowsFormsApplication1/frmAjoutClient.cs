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
            this.txtIdClient.Text = Client.nClient.ToString();
            this.txtIdClient.Enabled = false;
        }

        private bool instancieClient()
        {
            Client nouveauClient = new Client();
            try
            {
                nouveauClient.IdClient = Client.nClient;//int.Parse(base.txtIdClient.Text.Trim());
                nouveauClient.RaisonSociale = base.txtRaisonSociale.Text;
                nouveauClient.Nature = base.cbxNature.Text;
                nouveauClient.TypeSociete = base.cbxTypeSociete.Text;
                nouveauClient.Activite = base.cbxActivite.Text;
                nouveauClient.Telephone = base.txtTelephone.Text;
                nouveauClient.Adresse = base.txtAdresse.Text;
                nouveauClient.Ca = decimal.Parse(base.txtCa.Text.Trim());
                nouveauClient.Effectif = int.Parse(base.txtEffectif.Text.Trim());
                nouveauClient.CommentComm = base.txtCommentComm.Text;
                Donnees.listClient.Add(nouveauClient);
                return true;
            }
            catch(Exception ex)
            {
                nouveauClient = null;
                MessageBox.Show("Erreur :\n" + ex.Message, "Ajout de client");
                return false;
            }
        }

        private void btnValiderClient_Click(object sender, EventArgs e)
        {
            if (isRaisonSocialeValid())
            {
                errorProvider1.SetError(this.txtRaisonSociale, "Raison Sociale required.");
            }
            else
            {
                errorProvider1.SetError(this.txtRaisonSociale, String.Empty);
            }
            if (this.instancieClient())
                {
                    this.DialogResult = DialogResult.OK;
                }
            
        }

        private void btnAnnulerClient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Boolean isRaisonSocialeValid()
        {
            if (String.IsNullOrWhiteSpace(this.txtRaisonSociale.Text))
            {
                return true;
            }
            return false;
        }

        private void frmAjoutClient_Activated(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private bool testFields()
        {
            return false;
        }
    }
}
