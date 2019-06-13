using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TK_dnevnik
{
    public class Match
    {
        public int idMeca { get; set; }
        public string Rezultat { get; set; }
        public Boolean Finale { get; set; }
        public int dioTurnira { get; set; }
        public int idTurnira { get; set; }
        public int idPobjednika { get; set; }
        public int idGubitnika { get; set; }

        public Match() { }
        
        public int izracunajBodove()
        {
            //za gubitnika idu bodovi, te za pobjednika ako je finale
            return 0;
        }
    }

    public class Tournament
    {
        public int idTurnira { get; set; }
        public int UkupniBrBodova { get; set; }
        public string NazivTurnira { get; set; }
        public string DatumTurnira { get; set; }
        public Match[] matchesC { get; set; }

        public Tournament() { }
    }
}
