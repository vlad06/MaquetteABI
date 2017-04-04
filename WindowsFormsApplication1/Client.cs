using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Client
    {

        public static int nClient=1;  //le nombre de clients crées

        private Int32 idClient;   //le numéro de client incrémenté pour chaque nouveau client crée
        private String raisonSociale;   //raison sociale du client
        private String typeSociete;  //public ou privé
        private String activite;  //secteur d'activité du client (pour l'instant agro, industrie, ...)
        private String adresse;   //adresse du client
        private String telephone; //téléphone du client
        private String nature;    // principale, secondaire ou ancienne
        private Decimal ca;   //chiffre d'affaire du client
        private Int32 effectif; //nombre de salariés du client
        private String commentComm; //commentaire commercial concernant le projet
        private List<Contact> listContact = new List<Contact>(); //liste de contact du client

        public Client(int idClient, string raisonSociale, string typeSociete, string activite, string adresse,
            string telephone, string nature, decimal ca, int effectif, string commentComm)
        {
            this.IdClient = idClient;
            this.RaisonSociale = raisonSociale;
            this.TypeSociete = typeSociete;
            this.Activite = activite;
            this.Adresse = adresse;
            this.Telephone = telephone;
            this.Nature = nature;
            this.Ca = ca;
            this.Effectif = effectif;
            this.CommentComm = commentComm;
        }
        public Client()
        {

        }
        public int IdClient
        {
            get { return idClient; }
            set { idClient = value; }
        }
        public string RaisonSociale
        {
            get { return raisonSociale; }
            set { raisonSociale = value;}
        }

        public string TypeSociete
        {
            get { return typeSociete;  }
            set { typeSociete = value; }
        }

        public string Activite
        {
            get { return activite; }
            set { activite = value; }
        }

        public string Adresse
        {
            get{ return adresse;  }
            set{  adresse = value; }
        }

        public string Telephone
        {
            get { return telephone; }
            set { telephone = value;  }
        }

        public string Nature
        {
            get { return nature;  }
            set { nature = value;}
        }

        public decimal Ca
        {
            get { return ca; }
            set {ca = value; }
        }

        public int Effectif
        {
            get { return effectif;}
            set { effectif = value; }
        }

        public string CommentComm
        {
            get {return commentComm;}
            set { commentComm = value;}
        }

        public List<Contact> ListContact
        {
            get { return listContact; }
            set {  listContact = value;}
        }

        public decimal RatioCaEffectif()
        {
            return (this.Ca / this.Effectif);
        }
    }
}
