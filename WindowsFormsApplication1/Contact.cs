﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Contact
    {
        public static int nContact=1;

        private Int32 idContact;
        private String nomContact;
        private String prenomContact;
        private String telContact;
        private String fonctionContact;
        //private Int32 idClientParent;
        //private double totalHeuresContact;

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

        public int IdContact
        {
            get{ return idContact; }
            set  {  idContact = value; }
        }

        public string NomContact
        {
            get{  return nomContact; }
            set { nomContact = value; }
        }

        public string PrenomContact
        {
            get { return prenomContact;   }
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
