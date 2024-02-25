using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScacchiC
{
    public class Pedone : Pedina
    {
        

        public Pedone(Colore colore, int riga, int colonna, Scacchiera scacchiera) : base(colore, riga, colonna, scacchiera)
        {
            primaMossa = true;
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

            bool movimentoDiagonaleValido = false;
            int diffR = Math.Abs(nuovaRiga - riga);
            int diffC = nuovaColonna - colonna;
            if (diffC != 0)
            {
                if (!scacchiera.pedinaNelMezzo(riga, colonna, nuovaRiga, nuovaColonna) && !(scacchiera.getPedina(nuovaRiga, nuovaColonna).ColorePedina != ColorePedina)) {
                    throw new ArgumentException("Mossa non valida");
                }
                movimentoDiagonaleValido = true;
            }
            if (!primaMossa && diffR == 2)
            {
                throw new ArgumentException("Mossa non valida");
            }
            if (diffR == 0 || diffR > 2)
            {
                throw new ArgumentException("Mossa non valida");
            }
            if (colore == Pedina.Colore.Black)
            {
               if (nuovaRiga < riga)
                {
                    throw new ArgumentException("Mossa non valida");
                }
            }
            else
            {
                if (nuovaRiga > riga)
                {
                    throw new ArgumentException("Mossa non valida");
                }
            }
            //non posso muovere oltre una casella (in tutte le direzioni)
            if ((Math.Abs(nuovaRiga - riga) > 1 || Math.Abs(nuovaColonna - colonna) > 1) && !primaMossa)
            {
                throw new ArgumentException("Mossa non valida");
            }

            if (diffC > 1) {
                throw new ArgumentException("Mossa non valida.");
            }

            if (primaMossa) {
                if (scacchiera.pedinaNelMezzo(riga, colonna, nuovaRiga, nuovaColonna) && !movimentoDiagonaleValido) {
                    throw new ArgumentException("Pedina nel mezzo.");
                }
            }


            //TODO - manca arrocco

            //non e piu la prima mossa
            primaMossa = false;

            //muovo
            scacchiera.rimuoviPedina(riga, colonna);
            riga = nuovaRiga;
            colonna = nuovaColonna;
            scacchiera.posizionaPedina(riga, colonna, this);

        }

        public override string stampa()
        {
            return "♟";
        }
    }
}
