using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Client
    {

        public static int nClient;

        private int numeroClient;
        private string raisonSociale;
        private string typeClient;
        private string activiteClient;
        private string adresseClient;
        private string telephoneClient;
        private string faxClient;
        private string emailClient;
        private string natureClient;
        private string domaineClient;
        private decimal caClient;
        private int effectifClient;
        private string commentComm;

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


        public int NumeroClient
        {
            get  { return numeroClient; }
            set { numeroClient = value; }
        }

        public string RaisonSociale
        {
            get {return raisonSociale; }
            set { raisonSociale = value.Trim().ToUpper(); }
        }

        public string TypeClient
        {
            get {return typeClient; }
            set { typeClient = value;}
        }

        public string ActiviteClient
        {
            get {return activiteClient;}
            set{ activiteClient = value; }
        }

        public string AdresseClient
        {
            get { return adresseClient; }
            set{ adresseClient = value; }
        }

        public string TelephoneClient
        {
            get { return telephoneClient;}
            set { telephoneClient = value; }
        }

        public string FaxClient
        {
            get { return faxClient; }
            set { faxClient = value;}
        }

        public string EmailClient
        {
            get { return emailClient; }
            set { emailClient = value; }
        }

        public string NatureClient
        {
            get { return natureClient; }
            set { natureClient = value; }
        }

        public string DomaineClient
        {
            get{ return domaineClient; }

            set { domaineClient = value; }
        }

        public decimal CaClient
        {
            get { return caClient; }
            set { caClient = value; }
        }

        public int EffectifClient
        {
            get { return effectifClient; }
            set { effectifClient = value; }
        }

        public string CommentComm
        {
            get { return commentComm;  }
            set { commentComm = value; }
        }

        public decimal RatioCaEffectif()
        {
            return (this.caClient / this.effectifClient);
        }

        public static int NClient
        {
            get { return nClient; }
        }
    }
}
