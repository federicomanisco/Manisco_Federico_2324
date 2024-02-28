
namespace ScacchiC
{
    public class Torre : Pedina
    {
        public Torre(Colore colore, int riga, int colonna, Scacchiera scacchiera) : base(colore, riga, colonna, scacchiera)
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
            
            //non posso muovere in obliquo
            if (nuovaRiga != riga && nuovaColonna != colonna) {
                throw new ArgumentException("Mossa non valida");
            }
            
            //non possono esserci pedine nel mezzo
            if (scacchiera.pedinaNelMezzo(riga, colonna, nuovaRiga, nuovaColonna)){
                    throw new ArgumentException("Pedina nel mezzo");
            };

            /*if (nuovaColonna != colonna)
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
            }*/

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
            return "♜";
        }
    } 
}
