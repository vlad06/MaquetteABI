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
                nouveauClient.IdClient = Client.nClient;
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
            if (isFieldsValid())
            {
                if (this.instancieClient())
                {
                    this.DialogResult = DialogResult.OK;
                }
            }            
        }

        private void btnAnnulerClient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Boolean isFieldsValid()
        {
            bool valid = true;
            if (!Outils.isRaisonSocialeValid(this.txtRaisonSociale.Text.Trim()))
            {
                errorProvider1.SetError(this.txtRaisonSociale, "Raison Sociale invalide !");
                valid= false;
            }
            else
            {
                errorProvider1.SetError(this.txtRaisonSociale, String.Empty);
            }
            if (this.cbxNature.Text == "")
            {
                errorProvider1.SetError(this.cbxNature, "Nature société requise !");
                valid= false;
            }
            else
            {
                errorProvider1.SetError(this.cbxNature, String.Empty);
            }
            if (this.cbxTypeSociete.Text == "")
            {
                errorProvider1.SetError(this.cbxTypeSociete, "Type société requis !");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(this.cbxTypeSociete, String.Empty);
            }
            if (this.cbxActivite.Text == "")
            {
                errorProvider1.SetError(this.cbxActivite, "Activité requise !");
            }
            else
            {
                errorProvider1.SetError(this.cbxActivite, String.Empty);
            }
            if (!Outils.isCaValid(this.txtCa.Text.Trim()))
            {
                errorProvider1.SetError(this.txtCa, "Chiffre d'affaire invalide !");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(this.txtCa, String.Empty);
            }
            if (!(Outils.isEffectifValid(this.txtEffectif.Text.Trim())))
            {
                errorProvider1.SetError(this.txtEffectif, "Effectif invalide !");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(this.txtEffectif, String.Empty);
            }
            if (!(Outils.isTelephoneValid(this.txtTelephone.Text.Trim())))
            {
                errorProvider1.SetError(this.txtTelephone, "Téléphone invalide !");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(this.txtTelephone, String.Empty);
            }
            if (this.txtAdresse.Text.Trim() == "")
            {
                errorProvider1.SetError(this.txtAdresse, "Adresse requise !");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(this.txtAdresse, String.Empty);
            }
            return valid;
        }

        private void frmAjoutClient_Activated(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

    }
}
