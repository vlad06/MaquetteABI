using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Donnees
    {
        public static ABIdatabaseEntities abiDb = new ABIdatabaseEntities();
        /// <summary>
        /// Contient la liste de toutes les fenêtres clients ouverte, identifiée par l'idClient, propre à chaque client
        /// </summary>
        public static Dictionary<int, frmVisuClient> listFrmVisuClient = new Dictionary<int, frmVisuClient>();//associe un form à un id client
                                                                                                            //pour permettre la gestion de plusieurs fenêtres
                                                                                                            //client en même temps

        /// <summary>
        ///associe un contact à son id (pas utilisé actuellement)
        ///serait à remplir en ajoutant le contact fraichement initialisé quelque-soit son client associé, les Ids de contact étant unique
        ///pourrait être utilisé afin d'obtenir une datagrid listant tous les contacts sans avoir à les récupérer en imbricant des boucles foreach
        /// </summary>
        public static Dictionary<int, Contact> listContact = new Dictionary<int, Contact>();
    }
}
