using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Client
    {
        //********************************************************
        //***********************ATTRIBUTS************************
        //********************************************************
        public static int nClient;  //le nombre de clients crées

        private Int32 idClient;   //le numéro de client unique pour chaque client
        private String raisonSociale;   //raison sociale du client
        private String typeSociete;  //public ou privé
        private String activite;  //secteur d'activité du client (pour l'instant agro, industrie, ...)
        private String adresse;   //adresse du client
        private String telephone; //téléphone du client
        private String nature;    // principale, secondaire ou ancienne
        private Decimal ca;   //chiffre d'affaire du client
        private Int32 effectif; //nombre de salariés du client
        private String commentComm; //commentaire commercial concernant le projet

        //********************************************************
        //********************CONSTRUCTEURS***********************
        //********************************************************
        public Client(int idClient, string raisonSociale, string typeSociete, string activite, string adresse,
            string nature, string telephone, decimal ca, int effectif, string commentComm)
        {
            this.IdClient = idClient;
            this.RaisonSociale = raisonSociale;
            this.TypeSociete = typeSociete;
            this.Activite = activite;
            this.Adresse = adresse;
            this.Nature = nature;
            this.Telephone = telephone;
            this.Ca = ca;
            this.Effectif = effectif;
            this.CommentComm = commentComm;
        }
        /// <summary>
        /// constructeur de clients vide
        /// </summary>
        public Client()
        {

        }
        //********************************************************
        //******************GETTERS ET SETTERS********************
        //********************************************************
        public int IdClient
        {
            get { return idClient; }
            set { idClient = value; }
        }
        public string RaisonSociale
        {
            get { return raisonSociale.ToUpper(); }
            set
            {
                if (Outils.isMadeOfLettersAndNumbers(value))
                {
                    raisonSociale = value;
                }
                else
                {
                    throw new Exception(value.ToString() + "\n" + "n'est pas valide");
                }
            }
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
    }
}
