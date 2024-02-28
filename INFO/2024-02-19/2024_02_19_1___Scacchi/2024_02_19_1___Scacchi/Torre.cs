using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScacchiC
{
    public class Torre : Pedina
    {
        public Torre(string colore, int riga, int colonna, Scacchiera scacchiera) : base(colore, riga, colonna, scacchiera)
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

            if (nuovaRiga != riga && nuovaColonna != colonna) {
                throw new ArgumentException("Mossa non valida");
            }
            if (nuovaColonna != colonna)
            {
                if (nuovaColonna>colonna)
                {
                    for (int i = colonna+1; i <= nuovaColonna; i++) {
                        if (scacchiera.getPedina(riga,i) != null)
                        {
                            throw new ArgumentException("Pedina nel mezzo");
                        }
                    }
                }
                if (nuovaColonna < colonna)
                {
                    for (int i = colonna -1; i >= nuovaColonna; i--)
                    {
                        if (scacchiera.getPedina(riga, i) != null)
                        {
                            throw new ArgumentException("Pedina nel mezzo");
                        }
                    }
                }
            }
            if (nuovaRiga != riga)
            {
                if (nuovaRiga > riga)
                {
                    for (int i = riga + 1; i <= nuovaRiga; i++)
                    {
                        if (scacchiera.getPedina(i, colonna) != null)
                        {
                            throw new ArgumentException("Pedina nel mezzo");
                        }
                    }
                }
                if (nuovaRiga < riga)
                {
                    for (int i = riga - 1; i >= nuovaRiga; i--)
                    {
                        if (scacchiera.getPedina(i, colonna) != null)
                        {
                            throw new ArgumentException("Pedina nel mezzo");
                        }
                    }
                }
            }
            scacchiera.rimuoviPedina(riga, colonna);
            riga = nuovaRiga;
            colonna = nuovaColonna;
            scacchiera.posizionaPedina(riga, colonna, this);

        }

        public override string stampa()
        {
            return "t";
        }
    }
}
