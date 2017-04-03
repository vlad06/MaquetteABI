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
            //this.Size = new Size(370, 475);
        }

        private bool isIdUnique(int idClient)
        {
            foreach (Client cl in Donnees.listClient)
            {
                if (idClient == cl.IdClient && idClient != 0)
                {
                    return false;
                }
            }
            return true;
        }
        private bool instancieClient()
        {
            Client nouveauClient = new Client();
            try
            {
                /*
                if (!isIdUnique(int.Parse(base.txtIdClient.Text.Trim())))
                {
                    MessageBox.Show(new Form { TopMost = true }, "l'ID du client doit être unique !!", "Attention", MessageBoxButtons.OK);
                }
                else
                {
                    nouveauClient.IdClient = int.Parse(base.txtIdClient.Text.Trim());
                }
                */
                nouveauClient.IdClient = int.Parse(base.txtIdClient.Text.Trim());
                nouveauClient.RaisonSociale = base.txtRaisonSociale.Text;
                nouveauClient.Nature = base.cbxNature.Text;
                nouveauClient.TypeSociete = base.cbxTypeSociete.Text;
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

       /* private void btnVoirContact_Click(object sender, EventArgs e)
        {
            if(btnVoirContacts.Text== "Voir les contacts >>")
            {
                btnVoirContacts.Text = "Cacher les contacts";
                this.Size = new Size(790, 475);
                this.gbxAjoutContact.Enabled = true;
                this.gbxListeContact.Enabled = true;
                this.Show();
            }
            else
            {
                btnVoirContacts.Text = "Voir les contacts >>";
                this.Size = new Size(370, 475);
                this.gbxAjoutContact.Enabled = false;
                this.gbxListeContact.Enabled = false;
                this.Show();
            }
        }*/

        private void btnValiderClient_Click(object sender, EventArgs e)
        {
            if (!isIdUnique(int.Parse(base.txtIdClient.Text.Trim())))
            {
                MessageBox.Show(new Form { TopMost = true }, "l'ID du client doit être unique !!", "Attention", MessageBoxButtons.OK);
            }
            else if (this.instancieClient())
            {
                Client.nClient++;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnAnnulerClient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouterContact_Click(object sender, EventArgs e)
        {

        }
    }
}
