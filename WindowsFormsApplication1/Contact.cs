using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Contact
    {
        public static int NContact;

        private int numeroContact;
        public int NumeroContact
        {
            get { return this.numeroContact; }
            set { this.numeroContact = value; }
        }

        private string nomContact;
        public string NomContact
        {
            get { return this.nomContact; }
            set { this.nomContact = value.Trim().ToUpper(); }
        }

        private string prenomContact;
        public string PrenomContact
        {
            get { return this.prenomContact; }
            set { this.prenomContact = value.Trim().ToLower(); }
        }

        private string telephoneContact;
        public string TelephoneContact
        {
            get { return this.telephoneContact; }
            set { this.telephoneContact = value; }
        }

        private string fonctionContact;
        public string FonctionContact
        {
            get { return this.fonctionContact; }
            set { this.fonctionContact = value; }
        }

        private double totalHeureContact;
        public double TotalHeureContact
        {
            get { return this.totalHeureContact; }
            set { this.totalHeureContact = value; }
        }
    }
}
