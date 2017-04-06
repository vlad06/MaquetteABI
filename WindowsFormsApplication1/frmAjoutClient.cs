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
        //********************************************************
        //********************LES CONSTRUCTEURS*******************
        //********************************************************
        public frmAjoutClient()
        {
            InitializeComponent();
            this.txtIdClient.Text = Client.nClient.ToString();//affiche le numéro de client dans sa txtbox associée
            this.txtIdClient.ReadOnly = true;   //passe la textbox en lecture seule pour empêcher toute manipulation
        }
        //********************************************************
        //********************LES METHODES************************
        //********************************************************
        /// <summary>
        /// retourne true si le Client nouveauClient à pu être instancié via les champs associés et false sinon
        /// le client instancié est rajouté à la liste de clients
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// retourne true si tous les champs sont renseignés "correctement" et false sinon
        /// </summary>
        /// <returns></returns>
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
            if (this.cbxNature.Text == "")          //vérifie uniquement si le champ est vide
            {
                errorProvider1.SetError(this.cbxNature, "Nature société requise !");
                valid= false;
            }
            else
            {
                errorProvider1.SetError(this.cbxNature, String.Empty);
            }
            if (this.cbxTypeSociete.Text == "")         //vérifie uniquement si le champ est vide
            {
                errorProvider1.SetError(this.cbxTypeSociete, "Type société requis !");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(this.cbxTypeSociete, String.Empty);
            }
            if (this.cbxActivite.Text == "")            //vérifie uniquement si le champ est vide
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
        //********************************************************
        //********************LES EVENTS**************************
        //********************************************************
        /// <summary>
        /// valide le client si possible, indique les champs à corriger si la validation ne fonctionne pas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValiderClient_Click(object sender, EventArgs e)
        {
            if (isFieldsValid())    //si tous les champs sont remplis "correctement"
            {
                if (this.instancieClient()) //si le client peut-être instancié sans erreurs
                {
                    this.DialogResult = DialogResult.OK; //on passe au parent un DialogResult.OK
                }
            }
        }
        /// <summary>
        /// un clic sur le bouton annuler ferme la form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulerClient_Click(object sender, EventArgs e)
        {
            this.Close();   //on ferme cette instance de form
        }
        private void frmAjoutClient_Activated(object sender, EventArgs e)
        {
            this.TopMost = true;    //dès qu'elle est activée, on passe cette form au premier plan
        }

        //Ici il s'agit d'un test pour faire apparaitre les errors provider à chaque appui sur une touche du clavier
        //à peut-être implémenter par la suite

        //private void txtRaisonSociale_TextChanged(object sender, EventArgs e)
        //{       
        //    if (!Outils.isRaisonSocialeValid(this.txtRaisonSociale.Text.Trim()))
        //    {
        //        errorProvider1.SetError(this.txtRaisonSociale, "Raison Sociale invalide !");
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(this.txtRaisonSociale, String.Empty);
        //    }
        //}
        
    }
}
