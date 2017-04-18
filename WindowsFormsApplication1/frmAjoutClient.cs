using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmAjoutClient : WindowsFormsApplication1.frmClient
    {
        //********************************************************
        //************************CONSTRUCTEURS*******************
        //********************************************************
        public frmAjoutClient()
        {
            InitializeComponent();
            this.txtIdClient.Text = Outils.bestIdClient().ToString();
        }
        //********************************************************
        //************************METHODES************************
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
                nouveauClient.IdClient = Outils.bestIdClient();     //attribue une id client non utilisée
                nouveauClient.RaisonSociale = base.txtRaisonSociale.Text;
                nouveauClient.Nature = base.cbxNature.Text;
                nouveauClient.TypeSociete = base.cbxTypeSociete.Text;
                nouveauClient.Activite = base.cbxActivite.Text;
                nouveauClient.Telephone = base.txtTelephone.Text;
                nouveauClient.Adresse = base.txtAdresse.Text;
                if (base.txtCa.Text.Trim() == "") //si la txtbox CA n'a pas été renseignée
                {                                   //on l'initialise pour ne pas avoir d'erreur lors du parse
                    nouveauClient.Ca = 0;
                }
                else
                {
                    nouveauClient.Ca = decimal.Parse(base.txtCa.Text.Trim());
                }
                if (base.txtEffectif.Text.Trim() == "") //si la txtbox effectif n'a pas été renseignée
                {                                      //on l'initialise pour éviter d'avoir une erreur lors du parse
                    nouveauClient.Effectif = 1;     //initialise l'effectif à 1 pour eviter une division par zéro juste après
                }
                else
                {
                    nouveauClient.Effectif = int.Parse(base.txtEffectif.Text.Trim());
                }
                if(nouveauClient.Ca/nouveauClient.Effectif > 1000000)
                {
                    throw new Exception("Il y a un problème avec le chiffre d'affaire ou l'effectif saisi !");
                }
                nouveauClient.CommentComm = base.txtCommentComm.Text;

                TClient nouveauClientEF = new TClient();    //nouvel objet EntityFramework de type TClient

                nouveauClientEF.IdClient = nouveauClient.IdClient;
                nouveauClientEF.RaisonSociale = nouveauClient.RaisonSociale;
                nouveauClientEF.Nature = nouveauClient.Nature;
                nouveauClientEF.TypeSociete = nouveauClient.TypeSociete;
                nouveauClientEF.Activite = nouveauClient.Activite;
                nouveauClientEF.Telephone = nouveauClient.Telephone;
                nouveauClientEF.Adresse = nouveauClient.Adresse;
                nouveauClientEF.Ca = nouveauClient.Ca;
                nouveauClientEF.Effectif = nouveauClient.Effectif;
                nouveauClientEF.CommentComm = nouveauClient.CommentComm;
                //INSERTION EN DBCONTEXT
                Donnees.abiDb.TClient.Add(nouveauClientEF);
                //MISE A JOUR DE LA BDD
                Donnees.abiDb.SaveChanges();

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
            return valid;
        }
        //********************************************************
        //************************EVENTS**************************
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
    }
}
