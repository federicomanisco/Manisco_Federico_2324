using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_04_24_Verifica {
    public class Salvataggio {
        public DateTime OraInizio { get; set; }
        public DateTime OraFine { get; set; }
        public int Gruppo { get; set; }
        public (int, int)[] Domande { get; set; }
        public (int, int) Risposte { get; set; }

        public Salvataggio(DateTime oraInizio, DateTime oraFine, int gruppo, (int, int)[] domande, (int, int) risposte) {
            OraInizio = oraInizio;
            OraFine = oraFine;
            Gruppo = gruppo;
            Domande = domande;
            Risposte = risposte;
        }

        public override string ToString() {
            return $"Data Inizio: {OraInizio} -- Data Fine: {OraFine} -- Gruppo: {Gruppo} -- Domande: {Domande} -- Risposte: {Risposte}";
        }
    }
}
