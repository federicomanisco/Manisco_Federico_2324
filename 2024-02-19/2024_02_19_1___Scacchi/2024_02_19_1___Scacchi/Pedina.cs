using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScacchiC
{
    public abstract class Pedina
    {
        protected Scacchiera scacchiera;
        private string colore;
        protected int riga;
        protected int colonna;
        private bool viva;
        private bool primaMossa;

        public Pedina(string colore, int riga, int colonna, Scacchiera scacchiera)
        {
            this.colore = colore;
            this.riga = riga;
            this.colonna = colonna;
            this.scacchiera = scacchiera;
            viva = true;

            primaMossa = false;
        }

        public virtual void muovi(int nuovaRiga, int nuovaColonna)
        {
            if (nuovaRiga < 0 || nuovaRiga > 7)
            {
                throw new ArgumentException("Posizione non valida");
            }
            if (nuovaColonna < 0 || nuovaColonna > 7)
            {
                throw new ArgumentException("Posizione non valida");
            }
            Pedina p = scacchiera.getPedina(nuovaRiga, nuovaColonna);
            if (p != null && p.colore==colore)
            {
                throw new ArgumentException("Casella occupata da una pedina del tuo stesso colore");
            }
        }

        public abstract void mangia(int r, int c);

        //TODO - da sviluppare
        public abstract void trasforma(Pedina p);

        public abstract string stampa();

    }
}
