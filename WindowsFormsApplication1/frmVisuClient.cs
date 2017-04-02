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

        private void afficheClient(Client unClient)
        {
            this.txtRaisonSociale.Text = unClient.RaisonSociale;
            this.txtIdClient.Text = unClient.IdClient.ToString();
            this.txtTelephone.Text = unClient.Telephone;
            this.cbxNature.Text = unClient.Nature;
            this.cbxTypeSociete.Text = unClient.TypeSociete;
            this.txtAdresse.Text = unClient.Adresse;
            this.txtActivite.Text = unClient.Activite;
            this.txtCa.Text = unClient.Ca.ToString();
            this.txtEffectif.Text = unClient.Effectif.ToString();
            this.txtCommentComm.Text = unClient.CommentComm;
        }

        private void readable()
        {
            this.txtRaisonSociale.Enabled = false;
            this.txtIdClient.Enabled = false;
            this.txtTelephone.Enabled = false;
            this.cbxNature.Enabled = false;
            this.cbxTypeSociete.Enabled = false;
            this.txtAdresse.Enabled = false;
            this.txtActivite.Enabled = false;
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
            this.txtActivite.Enabled = true;
            this.txtCa.Enabled = true;
            this.txtEffectif.Enabled = true;
            this.txtCommentComm.Enabled = true;
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
                this.leClient.IdClient = int.Parse(base.txtIdClient.Text.Trim());
                this.leClient.RaisonSociale = base.txtRaisonSociale.Text;
                this.leClient.Nature = base.cbxNature.Text;
                this.leClient.TypeSociete = base.cbxTypeSociete.Text;
                this.leClient.Telephone = base.txtTelephone.Text;
                this.leClient.Adresse= base.txtAdresse.Text;
                this.leClient.Activite = base.txtActivite.Text;
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
    }
}
