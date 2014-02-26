using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Objects
{
    class Fiches
    {
        public int ID_Fiche { get; set; }
        public int ID_Pro { get; set; }
        public int ID_Imm { get; set; }
        public string Asterix { get; set; }
        public string Commentaire1 { get; set; }
        public string Commentaire2 { get; set; }
        public string EnvoiCourrier { get; set; }
        public string CD_Fiche { get; set; }
        public string DM_Fiche { get; set; }
        public string Reponse { get; set; }
        public string ModifierPar { get; set; }
        private byte[] SSMA_TimeStamp { get; set; }

    }
}
