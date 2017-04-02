using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Client
    {

        public static int nClient;  //le nombre de client crée

        private Int32 idClient;   //le numéro de client personnalisable par l'utilisateur
        private String raisonSociale;   //raison sociale du client
        private String typeSociete;  //public ou privé
        private String activite;  //secteur d'activité du client (pour l'instant agro, industrie, ...)
        private String adresse;   //adresse du client
        private String telephone; //téléphone du client
        private String nature;    // principale, secondaire ou ancienne
        private Decimal ca;   //chiffre d'affaire du client
        private Int32 effectif; //nombre de salariés du client
        private String commentComm; //commentaire commercial concernant le projet
        private List<Contact> arrayContact = new List<Contact>(); //liste de contact du client

        /*
                public Client(int numeroClient, string raisonSociale, string typeClient, string activiteClient, string adresseClient, string telephoneClient, string faxClient, string emailClient, string natureClient, string domaineClient, decimal caClient, int effectifClient, string commentComm)
                {
                    this.numeroClient = numeroClient;
                    this.raisonSociale = raisonSociale;
                    this.typeClient = typeClient;
                    this.activiteClient = activiteClient;
                    this.adresseClient = adresseClient;
                    this.telephoneClient = telephoneClient;
                    this.faxClient = faxClient;
                    this.emailClient = emailClient;
                    this.natureClient = natureClient;
                    this.domaineClient = domaineClient;
                    this.caClient = caClient;
                    this.effectifClient = effectifClient;
                    this.commentComm = commentComm;
                }
                public Client()
                {
                    this.numeroClient = 0;
                    this.raisonSociale = "";
                    this.typeClient = "";
                    this.activiteClient = "";
                    this.adresseClient = "";
                    this.telephoneClient = "";
                    this.faxClient = "";
                    this.emailClient = "";
                    this.natureClient = "";
                    this.domaineClient = "";
                    this.caClient = 0;
                    this.effectifClient = 0;
                    this.commentComm = "";
                }*/

        public static int NClient
        {
            get { return nClient; }
        }
        public int IdClient
        {
            get { return idClient; }

            set { idClient = value;}
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

        public List<Contact> ArrayContact
        {
            get {  return arrayContact;  }
            set { arrayContact = value; }
        }

        public decimal RatioCaEffectif()
        {
            return (this.Ca / this.Effectif);
        }
    }
}
