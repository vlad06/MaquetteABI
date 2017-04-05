using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Donnees
    {
        public static List<Client> listClient = new List<Client>();
        public static Dictionary<int, frmVisuClient> listFrmVisuClient = new Dictionary<int, frmVisuClient>();//associe un form à un id client
        public static Dictionary<int, Contact> listContact = new Dictionary<int, Contact>();//associe un contact à son id
    }
}
