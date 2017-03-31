using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmAjoutContact : Form
    {
        public frmAjoutContact()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (this.instancieContact())
            {
                Contact.NContact += 1;
                this.DialogResult = DialogResult.OK;
            }
        }

        private bool instancieContact()
        {
            Contact nouveauContact = new Contact();
            try
            {
                nouveauContact.NumeroContact = int.Parse(txtNumeroContact.Text.Trim());
                nouveauContact.NomContact = txtNomContact.Text;
                nouveauContact.PrenomContact = txtPrenomContact.Text;
                nouveauContact.TelephoneContact = txtTelephoneContact.Text;
                nouveauContact.EmailContact = txtEmailContact.Text;
                nouveauContact.FonctionContact = txtFonctionContact.Text;
                nouveauContact.TotalHeuresContact = double.Parse(txtTotalHeures.Text.Trim());
                Donnees.ArrayContact.Add(nouveauContact);
                return true;
            }
            catch (Exception ex)
            {
                nouveauContact = null;
                MessageBox.Show("Erreur :\n" + ex.Message, "Ajout de client");
                return false;
            }

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
