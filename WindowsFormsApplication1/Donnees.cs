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

        // Contient la liste de toutes les fenêtres clients ouverte, identifiée par l'idClient, propre à chaque client
        public static Dictionary<int, frmVisuClient> listFrmVisuClient = new Dictionary<int, frmVisuClient>();
    }
}
