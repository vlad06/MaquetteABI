using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Contact
    {
        public static int nContact;

        private int numeroContact;
        private string nomContact;
        private string prenomContact;
        private string telephoneContact;
        private string emailContact;
        private string fonctionContact;
        private double totalHeuresContact;

        public Contact(int numeroContact, string nomContact, string prenomContact, string telephoneContact, string emailContact, string fonctionContact, double totalHeuresContact)
        {
            this.NumeroContact = numeroContact;
            this.NomContact = nomContact;
            this.PrenomContact = prenomContact;
            this.TelephoneContact = telephoneContact;
            this.EmailContact = emailContact;
            this.FonctionContact = fonctionContact;
            this.TotalHeuresContact = totalHeuresContact;
        }

        public Contact()
        {

        }

        public int NumeroContact
        {
            get { return numeroContact; }
            set { numeroContact = value;}
        }

        public string NomContact
        {
            get{ return nomContact;}
            set{nomContact = value.Trim().ToUpper();}
        }

        public string PrenomContact
        {
            get{ return prenomContact;}
            set { prenomContact = value.Trim().ToLower();}
        }

        public string TelephoneContact
        {
            get { return telephoneContact; }
            set { telephoneContact = value;}
        }

        public string EmailContact
        {
            get{ return emailContact;}
            set { emailContact = value;}
        }

        public string FonctionContact
        {
            get{return fonctionContact;}
            set { fonctionContact = value;}
        }

        public double TotalHeuresContact
        {
            get {return totalHeuresContact; }
            set { totalHeuresContact = value; }
        }

        public static int NContact
        {
            get { return nContact; }
        }

    }
}
