using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Client
    {
        public static int NClient;

        private int numeroClient;
        public int NumeroClient { get; set; }

        private string raisonSociale;
        public string RaisonSociale
        {
            get { return this.raisonSociale; }
            set { this.raisonSociale = value.ToUpper(); }
        }

        private string typeClient;
        public string TypeClient { get; set; }

        private string activiteClient;
        public string ActiviteClient { get; set; }

        private string adresseClient;
        public string AdresseClient { get; set; }

        private string telephoneClient;
        public string TelephoneClient { get; set; }

        private string faxClient;
        public string FaxClient { get; set; }

        private string emailClient;
        public string EmailClient { get; set; }

        private string natureClient;
        public string NatureClient { get; set; }

        private string domaineClient;
        public string DomaineClient
        {
            get { return this.domaineClient; }
            set { this.domaineClient = value; }
        }

        private decimal caClient;
        public decimal CAClient{ get; set; }

        private int effectifClient;
        public int EffectifClient { get; set; }

        private string commentComm;
        public string CommentComm { get; set; }

            
    }
}
