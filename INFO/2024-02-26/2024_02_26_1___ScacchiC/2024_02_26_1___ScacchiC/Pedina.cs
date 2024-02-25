namespace ScacchiC
{
    public abstract class Pedina
    {

        public enum Colore
        {
            Black,
            White,
        }

        protected Scacchiera scacchiera;
        protected Colore colore;
        protected int riga;
        protected int colonna;
        private bool viva;
        protected bool primaMossa;

        public Pedina(Colore colore, int riga, int colonna, Scacchiera scacchiera)
        {
            this.colore = colore;
            this.riga = riga;
            this.colonna = colonna;
            this.scacchiera = scacchiera;
            viva = true;

            primaMossa = false;
        }

        public Colore ColorePedina {
            get { return colore; }
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
            //TODO aggiungere questa condizione di eccezione 
            //if (x1==x2 && y1==y2)

        }

        public abstract void mangia(int r, int c);

        //TODO - da sviluppare
        public abstract void trasforma(Pedina p);

        public abstract string stampa();

    }
}
