using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScacchiC
{
    public class Cavallo : Pedina
    {

        public Cavallo(string colore, int riga, int colonna, Scacchiera scacchiera) : base(colore, riga, colonna, scacchiera)
        {

        }

        public override void mangia(int r, int c)
        {
            throw new NotImplementedException();
        }

        public override void trasforma(Pedina p)
        {
            throw new NotImplementedException();
        }

        public override void muovi(int nuovaRiga, int nuovaColonna)
        {
            base.muovi(nuovaRiga, nuovaColonna);
            int diffX = Math.Abs(nuovaRiga - riga);
            int diffY = Math.Abs(nuovaColonna - colonna);
            if (diffX == 0 || diffY == 0) {
                throw new ArgumentException("Mossa non valida");
            }
            if (diffX > 2 || diffY > 2)
            {
                throw new ArgumentException("Mossa non valida");
            }
            if (
                (diffX == 2 && diffY !=1 || diffX ==1 && diffY !=2) &&
                (diffY == 2 && diffX != 1 || diffY == 1 && diffX != 2)
            ){
                throw new ArgumentException("Mossa non valida");
            }
            scacchiera.rimuoviPedina(riga, colonna);
            riga = nuovaRiga;
            colonna = nuovaColonna;
            scacchiera.posizionaPedina(riga, colonna, this);

        }

        public override string stampa()
        {
            return "c";
        }

    }
}
