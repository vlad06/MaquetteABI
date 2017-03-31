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
    public partial class frmGestionContact : Form
    {
        public frmGestionContact()
        {
            InitializeComponent();
        }

        private void afficheContacts()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ID Contact", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Nom", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Prénom", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Telephone", typeof(System.String)));
            dt.Columns.Add(new DataColumn("E-mail", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Fonction", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Total heure effectuées", typeof(System.Double)));

            DataRow dr;
            for (int i = 0; i < Donnees.ArrayContact.Count; i++)
            {
                dr = dt.NewRow();
                dr[0] = Donnees.ArrayContact[i].NumeroContact;
                dr[1] = Donnees.ArrayContact[i].NomContact;
                dr[2] = Donnees.ArrayContact[i].PrenomContact;
                dr[3] = Donnees.ArrayContact[i].TelephoneContact;
                dr[4] = Donnees.ArrayContact[i].EmailContact;
                dr[5] = Donnees.ArrayContact[i].FonctionContact;
                dr[6] = Donnees.ArrayContact[i].TotalHeuresContact;
                dt.Rows.Add(dr);
            }
            this.grdContact.DataSource = dt;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGestionContact_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ID Contact", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Nom", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Prénom", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Telephone", typeof(System.String)));
            dt.Columns.Add(new DataColumn("E-mail", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Fonction", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Total heure effectuées", typeof(System.Double)));
            this.grdContact.DataSource = dt;
        }

        private void btnAjouterContact_Click(object sender, EventArgs e)
        {
            frmAjoutContact frmAddCont = new frmAjoutContact();
            if (frmAddCont.ShowDialog() == DialogResult.OK)
            {
                this.afficheContacts();
            }
            

        }
    }
}
