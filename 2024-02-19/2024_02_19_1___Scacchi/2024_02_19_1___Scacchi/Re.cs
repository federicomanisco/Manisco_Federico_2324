using ScacchiC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_02_19_1___Scacchi {
    public class Re : Pedina {
        public Re(string colore, int riga, int colonna, Scacchiera scacchiera) : base(colore, riga, colonna, scacchiera) {

        }

        public override string stampa() {
            return "R";
        }

        public override void mangia(int r, int c) {
            throw new NotImplementedException();
        }

        public override void trasforma(Pedina p) {
            throw new NotImplementedException();
        }

        public override void muovi(int nuovaRiga, int nuovaColonna) {
            base.muovi(nuovaRiga, nuovaColonna);
            int distanza = (Math.Abs(nuovaRiga - riga) + Math.Abs(nuovaColonna - colonna)) - 1;
            
            if (distanza > 1) {
                throw new ArgumentException("Mossa non valida");
            }

            scacchiera.rimuoviPedina(riga, colonna);
            riga = nuovaRiga;
            colonna = nuovaColonna;
            scacchiera.posizionaPedina(riga, colonna, this);
        }
    }
}
