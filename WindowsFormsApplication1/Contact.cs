using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Contact
    {
        //********************************************************
        //***********************LES ATTRIBUTS********************
        //********************************************************
        public static int nContact;

        private Int32 idContact;
        private String nomContact;
        private String prenomContact;
        private String telContact;
        private String fonctionContact;
        //private Int32 idClientParent;
        //private double totalHeuresContact;

        //********************************************************
        //********************LES CONSTRUCTEURS*******************
        //********************************************************
        public Contact()
        {

        }

        public Contact(int idContact, string nomContact, string prenomContact, string telContact, string fonctionContact)
        {
            this.IdContact = idContact;
            this.NomContact = nomContact;
            this.PrenomContact = prenomContact;
            this.TelContact = telContact;
            this.FonctionContact = fonctionContact;
        }
        //********************************************************
        //****************LES GETTERS et SETTERS******************
        //********************************************************
        public int IdContact
        {
            get{ return idContact; }
            set  {  idContact = value; }
        }

        public string NomContact
        {
            get{  return nomContact.ToUpper(); }
            set { nomContact = value; }
        }

        public string PrenomContact
        {
            get { return prenomContact.ToLower();   }
            set { prenomContact = value;}
        }

        public string TelContact
        {
            get {  return telContact;}
            set{  telContact = value;}
        }

        public string FonctionContact
        {
            get{ return fonctionContact; }
            set {fonctionContact = value;}
        }
    }
}
