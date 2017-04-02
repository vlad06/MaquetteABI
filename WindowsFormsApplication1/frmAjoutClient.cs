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
            btnSupprimerContact.Enabled = false;
            this.Size = new Size(370, 475);
        }

        private bool instancieClient()
        {
            Client nouveauClient = new Client();
            try
            {
                nouveauClient.IdClient = int.Parse(base.txtIdClient.Text.Trim());
                nouveauClient.RaisonSociale = base.txtRaisonSociale.Text;
                nouveauClient.Nature = base.cbxNature.Text;
                nouveauClient.TypeSociete = base.cbxTypeSociete.Text;
                nouveauClient.Telephone = base.txtTelephone.Text;
                nouveauClient.Adresse = base.txtAdresse.Text;
                nouveauClient.Ca = decimal.Parse(base.txtCa.Text.Trim());
                nouveauClient.Effectif = int.Parse(base.txtEffectif.Text.Trim());
                nouveauClient.CommentComm = base.txtCommentComm.Text;
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

        private void btnAjouterContact_Click(object sender, EventArgs e)
        {
            if(btnAjouterContact.Text== "Ajouter un contact >>")
            {
                btnAjouterContact.Text = "Cacher les contacts";
                this.Size = new Size(790, 475);
                this.gbxAjoutContact.Enabled = true;
                this.gbxListeContact.Enabled = true;
                this.Show();
            }
            else
            {
                btnAjouterContact.Text = "Ajouter un contact >>";
                this.Size = new Size(370, 475);
                this.gbxAjoutContact.Enabled = false;
                this.gbxListeContact.Enabled = false;
                this.Show();
            }
        }

        private void btnValiderClient_Click(object sender, EventArgs e)
        {
            if (this.instancieClient())
            {
                Client.nClient++;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnAnnulerClient_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
